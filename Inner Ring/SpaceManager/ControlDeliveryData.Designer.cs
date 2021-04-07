
namespace SpaceManager
{
    partial class ControlDeliveryData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.idPlanet_swtxb = new BlibliotecaG2.SWTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.delDate_swtxb = new BlibliotecaG2.SWTextbox();
            this.swCodi_Sp = new Controles_Usuario.SWCodi();
            this.lbl8 = new System.Windows.Forms.Label();
            this.delCode_swtxb = new BlibliotecaG2.SWTextbox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.sp_swtxb = new BlibliotecaG2.SWTextbox();
            this.IdPlanet_swCodi = new Controles_Usuario.SWCodi();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(193, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 36);
            this.label4.TabIndex = 297;
            this.label4.Text = "Planet";
            // 
            // idPlanet_swtxb
            // 
            this.idPlanet_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.idPlanet_swtxb.ControllID = "IdPlanet_swCodi";
            this.idPlanet_swtxb.dada = null;
            this.idPlanet_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.idPlanet_swtxb.Foranea = true;
            this.idPlanet_swtxb.Location = new System.Drawing.Point(331, 221);
            this.idPlanet_swtxb.Name = "idPlanet_swtxb";
            this.idPlanet_swtxb.Nom_BBDD = "IdPlanet";
            this.idPlanet_swtxb.obligatorio = false;
            this.idPlanet_swtxb.Size = new System.Drawing.Size(127, 26);
            this.idPlanet_swtxb.TabIndex = 296;
            this.idPlanet_swtxb.Tag = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(111, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 36);
            this.label3.TabIndex = 295;
            this.label3.Text = "Delivery_Date\r\n";
            // 
            // delDate_swtxb
            // 
            this.delDate_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delDate_swtxb.ControllID = null;
            this.delDate_swtxb.dada = null;
            this.delDate_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.delDate_swtxb.Foranea = false;
            this.delDate_swtxb.Location = new System.Drawing.Point(331, 165);
            this.delDate_swtxb.Name = "delDate_swtxb";
            this.delDate_swtxb.Nom_BBDD = "DeliveryDate";
            this.delDate_swtxb.obligatorio = false;
            this.delDate_swtxb.Size = new System.Drawing.Size(127, 26);
            this.delDate_swtxb.TabIndex = 294;
            this.delDate_swtxb.Tag = "";
            // 
            // swCodi_Sp
            // 
            this.swCodi_Sp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodi_Sp.BackColor = System.Drawing.Color.Transparent;
            this.swCodi_Sp.ClasseCS = null;
            this.swCodi_Sp.ControlID = "sp_swtxb";
            this.swCodi_Sp.ForeColor = System.Drawing.Color.Black;
            this.swCodi_Sp.FormCS = null;
            this.swCodi_Sp.Location = new System.Drawing.Point(501, 276);
            this.swCodi_Sp.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swCodi_Sp.Name = "swCodi_Sp";
            this.swCodi_Sp.NomCodi = "CodeSpaceShip";
            this.swCodi_Sp.NomDesc = "IpSpaceShip";
            this.swCodi_Sp.NomId = "idSpaceShip";
            this.swCodi_Sp.NomTaula = "SpaceShips";
            this.swCodi_Sp.Requerit = false;
            this.swCodi_Sp.Size = new System.Drawing.Size(562, 43);
            this.swCodi_Sp.TabIndex = 292;
            // 
            // lbl8
            // 
            this.lbl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(102, 106);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(204, 36);
            this.lbl8.TabIndex = 290;
            this.lbl8.Text = "Code_Delivery";
            // 
            // delCode_swtxb
            // 
            this.delCode_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delCode_swtxb.ControllID = null;
            this.delCode_swtxb.dada = null;
            this.delCode_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.delCode_swtxb.Foranea = false;
            this.delCode_swtxb.Location = new System.Drawing.Point(331, 110);
            this.delCode_swtxb.Name = "delCode_swtxb";
            this.delCode_swtxb.Nom_BBDD = "codedelivery";
            this.delCode_swtxb.obligatorio = false;
            this.delCode_swtxb.Size = new System.Drawing.Size(127, 26);
            this.delCode_swtxb.TabIndex = 287;
            this.delCode_swtxb.Tag = "";
            // 
            // lbl7
            // 
            this.lbl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(143, 276);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(145, 36);
            this.lbl7.TabIndex = 289;
            this.lbl7.Text = "SpaceShip";
            // 
            // sp_swtxb
            // 
            this.sp_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sp_swtxb.ControllID = "swCodi_Sp";
            this.sp_swtxb.dada = null;
            this.sp_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Num;
            this.sp_swtxb.Foranea = true;
            this.sp_swtxb.Location = new System.Drawing.Point(331, 280);
            this.sp_swtxb.Name = "sp_swtxb";
            this.sp_swtxb.Nom_BBDD = "idSpaceShip";
            this.sp_swtxb.obligatorio = false;
            this.sp_swtxb.Size = new System.Drawing.Size(127, 26);
            this.sp_swtxb.TabIndex = 288;
            this.sp_swtxb.Tag = "";
            // 
            // IdPlanet_swCodi
            // 
            this.IdPlanet_swCodi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IdPlanet_swCodi.BackColor = System.Drawing.Color.Transparent;
            this.IdPlanet_swCodi.ClasseCS = null;
            this.IdPlanet_swCodi.ControlID = "idPlanet_swtxb";
            this.IdPlanet_swCodi.ForeColor = System.Drawing.Color.Black;
            this.IdPlanet_swCodi.FormCS = null;
            this.IdPlanet_swCodi.Location = new System.Drawing.Point(501, 221);
            this.IdPlanet_swCodi.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.IdPlanet_swCodi.Name = "IdPlanet_swCodi";
            this.IdPlanet_swCodi.NomCodi = "CodePlanet";
            this.IdPlanet_swCodi.NomDesc = "DescPlanet";
            this.IdPlanet_swCodi.NomId = "idPlanet";
            this.IdPlanet_swCodi.NomTaula = "Planets";
            this.IdPlanet_swCodi.Requerit = false;
            this.IdPlanet_swCodi.Size = new System.Drawing.Size(562, 43);
            this.IdPlanet_swCodi.TabIndex = 298;
            // 
            // ControlDeliveryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.IdPlanet_swCodi);
            this.Controls.Add(this.swCodi_Sp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idPlanet_swtxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delDate_swtxb);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.sp_swtxb);
            this.Controls.Add(this.delCode_swtxb);
            this.Name = "ControlDeliveryData";
            this.Text = "ControlDeliveryData";
            this.Controls.SetChildIndex(this.delCode_swtxb, 0);
            this.Controls.SetChildIndex(this.sp_swtxb, 0);
            this.Controls.SetChildIndex(this.lbl7, 0);
            this.Controls.SetChildIndex(this.lbl8, 0);
            this.Controls.SetChildIndex(this.delDate_swtxb, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.idPlanet_swtxb, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.swCodi_Sp, 0);
            this.Controls.SetChildIndex(this.IdPlanet_swCodi, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private BlibliotecaG2.SWTextbox idPlanet_swtxb;
        private System.Windows.Forms.Label label3;
        private BlibliotecaG2.SWTextbox delDate_swtxb;
        private Controles_Usuario.SWCodi swCodi_Sp;
        private System.Windows.Forms.Label lbl8;
        private BlibliotecaG2.SWTextbox delCode_swtxb;
        private System.Windows.Forms.Label lbl7;
        private BlibliotecaG2.SWTextbox sp_swtxb;
        private Controles_Usuario.SWCodi IdPlanet_swCodi;
    }
}