using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceManager
{
    public partial class ControlDeliveryData : Form_Base.Form_base
    {
        public ControlDeliveryData()
        {
            tabla = "deliverydata";
            order = "codedelivery";
            type = "asc";
            id = "iddeliverydata";
            dtg_head = new string[5] {"Id", "Codigo", "Fecha de Entrega", "Id Planeta", "Id Nave",};
            InitializeComponent();
        }
    }
}
