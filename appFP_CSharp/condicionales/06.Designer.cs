namespace appFP_CSharp.condicionales
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
            txtedad1 = new TextBox();
            txtedad2 = new TextBox();
            txtedad3 = new TextBox();
            txtEmayor = new TextBox();
            txtEmenor = new TextBox();
            lblEdad1 = new Label();
            lblEdad2 = new Label();
            lblEdad3 = new Label();
            lblEMayor = new Label();
            lblEmenor = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtedad1
            // 
            txtedad1.Location = new Point(135, 45);
            txtedad1.Name = "txtedad1";
            txtedad1.Size = new Size(100, 23);
            txtedad1.TabIndex = 0;
            txtedad1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtedad2
            // 
            txtedad2.Location = new Point(135, 74);
            txtedad2.Name = "txtedad2";
            txtedad2.Size = new Size(100, 23);
            txtedad2.TabIndex = 0;
            txtedad2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtedad3
            // 
            txtedad3.Location = new Point(135, 103);
            txtedad3.Name = "txtedad3";
            txtedad3.Size = new Size(100, 23);
            txtedad3.TabIndex = 0;
            txtedad3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEmayor
            // 
            txtEmayor.Location = new Point(135, 132);
            txtEmayor.Name = "txtEmayor";
            txtEmayor.ReadOnly = true;
            txtEmayor.Size = new Size(100, 23);
            txtEmayor.TabIndex = 0;
            txtEmayor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEmenor
            // 
            txtEmenor.Location = new Point(135, 161);
            txtEmenor.Name = "txtEmenor";
            txtEmenor.ReadOnly = true;
            txtEmenor.Size = new Size(100, 23);
            txtEmenor.TabIndex = 0;
            txtEmenor.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEdad1
            // 
            lblEdad1.AutoSize = true;
            lblEdad1.Location = new Point(50, 47);
            lblEdad1.Name = "lblEdad1";
            lblEdad1.Size = new Size(62, 15);
            lblEdad1.TabIndex = 0;
            lblEdad1.Text = "Edad Nº1 :";
            // 
            // lblEdad2
            // 
            lblEdad2.AutoSize = true;
            lblEdad2.Location = new Point(50, 77);
            lblEdad2.Name = "lblEdad2";
            lblEdad2.Size = new Size(62, 15);
            lblEdad2.TabIndex = 0;
            lblEdad2.Text = "Edad Nº2 :";
            // 
            // lblEdad3
            // 
            lblEdad3.AutoSize = true;
            lblEdad3.Location = new Point(50, 106);
            lblEdad3.Name = "lblEdad3";
            lblEdad3.Size = new Size(62, 15);
            lblEdad3.TabIndex = 0;
            lblEdad3.Text = "Edad Nº3 :";
            // 
            // lblEMayor
            // 
            lblEMayor.AutoSize = true;
            lblEMayor.Location = new Point(50, 135);
            lblEMayor.Name = "lblEMayor";
            lblEMayor.Size = new Size(76, 15);
            lblEMayor.TabIndex = 0;
            lblEMayor.Text = "Edad mayor :";
            // 
            // lblEmenor
            // 
            lblEmenor.AutoSize = true;
            lblEmenor.Location = new Point(50, 164);
            lblEmenor.Name = "lblEmenor";
            lblEmenor.Size = new Size(77, 15);
            lblEmenor.TabIndex = 0;
            lblEmenor.Text = "Edad menor :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(100, 211);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 274);
            Controls.Add(btnCalcular);
            Controls.Add(lblEmenor);
            Controls.Add(lblEMayor);
            Controls.Add(lblEdad3);
            Controls.Add(lblEdad2);
            Controls.Add(lblEdad1);
            Controls.Add(txtEmenor);
            Controls.Add(txtEmayor);
            Controls.Add(txtedad3);
            Controls.Add(txtedad2);
            Controls.Add(txtedad1);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtedad1;
        private TextBox txtedad2;
        private TextBox txtedad3;
        private TextBox txtEmayor;
        private TextBox txtEmenor;
        private Label lblEdad1;
        private Label lblEdad2;
        private Label lblEdad3;
        private Label lblEMayor;
        private Label lblEmenor;
        private Button btnCalcular;
    }
}