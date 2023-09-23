namespace appFP_CSharp.condicionales
{
    partial class _24
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
            txtVendido = new TextBox();
            txtSueldo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtVendido
            // 
            txtVendido.Location = new Point(151, 52);
            txtVendido.Name = "txtVendido";
            txtVendido.Size = new Size(100, 23);
            txtVendido.TabIndex = 1;
            txtVendido.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(151, 81);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.ReadOnly = true;
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 2;
            txtSueldo.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 55);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "vendido :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 1;
            label2.Text = "Sueldo :";
            // 
            // button1
            // 
            button1.Location = new Point(114, 133);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _24
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 186);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSueldo);
            Controls.Add(txtVendido);
            Name = "_24";
            Text = "_24";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtVendido;
        private TextBox txtSueldo;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}