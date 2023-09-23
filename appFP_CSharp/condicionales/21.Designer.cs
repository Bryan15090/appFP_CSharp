namespace appFP_CSharp.condicionales
{
    partial class _21
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
            txtnum = new TextBox();
            txtEstadoC = new TextBox();
            txtEdad = new TextBox();
            txtGenero = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtnum
            // 
            txtnum.Location = new Point(138, 44);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(100, 23);
            txtnum.TabIndex = 1;
            txtnum.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEstadoC
            // 
            txtEstadoC.Location = new Point(138, 73);
            txtEstadoC.Name = "txtEstadoC";
            txtEstadoC.ReadOnly = true;
            txtEstadoC.Size = new Size(100, 23);
            txtEstadoC.TabIndex = 2;
            txtEstadoC.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(138, 102);
            txtEdad.Name = "txtEdad";
            txtEdad.ReadOnly = true;
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 3;
            txtEdad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(138, 131);
            txtGenero.Name = "txtGenero";
            txtGenero.ReadOnly = true;
            txtGenero.Size = new Size(100, 23);
            txtGenero.TabIndex = 4;
            txtGenero.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(91, 182);
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
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 76);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 0;
            label2.Text = "Estado civil:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 105);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 134);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 0;
            label4.Text = "Genero:";
            // 
            // _21
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 247);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtGenero);
            Controls.Add(txtEdad);
            Controls.Add(txtEstadoC);
            Controls.Add(txtnum);
            Name = "_21";
            Text = "_21";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnum;
        private TextBox txtEstadoC;
        private TextBox txtEdad;
        private TextBox txtGenero;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}