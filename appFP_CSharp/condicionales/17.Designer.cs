namespace appFP_CSharp.condicionales
{
    partial class _17
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
            txaRpta = new TextBox();
            txtCDocenas = new TextBox();
            lblCDocenas = new Label();
            txtDocenas = new TextBox();
            lblDocenas = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txaRpta
            // 
            txaRpta.Location = new Point(65, 105);
            txaRpta.Multiline = true;
            txaRpta.Name = "txaRpta";
            txaRpta.ReadOnly = true;
            txaRpta.Size = new Size(198, 114);
            txaRpta.TabIndex = 1;
            // 
            // txtCDocenas
            // 
            txtCDocenas.Location = new Point(163, 32);
            txtCDocenas.Name = "txtCDocenas";
            txtCDocenas.Size = new Size(100, 23);
            txtCDocenas.TabIndex = 1;
            txtCDocenas.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCDocenas
            // 
            lblCDocenas.AutoSize = true;
            lblCDocenas.Location = new Point(35, 35);
            lblCDocenas.Name = "lblCDocenas";
            lblCDocenas.Size = new Size(92, 15);
            lblCDocenas.TabIndex = 0;
            lblCDocenas.Text = "Costo Docenas :";
            // 
            // txtDocenas
            // 
            txtDocenas.Location = new Point(163, 61);
            txtDocenas.Name = "txtDocenas";
            txtDocenas.Size = new Size(100, 23);
            txtDocenas.TabIndex = 2;
            txtDocenas.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDocenas
            // 
            lblDocenas.AutoSize = true;
            lblDocenas.Location = new Point(35, 64);
            lblDocenas.Name = "lblDocenas";
            lblDocenas.Size = new Size(58, 15);
            lblDocenas.TabIndex = 0;
            lblDocenas.Text = "Docenas :";
            // 
            // button1
            // 
            button1.Location = new Point(120, 241);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 302);
            Controls.Add(button1);
            Controls.Add(lblDocenas);
            Controls.Add(lblCDocenas);
            Controls.Add(txtDocenas);
            Controls.Add(txtCDocenas);
            Controls.Add(txaRpta);
            Name = "_17";
            Text = "_17";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txaRpta;
        private TextBox txtCDocenas;
        private Label lblCDocenas;
        private TextBox txtDocenas;
        private Label lblDocenas;
        private Button button1;
    }
}