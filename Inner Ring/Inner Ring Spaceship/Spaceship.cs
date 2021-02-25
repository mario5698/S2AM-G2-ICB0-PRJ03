using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDades;



namespace Inner_Ring_Spaceship
{
    public partial class Spaceship : Form
    {
        DataSet planets;
        Acceso Acc = new Acceso();
        //info planet
        string ipPlanetSelected;
        string portPlanetSelected;
        string idPlanetSelected;
        string validationCode; 
        //Send message
        TcpClient Client = null;
        NetworkStream NetStream;

        //listener
        Thread hilo1,hilo2;        
        int portMessage;
        int portCompressed;
        TcpListener ListenerRecieveMessage;
        TcpListener ListenerRecieveCompressed;
        bool listenerRecieveStart = false;
        bool listenerCompressedStart = false;

        //info spaceship
        DataSet spaceShip;
        string idSpaceshipSelected;
        string codeSpaceshipSelected;
        string ipSpaceshipSelected;
        string portSpaceshipSelected;
        string portSpaceship1Selected;


        //delivery data
        string deliveryCode;

        //control
        int posicion = 0;


        #region RSA

        RSACryptoServiceProvider rsa;
        byte[] datosEncriptados;
        string llavePublica;

        #endregion

        public Spaceship()
        {
            InitializeComponent();
            getAllPlanets();
        }

        private void sendMessage(string message)
        {

            Client = new TcpClient(ipPlanetSelected, Int32.Parse(portPlanetSelected));
            NetStream = Client.GetStream();
            byte[] frase = Encoding.UTF8.GetBytes(message);
            NetStream.Write(frase, 0, frase.Length);

        }
        #region Obtener Planetas, naves, Info Planetas, Codigo Envio
        private void getAllPlanets()
        {
            spaceShip = Acc.PortarPerConsulta("select * from SpaceShips");
            planets = Acc.PortarPerConsulta("select * from Planets");
            for (int i = 0; i < planets.Tables.Count; i++)
            {
                comboBox2.DataSource = planets.Tables[0];
                comboBox2.DisplayMember = "DescPlanet";
                comboBox2.ValueMember = "idPlanet";
            }
        }

        private void GetInfoPlanet_Click(object sender, EventArgs e)
        {
            DataRow[] planetSelected = planets.Tables[0].Select("IdPlanet=" + comboBox2.SelectedValue);
            idPlanetSelected = planetSelected[0][0].ToString();
            ipPlanetSelected = planetSelected[0][10].ToString();
            portPlanetSelected = planetSelected[0][11].ToString();
            getCodeValidation();
            getDeliveryCode();
            startCommunication();
        }

        private void getCodeValidation()
        {
            DataSet codeValidation;
            codeValidation = Acc.PortarPerConsulta("select * from InnerEncryption where idPlanet=" + idPlanetSelected);
            string codi = codeValidation.Tables[0].Rows[0][1].ToString();
            validationCode = "VK" + codi;
        }

        private void getDeliveryCode()
        {
            DataSet codeValidation;
            codeValidation = Acc.PortarPerConsulta("select * from DeliveryData where idPlanet=" + idPlanetSelected);
            string codeDelivery = codeValidation.Tables[0].Rows[0][1].ToString();
            deliveryCode = codeDelivery;
        }

        private void startCommunication()
        {
            if (posicion == 0)
            {
                sendMessage("ER" + codeSpaceshipSelected + deliveryCode);
                posicion++;
            }
            else if (posicion == 1)
            {
                sendMessage(validationCode);
                posicion++;
            }
        }


        #endregion

        private void GetInfoSpaceShit_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet infoSpaceship;
                infoSpaceship = Acc.PortarPerConsulta("select * from SpaceShips where CodeSpaceShip=" + "'" + textBox1.Text + "'");
                idSpaceshipSelected = infoSpaceship.Tables[0].Rows[0][0].ToString();
                codeSpaceshipSelected = infoSpaceship.Tables[0].Rows[0][2].ToString();
                ipSpaceshipSelected = infoSpaceship.Tables[0].Rows[0][3].ToString(); ;
                portSpaceshipSelected = infoSpaceship.Tables[0].Rows[0][4].ToString(); ;
                portSpaceship1Selected = infoSpaceship.Tables[0].Rows[0][5].ToString();
                createThreadToListener();
                createThreadToCompressed();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #region Crear Hilos
        private void createThreadToListener()
        {
            hilo1 = new Thread(ActivateListenerMessage);
            hilo1.Start();
        }
        private void createThreadToCompressed()
        {
            hilo2 = new Thread(ActivarListenerCompressed);
            hilo2.Start();
        }
        #endregion
        #region Activar Listener Recibir Mensajes  
        private void ActivateListenerMessage()
        {
            portMessage = Int32.Parse(portSpaceshipSelected);

            if (!listenerRecieveStart)
            {
                listenerRecieveStart = true;
                if (InvokeRequired)
                {
                    lbx_Missatges.Invoke(new MethodInvoker(delegate () {
                        lbx_Missatges.Items.Add("Listener Message using port " + portMessage.ToString());
                    }
                        )
                    );
                }
                ActivarListenerMessage();
            }
            else
            {
                if (InvokeRequired)
                {
                    lbx_Missatges.Invoke(new MethodInvoker(delegate () {
                        lbx_Missatges.Items.Add("The listener Message is activated");
                    }
                        )
                    );
                }
            }

            
        }


        private void ActivarListenerMessage()
        {
            TcpClient client;
            byte[] buffer = new byte[1024];
            string mensaje = null;
            NetworkStream str;

            ListenerRecieveMessage = new TcpListener(IPAddress.Any, portMessage);
            ListenerRecieveMessage.Start();

            byte[] recive = new byte[256];
            while (true)
            {
                try
                {
                    if (ListenerRecieveMessage.Pending())
                    {
                        startCommunication();
                        client = ListenerRecieveMessage.AcceptTcpClient();
                        str = client.GetStream();
                        Int32 bytes = str.Read(recive, 0, recive.Length);
                        mensaje = Encoding.UTF8.GetString(recive, 0, bytes);

                        if (InvokeRequired)
                        {
                            lbx_Missatges.Invoke(new MethodInvoker(delegate () {
                                lbx_Missatges.Items.Add(mensaje);
                            }
                                )
                            );
                        }
                        str.Close();
                        client.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region Activar Listener Recibir Archivos  
        private void ActivarListenerCompressed()
        {
            portCompressed = Int32.Parse(portSpaceship1Selected);

            if (!listenerCompressedStart)
            {
                listenerCompressedStart = true;
                if (InvokeRequired)
                {
                    lbx_Missatges.Invoke(new MethodInvoker(delegate () {
                        lbx_Missatges.Items.Add("Listener Compressed using port " + portMessage.ToString());
                    }
                        )
                    );
                }
                ActivateListenerCompressed();
            }
            else
            {
                if (InvokeRequired)
                {
                    lbx_Missatges.Invoke(new MethodInvoker(delegate () {
                        lbx_Missatges.Items.Add("The listener Compress is activated");
                    }
                        )
                    );
                }
            }

            
        }

      

        private void ActivateListenerCompressed()
        {
            TcpClient client;
            byte[] buffer = new byte[1024];
            NetworkStream str;

            ListenerRecieveCompressed = new TcpListener(IPAddress.Any, portCompressed);
            ListenerRecieveCompressed.Start();
            byte[] recive = new byte[256];
            while (true)
            {
                try
                {
                    if (ListenerRecieveCompressed.Pending())
                    {
                        startCommunication();
                        client = ListenerRecieveCompressed.AcceptTcpClient();
                        str = client.GetStream();
                        Int32 bytes = str.Read(recive, 0, recive.Length);

                        MessageBox.Show("Compressed File Recived");

                        str.Close();
                        client.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        private void btn_listener_Desc_Click(object sender, EventArgs e)
        {
            ListenerRecieveMessage.Stop();
            ListenerRecieveCompressed.Stop();
            hilo1.Abort();
            hilo2.Abort();
            listenerRecieveStart = false;
            listenerCompressedStart = false; 
            lbx_Missatges.Items.Clear();
        }

        #region RSAFunciones

        private void IniciarRSA(string llave)
        {
            rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(llave);
            llavePublica = rsa.ToXmlString(false);
        }

        private string Encriptar(string texto)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            byte[] bytesTexto = ByteConverter.GetBytes(texto);
            datosEncriptados = rsa.Encrypt(bytesTexto, true);
            return ByteConverter.GetString(datosEncriptados);
        }

        #endregion
    }
}
