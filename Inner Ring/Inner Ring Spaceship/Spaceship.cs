using System;
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
using GalaxyUI;

namespace Inner_Ring_Spaceship
{
    public partial class Spaceship : Form
    {
        string saveFolder = Application.StartupPath + "\\fitxers";

        DataSet planets;
        Acceso Acc = new Acceso();
        //info planet
        string ipPlanetSelected;
        string portPlanetSelected;
        string idPlanetSelected;
        // string validationCode;
        string port1PlanetSelected;
        //Send message
        TcpClient Client = null;
        NetworkStream NetStream;

        //listener
        Thread hilo1, hilo2;
        int portMessage;
        //int portCompressed;
        TcpListener ListenerRecieveMessage;
        TcpListener ListenerRecieveCompressed;
        bool listenerRecieveStart = false;
        //   bool listenerCompressedStart = false;

        //info spaceship
        DataSet spaceShip;
        // string idSpaceshipSelected;
        string codeSpaceshipSelected;
        string ipSpaceshipSelected;
        string portSpaceshipSelected;
        string portSpaceship1Selected;
        string Spaceshiptype;

        //delivery data
        DataTable infoDelivery;
        string deliveryCode;
        // bool exist=false; 
        //control
        int posicion = 0;
        private const int BufferSize = 1024;
        public string Status = string.Empty;
        public Thread T = null;
        //innerencryption
        string idInnerEncryption;
        string codeInnerEncryption;
        Dictionary<string, string> dictInnerEncryptionData = new Dictionary<string, string>();

        static string enviar = Application.StartupPath + "\\fitxers\\PACTOTAL.txt";
        //decompress
        string documents = "";
        string[] head = new string[6] { "id", "descSec", "descPla", "lat", "long", "codeDelivery" };

        int numeroTema;
        ThemeName nombreTema;
        Random rngx = new Random();
        GalaxyTheme tema = new GalaxyTheme();

        public Spaceship(string spaceshipCode)
        {
            InitializeComponent();
            AsignarTema();
            AsignarFunciones();
            getAllPlanetsToDelivery(spaceshipCode);
            getSpaceshipData(spaceshipCode);
            CleanDir(saveFolder);
            Dtg_header();
        }

        private void AsignarFunciones()
        {
            btn_start.label.Click += activateListener;
            btn_start.pictureBox.Click += activateListener;

            btn_disc.label.Click += listenerDisconected;
            btn_disc.pictureBox.Click += listenerDisconected;

            btn_conect_planet.label.Click += getInfoPlanet;
            btn_conect_planet.pictureBox.Click += getInfoPlanet;

            btn_send_file.label.Click += send_Pac;
            btn_send_file.pictureBox.Click += send_Pac;
        }

        private void AsignarTema()
        {
            numeroTema = rngx.Next(1, 4);
            //numeroTema = 2;
            if (numeroTema == 1) { nombreTema = ThemeName.Vitruvian; }
            else if (numeroTema == 2) { nombreTema = ThemeName.Fortuna; }
            else { nombreTema = ThemeName.Igni; }

            BackgroundImage = tema.ObtenerFondo(numeroTema);

            foreach (Control c in Controls)
            {
                if (c is Label)
                {
                    c.ForeColor = tema.ObtenerColor(nombreTema, false);
                }

                if (c is GalaxyButton)
                {
                    var button = (GalaxyButton)c;
                    button.Tema = nombreTema;
                }
                else if (c is GalaxyTextBox)
                {
                    var text = (GalaxyTextBox)c;
                    text.Tema = nombreTema;
                }
                else if (c is GalaxyPanel)
                {
                    var panel = (GalaxyPanel)c;
                    panel.Tema = nombreTema;
                }
            }
        }

        private void Dtg_header()
        {
            for (int i = 0; i < head.Length; i++)
            {
                dataGridView1.Columns[i].HeaderText = head[i].ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void getSpaceshipData(string spaceshipCode)
        {
            try
            {
                DataSet infoSpaceship;
                infoSpaceship = Acc.PortarPerConsulta("select CodeSpaceShip, IPSpaceShip, PortSpaceShip, PortSpaceShip1, DescSpaceShipType from SpaceShips, SpaceShipTypes where CodeSpaceShip = '" + spaceshipCode + "'");
                codeSpaceshipSelected = infoSpaceship.Tables[0].Rows[0]["codespaceship"].ToString();
                ipSpaceshipSelected = infoSpaceship.Tables[0].Rows[0]["ipspaceship"].ToString();
                portSpaceshipSelected = infoSpaceship.Tables[0].Rows[0]["portspaceship"].ToString();
                portSpaceship1Selected = infoSpaceship.Tables[0].Rows[0]["portspaceship1"].ToString();
                Spaceshiptype = infoSpaceship.Tables[0].Rows[0]["DescSpaceShipType"].ToString();
                setValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show("getSpaceshipData");
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

        private void sendMessage(string message = null, byte[] encrypted = null)
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
        private void getAllPlanetsToDelivery(string spaceshipCode)
        {
            string query = "select  p.idPlanet, sec.DescSector,p.DescPlanet,  p.lat, p.long , d.CodeDelivery   from  SpaceShips s " +
                "left join  DeliveryData d on s.idSpaceShip = d.idSpaceShip left join  planets p on d.idplanet = p.idPlanet " +
                "left join sectors sec on p.idSector = sec.idSector  where s.CodeSpaceShip =  '" + spaceshipCode + "'";

            DataSet deliveryPlanets = Acc.PortarPerConsulta(query);
            spaceShip = Acc.PortarPerConsulta("select * from SpaceShips");
            planets = Acc.PortarPerConsulta("select * from planets");

            infoDelivery = deliveryPlanets.Tables[0];
            dataGridView1.DataSource = infoDelivery;
            dataGridView1.Columns["idplanet"].Visible = false;
        }



        private void getInfoPlanet(object sender, EventArgs e)
        {
            DataRow[] planetSelected = planets.Tables[0].Select("IdPlanet=" + dataGridView1.SelectedCells[0].Value.ToString());
            idPlanetSelected = planetSelected[0]["idplanet"].ToString();
            ipPlanetSelected = planetSelected[0]["ipplanet"].ToString();
            portPlanetSelected = planetSelected[0]["portplanet"].ToString();
            port1PlanetSelected = planetSelected[0]["portplanet1"].ToString();
            getDeliveryCode();
            startCommunication();
        }

        private void getInnerEnryptionData()
        {

            DataSet InnerEncryptionData = Acc.PortarPerConsulta("select * from InnerEncryptionData where idInnerEncryption = " + idInnerEncryption + "  order by Word asc");
            DataTable Data = InnerEncryptionData.Tables[0];
            dictInnerEncryptionData = Data.AsEnumerable()
              .ToDictionary<DataRow, string, string>(row => row.Field<string>(2),
                                        row => row.Field<string>(3));
        }

        private void getCodeValidation()
        {
            DataSet codeValidation;
            codeValidation = Acc.PortarPerConsulta("select * from InnerEncryption where idPlanet = " + idPlanetSelected);
            idInnerEncryption = codeValidation.Tables[0].Rows[0]["idinnerencryption"].ToString();
            codeInnerEncryption = codeValidation.Tables[0].Rows[0]["validationcode"].ToString();

        }

        private void getDeliveryCode()
        {
            DataSet codeValidation;
            codeValidation = Acc.PortarPerConsulta("select * from DeliveryData where idPlanet=" + "'" + idPlanetSelected + "'");
            string codeDelivery = codeValidation.Tables[0].Rows[0]["codedelivery"].ToString();
            deliveryCode = codeDelivery;
        }

        private void startCommunication()
        {
            if (posicion == 0)
            {
                posicion++;
                string messageToSend = "ER" + codeSpaceshipSelected + deliveryCode;
                sendMessage(message: messageToSend);
                lbx_Missatges.Items.Add("+ " + messageToSend);
                lbx_Missatges.Items.Add("");
            }
            else if (posicion == 1)
            {
                posicion++;
                getCodeValidation();
                sendMessage(encrypted: Encriptar(codeInnerEncryption));
                if (InvokeRequired)
                {
                    lbx_Missatges.Invoke(new MethodInvoker(
                        delegate ()
                        {
                            lbx_Missatges.Items.Add("+ Encripted Message Sent");
                        }));
                }
            }
            else if (posicion == 2)
            {
                posicion++;
                getInnerEnryptionData();
                unzipPacs();
                numbersToString();

                if (InvokeRequired)
                {
                    lbx_Missatges.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        lbl_GetFIleComplete.Text = "The Files is Ready to Send ";
                    }
                    ));
                }
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
                            lbx_Missatges.Items.Add("- " + mensaje);
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
            DateTime thisDay = DateTime.Today;
            string name = "PACS.zip";
            string create = "";
            documents = name;
            try
            {
                ListenerRecieveCompressed = new TcpListener(IPAddress.Any, portN);
                ListenerRecieveCompressed.Start();
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
                    if (ListenerRecieveCompressed.Pending())
                    {
                        CleanDir(saveFolder);
                        client = ListenerRecieveCompressed.AcceptTcpClient();
                        netstream = client.GetStream();

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
                    MessageBox.Show("ReceiveTCP");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void unzipPacs()
        {
            try
            {
                string carpeta = saveFolder;
                string name = "PACS.zip";
                ZipFile.ExtractToDirectory(carpeta + "\\" + name, carpeta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail to UnzipPacs");
                MessageBox.Show(ex.Message);
            }
        }

        private void CleanDir(string dir)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Failed to clean the folder ");
                MessageBox.Show(ex.Message);
            }
        }
        #endregion


        private void send_Pac(object sender, EventArgs e)
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

        private void activateListener(object sender, EventArgs e)
        {
            try
            {
                createThreadToListener();
                createThreadToCompressed();
            }
            catch (Exception ex)
            {
                MessageBox.Show("listener button connect ");
                MessageBox.Show(ex.Message);
            }
        }

        private void listenerDisconected(object sender, EventArgs e)
        {
            try
            {
                createThreadToListener();
                createThreadToCompressed();
            }
            catch (Exception ex)
            {
                MessageBox.Show("listener button connect ");
                MessageBox.Show(ex.Message);
            }
        }

        private void Spaceship_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
        }


        private void galaxyButton1_Click(object sender, EventArgs e)
        {
            try
            {
                createThreadToListener();
                createThreadToCompressed();
            }
            catch (Exception ex)
            {
                MessageBox.Show("listener button connect ");
                MessageBox.Show(ex.Message);
            }
        }

        private void galaxyButton2_Click(object sender, EventArgs e)
        {
            ListenerRecieveMessage.Stop();
            ListenerRecieveCompressed.Stop();
            hilo1.Abort();
            //  hilo2.Abort();
            listenerRecieveStart = false;
            // listenerCompressedStart = false;
            lbx_Missatges.Items.Clear();
        }

        private void btn_conect_planet_Load(object sender, EventArgs e)
        {

        }

        private void btn_listener_Desc_Click(object sender, EventArgs e)
        {
            ListenerRecieveMessage.Stop();
            ListenerRecieveCompressed.Stop();
            hilo1.Abort();
            //  hilo2.Abort();
            listenerRecieveStart = false;
            // listenerCompressedStart = false;
            lbx_Missatges.Items.Clear();
        }
    }
}