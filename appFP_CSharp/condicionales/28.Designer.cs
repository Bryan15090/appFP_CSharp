namespace appFP_CSharp.condicionales
{
    partial class _28
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
            txtHora = new TextBox();
            txtHora2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtHora
            // 
            txtHora.Location = new Point(140, 54);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(100, 23);
            txtHora.TabIndex = 1;
            // 
            // txtHora2
            // 
            txtHora2.Location = new Point(140, 83);
            txtHora2.Name = "txtHora2";
            txtHora2.Size = new Size(100, 23);
            txtHora2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 57);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 1;
            label1.Text = "Ingresar hora:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 86);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 1;
            label2.Text = "Formato am/pm:";
            // 
            // button1
            // 
            button1.Location = new Point(107, 136);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _28
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 195);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHora2);
            Controls.Add(txtHora);
            Name = "_28";
            Text = "_28";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHora;
        private TextBox txtHora2;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}