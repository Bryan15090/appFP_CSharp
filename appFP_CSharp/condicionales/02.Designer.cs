namespace appFP_CSharp.condicionales
{
    partial class _02
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
            txtUnidades = new TextBox();
            txtCompra = new TextBox();
            txtDescuento = new TextBox();
            txtTotal = new TextBox();
            txtCaramelos = new TextBox();
            lblUnidades = new Label();
            lblCompra = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            lblCaramelos = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(147, 53);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 1;
            txtUnidades.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCompra
            // 
            txtCompra.Location = new Point(147, 82);
            txtCompra.Name = "txtCompra";
            txtCompra.ReadOnly = true;
            txtCompra.Size = new Size(100, 23);
            txtCompra.TabIndex = 2;
            txtCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(147, 111);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 3;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(147, 140);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 4;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCaramelos
            // 
            txtCaramelos.Location = new Point(147, 169);
            txtCaramelos.Name = "txtCaramelos";
            txtCaramelos.ReadOnly = true;
            txtCaramelos.Size = new Size(100, 23);
            txtCaramelos.TabIndex = 5;
            txtCaramelos.TextAlign = HorizontalAlignment.Right;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(52, 56);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(62, 15);
            lblUnidades.TabIndex = 0;
            lblUnidades.Text = "Unidades :";
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.Location = new Point(52, 85);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(56, 15);
            lblCompra.TabIndex = 0;
            lblCompra.Text = "Compra :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(52, 114);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(52, 143);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total :";
            // 
            // lblCaramelos
            // 
            lblCaramelos.AutoSize = true;
            lblCaramelos.Location = new Point(52, 172);
            lblCaramelos.Name = "lblCaramelos";
            lblCaramelos.Size = new Size(69, 15);
            lblCaramelos.TabIndex = 0;
            lblCaramelos.Text = "Caramelos :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(107, 222);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 293);
            Controls.Add(btnCalcular);
            Controls.Add(lblCaramelos);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblCompra);
            Controls.Add(lblUnidades);
            Controls.Add(txtCaramelos);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtCompra);
            Controls.Add(txtUnidades);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUnidades;
        private TextBox txtCompra;
        private TextBox txtDescuento;
        private TextBox txtTotal;
        private TextBox txtCaramelos;
        private Label lblUnidades;
        private Label lblCompra;
        private Label lblDescuento;
        private Label lblTotal;
        private Label lblCaramelos;
        private Button btnCalcular;
    }
}