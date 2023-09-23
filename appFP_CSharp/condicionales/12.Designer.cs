namespace appFP_CSharp.condicionales
{
    partial class _12
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
            txtDia = new TextBox();
            lblNumero = new Label();
            lblDias = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(132, 46);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(132, 75);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 2;
            txtDia.TextAlign = HorizontalAlignment.Right;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(51, 49);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero:";
            // 
            // lblDias
            // 
            lblDias.AutoSize = true;
            lblDias.Location = new Point(51, 78);
            lblDias.Name = "lblDias";
            lblDias.Size = new Size(35, 15);
            lblDias.TabIndex = 0;
            lblDias.Text = "Dias :";
            // 
            // button1
            // 
            button1.Location = new Point(93, 141);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 209);
            Controls.Add(button1);
            Controls.Add(lblDias);
            Controls.Add(lblNumero);
            Controls.Add(txtDia);
            Controls.Add(txtNumero);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtDia;
        private Label lblNumero;
        private Label lblDias;
        private Button button1;
    }
}