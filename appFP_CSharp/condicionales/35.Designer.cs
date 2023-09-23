namespace appFP_CSharp.condicionales
{
    partial class _35
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
            txtNumero = new TextBox();
            txtTipo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(131, 45);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(131, 74);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 2;
            txtTipo.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 48);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 77);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 0;
            label2.Text = "Tipo:";
            // 
            // button1
            // 
            button1.Location = new Point(106, 125);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _35
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 191);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTipo);
            Controls.Add(txtNumero);
            Name = "_35";
            Text = "_35";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtTipo;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}