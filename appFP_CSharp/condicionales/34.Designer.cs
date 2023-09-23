namespace appFP_CSharp.condicionales
{
    partial class _34
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
            txtPeso = new TextBox();
            txtEstatura = new TextBox();
            txtIMC = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(153, 53);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 1;
            txtPeso.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(153, 82);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(100, 23);
            txtEstatura.TabIndex = 2;
            txtEstatura.TextAlign = HorizontalAlignment.Right;
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(153, 111);
            txtIMC.Name = "txtIMC";
            txtIMC.ReadOnly = true;
            txtIMC.Size = new Size(100, 23);
            txtIMC.TabIndex = 3;
            txtIMC.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(115, 163);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 56);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Peso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 85);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 0;
            label2.Text = "Estatura: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 114);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 0;
            label3.Text = "IMC:";
            // 
            // _34
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 224);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtIMC);
            Controls.Add(txtEstatura);
            Controls.Add(txtPeso);
            Name = "_34";
            Text = "_34";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPeso;
        private TextBox txtEstatura;
        private TextBox txtIMC;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}