namespace appFP_CSharp.condicionales
{
    partial class _36
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
            txtCuadernos = new TextBox();
            txtLapiceros = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtCuadernos
            // 
            txtCuadernos.Location = new Point(118, 52);
            txtCuadernos.Name = "txtCuadernos";
            txtCuadernos.Size = new Size(100, 23);
            txtCuadernos.TabIndex = 1;
            txtCuadernos.TextAlign = HorizontalAlignment.Right;
            // 
            // txtLapiceros
            // 
            txtLapiceros.Location = new Point(118, 81);
            txtLapiceros.Name = "txtLapiceros";
            txtLapiceros.ReadOnly = true;
            txtLapiceros.Size = new Size(100, 23);
            txtLapiceros.TabIndex = 2;
            txtLapiceros.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 55);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Cuadernos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 84);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Lapiceros:";
            // 
            // button1
            // 
            button1.Location = new Point(91, 138);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _36
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 210);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLapiceros);
            Controls.Add(txtCuadernos);
            Name = "_36";
            Text = "_36";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCuadernos;
        private TextBox txtLapiceros;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}