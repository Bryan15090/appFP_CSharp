namespace appFP_CSharp.condicionales
{
    partial class _16
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
            txtImensual = new TextBox();
            txtCosto = new TextBox();
            txtCuota = new TextBox();
            txtMensualidad = new TextBox();
            lblIngreso = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtImensual
            // 
            txtImensual.Location = new Point(150, 56);
            txtImensual.Name = "txtImensual";
            txtImensual.Size = new Size(100, 23);
            txtImensual.TabIndex = 1;
            txtImensual.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(150, 85);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(100, 23);
            txtCosto.TabIndex = 2;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCuota
            // 
            txtCuota.Location = new Point(150, 114);
            txtCuota.Name = "txtCuota";
            txtCuota.ReadOnly = true;
            txtCuota.Size = new Size(100, 23);
            txtCuota.TabIndex = 3;
            txtCuota.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMensualidad
            // 
            txtMensualidad.Location = new Point(150, 143);
            txtMensualidad.Name = "txtMensualidad";
            txtMensualidad.ReadOnly = true;
            txtMensualidad.Size = new Size(100, 23);
            txtMensualidad.TabIndex = 4;
            txtMensualidad.TextAlign = HorizontalAlignment.Right;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(44, 59);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(100, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Ingreso mensual :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 88);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Costo casa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 117);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 0;
            label3.Text = "Cuota inicial:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 146);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 0;
            label4.Text = "Mensualidad :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(107, 193);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 265);
            Controls.Add(btnCalcular);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIngreso);
            Controls.Add(txtMensualidad);
            Controls.Add(txtCuota);
            Controls.Add(txtCosto);
            Controls.Add(txtImensual);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtImensual;
        private TextBox txtCosto;
        private TextBox txtCuota;
        private TextBox txtMensualidad;
        private Label lblIngreso;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCalcular;
    }
}