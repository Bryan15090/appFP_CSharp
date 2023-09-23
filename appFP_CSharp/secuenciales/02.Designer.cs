namespace appFP_CSharp.secuenciales
{
    partial class _02
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
            btnCalcular = new Button();
            txtCentimetros = new TextBox();
            txtMetros = new TextBox();
            lblMujeres = new Label();
            lblVarones = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPulgadas = new TextBox();
            txtPies = new TextBox();
            txtYardas = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(92, 212);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(122, 61);
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.ReadOnly = true;
            txtCentimetros.Size = new Size(75, 23);
            txtCentimetros.TabIndex = 2;
            txtCentimetros.TextAlign = HorizontalAlignment.Right;
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(122, 32);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(75, 23);
            txtMetros.TabIndex = 1;
            txtMetros.TextAlign = HorizontalAlignment.Right;
            // 
            // lblMujeres
            // 
            lblMujeres.AutoSize = true;
            lblMujeres.Location = new Point(34, 69);
            lblMujeres.Name = "lblMujeres";
            lblMujeres.Size = new Size(78, 15);
            lblMujeres.TabIndex = 5;
            lblMujeres.Text = "Centimetros :";
            // 
            // lblVarones
            // 
            lblVarones.AutoSize = true;
            lblVarones.Location = new Point(35, 40);
            lblVarones.Name = "lblVarones";
            lblVarones.Size = new Size(50, 15);
            lblVarones.TabIndex = 7;
            lblVarones.Text = "Metros :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 127);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 11;
            label1.Text = "Pies : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 98);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 12;
            label2.Text = "Pulgadas :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 156);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 13;
            label3.Text = "Yarda:";
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(122, 90);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.ReadOnly = true;
            txtPulgadas.Size = new Size(75, 23);
            txtPulgadas.TabIndex = 3;
            txtPulgadas.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPies
            // 
            txtPies.Location = new Point(122, 119);
            txtPies.Name = "txtPies";
            txtPies.ReadOnly = true;
            txtPies.Size = new Size(75, 23);
            txtPies.TabIndex = 4;
            txtPies.TextAlign = HorizontalAlignment.Right;
            // 
            // txtYardas
            // 
            txtYardas.Location = new Point(122, 148);
            txtYardas.Name = "txtYardas";
            txtYardas.ReadOnly = true;
            txtYardas.Size = new Size(75, 23);
            txtYardas.TabIndex = 5;
            txtYardas.TextAlign = HorizontalAlignment.Right;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(255, 290);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtYardas);
            Controls.Add(txtPies);
            Controls.Add(txtPulgadas);
            Controls.Add(txtCentimetros);
            Controls.Add(txtMetros);
            Controls.Add(lblMujeres);
            Controls.Add(lblVarones);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtCentimetros;
        private TextBox txtMetros;
        private Label lblMujeres;
        private Label lblVarones;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPulgadas;
        private TextBox txtPies;
        private TextBox txtYardas;
    }
}