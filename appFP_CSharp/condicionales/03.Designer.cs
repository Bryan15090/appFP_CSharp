namespace appFP_CSharp.condicionales
{
    partial class _03
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
            txtAngulo = new TextBox();
            txtRpta = new TextBox();
            lblAngulo = new Label();
            lblRpta = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtAngulo
            // 
            txtAngulo.Location = new Point(144, 45);
            txtAngulo.Name = "txtAngulo";
            txtAngulo.Size = new Size(100, 23);
            txtAngulo.TabIndex = 1;
            txtAngulo.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(144, 74);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(100, 23);
            txtRpta.TabIndex = 2;
            txtRpta.TextAlign = HorizontalAlignment.Right;
            // 
            // lblAngulo
            // 
            lblAngulo.AutoSize = true;
            lblAngulo.Location = new Point(60, 48);
            lblAngulo.Name = "lblAngulo";
            lblAngulo.Size = new Size(52, 15);
            lblAngulo.TabIndex = 1;
            lblAngulo.Text = "Angulo :";
            // 
            // lblRpta
            // 
            lblRpta.AutoSize = true;
            lblRpta.Location = new Point(60, 77);
            lblRpta.Name = "lblRpta";
            lblRpta.Size = new Size(66, 15);
            lblRpta.TabIndex = 1;
            lblRpta.Text = "Respuesta :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(109, 120);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 180);
            Controls.Add(btnCalcular);
            Controls.Add(lblRpta);
            Controls.Add(lblAngulo);
            Controls.Add(txtRpta);
            Controls.Add(txtAngulo);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAngulo;
        private TextBox txtRpta;
        private Label lblAngulo;
        private Label lblRpta;
        private Button btnCalcular;
    }
}