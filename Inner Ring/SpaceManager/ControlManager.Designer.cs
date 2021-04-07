
namespace SpaceManager
{
    partial class ControlManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlManager));
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PLANETS = new System.Windows.Forms.Button();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.pnl_buttons.SuspendLayout();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnl_buttons.Controls.Add(this.button3);
            this.pnl_buttons.Controls.Add(this.button1);
            this.pnl_buttons.Controls.Add(this.PLANETS);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 0);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(198, 1024);
            this.pnl_buttons.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 72F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(0, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 220);
            this.button3.TabIndex = 2;
            this.button3.Text = "📦";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Impact", 72F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 220);
            this.button1.TabIndex = 0;
            this.button1.Text = "🚀";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PLANETS
            // 
            this.PLANETS.BackColor = System.Drawing.Color.Black;
            this.PLANETS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PLANETS.Font = new System.Drawing.Font("Impact", 72F);
            this.PLANETS.ForeColor = System.Drawing.Color.White;
            this.PLANETS.Location = new System.Drawing.Point(0, 0);
            this.PLANETS.Name = "PLANETS";
            this.PLANETS.Size = new System.Drawing.Size(198, 220);
            this.PLANETS.TabIndex = 1;
            this.PLANETS.Text = "🪐";
            this.PLANETS.UseVisualStyleBackColor = false;
            this.PLANETS.Click += new System.EventHandler(this.button2_Click);
            // 
            // pnl_data
            // 
            this.pnl_data.BackColor = System.Drawing.Color.Black;
            this.pnl_data.Controls.Add(this.pictureBox2);
            this.pnl_data.Location = new System.Drawing.Point(204, 26);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(1693, 998);
            this.pnl_data.TabIndex = 1;
            this.pnl_data.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_data_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1693, 1021);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 111;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Location = new System.Drawing.Point(204, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1693, 27);
            this.panel1.TabIndex = 115;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Black;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Impact", 11F);
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Location = new System.Drawing.Point(1033, 0);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(43, 27);
            this.btn_Exit.TabIndex = 115;
            this.btn_Exit.Text = "✖️";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // ControlManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.pnl_buttons);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ForeColor = System.Drawing.Color.PaleGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ControlManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button PLANETS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Exit;
    }
}