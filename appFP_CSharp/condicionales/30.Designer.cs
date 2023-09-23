namespace appFP_CSharp.condicionales
{
    partial class _30
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
            txtCuota = new TextBox();
            txtDia = new TextBox();
            txtPago = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtCuota
            // 
            txtCuota.Location = new Point(127, 72);
            txtCuota.Name = "txtCuota";
            txtCuota.Size = new Size(100, 23);
            txtCuota.TabIndex = 0;
            txtCuota.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(127, 101);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 0;
            txtDia.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPago
            // 
            txtPago.Location = new Point(127, 130);
            txtPago.Name = "txtPago";
            txtPago.ReadOnly = true;
            txtPago.Size = new Size(100, 23);
            txtPago.TabIndex = 0;
            txtPago.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 75);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "cuota:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 104);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 1;
            label2.Text = "Dias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 133);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 1;
            label3.Text = "Pago";
            // 
            // button1
            // 
            button1.Location = new Point(90, 197);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _30
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 262);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPago);
            Controls.Add(txtDia);
            Controls.Add(txtCuota);
            Name = "_30";
            Text = "_30";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCuota;
        private TextBox txtDia;
        private TextBox txtPago;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}