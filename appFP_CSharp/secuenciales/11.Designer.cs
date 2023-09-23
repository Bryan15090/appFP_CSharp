namespace appFP_CSharp.secuenciales
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
            btnCalcular = new Button();
            lblIntercambio = new Label();
            lblN2 = new Label();
            lblN1 = new Label();
            txtIntercambio = new TextBox();
            txtNumero2 = new TextBox();
            txtNumero = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(129, 168);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 16;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblIntercambio
            // 
            lblIntercambio.AutoSize = true;
            lblIntercambio.Location = new Point(38, 114);
            lblIntercambio.Name = "lblIntercambio";
            lblIntercambio.Size = new Size(147, 15);
            lblIntercambio.TabIndex = 9;
            lblIntercambio.Text = "Numeros intercambiados :";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(38, 82);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(136, 15);
            lblN2.TabIndex = 10;
            lblN2.Text = "2do Numero de 3 cifras :";
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Location = new Point(38, 53);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(132, 15);
            lblN1.TabIndex = 11;
            lblN1.Text = "1er Numero de 3 cifras :";
            // 
            // txtIntercambio
            // 
            txtIntercambio.Location = new Point(194, 111);
            txtIntercambio.Name = "txtIntercambio";
            txtIntercambio.ReadOnly = true;
            txtIntercambio.Size = new Size(100, 23);
            txtIntercambio.TabIndex = 14;
            txtIntercambio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(194, 79);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 13;
            txtNumero2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(194, 50);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 12;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 224);
            Controls.Add(btnCalcular);
            Controls.Add(lblIntercambio);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(txtIntercambio);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblIntercambio;
        private Label lblN2;
        private Label lblN1;
        private TextBox txtIntercambio;
        private TextBox txtNumero2;
        private TextBox txtNumero;
    }
}