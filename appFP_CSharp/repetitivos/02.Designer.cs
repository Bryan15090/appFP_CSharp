namespace appFP_CSharp.repetitivos
{
    partial class _02
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
            txtProducto = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtN1
            // 
            txtN1.Location = new Point(138, 49);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(100, 23);
            txtN1.TabIndex = 1;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(138, 78);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(100, 23);
            txtN2.TabIndex = 2;
            txtN2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(138, 107);
            txtProducto.Name = "txtProducto";
            txtProducto.ReadOnly = true;
            txtProducto.Size = new Size(100, 23);
            txtProducto.TabIndex = 3;
            txtProducto.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(104, 161);
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
            label1.Location = new Point(62, 52);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "N1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 81);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 5;
            label2.Text = "N2 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 110);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Producto :";
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 238);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtProducto);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtProducto;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}