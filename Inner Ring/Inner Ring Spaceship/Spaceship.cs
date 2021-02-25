using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
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

        private const int BufferSize = 1024;
        public string Status = string.Empty;
        public Thread T = null;
        //innerencryption
        string idInnerEncryption;
        string codeInnerEncryption;
        string idPlanetEncryption;
        Dictionary<string, string> dictInnerEncryptionData = new Dictionary<string, string>();


        //decompress
        string documents;

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

        private void getInnerEnryptionData()
        {
            getCodeValidation();

            DataSet InnerEncryptionData = Acc.PortarPerConsulta("select * from InnerEncryptionData where IdInnerEncryption = "+ idInnerEncryption + "  order by Word asc");
            DataTable Data = InnerEncryptionData.Tables[0];
            dictInnerEncryptionData = Data.AsEnumerable()
              .ToDictionary<DataRow, string, string>(row => row.Field<string>(2),
                                        row => row.Field<string>(3));
        }
        
        


        private void getCodeValidation()
        {
            DataSet codeValidation;
            codeValidation = Acc.PortarPerConsulta("select * from InnerEncryption where idPlanet=1");// + idPlanetSelected);
            idInnerEncryption = codeValidation.Tables[0].Rows[0][0].ToString();
            codeInnerEncryption = codeValidation.Tables[0].Rows[0][1].ToString();
            idPlanetEncryption = codeValidation.Tables[0].Rows[0][2].ToString();
            validationCode = "VK" + codeInnerEncryption;
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
                getInnerEnryptionData();

            }
            else if (posicion == 2)
            {
              //  numbersToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saveFolder = Application.StartupPath + "\\fitxers";
            string name = "PACS.zip";
            unzipPacs(saveFolder,name);
            
            getInnerEnryptionData();
            numbersToString();
            //SendZip( );
        }
        #endregion

        static void Conc()
        {
            try
            {
                using (var outputStream = File.Create(Application.StartupPath + "\\fitxers\\PACTOTAL.txt"))
                {
                    string path = "";
                    for (int i = 0; i < 3; i++)
                    {
                        path = Application.StartupPath + "\\fitxers\\PAC" + i + ".txt";
                        using (var inputStream = File.OpenRead(path))
                        {
                            // Buffer size can be passed as the second argument.
                            inputStream.CopyTo(outputStream);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// 




        private void SendZip(string M, string IPA, Int32 PortN)
        {
            const int BufferSize = 1024;
            byte[] SendingBuffer = null;
            TcpClient client = null;
            NetworkStream netstream = null;
            try
            {
                client = new TcpClient(IPA, PortN);
                netstream = client.GetStream();
                FileStream Fs = new FileStream(M, FileMode.Open, FileAccess.Read);
                int NoOfPackets = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Fs.Length) / Convert.ToDouble(BufferSize)));
                int TotalLength = (int)Fs.Length, CurrentPacketLength, counter = 0;
                for (int i = 0; i < NoOfPackets; i++)
                {
                    if (TotalLength > BufferSize)
                    {
                        CurrentPacketLength = BufferSize;
                        TotalLength = TotalLength - CurrentPacketLength;
                    }
                    else
                        CurrentPacketLength = TotalLength;
                    SendingBuffer = new byte[CurrentPacketLength];
                    Fs.Read(SendingBuffer, 0, CurrentPacketLength);
                    netstream.Write(SendingBuffer, 0, (int)SendingBuffer.Length);
                }
                Fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                netstream.Close();
                client.Close();
            }

        }


        private void numbersToString()
        {
            string name = "PAC";
            string documents = "PACS";
            

            for (int i = 0; i < 3; i++)
            {
                bool final = false;
                string codi = "";
                string lletra = "";
                string numeros = "";

                StreamReader stream = new StreamReader(Application.StartupPath + "\\fitxers\\" + documents + i.ToString() + ".txt");
                FileStream fs = new FileStream(Application.StartupPath + "\\fitxers\\" + name+i+".txt", FileMode.Create, FileAccess.Write);
                StreamWriter wr = new StreamWriter(fs);
                while (!final)
                {

                    codi = Convert.ToString((char)stream.Read());

                    if (codi == "\r")
                    {
                        final = true;
                    }
                    else
                    {
                        try
                        {
                            numeros += codi;

                            if (numeros.Length == 3)
                            {
                                lletra += dictInnerEncryptionData.FirstOrDefault(x => x.Value == numeros.ToString()).Key;
                                numeros = "";
                            }

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }

                wr.WriteLine(lletra);
                wr.Flush();
                wr.Close();
                fs.Close();
            }
            Conc();
        }


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
           ThreadStart Ts = new ThreadStart(StartReceiving);
            T = new Thread(Ts);
            T.SetApartmentState(ApartmentState.STA);
            T.Start();


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
        public void StartReceiving()
        {
            ReceiveTCP(Int32.Parse(portSpaceship1Selected));
        }

        public void ReceiveTCP(int portN)
        {
            TcpListener Listener = null;
            string saveFolder = Application.StartupPath + "\\fitxers";
            string name = "PACS.zip";
            string create = "";
            documents = name;
            try
            {
                Listener = new TcpListener(IPAddress.Any, portN);
                Listener.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            byte[] RecData = new byte[BufferSize];
            int RecBytes;
            if (InvokeRequired)
            {
                lbx_Missatges.Invoke(new MethodInvoker(delegate () {
                    lbx_Missatges.Items.Add("Listener Compressed using port " + portN.ToString());
                }
                    )
                );
            }

            while (true)
            {
                TcpClient client = null;
                NetworkStream netstream = null;
                Status = string.Empty;
                try
                {
                    string message = "Accept the Incoming File ";
                    string caption = "Incoming Connection";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        Status = "Connected to a client\n";

                        result = MessageBox.Show(message, caption, buttons);

                            CleanDir(saveFolder);
                        create = saveFolder + "\\"+ name;
                            
                                int totalrecbytes = 0;
                                FileStream Fs = new FileStream(create, FileMode.OpenOrCreate, FileAccess.Write);
                                while ((RecBytes = netstream.Read(RecData, 0, RecData.Length)) > 0)
                                {
                                    Fs.Write(RecData, 0, RecBytes);
                                    totalrecbytes += RecBytes;
                                }
                                Fs.Close();
                            
                            netstream.Close();
                            client.Close();
                        unzipPacs(saveFolder,name);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
            
                }
            }
        }


        private void unzipPacs(string carpeta,string name)
        {
            ZipFile.ExtractToDirectory(carpeta+"\\"+name , carpeta);
        }


        private void CleanDir(string dir)
        {
            DirectoryInfo directory = new DirectoryInfo(dir);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
            foreach (FileInfo fi in directory.GetFiles())
            {
                fi.Delete();
            }
            foreach (DirectoryInfo di in directory.GetDirectories())
            {
                di.Delete(true);
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
