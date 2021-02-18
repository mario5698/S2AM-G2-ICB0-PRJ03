
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtRSA = new System.Windows.Forms.TextBox();
            this.encryA = new System.Windows.Forms.TextBox();
            this.encryB = new System.Windows.Forms.TextBox();
            this.decryA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 85);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(266, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRSA
            // 
            this.txtRSA.Location = new System.Drawing.Point(413, 87);
            this.txtRSA.Name = "txtRSA";
            this.txtRSA.Size = new System.Drawing.Size(100, 20);
            this.txtRSA.TabIndex = 2;
            // 
            // encryA
            // 
            this.encryA.Location = new System.Drawing.Point(96, 245);
            this.encryA.Name = "encryA";
            this.encryA.Size = new System.Drawing.Size(100, 20);
            this.encryA.TabIndex = 3;
            // 
            // encryB
            // 
            this.encryB.Location = new System.Drawing.Point(96, 271);
            this.encryB.Name = "encryB";
            this.encryB.Size = new System.Drawing.Size(100, 20);
            this.encryB.TabIndex = 4;
            // 
            // decryA
            // 
            this.decryA.Location = new System.Drawing.Point(96, 297);
            this.decryA.Name = "decryA";
            this.decryA.Size = new System.Drawing.Size(100, 20);
            this.decryA.TabIndex = 5;
            // 
            // Planet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decryA);
            this.Controls.Add(this.encryB);
            this.Controls.Add(this.encryA);
            this.Controls.Add(this.txtRSA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.ForeColor = System.Drawing.Color.PaleGreen;
            this.Name = "Planet";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRSA;
        private System.Windows.Forms.TextBox encryA;
        private System.Windows.Forms.TextBox encryB;
        private System.Windows.Forms.TextBox decryA;
    }
}

