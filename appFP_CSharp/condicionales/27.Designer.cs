namespace appFP_CSharp.condicionales
{
    partial class _27
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
            txtvendido = new TextBox();
            label1 = new Label();
            button1 = new Button();
            txaRpta = new TextBox();
            SuspendLayout();
            // 
            // txtvendido
            // 
            txtvendido.Location = new Point(160, 39);
            txtvendido.Name = "txtvendido";
            txtvendido.Size = new Size(100, 23);
            txtvendido.TabIndex = 1;
            txtvendido.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 42);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Monto vendido :";
            // 
            // button1
            // 
            button1.Location = new Point(117, 246);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txaRpta
            // 
            txaRpta.Location = new Point(51, 86);
            txaRpta.Multiline = true;
            txaRpta.Name = "txaRpta";
            txaRpta.Size = new Size(209, 154);
            txaRpta.TabIndex = 0;
            // 
            // _27
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 308);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txaRpta);
            Controls.Add(txtvendido);
            Name = "_27";
            Text = "_27";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtvendido;
        private Label label1;
        private Button button1;
        private TextBox txaRpta;
    }
}