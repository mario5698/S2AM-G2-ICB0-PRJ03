namespace Controles_Usuario
{
    partial class SWCodi
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TXT_SWCodi = new System.Windows.Forms.TextBox();
            this.TXT_SWDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TXT_SWCodi
            // 
            this.TXT_SWCodi.BackColor = System.Drawing.Color.PaleGreen;
            this.TXT_SWCodi.Dock = System.Windows.Forms.DockStyle.Left;
            this.TXT_SWCodi.Font = new System.Drawing.Font("Arial", 10F);
            this.TXT_SWCodi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.TXT_SWCodi.Location = new System.Drawing.Point(0, 0);
            this.TXT_SWCodi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_SWCodi.Name = "TXT_SWCodi";
            this.TXT_SWCodi.Size = new System.Drawing.Size(103, 30);
            this.TXT_SWCodi.TabIndex = 0;
            this.TXT_SWCodi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TXT_SWCodi.TextChanged += new System.EventHandler(this.TXT_SWCodi_TextChanged);
            this.TXT_SWCodi.Enter += new System.EventHandler(this.TXT_SWCodi_Enter);
            this.TXT_SWCodi.Leave += new System.EventHandler(this.TXT_SWCodi_Leave);
            // 
            // TXT_SWDesc
            // 
            this.TXT_SWDesc.BackColor = System.Drawing.Color.PaleGreen;
            this.TXT_SWDesc.Dock = System.Windows.Forms.DockStyle.Right;
            this.TXT_SWDesc.Font = new System.Drawing.Font("Arial", 10F);
            this.TXT_SWDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.TXT_SWDesc.HideSelection = false;
            this.TXT_SWDesc.Location = new System.Drawing.Point(176, 0);
            this.TXT_SWDesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TXT_SWDesc.Name = "TXT_SWDesc";
            this.TXT_SWDesc.ReadOnly = true;
            this.TXT_SWDesc.Size = new System.Drawing.Size(342, 30);
            this.TXT_SWDesc.TabIndex = 0;
            this.TXT_SWDesc.TabStop = false;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TXT_SWDesc);
            this.Controls.Add(this.TXT_SWCodi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(518, 32);
            this.Load += new System.EventHandler(this.SWCodi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_SWCodi;
        private System.Windows.Forms.TextBox TXT_SWDesc;
    }
}
