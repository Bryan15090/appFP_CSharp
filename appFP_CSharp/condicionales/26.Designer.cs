namespace appFP_CSharp.condicionales
{
    partial class _26
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
            txtcompra = new TextBox();
            txtpago = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtcompra
            // 
            txtcompra.Location = new Point(153, 53);
            txtcompra.Name = "txtcompra";
            txtcompra.Size = new Size(100, 23);
            txtcompra.TabIndex = 1;
            txtcompra.TextAlign = HorizontalAlignment.Right;
            // 
            // txtpago
            // 
            txtpago.Location = new Point(153, 82);
            txtpago.Name = "txtpago";
            txtpago.ReadOnly = true;
            txtpago.Size = new Size(100, 23);
            txtpago.TabIndex = 2;
            txtpago.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 56);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 0;
            label1.Text = "Monto compra:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 85);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "Pago empresa:";
            // 
            // button1
            // 
            button1.Location = new Point(98, 143);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _26
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 216);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtpago);
            Controls.Add(txtcompra);
            Name = "_26";
            Text = "_26";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcompra;
        private TextBox txtpago;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}