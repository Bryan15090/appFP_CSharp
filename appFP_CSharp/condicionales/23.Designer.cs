namespace appFP_CSharp.condicionales
{
    partial class _23
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
            txtNotam = new TextBox();
            txtNotaF = new TextBox();
            txtPropina = new TextBox();
            txtRegalo = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtNotam
            // 
            txtNotam.Location = new Point(144, 52);
            txtNotam.Name = "txtNotam";
            txtNotam.Size = new Size(100, 23);
            txtNotam.TabIndex = 1;
            txtNotam.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNotaF
            // 
            txtNotaF.Location = new Point(144, 81);
            txtNotaF.Name = "txtNotaF";
            txtNotaF.Size = new Size(100, 23);
            txtNotaF.TabIndex = 2;
            txtNotaF.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPropina
            // 
            txtPropina.Location = new Point(144, 110);
            txtPropina.Name = "txtPropina";
            txtPropina.ReadOnly = true;
            txtPropina.Size = new Size(100, 23);
            txtPropina.TabIndex = 3;
            txtPropina.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRegalo
            // 
            txtRegalo.Location = new Point(144, 139);
            txtRegalo.Name = "txtRegalo";
            txtRegalo.ReadOnly = true;
            txtRegalo.Size = new Size(100, 23);
            txtRegalo.TabIndex = 4;
            txtRegalo.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(92, 192);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 55);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "nota matematica :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 84);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "nota fisica :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 113);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Propina :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 142);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 0;
            label4.Text = "Regalo :";
            // 
            // _23
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 261);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtRegalo);
            Controls.Add(txtPropina);
            Controls.Add(txtNotaF);
            Controls.Add(txtNotam);
            Name = "_23";
            Text = "_23";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNotam;
        private TextBox txtNotaF;
        private TextBox txtPropina;
        private TextBox txtRegalo;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}