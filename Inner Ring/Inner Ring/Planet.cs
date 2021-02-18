using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDades;

namespace Inner_Ring
{
    public partial class Planet : Form
    {
        #region RSA

        public byte[] datosEncriptados;
        CspParameters parametros;
        RSACryptoServiceProvider rsa;
        UnicodeEncoding convertidor;
        string llavePublica;

        #endregion

        #region DB

        DataTable planets;
        Dictionary<int, string> planetsDictionary = new Dictionary<int, string>();
        Acceso Acc = new Acceso();
        private static Random random = new Random();

        #endregion

        public Planet()
        {
            InitializeComponent();
            ObtenerPlanetas();
        }

        #region DBFunciones

        private void ObtenerPlanetas() {
            planets  = Acc.PortarTaula("Planets");
            for (int i = 0; i < planets.Rows.Count; i++)
            {
                int id = int.Parse( planets.Rows[i][0].ToString());
                string planetName = planets.Rows[i][2].ToString();
                planetsDictionary.Add(id, planetName);
                comboBox1.Items.Add(planetName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string valorRandom = RandomString(10);
            MessageBox.Show(valorRandom);
            Test();
        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        #endregion

        #region RSAFunciones

        void Test()
        {
            //IniciarRSA();
            //byte[] datos;
            //datos = Encriptar(encryA.Text);
            //encryB.Text = convertidor.GetString(datos);
            //decryA.Text = convertidor.GetString(Desencriptar(datos));
        }

        private void IniciarRSA()
        {
            parametros = new CspParameters();
            parametros.KeyContainerName = txtRSA.Text;
            rsa = new RSACryptoServiceProvider(parametros);
            convertidor = new UnicodeEncoding();
            llavePublica = rsa.ToXmlString(false);
        }

        private byte[] Encriptar(string texto)
        {
            byte[] bytesTexto = convertidor.GetBytes(texto);
            return rsa.Encrypt(bytesTexto, true);
        }

        private byte[] Desencriptar(byte[] texto)
        {
            return rsa.Decrypt(texto, true);
        }

        #endregion
    }
}
