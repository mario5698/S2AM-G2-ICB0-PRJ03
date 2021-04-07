
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.galaxyPanel3 = new GalaxyUI.GalaxyPanel();
            this.galaxyPanel2 = new GalaxyUI.GalaxyPanel();
            this.btnCompare = new GalaxyUI.GalaxyButton();
            this.btnRSA = new GalaxyUI.GalaxyButton();
            this.btnConnect = new GalaxyUI.GalaxyButton();
            this.btnGenerate = new GalaxyUI.GalaxyButton();
            this.btnInsert = new GalaxyUI.GalaxyButton();
            this.btnCreateCodification = new GalaxyUI.GalaxyButton();
            this.galaxyPanel1 = new GalaxyUI.GalaxyPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(837, 113);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(641, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "PLANET:";
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
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lbx_Missatges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx_Missatges.ForeColor = System.Drawing.Color.White;
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.ItemHeight = 20;
            this.lbx_Missatges.Location = new System.Drawing.Point(565, 304);
            this.lbx_Missatges.Margin = new System.Windows.Forms.Padding(2);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(642, 220);
            this.lbx_Missatges.TabIndex = 10;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Black;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Impact", 11F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(1869, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(49, 44);
            this.btn_Exit.TabIndex = 115;
            this.btn_Exit.Text = "✖️";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1922, 44);
            this.panel1.TabIndex = 116;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(848, 623);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 36);
            this.label2.TabIndex = 119;
            this.label2.Text = "LOG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(815, 221);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 36);
            this.label4.TabIndex = 120;
            this.label4.Text = "MESSAGES";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(565, 711);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(642, 220);
            this.listBox1.TabIndex = 121;
            // 
            // galaxyPanel3
            // 
            this.galaxyPanel3.BackColor = System.Drawing.Color.Transparent;
            this.galaxyPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.galaxyPanel3.Location = new System.Drawing.Point(509, 669);
            this.galaxyPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.galaxyPanel3.Name = "galaxyPanel3";
            this.galaxyPanel3.Size = new System.Drawing.Size(773, 328);
            this.galaxyPanel3.TabIndex = 122;
            this.galaxyPanel3.Tema = GalaxyUI.ThemeName.Vitruvian;
            // 
            // galaxyPanel2
            // 
            this.galaxyPanel2.BackColor = System.Drawing.Color.Transparent;
            this.galaxyPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.galaxyPanel2.Location = new System.Drawing.Point(821, 105);
            this.galaxyPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.galaxyPanel2.Name = "galaxyPanel2";
            this.galaxyPanel2.Size = new System.Drawing.Size(217, 50);
            this.galaxyPanel2.TabIndex = 34;
            this.galaxyPanel2.Tema = GalaxyUI.ThemeName.Vitruvian;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.Color.Transparent;
            this.btnCompare.Location = new System.Drawing.Point(1324, 711);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(379, 124);
            this.btnCompare.TabIndex = 32;
            this.btnCompare.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnCompare.Texto = "Compare";
            // 
            // btnRSA
            // 
            this.btnRSA.BackColor = System.Drawing.Color.Transparent;
            this.btnRSA.Location = new System.Drawing.Point(1324, 484);
            this.btnRSA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRSA.Name = "btnRSA";
            this.btnRSA.Size = new System.Drawing.Size(379, 124);
            this.btnRSA.TabIndex = 31;
            this.btnRSA.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnRSA.Texto = "Create RSA";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.Location = new System.Drawing.Point(1324, 261);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(379, 124);
            this.btnConnect.TabIndex = 30;
            this.btnConnect.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnConnect.Texto = "Connect";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.Location = new System.Drawing.Point(71, 711);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(379, 124);
            this.btnGenerate.TabIndex = 29;
            this.btnGenerate.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnGenerate.Texto = "Generate Archives";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Transparent;
            this.btnInsert.Location = new System.Drawing.Point(71, 492);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(379, 116);
            this.btnInsert.TabIndex = 28;
            this.btnInsert.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnInsert.Texto = "Insert BBDD";
            // 
            // btnCreateCodification
            // 
            this.btnCreateCodification.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateCodification.Location = new System.Drawing.Point(71, 258);
            this.btnCreateCodification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateCodification.Name = "btnCreateCodification";
            this.btnCreateCodification.Size = new System.Drawing.Size(379, 127);
            this.btnCreateCodification.TabIndex = 27;
            this.btnCreateCodification.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btnCreateCodification.Texto = "Create Codification";
            // 
            // galaxyPanel1
            // 
            this.galaxyPanel1.BackColor = System.Drawing.Color.Transparent;
            this.galaxyPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.galaxyPanel1.Location = new System.Drawing.Point(509, 262);
            this.galaxyPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.galaxyPanel1.Name = "galaxyPanel1";
            this.galaxyPanel1.Size = new System.Drawing.Size(773, 328);
            this.galaxyPanel1.TabIndex = 33;
            this.galaxyPanel1.Tema = GalaxyUI.ThemeName.Vitruvian;
            // 
            // Planet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1920, 1046);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.galaxyPanel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "Planet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.StyleChanged += new System.EventHandler(this.Planet_Load);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private GalaxyUI.GalaxyPanel galaxyPanel3;
    }
}

