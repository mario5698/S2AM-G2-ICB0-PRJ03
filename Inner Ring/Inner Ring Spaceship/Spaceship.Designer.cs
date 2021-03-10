
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
            this.btn_listener_Conect = new System.Windows.Forms.Button();
            this.btn_SendPac = new System.Windows.Forms.Button();
            this.lbl_GetFIleComplete = new System.Windows.Forms.Label();
            this.lbl_Ip = new System.Windows.Forms.Label();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.lbl_Port1 = new System.Windows.Forms.Label();
            this.lbl_Type = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(291, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(188, 39);
            this.comboBox2.TabIndex = 1;
            // 
            // GetInfoPlanet
            // 
            this.GetInfoPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GetInfoPlanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.GetInfoPlanet.Location = new System.Drawing.Point(506, 144);
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
            this.lbx_Missatges.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.ItemHeight = 31;
            this.lbx_Missatges.Location = new System.Drawing.Point(711, 422);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(488, 345);
            this.lbx_Missatges.TabIndex = 13;
            // 
            // btn_listener_Desc
            // 
            this.btn_listener_Desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_listener_Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listener_Desc.Location = new System.Drawing.Point(973, 312);
            this.btn_listener_Desc.Name = "btn_listener_Desc";
            this.btn_listener_Desc.Size = new System.Drawing.Size(226, 82);
            this.btn_listener_Desc.TabIndex = 14;
            this.btn_listener_Desc.Text = "Disconect Listener";
            this.btn_listener_Desc.UseVisualStyleBackColor = false;
            this.btn_listener_Desc.Click += new System.EventHandler(this.btn_listener_Desc_Click);
            // 
            // btn_listener_Conect
            // 
            this.btn_listener_Conect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_listener_Conect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listener_Conect.Location = new System.Drawing.Point(711, 312);
            this.btn_listener_Conect.Name = "btn_listener_Conect";
            this.btn_listener_Conect.Size = new System.Drawing.Size(222, 82);
            this.btn_listener_Conect.TabIndex = 16;
            this.btn_listener_Conect.Text = "Start Listener";
            this.btn_listener_Conect.UseVisualStyleBackColor = false;
            this.btn_listener_Conect.Click += new System.EventHandler(this.btn_listener_Conect_Click);
            // 
            // btn_SendPac
            // 
            this.btn_SendPac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btn_SendPac.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.btn_SendPac.Location = new System.Drawing.Point(517, 245);
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
            this.lbl_GetFIleComplete.Location = new System.Drawing.Point(228, 262);
            this.lbl_GetFIleComplete.Name = "lbl_GetFIleComplete";
            this.lbl_GetFIleComplete.Size = new System.Drawing.Size(0, 13);
            this.lbl_GetFIleComplete.TabIndex = 19;
            // 
            // lbl_Ip
            // 
            this.lbl_Ip.AutoSize = true;
            this.lbl_Ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ip.Location = new System.Drawing.Point(978, 155);
            this.lbl_Ip.Name = "lbl_Ip";
            this.lbl_Ip.Size = new System.Drawing.Size(79, 31);
            this.lbl_Ip.TabIndex = 20;
            this.lbl_Ip.Text = "lbl_Ip";
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Code.Location = new System.Drawing.Point(980, 53);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(115, 31);
            this.lbl_Code.TabIndex = 21;
            this.lbl_Code.Text = "lbl_code";
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Port.Location = new System.Drawing.Point(978, 209);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(106, 31);
            this.lbl_Port.TabIndex = 22;
            this.lbl_Port.Text = "lbl_Port";
            // 
            // lbl_Port1
            // 
            this.lbl_Port1.AutoSize = true;
            this.lbl_Port1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Port1.Location = new System.Drawing.Point(1103, 209);
            this.lbl_Port1.Name = "lbl_Port1";
            this.lbl_Port1.Size = new System.Drawing.Size(121, 31);
            this.lbl_Port1.TabIndex = 25;
            this.lbl_Port1.Text = "lbl_Port1";
            // 
            // lbl_Type
            // 
            this.lbl_Type.AutoSize = true;
            this.lbl_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Type.Location = new System.Drawing.Point(980, 101);
            this.lbl_Type.Name = "lbl_Type";
            this.lbl_Type.Size = new System.Drawing.Size(117, 31);
            this.lbl_Type.TabIndex = 26;
            this.lbl_Type.Text = "lbl_Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(705, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Code Spaceship";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Spaceship IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(705, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Spaceship Port`s ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(705, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 31);
            this.label4.TabIndex = 30;
            this.label4.Text = "Type Spaceship";
            // 
            // Spaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Type);
            this.Controls.Add(this.lbl_Port1);
            this.Controls.Add(this.lbl_Port);
            this.Controls.Add(this.lbl_Code);
            this.Controls.Add(this.lbl_Ip);
            this.Controls.Add(this.lbl_GetFIleComplete);
            this.Controls.Add(this.btn_SendPac);
            this.Controls.Add(this.btn_listener_Conect);
            this.Controls.Add(this.btn_listener_Desc);
            this.Controls.Add(this.lbx_Missatges);
            this.Controls.Add(this.GetInfoPlanet);
            this.Controls.Add(this.comboBox2);
            this.ForeColor = System.Drawing.Color.PaleGreen;
            this.Name = "Spaceship";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button GetInfoPlanet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private System.Windows.Forms.Button btn_listener_Desc;
        private System.Windows.Forms.Button btn_listener_Conect;
        private System.Windows.Forms.Button btn_SendPac;
        private System.Windows.Forms.Label lbl_GetFIleComplete;
        private System.Windows.Forms.Label lbl_Ip;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.Label lbl_Port1;
        private System.Windows.Forms.Label lbl_Type;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

