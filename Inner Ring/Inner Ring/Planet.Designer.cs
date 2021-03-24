
namespace Inner_Ring
{
    partial class Planet
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.galaxyPanel2 = new GalaxyUI.GalaxyPanel();
            this.btnCompare = new GalaxyUI.GalaxyButton();
            this.btnRSA = new GalaxyUI.GalaxyButton();
            this.btnConnect = new GalaxyUI.GalaxyButton();
            this.btnGenerate = new GalaxyUI.GalaxyButton();
            this.btnInsert = new GalaxyUI.GalaxyButton();
            this.btnCreateCodification = new GalaxyUI.GalaxyButton();
            this.galaxyPanel1 = new GalaxyUI.GalaxyPanel();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(829, 144);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(633, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLANET:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(671, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 7;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lbx_Missatges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx_Missatges.ForeColor = System.Drawing.Color.White;
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.ItemHeight = 20;
            this.lbx_Missatges.Location = new System.Drawing.Point(675, 356);
            this.lbx_Missatges.Margin = new System.Windows.Forms.Padding(2);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(430, 460);
            this.lbx_Missatges.TabIndex = 10;
            this.lbx_Missatges.SelectedIndexChanged += new System.EventHandler(this.lbx_Missatges_SelectedIndexChanged);
            // 
            // galaxyPanel2
            // 
            this.galaxyPanel2.BackColor = System.Drawing.Color.Transparent;
            this.galaxyPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.galaxyPanel2.Location = new System.Drawing.Point(813, 136);
            this.galaxyPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.galaxyPanel2.Name = "galaxyPanel2";
            this.galaxyPanel2.Size = new System.Drawing.Size(217, 50);
            this.galaxyPanel2.TabIndex = 34;
            this.galaxyPanel2.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.galaxyPanel2.Load += new System.EventHandler(this.galaxyPanel2_Load);
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.Transparent;
            this.btnCompare.Location = new System.Drawing.Point(31, 764);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(379, 124);
            this.btnCompare.TabIndex = 32;
            this.btnCompare.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnCompare.Texto = "Compare";
            this.btnCompare.Load += new System.EventHandler(this.btnCompare_Load);
            // 
            // btnRSA
            // 
            this.btnRSA.BackColor = System.Drawing.Color.Transparent;
            this.btnRSA.Location = new System.Drawing.Point(31, 606);
            this.btnRSA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(379, 124);
            this.btnRSA.TabIndex = 31;
            this.btnRSA.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnRSA.Texto = "Create RSA";
            this.btnRSA.Load += new System.EventHandler(this.btnRSA_Load);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.Location = new System.Drawing.Point(31, 458);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(379, 124);
            this.btnConnect.TabIndex = 30;
            this.btnConnect.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnConnect.Texto = "Connect";
            this.btnConnect.Load += new System.EventHandler(this.btnConnect_Load);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.Location = new System.Drawing.Point(31, 308);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(379, 124);
            this.btnGenerate.TabIndex = 29;
            this.btnGenerate.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnGenerate.Texto = "Generate Archives";
            this.btnGenerate.Load += new System.EventHandler(this.btnGenerate_Load);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.Location = new System.Drawing.Point(31, 172);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(379, 116);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnInsert.Texto = "Insert BBDD";
            this.btnInsert.Load += new System.EventHandler(this.btnInsert_Load);
            // 
            // btnCreateCodification
            // 
            this.btnCreateCodification.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateCodification.Location = new System.Drawing.Point(31, 25);
            this.btnCreateCodification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateCodification.Name = "btnCreateCodification";
            this.btnCreateCodification.Size = new System.Drawing.Size(379, 127);
            this.btnCreateCodification.TabIndex = 27;
            this.btnCreateCodification.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnCreateCodification.Texto = "Create Codification";
            this.btnCreateCodification.Load += new System.EventHandler(this.btnCreateCodification_Load);
            // 
            // galaxyPanel1
            // 
            this.galaxyPanel1.BackColor = System.Drawing.Color.Transparent;
            this.galaxyPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.galaxyPanel1.Location = new System.Drawing.Point(637, 260);
            this.galaxyPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.galaxyPanel1.Name = "galaxyPanel1";
            this.galaxyPanel1.Size = new System.Drawing.Size(526, 696);
            this.galaxyPanel1.TabIndex = 33;
            this.galaxyPanel1.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.galaxyPanel1.Load += new System.EventHandler(this.galaxyPanel1_Load);
            // 
            // Planet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1920, 1046);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.galaxyPanel2);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.btnRSA);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCreateCodification);
            this.Controls.Add(this.lbx_Missatges);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.galaxyPanel1);
            this.ForeColor = System.Drawing.Color.PaleGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Planet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Planet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private GalaxyUI.GalaxyButton btnCreateCodification;
        private GalaxyUI.GalaxyButton btnInsert;
        private GalaxyUI.GalaxyButton btnGenerate;
        private GalaxyUI.GalaxyButton btnConnect;
        private GalaxyUI.GalaxyButton btnRSA;
        private GalaxyUI.GalaxyButton btnCompare;
        private GalaxyUI.GalaxyPanel galaxyPanel1;
        private GalaxyUI.GalaxyPanel galaxyPanel2;
    }
}

