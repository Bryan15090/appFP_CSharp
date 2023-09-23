namespace appFP_CSharp.repetitivos
{
    partial class _13
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
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtN1
            // 
            txtN1.Location = new Point(143, 46);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 1;
            txtN1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(143, 75);
            txtN2.Name = "txtN2";
            txtN2.ReadOnly = true;
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 2;
            txtN2.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 49);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 78);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 0;
            label2.Text = "Rpta :";
            // 
            // button1
            // 
            button1.Location = new Point(115, 117);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 178);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN1;
        private TextBox txtN2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}