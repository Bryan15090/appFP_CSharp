namespace appFP_CSharp.condicionales
{
    partial class _31
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
            txtHoras = new TextBox();
            txtCategoria = new TextBox();
            txaRpta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtHoras
            // 
            txtHoras.Location = new Point(157, 35);
            txtHoras.Name = "txtHoras";
            txtHoras.Size = new Size(100, 23);
            txtHoras.TabIndex = 0;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(157, 64);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 1;
            // 
            // txaRpta
            // 
            txaRpta.Location = new Point(47, 113);
            txaRpta.Multiline = true;
            txaRpta.Name = "txaRpta";
            txaRpta.ReadOnly = true;
            txaRpta.Size = new Size(210, 120);
            txaRpta.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 38);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 3;
            label1.Text = "Horas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 67);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Categoria(A,B,C)";
            // 
            // button1
            // 
            button1.Location = new Point(118, 239);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _31
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 296);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txaRpta);
            Controls.Add(txtCategoria);
            Controls.Add(txtHoras);
            Name = "_31";
            Text = "_31";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoras;
        private TextBox txtCategoria;
        private TextBox txaRpta;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}