namespace appFP_CSharp.condicionales
{
    partial class _25
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
            txtHijos = new TextBox();
            txtSueldo = new TextBox();
            txtBonificacion = new TextBox();
            txtSNeto = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtHijos
            // 
            txtHijos.Location = new Point(139, 58);
            txtHijos.Name = "txtHijos";
            txtHijos.Size = new Size(100, 23);
            txtHijos.TabIndex = 1;
            txtHijos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(139, 87);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 2;
            txtSueldo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBonificacion
            // 
            txtBonificacion.Location = new Point(139, 116);
            txtBonificacion.Name = "txtBonificacion";
            txtBonificacion.ReadOnly = true;
            txtBonificacion.Size = new Size(100, 23);
            txtBonificacion.TabIndex = 3;
            txtBonificacion.TextAlign = HorizontalAlignment.Right;
            // 
            // txtSNeto
            // 
            txtSNeto.Location = new Point(139, 145);
            txtSNeto.Name = "txtSNeto";
            txtSNeto.ReadOnly = true;
            txtSNeto.Size = new Size(100, 23);
            txtSNeto.TabIndex = 4;
            txtSNeto.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 61);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Hijos :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 90);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Sueldo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 119);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 1;
            label3.Text = "Bonificacion :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 148);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 1;
            label4.Text = "Sueldo neto :";
            // 
            // button1
            // 
            button1.Location = new Point(112, 197);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _25
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 264);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtSNeto);
            Controls.Add(txtBonificacion);
            Controls.Add(txtSueldo);
            Controls.Add(txtHijos);
            Name = "_25";
            Text = "_25";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHijos;
        private TextBox txtSueldo;
        private TextBox txtBonificacion;
        private TextBox txtSNeto;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}