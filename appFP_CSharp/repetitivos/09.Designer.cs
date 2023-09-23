namespace appFP_CSharp.repetitivos
{
    partial class _09
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
            txaRpta = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(160, 45);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 1;
            txtNum.TextAlign = HorizontalAlignment.Right;
            // 
            // txaRpta
            // 
            txaRpta.Location = new Point(62, 103);
            txaRpta.Multiline = true;
            txaRpta.Name = "txaRpta";
            txaRpta.ReadOnly = true;
            txaRpta.Size = new Size(179, 117);
            txaRpta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero:";
            // 
            // button1
            // 
            button1.Location = new Point(115, 235);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 294);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txaRpta);
            Controls.Add(txtNum);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private TextBox txaRpta;
        private Label label1;
        private Button button1;
    }
}