
namespace Inner_Ring_Spaceship
{
    partial class Login
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
            this.txt_galaxi = new GalaxyUI.GalaxyTextBox();
            this.btn_galaxy_exit = new GalaxyUI.GalaxyButton();
            this.btn_galaxy_login = new GalaxyUI.GalaxyButton();
            this.SuspendLayout();
            // 
            // txt_galaxi
            // 
            this.txt_galaxi.BackColor = System.Drawing.Color.Transparent;
            this.txt_galaxi.Location = new System.Drawing.Point(254, 139);
            this.txt_galaxi.Name = "txt_galaxi";
            this.txt_galaxi.Size = new System.Drawing.Size(220, 60);
            this.txt_galaxi.TabIndex = 5;
            this.txt_galaxi.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.txt_galaxi.Texto = "";
            this.txt_galaxi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.galaxyTextBox1_KeyDown);
            // 
            // btn_galaxy_exit
            // 
            this.btn_galaxy_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_galaxy_exit.Location = new System.Drawing.Point(394, 286);
            this.btn_galaxy_exit.Name = "btn_galaxy_exit";
            this.btn_galaxy_exit.Size = new System.Drawing.Size(129, 80);
            this.btn_galaxy_exit.TabIndex = 4;
            this.btn_galaxy_exit.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btn_galaxy_exit.Texto = "Exit";
            // 
            // btn_galaxy_login
            // 
            this.btn_galaxy_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_galaxy_login.Location = new System.Drawing.Point(187, 286);
            this.btn_galaxy_login.Name = "btn_galaxy_login";
            this.btn_galaxy_login.Size = new System.Drawing.Size(129, 80);
            this.btn_galaxy_login.TabIndex = 6;
            this.btn_galaxy_login.Tema = GalaxyUI.ThemeName.Vitruvian;
            this.btn_galaxy_login.Texto = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_galaxi);
            this.Controls.Add(this.btn_galaxy_exit);
            this.Controls.Add(this.btn_galaxy_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);

        }

        #endregion
        private GalaxyUI.GalaxyButton btn_galaxy_login;
        private GalaxyUI.GalaxyButton btn_galaxy_exit;
        private GalaxyUI.GalaxyTextBox txt_galaxi;
    }
}