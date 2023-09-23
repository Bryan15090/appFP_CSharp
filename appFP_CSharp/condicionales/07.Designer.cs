namespace appFP_CSharp.condicionales
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
            txtnum1 = new TextBox();
            txtnum2 = new TextBox();
            txtnum3 = new TextBox();
            txtRpta = new TextBox();
            lblnumero1 = new Label();
            lblnumero2 = new Label();
            lblnumero3 = new Label();
            lblIntermedio = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtnum1
            // 
            txtnum1.Location = new Point(130, 46);
            txtnum1.Name = "txtnum1";
            txtnum1.Size = new Size(100, 23);
            txtnum1.TabIndex = 1;
            txtnum1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnum2
            // 
            txtnum2.Location = new Point(130, 75);
            txtnum2.Name = "txtnum2";
            txtnum2.Size = new Size(100, 23);
            txtnum2.TabIndex = 2;
            txtnum2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnum3
            // 
            txtnum3.Location = new Point(130, 104);
            txtnum3.Name = "txtnum3";
            txtnum3.Size = new Size(100, 23);
            txtnum3.TabIndex = 3;
            txtnum3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(130, 133);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(100, 23);
            txtRpta.TabIndex = 4;
            txtRpta.TextAlign = HorizontalAlignment.Right;
            // 
            // lblnumero1
            // 
            lblnumero1.AutoSize = true;
            lblnumero1.Location = new Point(48, 49);
            lblnumero1.Name = "lblnumero1";
            lblnumero1.Size = new Size(69, 15);
            lblnumero1.TabIndex = 0;
            lblnumero1.Text = "1º numero :";
            // 
            // lblnumero2
            // 
            lblnumero2.AutoSize = true;
            lblnumero2.Location = new Point(48, 78);
            lblnumero2.Name = "lblnumero2";
            lblnumero2.Size = new Size(69, 15);
            lblnumero2.TabIndex = 0;
            lblnumero2.Text = "2º numero :";
            // 
            // lblnumero3
            // 
            lblnumero3.AutoSize = true;
            lblnumero3.Location = new Point(48, 107);
            lblnumero3.Name = "lblnumero3";
            lblnumero3.Size = new Size(69, 15);
            lblnumero3.TabIndex = 0;
            lblnumero3.Text = "3º numero :";
            // 
            // lblIntermedio
            // 
            lblIntermedio.AutoSize = true;
            lblIntermedio.Location = new Point(48, 136);
            lblIntermedio.Name = "lblIntermedio";
            lblIntermedio.Size = new Size(71, 15);
            lblIntermedio.TabIndex = 0;
            lblIntermedio.Text = "Intermedio :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(101, 187);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 258);
            Controls.Add(btnCalcular);
            Controls.Add(lblIntermedio);
            Controls.Add(lblnumero3);
            Controls.Add(lblnumero2);
            Controls.Add(lblnumero1);
            Controls.Add(txtRpta);
            Controls.Add(txtnum3);
            Controls.Add(txtnum2);
            Controls.Add(txtnum1);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum1;
        private TextBox txtnum2;
        private TextBox txtnum3;
        private TextBox txtRpta;
        private Label lblnumero1;
        private Label lblnumero2;
        private Label lblnumero3;
        private Label lblIntermedio;
        private Button btnCalcular;
    }
}