namespace appFP_CSharp.secuenciales
{
    partial class _12
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
            lblHipotenusa = new Label();
            lblN2 = new Label();
            lblCOpuesto = new Label();
            txtHipotenusa = new TextBox();
            txtCAdyacente = new TextBox();
            txtCOpuesto = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(114, 152);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 23;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblHipotenusa
            // 
            lblHipotenusa.AutoSize = true;
            lblHipotenusa.Location = new Point(41, 110);
            lblHipotenusa.Name = "lblHipotenusa";
            lblHipotenusa.Size = new Size(74, 15);
            lblHipotenusa.TabIndex = 17;
            lblHipotenusa.Text = "Hipotenusa :";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Location = new Point(41, 78);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(105, 15);
            lblN2.TabIndex = 18;
            lblN2.Text = "Cateto adyacente :";
            // 
            // lblCOpuesto
            // 
            lblCOpuesto.AutoSize = true;
            lblCOpuesto.Location = new Point(41, 49);
            lblCOpuesto.Name = "lblCOpuesto";
            lblCOpuesto.Size = new Size(94, 15);
            lblCOpuesto.TabIndex = 19;
            lblCOpuesto.Text = "Cateto opuesto :";
            // 
            // txtHipotenusa
            // 
            txtHipotenusa.Location = new Point(166, 107);
            txtHipotenusa.Name = "txtHipotenusa";
            txtHipotenusa.ReadOnly = true;
            txtHipotenusa.Size = new Size(100, 23);
            txtHipotenusa.TabIndex = 22;
            txtHipotenusa.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCAdyacente
            // 
            txtCAdyacente.Location = new Point(166, 75);
            txtCAdyacente.Name = "txtCAdyacente";
            txtCAdyacente.Size = new Size(100, 23);
            txtCAdyacente.TabIndex = 21;
            txtCAdyacente.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCOpuesto
            // 
            txtCOpuesto.Location = new Point(166, 46);
            txtCOpuesto.Name = "txtCOpuesto";
            txtCOpuesto.Size = new Size(100, 23);
            txtCOpuesto.TabIndex = 20;
            txtCOpuesto.TextAlign = HorizontalAlignment.Right;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 209);
            Controls.Add(btnCalcular);
            Controls.Add(lblHipotenusa);
            Controls.Add(lblN2);
            Controls.Add(lblCOpuesto);
            Controls.Add(txtHipotenusa);
            Controls.Add(txtCAdyacente);
            Controls.Add(txtCOpuesto);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblHipotenusa;
        private Label lblN2;
        private Label lblCOpuesto;
        private TextBox txtHipotenusa;
        private TextBox txtCAdyacente;
        private TextBox txtCOpuesto;
    }
}