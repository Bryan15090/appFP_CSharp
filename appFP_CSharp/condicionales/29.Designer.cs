namespace appFP_CSharp.condicionales
{
    partial class _29
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
            txtHorasT = new TextBox();
            txtpagoH = new TextBox();
            txaRpta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtHorasT
            // 
            txtHorasT.Location = new Point(163, 45);
            txtHorasT.Name = "txtHorasT";
            txtHorasT.Size = new Size(100, 23);
            txtHorasT.TabIndex = 1;
            txtHorasT.TextAlign = HorizontalAlignment.Right;
            // 
            // txtpagoH
            // 
            txtpagoH.Location = new Point(163, 74);
            txtpagoH.Name = "txtpagoH";
            txtpagoH.Size = new Size(100, 23);
            txtpagoH.TabIndex = 2;
            txtpagoH.TextAlign = HorizontalAlignment.Right;
            // 
            // txaRpta
            // 
            txaRpta.Location = new Point(64, 116);
            txaRpta.Multiline = true;
            txaRpta.Name = "txaRpta";
            txaRpta.Size = new Size(181, 111);
            txaRpta.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 48);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Horas trabajadas:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 77);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 0;
            label2.Text = "Pago por hora:";
            // 
            // button1
            // 
            button1.Location = new Point(115, 233);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _29
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 289);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txaRpta);
            Controls.Add(txtpagoH);
            Controls.Add(txtHorasT);
            Name = "_29";
            Text = "_29";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHorasT;
        private TextBox txtpagoH;
        private TextBox txaRpta;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}