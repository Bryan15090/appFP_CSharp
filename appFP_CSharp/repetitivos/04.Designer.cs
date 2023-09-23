namespace appFP_CSharp.repetitivos
{
    partial class _04
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
            txtNumeros = new TextBox();
            txtMultiplos = new TextBox();
            txtMultiplosd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(139, 63);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(100, 23);
            txtNumeros.TabIndex = 1;
            txtNumeros.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMultiplos
            // 
            txtMultiplos.Location = new Point(139, 92);
            txtMultiplos.Name = "txtMultiplos";
            txtMultiplos.Size = new Size(100, 23);
            txtMultiplos.TabIndex = 2;
            txtMultiplos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMultiplosd
            // 
            txtMultiplosd.Location = new Point(139, 121);
            txtMultiplosd.Name = "txtMultiplosd";
            txtMultiplosd.Size = new Size(100, 23);
            txtMultiplosd.TabIndex = 3;
            txtMultiplosd.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 66);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 95);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Multiplo: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 124);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 1;
            label3.Text = "Multiplos :";
            // 
            // button1
            // 
            button1.Location = new Point(119, 170);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 247);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMultiplosd);
            Controls.Add(txtMultiplos);
            Controls.Add(txtNumeros);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeros;
        private TextBox txtMultiplos;
        private TextBox txtMultiplosd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}