namespace appFP_CSharp.condicionales
{
    partial class _33
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
            txtPuntualidad = new TextBox();
            txtRendimiento = new TextBox();
            txtPtotal = new TextBox();
            txtBonficacion = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtPuntualidad
            // 
            txtPuntualidad.Location = new Point(155, 45);
            txtPuntualidad.Name = "txtPuntualidad";
            txtPuntualidad.Size = new Size(100, 23);
            txtPuntualidad.TabIndex = 1;
            txtPuntualidad.TextAlign = HorizontalAlignment.Right;
            // 
            // txtRendimiento
            // 
            txtRendimiento.Location = new Point(155, 74);
            txtRendimiento.Name = "txtRendimiento";
            txtRendimiento.Size = new Size(100, 23);
            txtRendimiento.TabIndex = 2;
            txtRendimiento.TextAlign = HorizontalAlignment.Right;
            // 
            // txtPtotal
            // 
            txtPtotal.Location = new Point(155, 103);
            txtPtotal.Name = "txtPtotal";
            txtPtotal.ReadOnly = true;
            txtPtotal.Size = new Size(100, 23);
            txtPtotal.TabIndex = 3;
            txtPtotal.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBonficacion
            // 
            txtBonficacion.Location = new Point(155, 132);
            txtBonficacion.Name = "txtBonficacion";
            txtBonficacion.ReadOnly = true;
            txtBonficacion.Size = new Size(100, 23);
            txtBonficacion.TabIndex = 4;
            txtBonficacion.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.Location = new Point(121, 191);
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
            label1.Location = new Point(72, 48);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Puntualidad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 77);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 0;
            label2.Text = "Rendimiento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 106);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 0;
            label3.Text = "Puntaje total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 135);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 0;
            label4.Text = "Bonficacion";
            // 
            // _33
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 269);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtBonficacion);
            Controls.Add(txtPtotal);
            Controls.Add(txtRendimiento);
            Controls.Add(txtPuntualidad);
            Name = "_33";
            Text = "t";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPuntualidad;
        private TextBox txtRendimiento;
        private TextBox txtPtotal;
        private TextBox txtBonficacion;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}