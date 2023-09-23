namespace appFP_CSharp.secuenciales
{
    partial class _08
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
            lblRadio = new Label();
            lblAltura = new Label();
            lblAreaB = new Label();
            label4 = new Label();
            lblAreaT = new Label();
            txtRadio = new TextBox();
            txtAltura = new TextBox();
            txtAreaB = new TextBox();
            txtAreaL = new TextBox();
            txtAreaT = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(50, 41);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(89, 15);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "Radio cilindro : ";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(50, 70);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(88, 15);
            lblAltura.TabIndex = 0;
            lblAltura.Text = "Altura cilindro :";
            // 
            // lblAreaB
            // 
            lblAreaB.AutoSize = true;
            lblAreaB.Location = new Point(50, 99);
            lblAreaB.Name = "lblAreaB";
            lblAreaB.Size = new Size(67, 15);
            lblAreaB.TabIndex = 0;
            lblAreaB.Text = "Area base : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 128);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 0;
            label4.Text = "Area lateral :";
            // 
            // lblAreaT
            // 
            lblAreaT.AutoSize = true;
            lblAreaT.Location = new Point(50, 157);
            lblAreaT.Name = "lblAreaT";
            lblAreaT.Size = new Size(64, 15);
            lblAreaT.TabIndex = 0;
            lblAreaT.Text = "Area total :";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(145, 38);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(100, 23);
            txtRadio.TabIndex = 1;
            txtRadio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(145, 67);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 1;
            txtAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAreaB
            // 
            txtAreaB.Location = new Point(145, 96);
            txtAreaB.Name = "txtAreaB";
            txtAreaB.ReadOnly = true;
            txtAreaB.Size = new Size(100, 23);
            txtAreaB.TabIndex = 3;
            txtAreaB.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAreaL
            // 
            txtAreaL.Location = new Point(145, 125);
            txtAreaL.Name = "txtAreaL";
            txtAreaL.ReadOnly = true;
            txtAreaL.Size = new Size(100, 23);
            txtAreaL.TabIndex = 4;
            txtAreaL.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAreaT
            // 
            txtAreaT.Location = new Point(145, 154);
            txtAreaT.Name = "txtAreaT";
            txtAreaT.ReadOnly = true;
            txtAreaT.Size = new Size(100, 23);
            txtAreaT.TabIndex = 5;
            txtAreaT.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(112, 200);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 255);
            Controls.Add(btnCalcular);
            Controls.Add(txtAreaT);
            Controls.Add(txtAreaL);
            Controls.Add(txtAreaB);
            Controls.Add(txtAltura);
            Controls.Add(txtRadio);
            Controls.Add(lblAreaT);
            Controls.Add(label4);
            Controls.Add(lblAreaB);
            Controls.Add(lblAltura);
            Controls.Add(lblRadio);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private Label lblAltura;
        private Label lblAreaB;
        private Label label4;
        private Label lblAreaT;
        private TextBox txtRadio;
        private TextBox txtAltura;
        private TextBox txtAreaB;
        private TextBox txtAreaL;
        private TextBox txtAreaT;
        private Button btnCalcular;
    }
}