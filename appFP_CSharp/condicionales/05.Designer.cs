namespace appFP_CSharp.condicionales
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
            txtNumero = new TextBox();
            txtRpta = new TextBox();
            lblNumero = new Label();
            lblNumeroMaximo = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(131, 55);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(131, 84);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(100, 23);
            txtRpta.TabIndex = 2;
            txtRpta.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(21, 58);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(57, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero :";
            // 
            // lblNumeroMaximo
            // 
            lblNumeroMaximo.AutoSize = true;
            lblNumeroMaximo.Location = new Point(21, 87);
            lblNumeroMaximo.Name = "lblNumeroMaximo";
            lblNumeroMaximo.Size = new Size(104, 15);
            lblNumeroMaximo.TabIndex = 0;
            lblNumeroMaximo.Text = "Numero maximo :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(95, 141);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 205);
            Controls.Add(btnCalcular);
            Controls.Add(lblNumeroMaximo);
            Controls.Add(lblNumero);
            Controls.Add(txtRpta);
            Controls.Add(txtNumero);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtRpta;
        private Label lblNumero;
        private Label lblNumeroMaximo;
        private Button btnCalcular;
    }
}