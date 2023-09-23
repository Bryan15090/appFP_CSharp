namespace appFP_CSharp.secuenciales
{
    partial class _10
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
            txtReversa = new TextBox();
            txtNumero = new TextBox();
            label2 = new Label();
            lblNumero = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // txtReversa
            // 
            txtReversa.Location = new Point(142, 72);
            txtReversa.Name = "txtReversa";
            txtReversa.ReadOnly = true;
            txtReversa.Size = new Size(100, 23);
            txtReversa.TabIndex = 7;
            txtReversa.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(142, 43);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 6;
            txtNumero.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 75);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 0;
            label2.Text = "Numero al reves :";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(37, 46);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(105, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero 4 digitos :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(101, 121);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 165);
            Controls.Add(txtReversa);
            Controls.Add(txtNumero);
            Controls.Add(label2);
            Controls.Add(lblNumero);
            Controls.Add(btnCalcular);
            Name = "_10";
            Text = "_10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReversa;
        private TextBox txtNumero;
        private Label label2;
        private Label lblNumero;
        private Button btnCalcular;
    }
}