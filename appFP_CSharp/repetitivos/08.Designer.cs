namespace appFP_CSharp.repetitivos
{
    partial class _08
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
            txtBase = new TextBox();
            txtExponente = new TextBox();
            txtResultado = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(146, 46);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(100, 23);
            txtBase.TabIndex = 1;
            txtBase.TextAlign = HorizontalAlignment.Right;
            // 
            // txtExponente
            // 
            txtExponente.Location = new Point(146, 75);
            txtExponente.Name = "txtExponente";
            txtExponente.Size = new Size(100, 23);
            txtExponente.TabIndex = 2;
            txtExponente.TextAlign = HorizontalAlignment.Right;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(146, 104);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 3;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 49);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 0;
            label1.Text = "Base:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 78);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Exponente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 107);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 0;
            label3.Text = "Resultado:";
            // 
            // button1
            // 
            button1.Location = new Point(125, 153);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 210);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtResultado);
            Controls.Add(txtExponente);
            Controls.Add(txtBase);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBase;
        private TextBox txtExponente;
        private TextBox txtResultado;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}