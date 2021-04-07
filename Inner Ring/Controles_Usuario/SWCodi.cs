using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDades;
using System.Windows.Forms;
//using BlibliotecaG2;

namespace Controles_Usuario
{
    public partial class SWCodi: UserControl
    {
        public SWCodi()
        {
            InitializeComponent();
        }

        #region Declarar Variables

        private bool _Requerit;

        private String _NomCodi;

        private String _NomTaula;

        private String _NomDesc;

        private String _NomId;

        private String _FormCS;

        private String _ClasseCs;

        private String _ControlID;

        #endregion

        #region propfulls 


        public bool Requerit
        {
            get { return _Requerit; }
            set { _Requerit = value; }
        }

        private string _Text;
        public override String  Text
        {
            get { return _Text; }
            set { _Text = value;
                InfoCodi(value);
            }
        }

        public String NomTaula
        {
            get { return _NomTaula; }
            set { _NomTaula = value; }
        }

        public String NomCodi
        {
            get { return _NomCodi; }
            set { _NomCodi = value; }
        }

        public String NomDesc   
        {
            get { return _NomDesc; }
            set { _NomDesc = value; }
        }

        public String NomId 
        {
            get { return _NomId; }
            set { _NomId = value; }
        }
        
        public String FormCS
        {
            get { return _FormCS; }
            set { _FormCS = value; }
        }

        public String ClasseCS
        {
            get { return _ClasseCs; }
            set { _ClasseCs = value; }
        }

        public String ControlID
        {
            get { return _ControlID; }
            set { _ControlID = value; }
        }


        #endregion

        private void TXT_SWCodi_Leave(object sender, EventArgs e)
        {
            TXT_SWDesc.BackColor = Color.White;
            TXT_SWDesc.ForeColor = Color.Black;
            TXT_SWCodi.BackColor = Color.White;
            TXT_SWCodi.ForeColor = Color.Black;

            Acceso acc = new Acceso();

            string consulta = "select * from " + _NomTaula + " where " + _NomCodi + "= '" + TXT_SWCodi.Text + "'";
            DataSet dts = acc.PortarPerConsulta(consulta);

            Form frm = this.FindForm();
            foreach (Control ctr in frm.Controls)
            {

                if (dts.Tables[0].Rows.Count > 0)
            {
                TXT_SWDesc.Text = dts.Tables[0].Rows[0][_NomDesc].ToString();
                if (ctr.Name == _ControlID)
                {
                    ctr.Text = dts.Tables[0].Rows[0][_NomId].ToString();
                }
            }
            else
            {
                TXT_SWDesc.Text = "Unknow Data";
                    if (ctr.Name == _ControlID)
                    {
                        ctr.Text = "";
                    }
                }
            }
        }

        private void SWCodi_Load(object sender, EventArgs e)
        {
        
        }

        public void InfoCodi(string datos)
        {
            Acceso acc = new Acceso();
            string consulta = "select * from " + _NomTaula + " where " + _NomId + "= '" + datos + "'";
            DataSet dts = acc.PortarPerConsulta(consulta);
            if (dts.Tables[0].Rows.Count > 0)
            {
                TXT_SWDesc.Text = dts.Tables[0].Rows[0][_NomDesc].ToString();
                TXT_SWCodi.Text = dts.Tables[0].Rows[0][_NomCodi].ToString();
            }
          

        }

        private void TXT_SWCodi_Enter(object sender, EventArgs e)
        {
            TXT_SWDesc.ForeColor = Color.White;
            TXT_SWDesc.BackColor = Color.Black;
            TXT_SWCodi.ForeColor = Color.White;
            TXT_SWCodi.BackColor = Color.Black;
        }

        private void TXT_SWCodi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

