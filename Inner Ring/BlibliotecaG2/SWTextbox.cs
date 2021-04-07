using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data;
using Controles_Usuario;

namespace BlibliotecaG2
{
    public class SWTextbox : TextBox
    {
        public SWTextbox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.TextChanged += new System.EventHandler(this.SWTextbox_TextChanged);
            this.GotFocus += new System.EventHandler(this.SWTextbox_Enter);
            this.LostFocus += new System.EventHandler(this.SWTextbox_leave);
            this.ResumeLayout(false);

        }

        #region Declaracion Variables
        public enum TipusDada
        {
            Text,
            Data,
            Codi,
            Num
        }
        bool _Foranea, _Obligatorio;
        private TipusDada _DadaPermesa;
        string _datos;
        String _NombreBBDD, _ControllID;

        #endregion

        #region Entrada Eventos
        public bool obligatorio
        {
            get { return _Obligatorio; }
            set { _Obligatorio = value; }
        }

        public String Nom_BBDD
        {
            get { return _NombreBBDD; }
            set { _NombreBBDD = value; }
        }

        public bool Foranea
        {
            get { return _Foranea; }
            set { _Foranea = value; }
        }

        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set { _DadaPermesa = value; }
        }

        public String dada
        {
            get { return _datos; }
            set
            {
                _datos = value;
            }
        }

        public string ControllID
        {
            get { return _ControllID; }
            set { _ControllID = value; }
        }
        #endregion 



        #region Validacion de entrada
        private bool SWTextbox_Validate()
        {
            if (obligatorio && this.Text == string.Empty)
            {
                this.BackColor = Color.DarkRed;
                this.ForeColor = Color.Black;
                return false;
            }
            else
            {
                if (_DadaPermesa == TipusDada.Data)
                {
                    DateTime _val;
                    bool fecha = DateTime.TryParse(this.Text, out _val);
                    if (!fecha)
                    {
                        this.Text = string.Empty;
                        return false;
                    }
                }
                else if (_DadaPermesa == TipusDada.Codi)
                {
                    Regex rx = new Regex(@"^[A-Z]{4}-\d{3}/[1,3,5,7,9][A-Z]{1}$");
                    MatchCollection matches = rx.Matches(this.Text);
                    if (matches.Count == 0)
                    {
                        this.Text = string.Empty;
                        return false;
                    }
                }
                else if (_DadaPermesa == TipusDada.Num)
                {
                    if ((!(int.TryParse((this.Text), out int outbound))))
                    {
                        this.Text = string.Empty;
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        private void SWTextbox_leave(object sender, EventArgs e)
        {
            if (SWTextbox_Validate())
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }

        private void SWTextbox_TextChanged(object sender, EventArgs e)
        {
            if (SWTextbox_Validate())
            {

                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                if (_Foranea)
                {
                    Pasar_id();
                }
            }
            else
            {
                this.BackColor = Color.DarkRed;
                this.ForeColor = Color.Black;
            }
        }

        private void Pasar_id()
        {
            Form frm = this.FindForm();
            foreach (Control ctr in frm.Controls)
            {
                if (ctr.Name == _ControllID)
                {
                    ctr.Text = this.Text;
                }
            }
        }
        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.ForeColor = Color.White;
            this.BackColor = Color.Black;
        }
    }
}