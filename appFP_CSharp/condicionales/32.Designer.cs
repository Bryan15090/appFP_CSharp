namespace appFP_CSharp.condicionales
{
    partial class _32
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
            txtCategoria = new TextBox();
            txtPromedio = new TextBox();
            txtPension = new TextBox();
            txtDescuento = new TextBox();
            txtNPension = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(146, 50);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 1;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(146, 79);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(100, 23);
            txtPromedio.TabIndex = 2;
            // 
            // txtPension
            // 
            txtPension.Location = new Point(146, 108);
            txtPension.Name = "txtPension";
            txtPension.Size = new Size(100, 23);
            txtPension.TabIndex = 3;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(146, 137);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(100, 23);
            txtDescuento.TabIndex = 4;
            // 
            // txtNPension
            // 
            txtNPension.Location = new Point(146, 166);
            txtNPension.Name = "txtNPension";
            txtNPension.Size = new Size(100, 23);
            txtNPension.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 53);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Categoria:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 82);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Promedio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 111);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 0;
            label3.Text = "Pension:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 140);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 0;
            label4.Text = "Descuento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 169);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 0;
            label5.Text = "Nueva pension:";
            // 
            // button1
            // 
            button1.Location = new Point(106, 213);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _32
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 270);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNPension);
            Controls.Add(txtDescuento);
            Controls.Add(txtPension);
            Controls.Add(txtPromedio);
            Controls.Add(txtCategoria);
            Name = "_32";
            Text = "_32";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCategoria;
        private TextBox txtPromedio;
        private TextBox txtPension;
        private TextBox txtDescuento;
        private TextBox txtNPension;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
    }
}