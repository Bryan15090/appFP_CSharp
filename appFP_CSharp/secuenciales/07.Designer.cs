namespace appFP_CSharp.secuenciales
{
    partial class _07
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
            txtAltura = new TextBox();
            txtBase = new TextBox();
            txtArea = new TextBox();
            txtPerimetro = new TextBox();
            lblBase = new Label();
            lblAltura = new Label();
            lblArea = new Label();
            lblPerimetro = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(138, 88);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(100, 23);
            txtAltura.TabIndex = 2;
            txtAltura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(138, 59);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 1;
            txtBase.TextAlign = HorizontalAlignment.Right;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(138, 117);
            txtArea.Name = "txtArea";
            txtArea.ReadOnly = true;
            txtArea.Size = new Size(100, 23);
            txtArea.TabIndex = 3;
            txtArea.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPerimetro
            // 
            txtPerimetro.Location = new Point(138, 146);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.ReadOnly = true;
            txtPerimetro.Size = new Size(100, 23);
            txtPerimetro.TabIndex = 4;
            txtPerimetro.TextAlign = HorizontalAlignment.Right;
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(54, 62);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(37, 15);
            lblBase.TabIndex = 1;
            lblBase.Text = "Base :";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(54, 91);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(45, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "Altura :";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(54, 120);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(37, 15);
            lblArea.TabIndex = 1;
            lblArea.Text = "Area :";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(54, 149);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(68, 15);
            lblPerimetro.TabIndex = 1;
            lblPerimetro.Text = "Perimetro : ";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(95, 203);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 276);
            Controls.Add(btnCalcular);
            Controls.Add(lblPerimetro);
            Controls.Add(lblArea);
            Controls.Add(lblAltura);
            Controls.Add(lblBase);
            Controls.Add(txtPerimetro);
            Controls.Add(txtArea);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAltura;
        private TextBox txtBase;
        private TextBox txtArea;
        private TextBox txtPerimetro;
        private Label lblBase;
        private Label lblAltura;
        private Label lblArea;
        private Label lblPerimetro;
        private Button btnCalcular;
    }
}