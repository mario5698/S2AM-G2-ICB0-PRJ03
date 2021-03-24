namespace Form_Base
{
    partial class Form_base
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cancel = new System.Windows.Forms.Button();
            this.Actualizar_Base = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.dtgUsers = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.ForeColor = System.Drawing.Color.PaleGreen;
            this.cancel.Location = new System.Drawing.Point(466, 428);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(114, 43);
            this.cancel.TabIndex = 108;
            this.cancel.Text = "CANCEL";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Actualizar_Base
            // 
            this.Actualizar_Base.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Actualizar_Base.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.Actualizar_Base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.Actualizar_Base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Actualizar_Base.ForeColor = System.Drawing.Color.PaleGreen;
            this.Actualizar_Base.Location = new System.Drawing.Point(646, 428);
            this.Actualizar_Base.Name = "Actualizar_Base";
            this.Actualizar_Base.Size = new System.Drawing.Size(114, 43);
            this.Actualizar_Base.TabIndex = 106;
            this.Actualizar_Base.Text = "SAVE";
            this.Actualizar_Base.UseVisualStyleBackColor = false;
            this.Actualizar_Base.Click += new System.EventHandler(this.Actualizar_Base_Click);
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.PaleGreen;
            this.add.Location = new System.Drawing.Point(284, 428);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 43);
            this.add.TabIndex = 107;
            this.add.Text = "ADD";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // dtgUsers
            // 
            this.dtgUsers.AllowUserToAddRows = false;
            this.dtgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(50)))), ((int)(((byte)(60)))));
            this.dtgUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgUsers.ColumnHeadersHeight = 34;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgUsers.EnableHeadersVisualStyles = false;
            this.dtgUsers.GridColor = System.Drawing.Color.PaleGreen;
            this.dtgUsers.Location = new System.Drawing.Point(22, 581);
            this.dtgUsers.Name = "dtgUsers";
            this.dtgUsers.ReadOnly = true;
            this.dtgUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.PaleGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.PaleGreen;
            this.dtgUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgUsers.RowTemplate.Height = 28;
            this.dtgUsers.Size = new System.Drawing.Size(1195, 205);
            this.dtgUsers.TabIndex = 93;
            this.dtgUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsers_CellContentClick);
            this.dtgUsers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsers_CellEnter);
            this.dtgUsers.CurrentCellChanged += new System.EventHandler(this.ChangeImage);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(877, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // Form_base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Actualizar_Base);
            this.Controls.Add(this.add);
            this.Controls.Add(this.dtgUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_base";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button Actualizar_Base;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView dtgUsers;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}