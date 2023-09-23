namespace appFP_CSharp.condicionales
{
    partial class _18
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
            txtDAnual = new TextBox();
            txtCSalud = new TextBox();
            txtCNiños = new TextBox();
            txtInvertir = new TextBox();
            lblDonacion = new Label();
            lblCSalud = new Label();
            label3 = new Label();
            lblInvertir = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtDAnual
            // 
            txtDAnual.Location = new Point(147, 54);
            txtDAnual.Name = "txtDAnual";
            txtDAnual.Size = new Size(100, 23);
            txtDAnual.TabIndex = 1;
            txtDAnual.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCSalud
            // 
            txtCSalud.Location = new Point(147, 83);
            txtCSalud.Name = "txtCSalud";
            txtCSalud.ReadOnly = true;
            txtCSalud.Size = new Size(100, 23);
            txtCSalud.TabIndex = 2;
            txtCSalud.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCNiños
            // 
            txtCNiños.Location = new Point(147, 112);
            txtCNiños.Name = "txtCNiños";
            txtCNiños.ReadOnly = true;
            txtCNiños.Size = new Size(100, 23);
            txtCNiños.TabIndex = 3;
            txtCNiños.TextAlign = HorizontalAlignment.Right;
            // 
            // txtInvertir
            // 
            txtInvertir.Location = new Point(147, 141);
            txtInvertir.Name = "txtInvertir";
            txtInvertir.ReadOnly = true;
            txtInvertir.Size = new Size(100, 23);
            txtInvertir.TabIndex = 4;
            txtInvertir.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDonacion
            // 
            lblDonacion.AutoSize = true;
            lblDonacion.Location = new Point(36, 57);
            lblDonacion.Name = "lblDonacion";
            lblDonacion.Size = new Size(93, 15);
            lblDonacion.TabIndex = 0;
            lblDonacion.Text = "Donacion anual:";
            // 
            // lblCSalud
            // 
            lblCSalud.AutoSize = true;
            lblCSalud.Location = new Point(36, 86);
            lblCSalud.Name = "lblCSalud";
            lblCSalud.Size = new Size(93, 15);
            lblCSalud.TabIndex = 0;
            lblCSalud.Text = "Centro de salud:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 115);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 0;
            label3.Text = "Comedor niños :";
            // 
            // lblInvertir
            // 
            lblInvertir.AutoSize = true;
            lblInvertir.Location = new Point(36, 144);
            lblInvertir.Name = "lblInvertir";
            lblInvertir.Size = new Size(50, 15);
            lblInvertir.TabIndex = 0;
            lblInvertir.Text = "Invertir :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(101, 196);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 257);
            Controls.Add(btnCalcular);
            Controls.Add(lblInvertir);
            Controls.Add(label3);
            Controls.Add(lblCSalud);
            Controls.Add(lblDonacion);
            Controls.Add(txtInvertir);
            Controls.Add(txtCNiños);
            Controls.Add(txtCSalud);
            Controls.Add(txtDAnual);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDAnual;
        private TextBox txtCSalud;
        private TextBox txtCNiños;
        private TextBox txtInvertir;
        private Label lblDonacion;
        private Label lblCSalud;
        private Label label3;
        private Label lblInvertir;
        private Button btnCalcular;
    }
}