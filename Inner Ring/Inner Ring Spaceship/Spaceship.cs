﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
        string port1PlanetSelected;
        //Send message
        TcpClient Client = null;
        NetworkStream NetStream;

        //listener
        Thread hilo1, hilo2;
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
        string Spaceshiptype; 
        //delivery data
        string deliveryCode;
        bool exist=false; 
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

        static string enviar= Application.StartupPath + "\\fitxers\\PACTOTAL.txt";
        //decompress
        string documents;

        
        public Spaceship(string spaceshipCode)
        {
            InitializeComponent();
            getAllPlanets();
            getSpaceshipData(spaceshipCode);

        }
        private void getSpaceshipData(string spaceshipCode)
        {
            try
            {
                DataSet infoSpaceship;
                // infoSpaceship = Acc.PortarPerConsulta("select * from SpaceShips where CodeSpaceShip=" + "'" + label1.Text + "'");
                infoSpaceship = Acc.PortarPerConsulta("select CodeSpaceShip, IPSpaceShip, PortSpaceShip, PortSpaceShip1, DescSpaceShipType from SpaceShips , SpaceShipTypes where CodeSpaceShip = '"+spaceshipCode+"'");
                //    idSpaceshipSelected = infoSpaceship.Tables[0].Rows[0][0].ToString();
                codeSpaceshipSelected = infoSpaceship.Tables[0].Rows[0][0].ToString();
                ipSpaceshipSelected = infoSpaceship.Tables[0].Rows[0][1].ToString();
                portSpaceshipSelected = infoSpaceship.Tables[0].Rows[0][2].ToString();
                portSpaceship1Selected = infoSpaceship.Tables[0].Rows[0][3].ToString();
                Spaceshiptype = infoSpaceship.Tables[0].Rows[0][4].ToString();

                setValues(); 


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setValues()
        {
            lbl_Code.Text = codeSpaceshipSelected;
            lbl_Ip.Text = ipSpaceshipSelected;
            lbl_Port.Text = portSpaceshipSelected;
            lbl_Port1.Text = portSpaceship1Selected;
            lbl_Type.Text = Spaceshiptype;
        }


        private void sendMessage(string message = null, byte[] encrypted = null )
        {

            Client = new TcpClient(ipPlanetSelected, Int32.Parse(portPlanetSelected));
            NetStream = Client.GetStream();
            byte[] frase = null;
            if (message != null)
            {
                frase = Encoding.UTF8.GetBytes(message);
            }
            else if (encrypted != null)
            {
                frase = encrypted;
            }
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
            port1PlanetSelected = planetSelected[0][12].ToString();
            getCodeValidation();
            getDeliveryCode();
            startCommunication();
        }

        private void getInnerEnryptionData()
        {
            getCodeValidation();

            DataSet InnerEncryptionData = Acc.PortarPerConsulta("select * from InnerEncryptionData where IdInnerEncryption = " + idInnerEncryption + "  order by Word asc");
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
                posicion++;
                string messageToSend = "ER" + codeSpaceshipSelected + deliveryCode;
                sendMessage( message: messageToSend);
                lbx_Missatges.Items.Add("+ " + messageToSend);
                lbx_Missatges.Items.Add("");


            }
            else if (posicion == 1)
            {
                posicion++;
                sendMessage(encrypted: Encriptar(codeInnerEncryption)) ;
                lbx_Missatges.Items.Add("+ Encripted Message Sent");

            }
            else if (posicion == 2)
            {
                posicion++;
                getInnerEnryptionData();
                unzipPacs();
                numbersToString();
                label5.Text = "The Files is Ready to Send ";
            }
        }


        private byte[] Encriptar(string texto)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();
            string xmlkey = Acc.PortarPerConsulta("select * from planetkeys where idplanet = " + idPlanetSelected).Tables[0].Rows[0]["xmlkey"].ToString();
            rsaEnc.FromXmlString(xmlkey);
            byte[] bytesTexto = ByteConverter.GetBytes(texto);
            return rsaEnc.Encrypt(bytesTexto, false);
        }

        #endregion

        private void Conc()
        {
            try
            {
                using (var outputStream = File.Create(enviar))
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
                MessageBox.Show("Conc");
                MessageBox.Show(e.Message);
            }
        }

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
                MessageBox.Show("SendZip");
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
                FileStream fs = new FileStream(Application.StartupPath + "\\fitxers\\" + name + i + ".txt", FileMode.Create, FileAccess.Write);
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
                        catch (Exception ex)
                        {
                            MessageBox.Show("numbersToString");
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
                    lbx_Missatges.Invoke(new MethodInvoker(delegate ()
                    {
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
                    lbx_Missatges.Invoke(new MethodInvoker(delegate ()
                    {
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
            byte[] recive = new byte[256];

            ListenerRecieveMessage = new TcpListener(IPAddress.Any, portMessage);
            ListenerRecieveMessage.Start();

            while (true)
            {
                if (ListenerRecieveMessage.Pending())
                {
                    client = ListenerRecieveMessage.AcceptTcpClient();
                    str = client.GetStream();
                    Int32 bytes = str.Read(recive, 0, recive.Length);
                    mensaje = Encoding.UTF8.GetString(recive, 0, bytes);

                    if (InvokeRequired)
                    {
                        lbx_Missatges.Invoke(new MethodInvoker(delegate ()
                        {
                            lbx_Missatges.Items.Add("- "+ mensaje);
                        }));
                    }
                    str.Close();
                    client.Close();
                    startCommunication();
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
                MessageBox.Show("ReceiveTCP");
                Console.WriteLine(ex.Message);
            }

            byte[] RecData = new byte[BufferSize];
            int RecBytes;
            if (InvokeRequired)
            {
                lbx_Missatges.Invoke(new MethodInvoker(delegate ()
                {
                    lbx_Missatges.Items.Add("Listener Compressed using port " + portN.ToString());
                }));
            }

            while (true)
            {
                TcpClient client = null;
                NetworkStream netstream = null;
                Status = string.Empty;
                try
                {          
                    if (Listener.Pending())
                    {
                        client = Listener.AcceptTcpClient();
                        netstream = client.GetStream();
                        CleanDir(saveFolder);

                        create = saveFolder + "\\" + name;

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
                        startCommunication();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void unzipPacs()
        {
            string carpeta = Application.StartupPath + "\\fitxers";
            string name = "PACS.zip";
            ZipFile.ExtractToDirectory(carpeta + "\\" + name, carpeta);

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

        private void btn_SendPac_Click(object sender, EventArgs e)
        {
            if (File.Exists(enviar))
            {
                SendZip(enviar, ipPlanetSelected, Int32.Parse(port1PlanetSelected));
                lbl_GetFIleComplete.Text = "The document has been sent successfully";
            }
            else
            {
                lbl_GetFIleComplete.Text = "The document has not been created yet";
            }
        }
       
        private void btn_listener_Conect_Click(object sender, EventArgs e)
        {
            try
            {

                createThreadToListener();
                createThreadToCompressed();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

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
    }
}