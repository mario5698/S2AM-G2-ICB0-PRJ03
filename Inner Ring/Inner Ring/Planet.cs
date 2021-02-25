using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


namespace Inner_Ring
{
    public partial class Planet : Form
    {

        public Planet()
        {
            InitializeComponent();
            ObtenerPlanetas();

        }

        #region RSA

        public byte[] encrypted;
        Thread sendzip;
        Thread fitxers;
        Thread comprimit;
        Thread hilotcp;
        TcpListener Listener;
        TcpClient client;
        byte[] buffer;
        NetworkStream ns;
        CspParameters cspp;
        Byte[] dades;
        RSACryptoServiceProvider rsa;
        string publicKey;
        string code;
        string path;
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
            foreach (KeyValuePair<string, string> kvp in dic)
            {
                listBox1.Items.Add(kvp.Key + "  --  " + kvp.Value);
            }
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
            Parallel.For(0, 3, i =>
            {
                EscriureLletres(i);
                EscriureCodi(i);
            });
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
            FileStream fs = new FileStream(Application.StartupPath + "\\fitxers\\lletres" + num + ".txt", FileMode.Create, FileAccess.Write);
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

        private void EscriureCodi(int num)
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\fitxers\\PACS\\PACS" + num + ".txt", FileMode.Append, FileAccess.Write, FileShare.Read);
            FileStream frs = new FileStream(Application.StartupPath + "\\fitxers\\lletres" + num + ".txt", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);

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
            { }
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


        private void button1_Click(object sender, EventArgs e)
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
                Listener = new TcpListener(IPAddress.Any, Int32.Parse(portPlanetSelected));
                Listener.Start();
                MessageBox.Show("Conexió habilitada amb el port: " + portPlanetSelected);
                while (conectado)
                {
                    if (Listener.Pending())
                    { 
                        client = Listener.AcceptTcpClient();
                        string[] ip = client.Client.RemoteEndPoint.ToString().Split(':');
                        ns = client.GetStream();
                        buffer = new byte[1024];
                        int bytes = ns.Read(buffer, 0, buffer.Length);
                        lbx_Missatges.Items.Add(codeNau + " ha enviat:");
                        lbx_Missatges.Items.Add(" ");
                        rebut = Encoding.ASCII.GetString(buffer, 0, bytes);
                        lbx_Missatges.Items.Add(rebut);
                        lbx_Missatges.Items.Add("---------------------------------------------------");
                        AnaliseMess(rebut);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error del servidor");
            }
        }

        private void HiloTCP()
        {
            hilotcp = new Thread(new ThreadStart(Listen));
            hilotcp.Start();
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
                        }
                        else
                        {
                            message = "VR" + codeNau + "AD";
                            SendMessage(message, ipSpaceShip, portSpaceShip);
                        }
                    }
                    catch (Exception)
                    {
                        SendMessage("ERRORES AJENOS AL CÓDIGO", ipSpaceShip, portSpaceShip);
                    }
                }
                else
                {
                    SendMessage("ORDEN DE ENTRADA INCORRECTA", ipSpaceShip, portSpaceShip);
                }

            }
            else if (first == "VK")
            {
                int pos = 1;
                if (pos == status)
                {
                    try
                    {
                        string validationCode = text.Substring(2, 12);
                        string valCodeBBDD = Acc.PortarPerConsulta("select * from innerencryption where idplanet = " + idpla).Tables[0].Rows[0][1].ToString();
                        string message;
                        if (validationCode == valCodeBBDD)
                        {
                            message = "VR" + codeNau + "VP";
                            SendMessage(message, ipSpaceShip, portSpaceShip);
                            SendZip(Application.StartupPath + "\\fitxers\\PACS.zip", ipSpaceShip, int.Parse(port1SpaceShip));
                        }
                        else
                        {
                            message = "VR" + codeNau + "AD";
                            SendMessage(message, ipSpaceShip, portSpaceShip);
                        }
                    }
                    catch (Exception)
                    {
                        SendMessage("ERRORES AJENOS AL CÓDIGO", ipSpaceShip, portSpaceShip);
                    }
                }
                else
                {
                    SendMessage("ORDEN DE ENTRADA INCORRECTA", ipSpaceShip, portSpaceShip);
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
            idinn = Acc.PortarPerConsulta("select * from innerencryption where idplanet = " + idpla).Tables[0].Rows[0][0].ToString();
            DataSet infotabla = Acc.PortarTaula("InnerEncryptionData");
            DataRow row = null;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                row = infotabla.Tables[0].NewRow();
                row["idInnerEncryption"] = idinn;
                row["word"] = i;
                row["numbers"] = dic[i.ToString()];
                infotabla.Tables[0].Rows.Add(row);
            }
            Acc.Actualitzar(infotabla);
        }

        private void Insert_Encryption()
        {
            DataSet infotabla = Acc.PortarTaula("InnerEncryption");
            DataRow row;
            row = infotabla.Tables[0].NewRow();
            row["idPlanet"] = idpla;
            row["ValidationCode"] = code;
            infotabla.Tables[0].Rows.Add(row);
            Acc.Actualitzar(infotabla);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            comprimit = new Thread(ComprimirFitxers);
            fitxers = new Thread(GenerarFitxers);
            comprimit.Start();
            fitxers.Start();
        }

        private void encryA_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteData()
        {
            idpla = Acc.PortarPerConsulta("select * from planets where idplanet = '" + comboBox1.SelectedValue + "'").Tables[0].Rows[0][0].ToString();
            try
            {
                idinn = Acc.PortarPerConsulta("select * from innerencryption where idplanet = " + idpla).Tables[0].Rows[0][0].ToString();
                Acc.Executa("delete from innerencryptiondata where idinnerencryption = " + idinn);
                Acc.Executa("delete from innerencryption where idplanet = " + idpla);
            }
            catch (Exception)
            {}
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DeleteData();
            Insert_Encryption();
            Insert_EncryptionData();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            idpla = Acc.PortarPerConsulta("select * from planets where idplanet = '" + comboBox1.SelectedValue + "'").Tables[0].Rows[0][0].ToString();
            planetSelected = planets.Tables[0].Select("IdPlanet=" + comboBox1.SelectedValue);
            portPlanetSelected = planetSelected[0][11].ToString();
            HiloTCP();
            conectado = true;
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
                MessageBox.Show("Error al intentarse conectar al puerto");
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
                    Fs.Close();
                }
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

        private void button4_Click(object sender, EventArgs e)
        {
            planetSelected = planets.Tables[0].Select("IdPlanet=" + comboBox1.SelectedValue);
            portPlanetSelected = planetSelected[0][11].ToString();
            try
            {
                dades = Encoding.ASCII.GetBytes(txb_message.Text);
                client = new TcpClient(txb_ip.Text, Int32.Parse(txb_portS.Text));
                ns = client.GetStream();
                byte[] nouBuffer = Encoding.ASCII.GetBytes(txb_message.Text);
                ns.Write(nouBuffer, 0, nouBuffer.Length);
                ns.Close();
                client.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al intentarse conectar al puerto");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region RSAFunciones

        private void Encriptar()
        {
            cspp = new CspParameters();
            cspp.KeyContainerName = txtRSA.Text;
            rsa = new RSACryptoServiceProvider(cspp);
            publicKey = rsa.ToXmlString(false);
            //File.WriteAllText(path, publicKey);

        }
        #endregion

    }
}
