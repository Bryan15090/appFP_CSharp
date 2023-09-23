namespace appFP_CSharp.condicionales
{
    partial class _08
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
            txtnota1 = new TextBox();
            txtnota2 = new TextBox();
            txtnota3 = new TextBox();
            txtmensualidad = new TextBox();
            btnCalcular = new Button();
            lblnota1 = new Label();
            lblnota2 = new Label();
            lblnota3 = new Label();
            mensualidad = new Label();
            SuspendLayout();
            // 
            // txtnota1
            // 
            txtnota1.Location = new Point(137, 47);
            txtnota1.Name = "txtnota1";
            txtnota1.Size = new Size(100, 23);
            txtnota1.TabIndex = 1;
            txtnota1.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnota2
            // 
            txtnota2.Location = new Point(137, 76);
            txtnota2.Name = "txtnota2";
            txtnota2.Size = new Size(100, 23);
            txtnota2.TabIndex = 2;
            txtnota2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtnota3
            // 
            txtnota3.Location = new Point(137, 105);
            txtnota3.Name = "txtnota3";
            txtnota3.Size = new Size(100, 23);
            txtnota3.TabIndex = 3;
            txtnota3.TextAlign = HorizontalAlignment.Right;
            // 
            // txtmensualidad
            // 
            txtmensualidad.Location = new Point(137, 134);
            txtmensualidad.Name = "txtmensualidad";
            txtmensualidad.ReadOnly = true;
            txtmensualidad.Size = new Size(100, 23);
            txtmensualidad.TabIndex = 4;
            txtmensualidad.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(97, 191);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // lblnota1
            // 
            lblnota1.AutoSize = true;
            lblnota1.Location = new Point(50, 50);
            lblnota1.Name = "lblnota1";
            lblnota1.Size = new Size(62, 15);
            lblnota1.TabIndex = 0;
            lblnota1.Text = "Nota Nº1 :";
            // 
            // lblnota2
            // 
            lblnota2.AutoSize = true;
            lblnota2.Location = new Point(50, 79);
            lblnota2.Name = "lblnota2";
            lblnota2.Size = new Size(62, 15);
            lblnota2.TabIndex = 0;
            lblnota2.Text = "Nota Nº2 :";
            // 
            // lblnota3
            // 
            lblnota3.AutoSize = true;
            lblnota3.Location = new Point(50, 108);
            lblnota3.Name = "lblnota3";
            lblnota3.Size = new Size(62, 15);
            lblnota3.TabIndex = 0;
            lblnota3.Text = "Nota Nº3 :";
            // 
            // mensualidad
            // 
            mensualidad.AutoSize = true;
            mensualidad.Location = new Point(50, 137);
            mensualidad.Name = "mensualidad";
            mensualidad.Size = new Size(81, 15);
            mensualidad.TabIndex = 0;
            mensualidad.Text = "Mensualidad :";
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 257);
            Controls.Add(mensualidad);
            Controls.Add(lblnota3);
            Controls.Add(lblnota2);
            Controls.Add(lblnota1);
            Controls.Add(btnCalcular);
            Controls.Add(txtmensualidad);
            Controls.Add(txtnota3);
            Controls.Add(txtnota2);
            Controls.Add(txtnota1);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnota1;
        private TextBox txtnota2;
        private TextBox txtnota3;
        private TextBox txtmensualidad;
        private Button btnCalcular;
        private Label lblnota1;
        private Label lblnota2;
        private Label lblnota3;
        private Label mensualidad;
    }
}