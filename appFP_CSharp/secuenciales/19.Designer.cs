namespace appFP_CSharp.secuenciales
{
    partial class _19
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
            lblNeto = new Label();
            lblDescuento = new Label();
            lblBruto = new Label();
            lblComision = new Label();
            lblVendido = new Label();
            txtNeto = new TextBox();
            txtDescuento = new TextBox();
            txtBruto = new TextBox();
            txtComision = new TextBox();
            txtVendido = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(99, 213);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblNeto
            // 
            lblNeto.AutoSize = true;
            lblNeto.Location = new Point(28, 160);
            lblNeto.Name = "lblNeto";
            lblNeto.Size = new Size(76, 15);
            lblNeto.TabIndex = 0;
            lblNeto.Text = "Sueldo neto :";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(28, 131);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(69, 15);
            lblDescuento.TabIndex = 0;
            lblDescuento.Text = "Descuento :";
            // 
            // lblBruto
            // 
            lblBruto.AutoSize = true;
            lblBruto.Location = new Point(28, 102);
            lblBruto.Name = "lblBruto";
            lblBruto.Size = new Size(81, 15);
            lblBruto.TabIndex = 0;
            lblBruto.Text = "Sueldo bruto :";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new Point(28, 73);
            lblComision.Name = "lblComision";
            lblComision.Size = new Size(64, 15);
            lblComision.TabIndex = 0;
            lblComision.Text = "Comision :";
            // 
            // lblVendido
            // 
            lblVendido.AutoSize = true;
            lblVendido.Location = new Point(28, 44);
            lblVendido.Name = "lblVendido";
            lblVendido.Size = new Size(95, 15);
            lblVendido.TabIndex = 0;
            lblVendido.Text = "Monto vendido :";
            // 
            // txtNeto
            // 
            txtNeto.Location = new Point(145, 157);
            txtNeto.Name = "txtNeto";
            txtNeto.ReadOnly = true;
            txtNeto.Size = new Size(100, 23);
            txtNeto.TabIndex = 5;
            txtNeto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(145, 128);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.ReadOnly = true;
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            txtDescuento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBruto
            // 
            txtBruto.Location = new Point(145, 99);
            txtBruto.Name = "txtBruto";
            txtBruto.ReadOnly = true;
            txtBruto.Size = new Size(100, 23);
            txtBruto.TabIndex = 3;
            txtBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtComision
            // 
            txtComision.Location = new Point(145, 70);
            txtComision.Name = "txtComision";
            txtComision.ReadOnly = true;
            txtComision.Size = new Size(100, 23);
            txtComision.TabIndex = 2;
            txtComision.TextAlign = HorizontalAlignment.Right;
            // 
            // txtVendido
            // 
            txtVendido.Location = new Point(145, 41);
            txtVendido.Name = "txtVendido";
            txtVendido.Size = new Size(100, 23);
            txtVendido.TabIndex = 1;
            txtVendido.TextAlign = HorizontalAlignment.Right;
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 265);
            Controls.Add(button1);
            Controls.Add(lblNeto);
            Controls.Add(lblDescuento);
            Controls.Add(lblBruto);
            Controls.Add(lblComision);
            Controls.Add(lblVendido);
            Controls.Add(txtNeto);
            Controls.Add(txtDescuento);
            Controls.Add(txtBruto);
            Controls.Add(txtComision);
            Controls.Add(txtVendido);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblNeto;
        private Label lblDescuento;
        private Label lblBruto;
        private Label lblComision;
        private Label lblVendido;
        private TextBox txtNeto;
        private TextBox txtDescuento;
        private TextBox txtBruto;
        private TextBox txtComision;
        private TextBox txtVendido;
    }
}