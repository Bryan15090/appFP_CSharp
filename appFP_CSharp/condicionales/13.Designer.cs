namespace appFP_CSharp.condicionales
{
    partial class _13
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
            txtRpta = new TextBox();
            btnCalcular = new Button();
            lblNumero = new Label();
            lblRpta = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(146, 56);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 1;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRpta
            // 
            txtRpta.Location = new Point(146, 85);
            txtRpta.Name = "txtRpta";
            txtRpta.ReadOnly = true;
            txtRpta.Size = new Size(100, 23);
            txtRpta.TabIndex = 2;
            txtRpta.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(110, 148);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 3;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(62, 59);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(54, 15);
            lblNumero.TabIndex = 4;
            lblNumero.Text = "Numero:";
            // 
            // lblRpta
            // 
            lblRpta.AutoSize = true;
            lblRpta.Location = new Point(62, 88);
            lblRpta.Name = "lblRpta";
            lblRpta.Size = new Size(63, 15);
            lblRpta.TabIndex = 4;
            lblRpta.Text = "Respuesta:";
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 228);
            Controls.Add(lblRpta);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Controls.Add(txtRpta);
            Controls.Add(txtNumero);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private TextBox txtRpta;
        private Button btnCalcular;
        private Label lblNumero;
        private Label lblRpta;
    }
}