namespace GalaxyUI
{
    partial class GalaxyButton
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GalaxyButton));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(0, 30);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(376, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseEnter += new System.EventHandler(this.CambiarColorActivo);
            this.pictureBox.MouseLeave += new System.EventHandler(this.CambiarColorNormal);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label.Dock = System.Windows.Forms.DockStyle.Right;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Yellow;
            this.label.Location = new System.Drawing.Point(261, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(115, 31);
            this.label.TabIndex = 1;
            this.label.Text = "Button 1";
            this.label.MouseEnter += new System.EventHandler(this.CambiarColorActivo);
            this.label.MouseLeave += new System.EventHandler(this.CambiarColorNormal);
            // 
            // GalaxyButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Name = "GalaxyButton";
            this.Size = new System.Drawing.Size(376, 80);
            this.Load += new System.EventHandler(this.GalaxyButton_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.Label label;
    }
}
