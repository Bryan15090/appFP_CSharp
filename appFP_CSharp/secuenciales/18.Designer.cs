namespace appFP_CSharp.secuenciales
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
            button1 = new Button();
            lblpagar = new Label();
            lblDescuento = new Label();
            lblImporte = new Label();
            lblPrecio = new Label();
            lblCantidad = new Label();
            txtPagar = new TextBox();
            txtDescuento = new TextBox();
            txtImporte = new TextBox();
            txtPrecio = new TextBox();
            txtCantidad = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(99, 211);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblpagar
            // 
            lblpagar.AutoSize = true;
            lblpagar.Location = new Point(28, 158);
            lblpagar.Name = "lblpagar";
            lblpagar.Size = new Size(97, 15);
            lblpagar.TabIndex = 0;
            lblpagar.Text = "Importe a pagar :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(28, 129);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(28, 100);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(115, 15);
            lblImporte.TabIndex = 0;
            lblImporte.Text = "Importe de compra :";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(28, 71);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(90, 15);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio unitario :";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(28, 42);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(61, 15);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad :";
            // 
            // txtPagar
            // 
            txtPagar.Location = new Point(145, 155);
            txtPagar.Name = "txtPagar";
            txtPagar.ReadOnly = true;
            txtPagar.Size = new Size(100, 23);
            txtPagar.TabIndex = 5;
            txtPagar.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(145, 126);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(145, 97);
            txtImporte.Name = "txtImporte";
            txtImporte.ReadOnly = true;
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 3;
            txtImporte.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(145, 68);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(145, 39);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            txtCantidad.TextAlign = HorizontalAlignment.Right;
            // 
            // _18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 273);
            Controls.Add(button1);
            Controls.Add(lblpagar);
            Controls.Add(lblDescuento);
            Controls.Add(lblImporte);
            Controls.Add(lblPrecio);
            Controls.Add(lblCantidad);
            Controls.Add(txtPagar);
            Controls.Add(txtDescuento);
            Controls.Add(txtImporte);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Name = "_18";
            Text = "_18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblpagar;
        private Label lblDescuento;
        private Label lblImporte;
        private Label lblPrecio;
        private Label lblCantidad;
        private TextBox txtPagar;
        private TextBox txtDescuento;
        private TextBox txtImporte;
        private TextBox txtPrecio;
        private TextBox txtCantidad;
    }
}