namespace appFP_CSharp.repetitivos
{
    partial class _17
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
            txtIndexOf = new TextBox();
            txtTexto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtIndexOf
            // 
            txtIndexOf.Location = new Point(121, 82);
            txtIndexOf.Name = "txtIndexOf";
            txtIndexOf.Size = new Size(100, 23);
            txtIndexOf.TabIndex = 2;
            txtIndexOf.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(121, 53);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(100, 23);
            txtTexto.TabIndex = 1;
            txtTexto.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 56);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Texto :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 85);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "IndexOF :";
            // 
            // button1
            // 
            button1.Location = new Point(89, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 191);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTexto);
            Controls.Add(txtIndexOf);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIndexOf;
        private TextBox txtTexto;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}