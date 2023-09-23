namespace appFP_CSharp.repetitivos
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
            txtDividendo = new TextBox();
            txtDivisor = new TextBox();
            txtCociente = new TextBox();
            txtResiduo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDividendo
            // 
            txtDividendo.Location = new Point(146, 70);
            txtDividendo.Name = "txtDividendo";
            txtDividendo.Size = new Size(100, 23);
            txtDividendo.TabIndex = 1;
            txtDividendo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(146, 99);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 2;
            txtDivisor.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCociente
            // 
            txtCociente.Location = new Point(146, 128);
            txtCociente.Name = "txtCociente";
            txtCociente.ReadOnly = true;
            txtCociente.Size = new Size(100, 23);
            txtCociente.TabIndex = 3;
            txtCociente.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResiduo
            // 
            txtResiduo.Location = new Point(146, 157);
            txtResiduo.Name = "txtResiduo";
            txtResiduo.ReadOnly = true;
            txtResiduo.Size = new Size(100, 23);
            txtResiduo.TabIndex = 4;
            txtResiduo.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 73);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 5;
            label1.Text = "Dividendo :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 102);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Divisor :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 131);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 5;
            label3.Text = "Cociente :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 160);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 5;
            label4.Text = "Residuo :";
            // 
            // button1
            // 
            button1.Location = new Point(117, 212);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 285);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResiduo);
            Controls.Add(txtCociente);
            Controls.Add(txtDivisor);
            Controls.Add(txtDividendo);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDividendo;
        private TextBox txtDivisor;
        private TextBox txtCociente;
        private TextBox txtResiduo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}