
namespace SpaceManager
{
    partial class LoginManager
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
            this.txt_Manager_User = new System.Windows.Forms.TextBox();
            this.txt_Manager_Passwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_Passwd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Manager_User
            // 
            this.txt_Manager_User.Location = new System.Drawing.Point(331, 156);
            this.txt_Manager_User.Name = "txt_Manager_User";
            this.txt_Manager_User.Size = new System.Drawing.Size(100, 20);
            this.txt_Manager_User.TabIndex = 0;
            this.txt_Manager_User.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_Manager_Passwd
            // 
            this.txt_Manager_Passwd.Location = new System.Drawing.Point(331, 203);
            this.txt_Manager_Passwd.Name = "txt_Manager_Passwd";
            this.txt_Manager_Passwd.Size = new System.Drawing.Size(100, 20);
            this.txt_Manager_Passwd.TabIndex = 1;
            this.txt_Manager_Passwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(220, 297);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(449, 297);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_Welcome.Location = new System.Drawing.Point(231, 58);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(293, 31);
            this.lbl_Welcome.TabIndex = 4;
            this.lbl_Welcome.Text = "Welcome Administrator";
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_User.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_User.Location = new System.Drawing.Point(223, 145);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(72, 31);
            this.lbl_User.TabIndex = 5;
            this.lbl_User.Text = "User";
            // 
            // lbl_Passwd
            // 
            this.lbl_Passwd.AutoSize = true;
            this.lbl_Passwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl_Passwd.ForeColor = System.Drawing.Color.PaleGreen;
            this.lbl_Passwd.Location = new System.Drawing.Point(161, 192);
            this.lbl_Passwd.Name = "lbl_Passwd";
            this.lbl_Passwd.Size = new System.Drawing.Size(134, 31);
            this.lbl_Passwd.TabIndex = 6;
            this.lbl_Passwd.Text = "Password";
            this.lbl_Passwd.Click += new System.EventHandler(this.lbl_Passwd_Click);
            // 
            // LoginManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.lbl_Passwd);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Manager_Passwd);
            this.Controls.Add(this.txt_Manager_User);
            this.Name = "LoginManager";
            this.Text = "LoginManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Manager_User;
        private System.Windows.Forms.TextBox txt_Manager_Passwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_Passwd;
    }
}