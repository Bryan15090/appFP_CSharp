namespace appFP_CSharp.repetitivos
{
    partial class _07
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
            label2 = new Label();
            label1 = new Label();
            txtFactorial = new TextBox();
            txtNum = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(103, 142);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 83);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 4;
            label2.Text = "Factorial:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 54);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 5;
            label1.Text = "Numero:";
            // 
            // txtFactorial
            // 
            txtFactorial.Location = new Point(129, 80);
            txtFactorial.Name = "txtFactorial";
            txtFactorial.Size = new Size(100, 23);
            txtFactorial.TabIndex = 7;
            txtFactorial.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(129, 51);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 6;
            txtNum.TextAlign = HorizontalAlignment.Right;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 195);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFactorial);
            Controls.Add(txtNum);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox txtFactorial;
        private TextBox txtNum;
    }
}