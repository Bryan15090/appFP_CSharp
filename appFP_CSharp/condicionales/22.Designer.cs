namespace appFP_CSharp.condicionales
{
    partial class _22
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
            txtCantidadA = new TextBox();
            txtCantidadB = new TextBox();
            txaRpta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtCantidadA
            // 
            txtCantidadA.Location = new Point(181, 55);
            txtCantidadA.Name = "txtCantidadA";
            txtCantidadA.Size = new Size(100, 23);
            txtCantidadA.TabIndex = 1;
            txtCantidadA.TextAlign = HorizontalAlignment.Right;
            // 
            // txtCantidadB
            // 
            txtCantidadB.Location = new Point(181, 84);
            txtCantidadB.Name = "txtCantidadB";
            txtCantidadB.Size = new Size(100, 23);
            txtCantidadB.TabIndex = 1;
            txtCantidadB.TextAlign = HorizontalAlignment.Right;
            // 
            // txaRpta
            // 
            txaRpta.Location = new Point(55, 128);
            txaRpta.Multiline = true;
            txaRpta.Name = "txaRpta";
            txaRpta.ReadOnly = true;
            txaRpta.Size = new Size(196, 111);
            txaRpta.TabIndex = 0;
            txaRpta.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 58);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de unidades A :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 87);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 0;
            label2.Text = "Cantidad de unidades B :";
            // 
            // button1
            // 
            button1.Location = new Point(109, 253);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _22
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 300);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txaRpta);
            Controls.Add(txtCantidadB);
            Controls.Add(txtCantidadA);
            Name = "_22";
            Text = "_22";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCantidadA;
        private TextBox txtCantidadB;
        private TextBox txaRpta;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}