namespace appFP_CSharp.secuenciales
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
            btncalcular = new Button();
            lblEstatura = new Label();
            txtEstatura = new TextBox();
            txtEMetros = new TextBox();
            lblEMetros = new Label();
            SuspendLayout();
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(94, 118);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 3;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click;
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(25, 48);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(95, 15);
            lblEstatura.TabIndex = 2;
            lblEstatura.Text = "Estatura en pies :";
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(151, 45);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(100, 23);
            txtEstatura.TabIndex = 1;
            txtEstatura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEMetros
            // 
            txtEMetros.Location = new Point(151, 74);
            txtEMetros.Name = "txtEMetros";
            txtEMetros.ReadOnly = true;
            txtEMetros.Size = new Size(100, 23);
            txtEMetros.TabIndex = 2;
            txtEMetros.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEMetros
            // 
            lblEMetros.AutoSize = true;
            lblEMetros.Location = new Point(25, 82);
            lblEMetros.Name = "lblEMetros";
            lblEMetros.Size = new Size(108, 15);
            lblEMetros.TabIndex = 2;
            lblEMetros.Text = "Estatura en metros:";
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 175);
            Controls.Add(txtEMetros);
            Controls.Add(txtEstatura);
            Controls.Add(lblEMetros);
            Controls.Add(lblEstatura);
            Controls.Add(btncalcular);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncalcular;
        private Label lblEstatura;
        private TextBox txtEstatura;
        private TextBox txtEMetros;
        private Label lblEMetros;
    }
}