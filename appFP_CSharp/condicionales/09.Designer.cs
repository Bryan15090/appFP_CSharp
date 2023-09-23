namespace appFP_CSharp.condicionales
{
    partial class _09
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
            txtCodigo = new TextBox();
            txtCantidad = new TextBox();
            txtImporte = new TextBox();
            txtDescuento = new TextBox();
            txtTotal = new TextBox();
            lblCodigo = new Label();
            lblCantidad = new Label();
            lblImporte = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(192, 40);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(192, 69);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 0;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(192, 98);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 0;
            txtImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(192, 127);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 0;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(192, 156);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 0;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(50, 43);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(136, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "codigo(101,102,103,104):";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(50, 72);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(50, 101);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(112, 15);
            lblImporte.TabIndex = 1;
            lblImporte.Text = "Importe de compra:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(50, 130);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(66, 15);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(50, 159);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total:";
            // 
            // button1
            // 
            button1.Location = new Point(111, 199);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 260);
            Controls.Add(button1);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblImporte);
            Controls.Add(lblCantidad);
            Controls.Add(lblCodigo);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtImporte);
            Controls.Add(txtCantidad);
            Controls.Add(txtCodigo);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCodigo;
        private TextBox txtCantidad;
        private TextBox txtImporte;
        private TextBox txtDescuento;
        private TextBox txtTotal;
        private Label lblCodigo;
        private Label lblCantidad;
        private Label lblImporte;
        private Label lblDescuento;
        private Label lblTotal;
        private Button button1;
    }
}