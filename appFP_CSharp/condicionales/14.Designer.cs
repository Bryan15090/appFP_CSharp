namespace appFP_CSharp.condicionales
{
    partial class _14
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
            txttarjeta = new TextBox();
            txtcompra = new TextBox();
            txtdescuento = new TextBox();
            lblNumero = new Label();
            lblMonto = new Label();
            lblDescuento = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txttarjeta
            // 
            txttarjeta.Location = new Point(168, 53);
            txttarjeta.Name = "txttarjeta";
            txttarjeta.Size = new Size(100, 23);
            txttarjeta.TabIndex = 1;
            txttarjeta.TextAlign = HorizontalAlignment.Right;
            // 
            // txtcompra
            // 
            txtcompra.Location = new Point(168, 82);
            txtcompra.Name = "txtcompra";
            txtcompra.Size = new Size(100, 23);
            txtcompra.TabIndex = 2;
            txtcompra.TextAlign = HorizontalAlignment.Right;
            // 
            // txtdescuento
            // 
            txtdescuento.Location = new Point(168, 111);
            txtdescuento.Name = "txtdescuento";
            txtdescuento.ReadOnly = true;
            txtdescuento.Size = new Size(100, 23);
            txtdescuento.TabIndex = 3;
            txtdescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(34, 56);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(109, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero de tarjeta :";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(34, 85);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(106, 15);
            lblMonto.TabIndex = 0;
            lblMonto.Text = "Monto de compra:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(34, 114);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // button1
            // 
            button1.Location = new Point(101, 165);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _14
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 241);
            Controls.Add(button1);
            Controls.Add(lblDescuento);
            Controls.Add(lblMonto);
            Controls.Add(lblNumero);
            Controls.Add(txtdescuento);
            Controls.Add(txtcompra);
            Controls.Add(txttarjeta);
            Name = "_14";
            Text = "_14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttarjeta;
        private TextBox txtcompra;
        private TextBox txtdescuento;
        private Label lblNumero;
        private Label lblMonto;
        private Label lblDescuento;
        private Button button1;
    }
}