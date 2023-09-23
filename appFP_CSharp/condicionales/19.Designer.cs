namespace appFP_CSharp.condicionales
{
    partial class _19
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
            txtSexo = new TextBox();
            txtEdad = new TextBox();
            txtCategoria = new TextBox();
            lblsexo = new Label();
            lblEdad = new Label();
            lblCategoria = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(128, 66);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(100, 23);
            txtSexo.TabIndex = 1;
            txtSexo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(128, 95);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 2;
            txtEdad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(128, 124);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(100, 23);
            txtCategoria.TabIndex = 3;
            txtCategoria.TextAlign = HorizontalAlignment.Right;
            // 
            // lblsexo
            // 
            lblsexo.AutoSize = true;
            lblsexo.Location = new Point(52, 69);
            lblsexo.Name = "lblsexo";
            lblsexo.Size = new Size(65, 15);
            lblsexo.TabIndex = 1;
            lblsexo.Text = "Sexo(F/M):";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(52, 98);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 1;
            lblEdad.Text = "Edad:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(52, 127);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(64, 15);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria :";
            // 
            // button1
            // 
            button1.Location = new Point(99, 186);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 250);
            Controls.Add(button1);
            Controls.Add(lblCategoria);
            Controls.Add(lblEdad);
            Controls.Add(lblsexo);
            Controls.Add(txtCategoria);
            Controls.Add(txtEdad);
            Controls.Add(txtSexo);
            Name = "_19";
            Text = "_19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSexo;
        private TextBox txtEdad;
        private TextBox txtCategoria;
        private Label lblsexo;
        private Label lblEdad;
        private Label lblCategoria;
        private Button button1;
    }
}