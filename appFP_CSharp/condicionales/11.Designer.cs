namespace appFP_CSharp.condicionales
{
    partial class _11
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
            txtNumero = new TextBox();
            txtRpta = new TextBox();
            lblNumero = new Label();
            lblRpta = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(119, 53);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(119, 82);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(100, 23);
            txtRpta.TabIndex = 2;
            txtRpta.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(44, 56);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero:";
            // 
            // lblRpta
            // 
            lblRpta.AutoSize = true;
            lblRpta.Location = new Point(44, 85);
            lblRpta.Name = "lblRpta";
            lblRpta.Size = new Size(63, 15);
            lblRpta.TabIndex = 1;
            lblRpta.Text = "Respuesta:";
            // 
            // button1
            // 
            button1.Location = new Point(85, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 216);
            Controls.Add(button1);
            Controls.Add(lblRpta);
            Controls.Add(lblNumero);
            Controls.Add(txtRpta);
            Controls.Add(txtNumero);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtRpta;
        private Label lblNumero;
        private Label lblRpta;
        private Button button1;
    }
}