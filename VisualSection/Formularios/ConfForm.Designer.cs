namespace VisualSection.Formularios
{
    partial class ConfForm
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.HeladitosBtn = new System.Windows.Forms.Button();
            this.GrisBtn = new System.Windows.Forms.Button();
            this.AzulBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.HeladitosBtn);
            this.panelPrincipal.Controls.Add(this.GrisBtn);
            this.panelPrincipal.Controls.Add(this.AzulBtn);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(384, 361);
            this.panelPrincipal.TabIndex = 0;
            // 
            // HeladitosBtn
            // 
            this.HeladitosBtn.Location = new System.Drawing.Point(238, 54);
            this.HeladitosBtn.Name = "HeladitosBtn";
            this.HeladitosBtn.Size = new System.Drawing.Size(75, 23);
            this.HeladitosBtn.TabIndex = 4;
            this.HeladitosBtn.Text = "Heladitos";
            this.HeladitosBtn.UseVisualStyleBackColor = true;
            this.HeladitosBtn.Click += new System.EventHandler(this.HeladitosBtn_Click);
            // 
            // GrisBtn
            // 
            this.GrisBtn.Location = new System.Drawing.Point(126, 54);
            this.GrisBtn.Name = "GrisBtn";
            this.GrisBtn.Size = new System.Drawing.Size(75, 23);
            this.GrisBtn.TabIndex = 3;
            this.GrisBtn.Text = "Gris";
            this.GrisBtn.UseVisualStyleBackColor = true;
            this.GrisBtn.Click += new System.EventHandler(this.GrisBtn_Click);
            // 
            // AzulBtn
            // 
            this.AzulBtn.Location = new System.Drawing.Point(16, 54);
            this.AzulBtn.Name = "AzulBtn";
            this.AzulBtn.Size = new System.Drawing.Size(75, 23);
            this.AzulBtn.TabIndex = 2;
            this.AzulBtn.Text = "Azul";
            this.AzulBtn.UseVisualStyleBackColor = true;
            this.AzulBtn.Click += new System.EventHandler(this.AzulBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diseños";
            // 
            // ConfForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "ConfForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfForm";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GrisBtn;
        private System.Windows.Forms.Button AzulBtn;
        private System.Windows.Forms.Button HeladitosBtn;
    }
}