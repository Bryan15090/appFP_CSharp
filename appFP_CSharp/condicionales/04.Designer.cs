namespace appFP_CSharp.condicionales
{
    partial class _04
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
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtPromedio = new TextBox();
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblPromedio = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(129, 43);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 1;
            txtNota1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(129, 72);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 2;
            txtNota2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(129, 101);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(100, 23);
            txtNota3.TabIndex = 3;
            txtNota3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(129, 130);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.ReadOnly = true;
            txtPromedio.Size = new Size(100, 23);
            txtPromedio.TabIndex = 4;
            txtPromedio.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(49, 46);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(59, 15);
            lblNota1.TabIndex = 5;
            lblNota1.Text = "Nota Nº1:";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(49, 75);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(59, 15);
            lblNota2.TabIndex = 5;
            lblNota2.Text = "Nota Nº2:";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(49, 104);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(59, 15);
            lblNota3.TabIndex = 5;
            lblNota3.Text = "Nota Nº3:";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(49, 133);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(62, 15);
            lblPromedio.TabIndex = 5;
            lblPromedio.Text = "Promedio:";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(96, 185);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 259);
            Controls.Add(btnCalcular);
            Controls.Add(lblPromedio);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtPromedio;
        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblPromedio;
        private Button btnCalcular;
    }
}