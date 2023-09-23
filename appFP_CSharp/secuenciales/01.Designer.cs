namespace appFP_CSharp.secuenciales
{
    partial class _01
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
            this.lblVarones = new System.Windows.Forms.Label();
            this.lblMujeres = new System.Windows.Forms.Label();
            this.txtVarones = new System.Windows.Forms.TextBox();
            this.txtMujeres = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblPVarones = new System.Windows.Forms.Label();
            this.lblPMujeres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVarones
            // 
            this.lblVarones.AutoSize = true;
            this.lblVarones.Location = new System.Drawing.Point(40, 40);
            this.lblVarones.Name = "lblVarones";
            this.lblVarones.Size = new System.Drawing.Size(48, 15);
            this.lblVarones.TabIndex = 0;
            this.lblVarones.Text = "Varones";
            // 
            // lblMujeres
            // 
            this.lblMujeres.AutoSize = true;
            this.lblMujeres.Location = new System.Drawing.Point(40, 91);
            this.lblMujeres.Name = "lblMujeres";
            this.lblMujeres.Size = new System.Drawing.Size(49, 15);
            this.lblMujeres.TabIndex = 0;
            this.lblMujeres.Text = "Mujeres";
            // 
            // txtVarones
            // 
            this.txtVarones.Location = new System.Drawing.Point(107, 32);
            this.txtVarones.Name = "txtVarones";
            this.txtVarones.Size = new System.Drawing.Size(75, 23);
            this.txtVarones.TabIndex = 1;
            this.txtVarones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVarones.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMujeres
            // 
            this.txtMujeres.Location = new System.Drawing.Point(107, 83);
            this.txtMujeres.Name = "txtMujeres";
            this.txtMujeres.Size = new System.Drawing.Size(75, 23);
            this.txtMujeres.TabIndex = 2;
            this.txtMujeres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMujeres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(107, 143);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblPVarones
            // 
            this.lblPVarones.AutoSize = true;
            this.lblPVarones.Location = new System.Drawing.Point(199, 40);
            this.lblPVarones.Name = "lblPVarones";
            this.lblPVarones.Size = new System.Drawing.Size(17, 15);
            this.lblPVarones.TabIndex = 0;
            this.lblPVarones.Text = "%";
            // 
            // lblPMujeres
            // 
            this.lblPMujeres.AutoSize = true;
            this.lblPMujeres.Location = new System.Drawing.Point(199, 91);
            this.lblPMujeres.Name = "lblPMujeres";
            this.lblPMujeres.Size = new System.Drawing.Size(17, 15);
            this.lblPMujeres.TabIndex = 0;
            this.lblPMujeres.Text = "%";
            // 
            // _01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 207);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMujeres);
            this.Controls.Add(this.txtVarones);
            this.Controls.Add(this.lblPMujeres);
            this.Controls.Add(this.lblMujeres);
            this.Controls.Add(this.lblPVarones);
            this.Controls.Add(this.lblVarones);
            this.Name = "_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVarones;
        private Label lblMujeres;
        private TextBox txtVarones;
        private TextBox txtMujeres;
        private Button btnCalcular;
        private Label lblPVarones;
        private Label lblPMujeres;
    }
}