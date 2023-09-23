namespace appFP_CSharp.repetitivos
{
    partial class _03
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
            txtNum = new TextBox();
            txtDivisor = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(144, 53);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            txtNum.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(144, 82);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(100, 23);
            txtDivisor.TabIndex = 2;
            txtDivisor.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(109, 139);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calculadora";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 56);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 2;
            label1.Text = "Numero: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 85);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Divisor:";
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 205);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtDivisor);
            Controls.Add(txtNum);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private TextBox txtDivisor;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}