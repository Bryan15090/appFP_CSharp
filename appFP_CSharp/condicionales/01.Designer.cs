namespace appFP_CSharp.condicionales
{
    partial class _01
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
            txtPrecio = new TextBox();
            txtDescuento = new TextBox();
            txtTotal = new TextBox();
            lblUnidades = new Label();
            lblPrecio = new Label();
            lblDescuento = new Label();
            lblTotal = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtUnidades
            // 
            txtUnidades.Location = new Point(141, 45);
            txtUnidades.Name = "txtUnidades";
            txtUnidades.Size = new Size(100, 23);
            txtUnidades.TabIndex = 1;
            txtUnidades.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(141, 74);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(141, 103);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 3;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(141, 132);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 4;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // lblUnidades
            // 
            lblUnidades.AutoSize = true;
            lblUnidades.Location = new Point(47, 48);
            lblUnidades.Name = "lblUnidades";
            lblUnidades.Size = new Size(62, 15);
            lblUnidades.TabIndex = 0;
            lblUnidades.Text = "Unidades :";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(47, 77);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(46, 15);
            lblPrecio.TabIndex = 0;
            lblPrecio.Text = "Precio :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(47, 106);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(47, 135);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(98, 184);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 241);
            Controls.Add(btnCalcular);
            Controls.Add(lblTotal);
            Controls.Add(lblDescuento);
            Controls.Add(lblPrecio);
            Controls.Add(lblUnidades);
            Controls.Add(txtTotal);
            Controls.Add(txtDescuento);
            Controls.Add(txtPrecio);
            Controls.Add(txtUnidades);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUnidades;
        private TextBox txtPrecio;
        private TextBox txtDescuento;
        private TextBox txtTotal;
        private Label lblUnidades;
        private Label lblPrecio;
        private Label lblDescuento;
        private Label lblTotal;
        private Button btnCalcular;
    }
}