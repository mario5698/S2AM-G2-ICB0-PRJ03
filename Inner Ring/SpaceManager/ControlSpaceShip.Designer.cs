
namespace SpaceManager
{
    partial class ControlSpaceShip
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
            this.button1 = new System.Windows.Forms.Button();
            this.swCodi_SpType = new Controles_Usuario.SWCodi();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.sptype_swtxb = new BlibliotecaG2.SWTextbox();
            this.spCode_swtxb = new BlibliotecaG2.SWTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.portSp1_swtxb = new BlibliotecaG2.SWTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.portSp_swtxb = new BlibliotecaG2.SWTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipSp_swtxb = new BlibliotecaG2.SWTextbox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(421, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 31);
            this.button1.TabIndex = 280;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // swCodi_SpType
            // 
            this.swCodi_SpType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.swCodi_SpType.BackColor = System.Drawing.Color.Transparent;
            this.swCodi_SpType.ClasseCS = null;
            this.swCodi_SpType.ControlID = "sptype_swtxb";
            this.swCodi_SpType.ForeColor = System.Drawing.Color.Black;
            this.swCodi_SpType.FormCS = null;
            this.swCodi_SpType.Location = new System.Drawing.Point(543, 49);
            this.swCodi_SpType.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.swCodi_SpType.Name = "swCodi_SpType";
            this.swCodi_SpType.NomCodi = "CodeSpaceShipType";
            this.swCodi_SpType.NomDesc = "DescSpaceShipType";
            this.swCodi_SpType.NomId = "idSpaceShipType";
            this.swCodi_SpType.NomTaula = "SpaceShipTypes";
            this.swCodi_SpType.Requerit = false;
            this.swCodi_SpType.Size = new System.Drawing.Size(562, 43);
            this.swCodi_SpType.TabIndex = 274;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 36);
            this.label2.TabIndex = 271;
            this.label2.Text = "SpaceShip_Picture";
            // 
            // lbl8
            // 
            this.lbl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(117, 103);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(226, 36);
            this.lbl8.TabIndex = 270;
            this.lbl8.Text = "Code_SpaceShip";
            // 
            // lbl7
            // 
            this.lbl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(131, 49);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(207, 36);
            this.lbl7.TabIndex = 268;
            this.lbl7.Text = "SpaceShipType";
            // 
            // sptype_swtxb
            // 
            this.sptype_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sptype_swtxb.ControllID = "swCodi_SpType";
            this.sptype_swtxb.dada = null;
            this.sptype_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Num;
            this.sptype_swtxb.Foranea = true;
            this.sptype_swtxb.Location = new System.Drawing.Point(377, 49);
            this.sptype_swtxb.Name = "sptype_swtxb";
            this.sptype_swtxb.Nom_BBDD = "idSpaceShipType";
            this.sptype_swtxb.obligatorio = false;
            this.sptype_swtxb.Size = new System.Drawing.Size(127, 26);
            this.sptype_swtxb.TabIndex = 261;
            this.sptype_swtxb.Tag = "";
            // 
            // spCode_swtxb
            // 
            this.spCode_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spCode_swtxb.ControllID = null;
            this.spCode_swtxb.dada = null;
            this.spCode_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.spCode_swtxb.Foranea = false;
            this.spCode_swtxb.Location = new System.Drawing.Point(377, 106);
            this.spCode_swtxb.Name = "spCode_swtxb";
            this.spCode_swtxb.Nom_BBDD = "codeSpaceShip";
            this.spCode_swtxb.obligatorio = false;
            this.spCode_swtxb.Size = new System.Drawing.Size(127, 26);
            this.spCode_swtxb.TabIndex = 260;
            this.spCode_swtxb.Tag = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(116, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 36);
            this.label5.TabIndex = 286;
            this.label5.Text = "Port_SpaceShip*";
            // 
            // portSp1_swtxb
            // 
            this.portSp1_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.portSp1_swtxb.ControllID = null;
            this.portSp1_swtxb.dada = null;
            this.portSp1_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.portSp1_swtxb.Foranea = false;
            this.portSp1_swtxb.Location = new System.Drawing.Point(377, 276);
            this.portSp1_swtxb.Name = "portSp1_swtxb";
            this.portSp1_swtxb.Nom_BBDD = "PortSpaceShip1";
            this.portSp1_swtxb.obligatorio = false;
            this.portSp1_swtxb.Size = new System.Drawing.Size(127, 26);
            this.portSp1_swtxb.TabIndex = 285;
            this.portSp1_swtxb.Tag = "";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(124, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 36);
            this.label4.TabIndex = 284;
            this.label4.Text = "Port_SpaceShip";
            // 
            // portSp_swtxb
            // 
            this.portSp_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.portSp_swtxb.ControllID = null;
            this.portSp_swtxb.dada = null;
            this.portSp_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.portSp_swtxb.Foranea = false;
            this.portSp_swtxb.Location = new System.Drawing.Point(377, 217);
            this.portSp_swtxb.Name = "portSp_swtxb";
            this.portSp_swtxb.Nom_BBDD = "PortSpaceShip";
            this.portSp_swtxb.obligatorio = false;
            this.portSp_swtxb.Size = new System.Drawing.Size(127, 26);
            this.portSp_swtxb.TabIndex = 283;
            this.portSp_swtxb.Tag = "";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(154, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 36);
            this.label3.TabIndex = 282;
            this.label3.Text = "IP_SpaceShip";
            // 
            // ipSp_swtxb
            // 
            this.ipSp_swtxb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ipSp_swtxb.ControllID = null;
            this.ipSp_swtxb.dada = null;
            this.ipSp_swtxb.DadaPermesa = BlibliotecaG2.SWTextbox.TipusDada.Text;
            this.ipSp_swtxb.Foranea = false;
            this.ipSp_swtxb.Location = new System.Drawing.Point(377, 161);
            this.ipSp_swtxb.Name = "ipSp_swtxb";
            this.ipSp_swtxb.Nom_BBDD = "IPSpaceShip";
            this.ipSp_swtxb.obligatorio = false;
            this.ipSp_swtxb.Size = new System.Drawing.Size(127, 26);
            this.ipSp_swtxb.TabIndex = 281;
            this.ipSp_swtxb.Tag = "";
            // 
            // ControlSpaceShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.portSp1_swtxb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.portSp_swtxb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipSp_swtxb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.swCodi_SpType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.sptype_swtxb);
            this.Controls.Add(this.spCode_swtxb);
            this.Name = "ControlSpaceShip";
            this.Text = "ControlSpaceShip";
            this.Controls.SetChildIndex(this.spCode_swtxb, 0);
            this.Controls.SetChildIndex(this.sptype_swtxb, 0);
            this.Controls.SetChildIndex(this.lbl7, 0);
            this.Controls.SetChildIndex(this.lbl8, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.swCodi_SpType, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.ipSp_swtxb, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.portSp_swtxb, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.portSp1_swtxb, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Controles_Usuario.SWCodi swCodi_SpType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private BlibliotecaG2.SWTextbox sptype_swtxb;
        private BlibliotecaG2.SWTextbox spCode_swtxb;
        private System.Windows.Forms.Label label5;
        private BlibliotecaG2.SWTextbox portSp1_swtxb;
        private System.Windows.Forms.Label label4;
        private BlibliotecaG2.SWTextbox portSp_swtxb;
        private System.Windows.Forms.Label label3;
        private BlibliotecaG2.SWTextbox ipSp_swtxb;
    }
}