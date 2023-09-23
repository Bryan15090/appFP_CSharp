namespace appFP_CSharp.repetitivos
{
    partial class _16
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
            txtTexto = new TextBox();
            txtRpta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(129, 46);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(100, 23);
            txtTexto.TabIndex = 1;
            txtTexto.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(129, 75);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(100, 23);
            txtRpta.TabIndex = 2;
            txtRpta.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 49);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Texto :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 78);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 1;
            label2.Text = "Respuesta :";
            // 
            // button1
            // 
            button1.Location = new Point(111, 124);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 187);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtRpta);
            Controls.Add(txtTexto);
            Name = "_16";
            Text = "_16";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTexto;
        private TextBox txtRpta;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}