namespace appFP_CSharp.secuenciales
{
    partial class _06
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
            lblAltura = new Label();
            txtAltura = new TextBox();
            txtRadio = new TextBox();
            txtArea = new TextBox();
            txtVolumen = new TextBox();
            lblRadio = new Label();
            lblArea = new Label();
            lblVolumen = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(92, 187);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(51, 43);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(48, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura : ";
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(133, 40);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            txtAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(133, 69);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 2;
            txtRadio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(133, 98);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 3;
            txtArea.TextAlign = HorizontalAlignment.Right;
            // 
            // txtVolumen
            // 
            txtVolumen.Location = new Point(133, 127);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.ReadOnly = true;
            txtVolumen.Size = new Size(100, 23);
            txtVolumen.TabIndex = 4;
            txtVolumen.TextAlign = HorizontalAlignment.Right;
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(51, 72);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(43, 15);
            lblRadio.TabIndex = 1;
            lblRadio.Text = "Radio :";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(51, 101);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 15);
            lblArea.TabIndex = 1;
            lblArea.Text = "Area : ";
            // 
            // lblVolumen
            // 
            lblVolumen.AutoSize = true;
            lblVolumen.Location = new Point(51, 130);
            lblVolumen.Name = "lblVolumen";
            lblVolumen.Size = new Size(60, 15);
            lblVolumen.TabIndex = 1;
            lblVolumen.Text = "Volumen :";
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 242);
            Controls.Add(txtVolumen);
            Controls.Add(txtArea);
            Controls.Add(txtRadio);
            Controls.Add(txtAltura);
            Controls.Add(lblVolumen);
            Controls.Add(lblArea);
            Controls.Add(lblRadio);
            Controls.Add(lblAltura);
            Controls.Add(btnCalcular);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblAltura;
        private TextBox txtAltura;
        private TextBox txtRadio;
        private TextBox txtArea;
        private TextBox txtVolumen;
        private Label lblRadio;
        private Label lblArea;
        private Label lblVolumen;
    }
}