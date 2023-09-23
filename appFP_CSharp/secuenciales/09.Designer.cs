namespace appFP_CSharp.secuenciales
{
    partial class _09
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
            btnCalcular = new Button();
            lblNumero = new Label();
            txtNumero = new TextBox();
            txtSuma = new TextBox();
            lblSuma = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(89, 116);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(25, 41);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(105, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero 4 digitos :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(130, 38);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(130, 67);
            txtSuma.Name = "txtSuma";
            txtSuma.ReadOnly = true;
            txtSuma.Size = new Size(100, 23);
            txtSuma.TabIndex = 2;
            txtSuma.TextAlign = HorizontalAlignment.Right;
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(25, 70);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(98, 15);
            lblSuma.TabIndex = 0;
            lblSuma.Text = "Suma de digitos :";
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 162);
            Controls.Add(txtSuma);
            Controls.Add(txtNumero);
            Controls.Add(lblSuma);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblNumero;
        private TextBox txtNumero;
        private TextBox txtSuma;
        private Label lblSuma;
    }
}