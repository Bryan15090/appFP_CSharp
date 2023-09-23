namespace appFP_CSharp.secuenciales
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
            lblKilometros = new Label();
            lblPies = new Label();
            lblMillas = new Label();
            lblTMetros = new Label();
            lblTYardas = new Label();
            btncalcular = new Button();
            txtKilometros = new TextBox();
            txtPies = new TextBox();
            txtMillas = new TextBox();
            txtTMetros = new TextBox();
            txtTYardas = new TextBox();
            SuspendLayout();
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(31, 50);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(70, 15);
            lblKilometros.TabIndex = 0;
            lblKilometros.Text = "Kilometros :";
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(31, 79);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(34, 15);
            lblPies.TabIndex = 0;
            lblPies.Text = "Pies :";
            // 
            // lblMillas
            // 
            lblMillas.AutoSize = true;
            lblMillas.Location = new Point(31, 108);
            lblMillas.Name = "lblMillas";
            lblMillas.Size = new Size(44, 15);
            lblMillas.TabIndex = 0;
            lblMillas.Text = "Millas :";
            // 
            // lblTMetros
            // 
            lblTMetros.AutoSize = true;
            lblTMetros.Location = new Point(31, 137);
            lblTMetros.Name = "lblTMetros";
            lblTMetros.Size = new Size(81, 15);
            lblTMetros.TabIndex = 0;
            lblTMetros.Text = "Total metros : ";
            // 
            // lblTYardas
            // 
            lblTYardas.AutoSize = true;
            lblTYardas.Location = new Point(31, 166);
            lblTYardas.Name = "lblTYardas";
            lblTYardas.Size = new Size(75, 15);
            lblTYardas.TabIndex = 0;
            lblTYardas.Text = "Total Yardas :";
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(81, 207);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 6;
            btncalcular.Text = "Calcular";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += button1_Click;
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(119, 42);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(100, 23);
            txtKilometros.TabIndex = 1;
            txtKilometros.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPies
            // 
            txtPies.Location = new Point(119, 71);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(100, 23);
            txtPies.TabIndex = 2;
            txtPies.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMillas
            // 
            txtMillas.Location = new Point(119, 100);
            txtMillas.Name = "txtMillas";
            txtMillas.Size = new Size(100, 23);
            txtMillas.TabIndex = 3;
            txtMillas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTMetros
            // 
            txtTMetros.Location = new Point(119, 129);
            txtTMetros.Name = "txtTMetros";
            txtTMetros.ReadOnly = true;
            txtTMetros.Size = new Size(100, 23);
            txtTMetros.TabIndex = 4;
            txtTMetros.TextAlign = HorizontalAlignment.Right;
            // 
            // txtTYardas
            // 
            txtTYardas.Location = new Point(119, 158);
            txtTYardas.Name = "txtTYardas";
            txtTYardas.ReadOnly = true;
            txtTYardas.Size = new Size(100, 23);
            txtTYardas.TabIndex = 5;
            txtTYardas.TextAlign = HorizontalAlignment.Right;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 261);
            Controls.Add(txtTYardas);
            Controls.Add(txtTMetros);
            Controls.Add(txtMillas);
            Controls.Add(txtPies);
            Controls.Add(txtKilometros);
            Controls.Add(btncalcular);
            Controls.Add(lblTYardas);
            Controls.Add(lblTMetros);
            Controls.Add(lblMillas);
            Controls.Add(lblPies);
            Controls.Add(lblKilometros);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKilometros;
        private Label lblPies;
        private Label lblMillas;
        private Label lblTMetros;
        private Label lblTYardas;
        private Button btncalcular;
        private TextBox txtKilometros;
        private TextBox txtPies;
        private TextBox txtMillas;
        private TextBox txtTMetros;
        private TextBox txtTYardas;
    }
}