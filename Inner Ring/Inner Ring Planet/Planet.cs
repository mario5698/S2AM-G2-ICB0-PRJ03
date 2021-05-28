using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Windows.Forms;
using AccesoDades;
using System.Net.Sockets;
using System.Net;
using GalaxyUI;

namespace Inner_Ring
{
    public partial class Planet : Form
    {
        int numeroTema;
        ThemeName nombreTema;
        Random rngx = new Random();
        GalaxyTheme tema = new GalaxyTheme();
        string text;
        bool listening;


        public Planet()
        {
            InitializeComponent();
            ObtenerPlanetas();
            AsignarTema();
            AsignarFunciones();
        }

        private void AsignarTema()
        {
            numeroTema = rngx.Next(1, 4);
            numeroTema = 1;
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


        private void AsignarFunciones()
        {
            btnCreateCodification.label.Click += CreateCodification;
            btnCreateCodification.pictureBox.Click += CreateCodification;

            btnInsert.label.Click += Insert;
            btnInsert.pictureBox.Click += Insert;

            btnConnect.label.Click += Connect;
            btnConnect.pictureBox.Click += Connect;

            btnRSA.label.Click += RSA;
            btnRSA.pictureBox.Click += RSA;

            btnGenerate.label.Click += Generate;
            btnGenerate.pictureBox.Click += Generate;

            btnCompare.label.Click += Compare;
            btnCompare.pictureBox.Click += Compare;
        }


        #region RSA

        public byte[] datosEncriptados;
        CspParameters parametros;
        RSACryptoServiceProvider rsa;
        UnicodeEncoding ByteConverter = new UnicodeEncoding();
        string llavePublica;

        private const int BufferSize = 1024;
        public string Status = string.Empty;
        public Thread T = null;
        public byte[] encrypted;
        Thread fitxers;
        Thread comprimit;
        Thread hilotcp;
        TcpListener Listener;
        TcpClient client;
        byte[] buffer;
        NetworkStream ns;
        Byte[] dades;
        string code;
        string key = "", num_format = "";
        Dictionary<string, string> dic = new Dictionary<string, string>();
        RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabdecejghijklmnopqrstuvwxyz0123456789";
        char[] caract;
        DataRow[] planetSelected;
        string idpla, idinn, ipPlanetSelected, ipSpaceShip, portSpaceShip, port1SpaceShip, portPlanetSelected;
        bool comprobar = true;
        bool conectado = false;
        int status = 0;
        string rebut, codeNau = "";


        #endregion

        #region DB

        DataSet planets;
        Dictionary<int, string> planetsDictionary = new Dictionary<int, string>();
        Acceso Acc = new Acceso();
        Encrypt cry = new Encrypt();
        
        private static Random random = new Random();

        #endregion


        #region DBFunciones

        private void ObtenerPlanetas()
        {
            planets = Acc.PortarPerConsulta("select * from Planets");
            for (int i = 0; i < planets.Tables.Count; i++)
            {
                comboBox1.DataSource = planets.Tables[0];
                comboBox1.DisplayMember = "DescPlanet";
                comboBox1.ValueMember = "idPlanet";
            }
        }
        public void GenerarDic()
        {
            dic.Clear();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                num_format = Agregar_Num();
                while (comprobar)
                {
                    comprobar = dic.ContainsValue(num_format);
                    if (comprobar)
                    {
                        num_format = Agregar_Num();
                    }
                    else
                    {
                        comprobar = false;
                    }
                }
                comprobar = true;
                key = c.ToString();
                dic.Add(key, num_format);
            }
        }

        public void ReceiveTCP(int portN)
        {
            TcpListener Listener = null;
            string recPath = Application.StartupPath + "\\fitxers\\forCompare";
            string saveFolder = recPath + "\\";
            string name = "lletresTotalsRecived.txt";
            string create = "";
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
                        }
                    
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add("⚠️" + ex.Message);
                    break;
                }
            }
        }

        private bool CompararHash()
        {
            string comPath = Application.StartupPath + "\\fitxers\\forCompare";
            DirectoryInfo CompDir = new DirectoryInfo(comPath);
            byte[] sal = cry.Sal();
            List<byte[]> files = new List<byte[]>();
            try
            {
                if (Directory.GetFiles(comPath, "*", SearchOption.AllDirectories).Length != 0)
                {
                    foreach (FileInfo file in CompDir.GetFiles())
                    {
                        files.Add(cry.Hash(File.ReadAllText(comPath + "\\" + file.Name), sal));
                    }
                    return cry.HashesIguales(files[0], files[1]);
                }
            }
            catch (Exception e)
            {
                listBox1.Items.Add("⚠️" + e.Message);

            }
            return false;
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

        private void GenerarFitxers()
        {
            CleanDir(Application.StartupPath + "\\fitxers");
            CleanDir(Application.StartupPath + "\\fitxers\\PACS");
            CleanDir(Application.StartupPath + "\\fitxers\\Lletres");

            Parallel.For(0, 3, i =>
            {
                EscriureLletres(i);
                EscriureCodi(i);
            });
            Conc();
        }

        private string LLetraRandomKey()
        {
            var bytenum = new byte[4];
            rng.GetBytes(bytenum);
            var randint = BitConverter.ToInt32(bytenum, 0);
            Random rand = new Random(randint);
            int pos = rand.Next(0, 26);
            return dic.ElementAt(pos).Key;
        }

        private void EscriureLletres(int num)
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\fitxers\\Lletres\\lletres" + num + ".txt", FileMode.Create, FileAccess.Write);
            StreamWriter wr = new StreamWriter(fs);

            string lletra = "";
            for (int i = 0; i < 100000; i++)
            {
                lletra = lletra + LLetraRandomKey();
            }
            wr.WriteLine(lletra);
            wr.Flush();
            wr.Close();
            fs.Close();
        }


        private void Conc()
        {
            try
            {
                string recPath = Application.StartupPath + "\\fitxers\\forCompare";
                CleanDir(recPath);
                using (var outputStream = File.Create(recPath + "\\lletresTotal.txt"))
                {
                    string path = "";

                    for (int i = 0; i < 3; i++)
                    {
                        path = Application.StartupPath + "\\fitxers\\Lletres\\lletres" + i + ".txt";
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
                listBox1.Items.Add("⚠️" + e.Message);

            }
        }

        private void EscriureCodi(int num)
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\fitxers\\PACS\\PACS" + num + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read);
            FileStream frs = new FileStream(Application.StartupPath + "\\fitxers\\Lletres\\lletres" + num + ".txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

            StreamWriter wr = new StreamWriter(fs);
            StreamReader rd = new StreamReader(frs);
            string lletra;
            bool fi = false;
            while (!fi)
            {
                lletra = Convert.ToString((char)rd.Read());
                if (lletra == "\r")
                {
                    fi = true;
                    wr.WriteLine();
                }
                else
                {
                    try
                    {
                        string code = dic[lletra];
                        wr.Write(code);
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            rd.Close();
            wr.Flush();
            wr.Close();
            fs.Close();
            frs.Close();
        }

        private void ComprimirFitxers()
        {
            fitxers.Join();
            try
            {
                ZipFile.CreateFromDirectory(Application.StartupPath + "\\fitxers\\PACS", Application.StartupPath + "\\fitxers\\PACS.zip");
            }
            catch (Exception)
            {
            }
        }

        private string Agregar_Num()
        {
            var bytearr = new byte[4];
            rng.GetBytes(bytearr);
            var randint = BitConverter.ToInt32(bytearr, 0);
            Random rand = new Random(randint);
            int r = rand.Next(0, 999);
            string num_format = dar_formato_random(r);
            return num_format;
        }


        private string dar_formato_random(int r)
        {
            string ran = r.ToString();
            int longitud = ran.Length;
            for (int i = longitud; i < 3; i++)
            {
                ran = "0" + ran;
            }
            return ran;
        }


        private void CreateCodification(object sender, EventArgs e)
        {
            GenerarDic();
            code = "";
            for (int i = 0; i < 12; i++)
            {
                code = code + RandomString();
            }
            label3.Text = code;
        }

        public void Listen()
        {
            try
            {
                if (listening)
                {
                    throw new InvalidOperationException("Conexión ya establecida.");
                }
                else
                {
                    Listener = new TcpListener(IPAddress.Any, Int32.Parse(portPlanetSelected));
                    Listener.Start();
                    listBox1.Items.Add("✔️Conexió habilitada amb el port: " + portPlanetSelected);
                    listening = true;
                    while (conectado)
                    {
                        if (Listener.Pending())
                        {
                            client = Listener.AcceptTcpClient();
                            string[] ip = client.Client.RemoteEndPoint.ToString().Split(':');
                            ns = client.GetStream();
                            buffer = new byte[128];
                            int bytes = ns.Read(buffer, 0, buffer.Length);
                            if (status < 1)
                            {
                                rebut = Encoding.ASCII.GetString(buffer, 0, bytes);
                            }
                            else
                            {
                                AddLb("+ ENC --> " + Encoding.ASCII.GetString(buffer, 0, bytes));
                                rebut = ByteConverter.GetString(Desencriptar(buffer));
                            }
                            AnaliseMess(rebut);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                listBox1.Items.Add("⚠️" + e.Message);
            }
        }

        private void HiloTCP()
        {
            hilotcp = new Thread(new ThreadStart(Listen));
            hilotcp.Start();
        }

        private void AddLb(string rebut)
        {
            lbx_Missatges.Items.Add(" ");
            lbx_Missatges.Items.Add(rebut);

        }

        private void AnaliseMess(string text)
        {
            string first = text.Substring(0, 2);
            if (first == "ER")
            {
                int pos = 0;
                if (pos == status)
                {
                    try
                    {
                        codeNau = text.Substring(2, 12);
                        lbx_Missatges.Items.Add("Nau:" + codeNau);
                        AddLb("+ " + text);
                        string codeDeliv = text.Substring(14, 12);
                        string idspaceship = Acc.PortarPerConsulta("Select * from DeliveryData where codeDelivery = '" + codeDeliv + "'").Tables[0].Rows[0]["idspaceship"].ToString();
                        DataSet dtsp = Acc.PortarPerConsulta("Select * from Spaceships where idspaceship =" + idspaceship);
                        string codeNauBBDD = dtsp.Tables[0].Rows[0]["codespaceship"].ToString();
                        portSpaceShip = dtsp.Tables[0].Rows[0]["portspaceship"].ToString();
                        port1SpaceShip = dtsp.Tables[0].Rows[0]["portspaceship1"].ToString();
                        ipSpaceShip = dtsp.Tables[0].Rows[0]["ipspaceship"].ToString();
                        string message;
                        if (codeNau == codeNauBBDD)
                        {
                            portSpaceShip = dtsp.Tables[0].Rows[0]["portspaceship"].ToString();
                            ipSpaceShip = dtsp.Tables[0].Rows[0]["ipspaceship"].ToString();
                            message = "VR" + codeNau + "VP";
                            SendMessage(message, ipSpaceShip, portSpaceShip);
                            AddLb("- " + message);
                        }
                        else
                        {
                            message = "VR" + codeNau + "AD";
                            SendMessage(message, ipSpaceShip, portSpaceShip);
                            AddLb("- " + message);

                        }
                    }
                    catch (Exception)
                    {
                        SendMessage("ERRORES AJENOS AL CÓDIGO", ipSpaceShip, portSpaceShip);
                        AddLb("- ERRORES AJENOS AL CÓDIGO");
                    }
                }
                else
                {
                    SendMessage("ORDEN DE ENTRADA INCORRECTA", ipSpaceShip, portSpaceShip);
                    AddLb("- ORDEN DE ENTRADA INCORRECTA");
                }
            }
            else
            {
                AddLb("+ DEC --> " + text);
                int pos = 1;
                if (pos == status)
                {
                    try
                    {
                        string validationCode = text;
                        string valCodeBBDD = Acc.PortarPerConsulta("select * from innerencryption where idplanet = " + idpla).Tables[0].Rows[0][1].ToString();
                        string message;
                        if (validationCode == valCodeBBDD)
                        {
                            message = "VR" + codeNau + "VP";
                            SendMessage(message, ipSpaceShip, portSpaceShip);
                            AddLb("-" + message);
                            SendZip(Application.StartupPath + "\\fitxers\\PACS.zip", ipSpaceShip, int.Parse(port1SpaceShip));
                        }
                        else
                        {
                            message = "VR" + codeNau + "AD";
                            SendMessage(message, ipSpaceShip, portSpaceShip);
                            AddLb("-" + message);
                        }
                    }
                    catch (Exception)
                    {
                        SendMessage("ERRORES AJENOS AL CÓDIGO", ipSpaceShip, portSpaceShip);
                        AddLb("- ERRORES AJENOS AL CÓDIGO");
                    }
                }
                else
                {
                    SendMessage("ORDEN DE ENTRADA INCORRECTA", ipSpaceShip, portSpaceShip);
                    AddLb("- ORDEN DE ENTRADA INCORRECTA");
                }
            }
        }


        public string RandomString()
        {
            caract = chars.ToCharArray();
            var bytearr = new byte[4];
            rng.GetBytes(bytearr);
            var randint = BitConverter.ToInt32(bytearr, 0);
            Random rand = new Random(randint);
            int pos = rand.Next(0, caract.Length);
            return caract[pos].ToString();
        }

        private void Planet_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        private void Insert_EncryptionData()
        {
            planets = Acc.PortarPerConsulta("select * from Planets");
            idinn = Acc.PortarPerConsulta("select * from innerencryption where idplanet = " + idpla).Tables[0].Rows[0]["idinnerencryption"].ToString();
            DataSet infotabla = Acc.PortarTaula("InnerEncryptionData");
            string query = "Select * from InnerEncryptionData";
            DataRow row = null;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                row = infotabla.Tables[0].NewRow();
                row["idInnerEncryption"] = idinn;
                row["word"] = i;
                row["numbers"] = dic[i.ToString()];
                infotabla.Tables[0].Rows.Add(row);
            }
            Acc.Actualitzar(infotabla, query);
        }

        private void Insert_Encryption()
        {
            DataSet infotabla = Acc.PortarTaula("InnerEncryption");
            DataRow row;
            string query = "select * from InnerEncryption";
            row = infotabla.Tables[0].NewRow();
            row["idPlanet"] = idpla;
            row["ValidationCode"] = code;
            infotabla.Tables[0].Rows.Add(row);
            Acc.Actualitzar(infotabla, query);
        }

        private void Generate(object sender, EventArgs e)
        {
            comprimit = new Thread(ComprimirFitxers);
            fitxers = new Thread(GenerarFitxers);
            comprimit.Start();
            fitxers.Start();
        }
        private void DeleteData()
        {
            idpla = Acc.PortarPerConsulta("select * from planets where idplanet = '" + comboBox1.SelectedValue + "'").Tables[0].Rows[0]["idplanet"].ToString();
            try
            {
                idinn = Acc.PortarPerConsulta("select * from innerencryption where idplanet = " + idpla).Tables[0].Rows[0]["idinnerencryption"].ToString();
                Acc.Executa("delete from innerencryptiondata where idinnerencryption = " + idinn);
                Acc.Executa("delete from innerencryption where idplanet = " + idpla);
            }
            catch (Exception)
            { }
        }

        private void Compare(object sender, EventArgs e)
        {
            if (CompararHash())
            {
                listBox1.Items.Add("✔️FRIENDLY SPACESHIP✔️. ACCES ALLOWED");
            }
            else
            {
                listBox1.Items.Add("⚠️UNKNOWN SPACESHIP⚠️. ACCES DENIED.");
            }
        }

        private void Insert(object sender, EventArgs e)
        {
            DeleteData();
            Insert_Encryption();
            Insert_EncryptionData();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Connect(object sender, EventArgs e)
        {
            idpla = Acc.PortarPerConsulta("select * from planets where idplanet = '" + comboBox1.SelectedValue + "'").Tables[0].Rows[0]["idplanet"].ToString();
            planetSelected = planets.Tables[0].Select("IdPlanet=" + comboBox1.SelectedValue);
            portPlanetSelected = planetSelected[0]["portplanet"].ToString();
            conectado = true;
            HiloTCP();
            ThreadStart Ts = new ThreadStart(StartReceiving);
            T = new Thread(Ts);
            T.SetApartmentState(ApartmentState.STA);
            T.Start();
        }

        private void RSA(object sender, EventArgs e)
        {
            IniciarRSA();
        }

        public void StartReceiving()
        {
            ReceiveTCP(int.Parse(planetSelected[0]["portplanet1"].ToString()));
        }

        private void SendMessage(string mes, string ip, string port)
        {
            try
            {
                client = new TcpClient(ip, Int32.Parse(port));
                ns = client.GetStream();
                byte[] nouBuffer = Encoding.ASCII.GetBytes(mes);
                ns.Write(nouBuffer, 0, nouBuffer.Length);
                status++;
                ns.Close();
                client.Close();
            }
            catch (Exception)
            {
                listBox1.Items.Add("⚠️Error al intentarse conectar al puerto.");
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
                int TotalLength = (int)Fs.Length, CurrentPacketLength;
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
                listBox1.Items.Add("⚠️" + ex.Message);
            }
            finally
            {
                netstream.Close();
                client.Close();
            }

        }

        #endregion

        #region RSAFunciones

        private void IniciarRSA()
        {
            planetSelected = planets.Tables[0].Select("IdPlanet=" + comboBox1.SelectedValue);
            portPlanetSelected = planetSelected[0]["portplanet"].ToString();
            parametros = new CspParameters();
            parametros.KeyContainerName = Acc.PortarPerConsulta("select * from planets where idplanet = " + comboBox1.SelectedValue).Tables[0].Rows[0]["codeplanet"].ToString();
            rsa = new RSACryptoServiceProvider(parametros);

            llavePublica = rsa.ToXmlString(false);
            Acc.Executa("delete from planetkeys where idplanet = " + comboBox1.SelectedValue);
            DataSet pKey = Acc.PortarTaula("Planetkeys");
            DataRow row;
            row = pKey.Tables[0].NewRow();
            row["idPlanet"] = comboBox1.SelectedValue;
            row["xmlkey"] = llavePublica;
            pKey.Tables[0].Rows.Add(row);
            string query = "Select * from planetkeys";
            Acc.Actualitzar(pKey, query);
        }

        private byte[] Encriptar(string texto)
        {
            RSACryptoServiceProvider rsaEnc = new RSACryptoServiceProvider();
            string xmlkey = Acc.PortarPerConsulta("select * from planetkeys where idplanet = " + comboBox1.SelectedValue).Tables[0].Rows[0]["xmlkey"].ToString();
            rsaEnc.FromXmlString(xmlkey);
            byte[] bytesTexto = ByteConverter.GetBytes(texto);
            return rsaEnc.Encrypt(bytesTexto, false);
        }

        private byte[] Desencriptar(byte[] texto)
        {
            CspParameters csp = new CspParameters();
            csp.KeyContainerName = Acc.PortarPerConsulta("select * from planets where idplanet = " + comboBox1.SelectedValue).Tables[0].Rows[0]["codeplanet"].ToString();
            RSACryptoServiceProvider rsade = new RSACryptoServiceProvider(csp);
            return rsade.Decrypt(texto, false);
        }
        #endregion

    }
}
