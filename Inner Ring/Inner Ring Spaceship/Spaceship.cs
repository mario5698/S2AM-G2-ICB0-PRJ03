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

namespace Inner_Ring_Spaceship
{
    public partial class Spaceship : Form
    {

        #region RSA

        RSACryptoServiceProvider rsa;
        byte[] datosEncriptados;
        string llavePublica;

        #endregion

        public Spaceship()
        {
            InitializeComponent();
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
