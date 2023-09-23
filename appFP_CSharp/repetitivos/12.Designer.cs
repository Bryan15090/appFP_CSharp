namespace appFP_CSharp.repetitivos
{
    partial class _12
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
            button1 = new Button();
            SuspendLayout();
            // 
            // txaRpta
            // 
            txaRpta.Location = new Point(61, 45);
            txaRpta.Multiline = true;
            txaRpta.Name = "txaRpta";
            txaRpta.Size = new Size(167, 139);
            txaRpta.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(106, 206);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 260);
            Controls.Add(button1);
            Controls.Add(txaRpta);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txaRpta;
        private Button button1;
    }
}