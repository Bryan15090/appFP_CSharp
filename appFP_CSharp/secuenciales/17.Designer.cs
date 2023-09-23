namespace appFP_CSharp.secuenciales
{
    partial class _17
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
            txtDonacion = new TextBox();
            txtSalud = new TextBox();
            txtComedor = new TextBox();
            txtEscuela = new TextBox();
            txtAsilo = new TextBox();
            lblDonacion = new Label();
            lblCsalud = new Label();
            lblComedor = new Label();
            lblEscuela = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDonacion
            // 
            txtDonacion.Location = new Point(144, 47);
            txtDonacion.Name = "txtDonacion";
            txtDonacion.Size = new Size(100, 23);
            txtDonacion.TabIndex = 1;
            txtDonacion.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSalud
            // 
            txtSalud.Location = new Point(144, 76);
            txtSalud.Name = "txtSalud";
            txtSalud.ReadOnly = true;
            txtSalud.Size = new Size(100, 23);
            txtSalud.TabIndex = 2;
            txtSalud.TextAlign = HorizontalAlignment.Right;
            // 
            // txtComedor
            // 
            txtComedor.Location = new Point(144, 105);
            txtComedor.Name = "txtComedor";
            txtComedor.ReadOnly = true;
            txtComedor.Size = new Size(100, 23);
            txtComedor.TabIndex = 3;
            txtComedor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEscuela
            // 
            txtEscuela.Location = new Point(144, 134);
            txtEscuela.Name = "txtEscuela";
            txtEscuela.ReadOnly = true;
            txtEscuela.Size = new Size(100, 23);
            txtEscuela.TabIndex = 4;
            txtEscuela.TextAlign = HorizontalAlignment.Right;
            // 
            // txtAsilo
            // 
            txtAsilo.Location = new Point(144, 163);
            txtAsilo.Name = "txtAsilo";
            txtAsilo.ReadOnly = true;
            txtAsilo.Size = new Size(100, 23);
            txtAsilo.TabIndex = 5;
            txtAsilo.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDonacion
            // 
            lblDonacion.AutoSize = true;
            lblDonacion.Location = new Point(27, 50);
            lblDonacion.Name = "lblDonacion";
            lblDonacion.Size = new Size(64, 15);
            lblDonacion.TabIndex = 0;
            lblDonacion.Text = "Donacion :";
            // 
            // lblCsalud
            // 
            lblCsalud.AutoSize = true;
            lblCsalud.Location = new Point(27, 79);
            lblCsalud.Name = "lblCsalud";
            lblCsalud.Size = new Size(96, 15);
            lblCsalud.TabIndex = 0;
            lblCsalud.Text = "Centro de salud :";
            // 
            // lblComedor
            // 
            lblComedor.AutoSize = true;
            lblComedor.Location = new Point(27, 108);
            lblComedor.Name = "lblComedor";
            lblComedor.Size = new Size(103, 15);
            lblComedor.TabIndex = 0;
            lblComedor.Text = "Comedor infantil :";
            // 
            // lblEscuela
            // 
            lblEscuela.AutoSize = true;
            lblEscuela.Location = new Point(27, 137);
            lblEscuela.Name = "lblEscuela";
            lblEscuela.Size = new Size(92, 15);
            lblEscuela.TabIndex = 0;
            lblEscuela.Text = "Escuela infantil :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 166);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 0;
            label5.Text = "Asilo de ancianos :";
            // 
            // button1
            // 
            button1.Location = new Point(98, 219);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 280);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(lblEscuela);
            Controls.Add(lblComedor);
            Controls.Add(lblCsalud);
            Controls.Add(lblDonacion);
            Controls.Add(txtAsilo);
            Controls.Add(txtEscuela);
            Controls.Add(txtComedor);
            Controls.Add(txtSalud);
            Controls.Add(txtDonacion);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDonacion;
        private TextBox txtSalud;
        private TextBox txtComedor;
        private TextBox txtEscuela;
        private TextBox txtAsilo;
        private Label lblDonacion;
        private Label lblCsalud;
        private Label lblComedor;
        private Label lblEscuela;
        private Label label5;
        private Button button1;
    }
}