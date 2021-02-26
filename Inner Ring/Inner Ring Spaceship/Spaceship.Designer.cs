
namespace Inner_Ring_Spaceship
{
    partial class Spaceship
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
            this.components = new System.ComponentModel.Container();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.GetInfoPlanet = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.btn_listener_Desc = new System.Windows.Forms.Button();
            this.GetInfoSpaceShit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_SendPac = new System.Windows.Forms.Button();
            this.lbl_GetFIleComplete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(91, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // GetInfoPlanet
            // 
            this.GetInfoPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GetInfoPlanet.Location = new System.Drawing.Point(239, 59);
            this.GetInfoPlanet.Name = "GetInfoPlanet";
            this.GetInfoPlanet.Size = new System.Drawing.Size(142, 45);
            this.GetInfoPlanet.TabIndex = 2;
            this.GetInfoPlanet.Text = "get ip and port planet selected";
            this.GetInfoPlanet.UseVisualStyleBackColor = false;
            this.GetInfoPlanet.Click += new System.EventHandler(this.GetInfoPlanet_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.Location = new System.Drawing.Point(480, 187);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(256, 95);
            this.lbx_Missatges.TabIndex = 13;
            // 
            // btn_listener_Desc
            // 
            this.btn_listener_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_listener_Desc.Location = new System.Drawing.Point(558, 109);
            this.btn_listener_Desc.Name = "btn_listener_Desc";
            this.btn_listener_Desc.Size = new System.Drawing.Size(142, 53);
            this.btn_listener_Desc.TabIndex = 14;
            this.btn_listener_Desc.Text = "Disconect Listener";
            this.btn_listener_Desc.UseVisualStyleBackColor = false;
            this.btn_listener_Desc.Click += new System.EventHandler(this.btn_listener_Desc_Click);
            // 
            // GetInfoSpaceShit
            // 
            this.GetInfoSpaceShit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GetInfoSpaceShit.Location = new System.Drawing.Point(605, 35);
            this.GetInfoSpaceShit.Name = "GetInfoSpaceShit";
            this.GetInfoSpaceShit.Size = new System.Drawing.Size(142, 45);
            this.GetInfoSpaceShit.TabIndex = 16;
            this.GetInfoSpaceShit.Text = "get ip and port SpaceShit selected";
            this.GetInfoSpaceShit.UseVisualStyleBackColor = false;
            this.GetInfoSpaceShit.Click += new System.EventHandler(this.GetInfoSpaceShit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(480, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // btn_SendPac
            // 
            this.btn_SendPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_SendPac.Location = new System.Drawing.Point(239, 144);
            this.btn_SendPac.Name = "btn_SendPac";
            this.btn_SendPac.Size = new System.Drawing.Size(142, 52);
            this.btn_SendPac.TabIndex = 18;
            this.btn_SendPac.Text = "Send File PAC";
            this.btn_SendPac.UseVisualStyleBackColor = false;
            this.btn_SendPac.Click += new System.EventHandler(this.btn_SendPac_Click);
            // 
            // lbl_GetFIleComplete
            // 
            this.lbl_GetFIleComplete.AutoSize = true;
            this.lbl_GetFIleComplete.Location = new System.Drawing.Point(52, 144);
            this.lbl_GetFIleComplete.Name = "lbl_GetFIleComplete";
            this.lbl_GetFIleComplete.Size = new System.Drawing.Size(0, 13);
            this.lbl_GetFIleComplete.TabIndex = 19;
            // 
            // Spaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_GetFIleComplete);
            this.Controls.Add(this.btn_SendPac);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GetInfoSpaceShit);
            this.Controls.Add(this.btn_listener_Desc);
            this.Controls.Add(this.lbx_Missatges);
            this.Controls.Add(this.GetInfoPlanet);
            this.Controls.Add(this.comboBox2);
            this.ForeColor = System.Drawing.Color.PaleGreen;
            this.Name = "Spaceship";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button GetInfoPlanet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private System.Windows.Forms.Button btn_listener_Desc;
        private System.Windows.Forms.Button GetInfoSpaceShit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_SendPac;
        private System.Windows.Forms.Label lbl_GetFIleComplete;
    }
}

