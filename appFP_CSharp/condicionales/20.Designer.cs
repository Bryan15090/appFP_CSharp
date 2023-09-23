namespace appFP_CSharp.condicionales
{
    partial class _20
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
            txtnumero1 = new TextBox();
            txtnumero2 = new TextBox();
            txtnumero3 = new TextBox();
            txtrpta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtnumero1
            // 
            txtnumero1.Location = new Point(133, 53);
            txtnumero1.Name = "txtnumero1";
            txtnumero1.Size = new Size(100, 23);
            txtnumero1.TabIndex = 1;
            txtnumero1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnumero2
            // 
            txtnumero2.Location = new Point(133, 82);
            txtnumero2.Name = "txtnumero2";
            txtnumero2.Size = new Size(100, 23);
            txtnumero2.TabIndex = 2;
            txtnumero2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnumero3
            // 
            txtnumero3.Location = new Point(133, 111);
            txtnumero3.Name = "txtnumero3";
            txtnumero3.Size = new Size(100, 23);
            txtnumero3.TabIndex = 3;
            txtnumero3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtrpta
            // 
            txtrpta.Location = new Point(133, 140);
            txtrpta.Name = "txtrpta";
            txtrpta.ReadOnly = true;
            txtrpta.Size = new Size(100, 23);
            txtrpta.TabIndex = 4;
            txtrpta.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 56);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "1º numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 85);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "2º numero:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 114);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 0;
            label3.Text = "3º numero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 143);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 0;
            label4.Text = "Respuesta:";
            // 
            // button1
            // 
            button1.Location = new Point(105, 204);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _20
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 260);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtrpta);
            Controls.Add(txtnumero3);
            Controls.Add(txtnumero2);
            Controls.Add(txtnumero1);
            Name = "_20";
            Text = "_20";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnumero1;
        private TextBox txtnumero2;
        private TextBox txtnumero3;
        private TextBox txtrpta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}