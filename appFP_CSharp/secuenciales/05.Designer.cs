namespace appFP_CSharp.secuenciales
{
    partial class _05
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
            btncalcular = new Button();
            lblGigabyte = new Label();
            txtGigabytes = new TextBox();
            txtMegabytes = new TextBox();
            txtKilobytes = new TextBox();
            txtBytes = new TextBox();
            lblMegabytes = new Label();
            lblBytes = new Label();
            lblKilobytes = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(82, 178);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 5;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += button1_Click;
            // 
            // lblGigabyte
            // 
            lblGigabyte.AutoSize = true;
            lblGigabyte.Location = new Point(29, 40);
            lblGigabyte.Name = "lblGigabyte";
            lblGigabyte.Size = new Size(60, 15);
            lblGigabyte.TabIndex = 1;
            lblGigabyte.Text = "Gigabyte :";
            // 
            // txtGigabytes
            // 
            txtGigabytes.Location = new Point(119, 37);
            txtGigabytes.Name = "txtGigabytes";
            txtGigabytes.Size = new Size(100, 23);
            txtGigabytes.TabIndex = 1;
            txtGigabytes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMegabytes
            // 
            txtMegabytes.Location = new Point(119, 66);
            txtMegabytes.Name = "txtMegabytes";
            txtMegabytes.ReadOnly = true;
            txtMegabytes.Size = new Size(100, 23);
            txtMegabytes.TabIndex = 2;
            txtMegabytes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtKilobytes
            // 
            txtKilobytes.Location = new Point(119, 95);
            txtKilobytes.Name = "txtKilobytes";
            txtKilobytes.ReadOnly = true;
            txtKilobytes.Size = new Size(100, 23);
            txtKilobytes.TabIndex = 3;
            txtKilobytes.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBytes
            // 
            txtBytes.Location = new Point(119, 124);
            txtBytes.Name = "txtBytes";
            txtBytes.ReadOnly = true;
            txtBytes.Size = new Size(100, 23);
            txtBytes.TabIndex = 4;
            txtBytes.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMegabytes
            // 
            lblMegabytes.AutoSize = true;
            lblMegabytes.Location = new Point(29, 69);
            lblMegabytes.Name = "lblMegabytes";
            lblMegabytes.Size = new Size(71, 15);
            lblMegabytes.TabIndex = 1;
            lblMegabytes.Text = "Megabytes :";
            // 
            // lblBytes
            // 
            lblBytes.AutoSize = true;
            lblBytes.Location = new Point(29, 127);
            lblBytes.Name = "lblBytes";
            lblBytes.Size = new Size(41, 15);
            lblBytes.TabIndex = 1;
            lblBytes.Text = "Bytes :";
            // 
            // lblKilobytes
            // 
            lblKilobytes.AutoSize = true;
            lblKilobytes.Location = new Point(29, 98);
            lblKilobytes.Name = "lblKilobytes";
            lblKilobytes.Size = new Size(61, 15);
            lblKilobytes.TabIndex = 1;
            lblKilobytes.Text = "Kilobytes :";
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 241);
            Controls.Add(txtBytes);
            Controls.Add(txtKilobytes);
            Controls.Add(txtMegabytes);
            Controls.Add(txtGigabytes);
            Controls.Add(lblBytes);
            Controls.Add(lblKilobytes);
            Controls.Add(lblMegabytes);
            Controls.Add(lblGigabyte);
            Controls.Add(btncalcular);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Label lblGigabyte;
        private TextBox txtGigabytes;
        private TextBox txtMegabytes;
        private TextBox txtKilobytes;
        private TextBox txtBytes;
        private Label lblMegabytes;
        private Label lblBytes;
        private Label lblKilobytes;
    }
}