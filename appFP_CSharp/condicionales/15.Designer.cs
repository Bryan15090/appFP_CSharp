namespace appFP_CSharp.condicionales
{
    partial class _15
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
            txtVendido = new TextBox();
            txtbruto = new TextBox();
            txtcomision = new TextBox();
            txtneto = new TextBox();
            txtdescuento = new TextBox();
            lblVendido = new Label();
            lblBruto = new Label();
            lblNeto = new Label();
            lblDescuento = new Label();
            lblComision = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtVendido
            // 
            txtVendido.Location = new Point(130, 45);
            txtVendido.Name = "txtVendido";
            txtVendido.Size = new Size(100, 23);
            txtVendido.TabIndex = 1;
            txtVendido.TextAlign = HorizontalAlignment.Right;
            // 
            // txtbruto
            // 
            txtbruto.Location = new Point(130, 74);
            txtbruto.Name = "txtbruto";
            txtbruto.ReadOnly = true;
            txtbruto.Size = new Size(100, 23);
            txtbruto.TabIndex = 2;
            txtbruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtcomision
            // 
            txtcomision.Location = new Point(130, 103);
            txtcomision.Name = "txtcomision";
            txtcomision.ReadOnly = true;
            txtcomision.Size = new Size(100, 23);
            txtcomision.TabIndex = 3;
            txtcomision.TextAlign = HorizontalAlignment.Right;
            // 
            // txtneto
            // 
            txtneto.Location = new Point(130, 132);
            txtneto.Name = "txtneto";
            txtneto.ReadOnly = true;
            txtneto.Size = new Size(100, 23);
            txtneto.TabIndex = 4;
            txtneto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtdescuento
            // 
            txtdescuento.Location = new Point(130, 164);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.ReadOnly = true;
            txtdescuento.Size = new Size(100, 23);
            txtdescuento.TabIndex = 5;
            txtdescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // lblVendido
            // 
            lblVendido.AutoSize = true;
            lblVendido.Location = new Point(36, 48);
            lblVendido.Name = "lblVendido";
            lblVendido.Size = new Size(92, 15);
            lblVendido.TabIndex = 0;
            lblVendido.Text = "Monto vendido:";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(36, 77);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(78, 15);
            lblBruto.TabIndex = 0;
            lblBruto.Text = "Sueldo Bruto:";
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(36, 106);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(78, 15);
            lblNeto.TabIndex = 0;
            lblNeto.Text = "Sueldo Neto :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(36, 135);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(36, 164);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(64, 15);
            lblComision.TabIndex = 0;
            lblComision.Text = "Comision :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(91, 212);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 267);
            Controls.Add(btnCalcular);
            Controls.Add(lblComision);
            Controls.Add(lblDescuento);
            Controls.Add(lblNeto);
            Controls.Add(lblBruto);
            Controls.Add(lblVendido);
            Controls.Add(txtdescuento);
            Controls.Add(txtneto);
            Controls.Add(txtcomision);
            Controls.Add(txtbruto);
            Controls.Add(txtVendido);
            Name = "_15";
            Text = "_15";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVendido;
        private TextBox txtbruto;
        private TextBox txtcomision;
        private TextBox txtneto;
        private TextBox txtdescuento;
        private Label lblVendido;
        private Label lblBruto;
        private Label lblNeto;
        private Label lblDescuento;
        private Label lblComision;
        private Button btnCalcular;
    }
}