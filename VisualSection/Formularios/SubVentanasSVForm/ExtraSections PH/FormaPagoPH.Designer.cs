namespace VisualSection.Formularios.SubVentanasSVForm.ExtraSections_PH
{
    partial class FormaPagoPH
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
            this.ventanilla = new System.Windows.Forms.Panel();
            this.CerrarBtnPanel = new System.Windows.Forms.Panel();
            this.CerrarBtnIcon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guardarDatosBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ContadoRB = new System.Windows.Forms.RadioButton();
            this.targetaCreditoRB = new System.Windows.Forms.RadioButton();
            this.targetaDebitoRB = new System.Windows.Forms.RadioButton();
            this.chequeRB = new System.Windows.Forms.RadioButton();
            this.bitcoinRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.precioValue = new System.Windows.Forms.TextBox();
            this.ventanilla.SuspendLayout();
            this.CerrarBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtnIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ventanilla
            // 
            this.ventanilla.BackColor = System.Drawing.Color.DimGray;
            this.ventanilla.Controls.Add(this.CerrarBtnPanel);
            this.ventanilla.Controls.Add(this.label1);
            this.ventanilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.ventanilla.Location = new System.Drawing.Point(0, 0);
            this.ventanilla.Name = "ventanilla";
            this.ventanilla.Size = new System.Drawing.Size(235, 40);
            this.ventanilla.TabIndex = 1;
            this.ventanilla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ventanilla_MouseDown);
            // 
            // CerrarBtnPanel
            // 
            this.CerrarBtnPanel.Controls.Add(this.CerrarBtnIcon);
            this.CerrarBtnPanel.Location = new System.Drawing.Point(195, 0);
            this.CerrarBtnPanel.Name = "CerrarBtnPanel";
            this.CerrarBtnPanel.Size = new System.Drawing.Size(40, 40);
            this.CerrarBtnPanel.TabIndex = 3;
            this.CerrarBtnPanel.Click += new System.EventHandler(this.CerrarBtnIcon_Click);
            // 
            // CerrarBtnIcon
            // 
            this.CerrarBtnIcon.Image = global::VisualSection.Properties.Resources.Transparent_X;
            this.CerrarBtnIcon.Location = new System.Drawing.Point(10, 10);
            this.CerrarBtnIcon.Name = "CerrarBtnIcon";
            this.CerrarBtnIcon.Size = new System.Drawing.Size(20, 20);
            this.CerrarBtnIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarBtnIcon.TabIndex = 0;
            this.CerrarBtnIcon.TabStop = false;
            this.CerrarBtnIcon.Click += new System.EventHandler(this.CerrarBtnIcon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodo de Pago";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ventanilla_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.guardarDatosBtn);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.precioValue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 274);
            this.panel2.TabIndex = 2;
            // 
            // guardarDatosBtn
            // 
            this.guardarDatosBtn.Location = new System.Drawing.Point(32, 239);
            this.guardarDatosBtn.Name = "guardarDatosBtn";
            this.guardarDatosBtn.Size = new System.Drawing.Size(116, 23);
            this.guardarDatosBtn.TabIndex = 12;
            this.guardarDatosBtn.Text = "Guardar Datos";
            this.guardarDatosBtn.UseVisualStyleBackColor = true;
            this.guardarDatosBtn.Click += new System.EventHandler(this.guardarDatosBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ContadoRB);
            this.groupBox1.Controls.Add(this.targetaCreditoRB);
            this.groupBox1.Controls.Add(this.targetaDebitoRB);
            this.groupBox1.Controls.Add(this.chequeRB);
            this.groupBox1.Controls.Add(this.bitcoinRB);
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo de pago";
            // 
            // ContadoRB
            // 
            this.ContadoRB.AutoSize = true;
            this.ContadoRB.Location = new System.Drawing.Point(13, 19);
            this.ContadoRB.Name = "ContadoRB";
            this.ContadoRB.Size = new System.Drawing.Size(65, 17);
            this.ContadoRB.TabIndex = 0;
            this.ContadoRB.TabStop = true;
            this.ContadoRB.Text = "Contado";
            this.ContadoRB.UseVisualStyleBackColor = true;
            this.ContadoRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // targetaCreditoRB
            // 
            this.targetaCreditoRB.AutoSize = true;
            this.targetaCreditoRB.Location = new System.Drawing.Point(13, 52);
            this.targetaCreditoRB.Name = "targetaCreditoRB";
            this.targetaCreditoRB.Size = new System.Drawing.Size(112, 17);
            this.targetaCreditoRB.TabIndex = 1;
            this.targetaCreditoRB.TabStop = true;
            this.targetaCreditoRB.Text = "Targeta de credito";
            this.targetaCreditoRB.UseVisualStyleBackColor = true;
            this.targetaCreditoRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // targetaDebitoRB
            // 
            this.targetaDebitoRB.AutoSize = true;
            this.targetaDebitoRB.Location = new System.Drawing.Point(13, 84);
            this.targetaDebitoRB.Name = "targetaDebitoRB";
            this.targetaDebitoRB.Size = new System.Drawing.Size(94, 17);
            this.targetaDebitoRB.TabIndex = 2;
            this.targetaDebitoRB.TabStop = true;
            this.targetaDebitoRB.Text = "Targeta debito";
            this.targetaDebitoRB.UseVisualStyleBackColor = true;
            this.targetaDebitoRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // chequeRB
            // 
            this.chequeRB.AutoSize = true;
            this.chequeRB.Location = new System.Drawing.Point(13, 116);
            this.chequeRB.Name = "chequeRB";
            this.chequeRB.Size = new System.Drawing.Size(61, 17);
            this.chequeRB.TabIndex = 3;
            this.chequeRB.TabStop = true;
            this.chequeRB.Text = "cheque";
            this.chequeRB.UseVisualStyleBackColor = true;
            this.chequeRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // bitcoinRB
            // 
            this.bitcoinRB.AutoSize = true;
            this.bitcoinRB.Location = new System.Drawing.Point(13, 149);
            this.bitcoinRB.Name = "bitcoinRB";
            this.bitcoinRB.Size = new System.Drawing.Size(56, 17);
            this.bitcoinRB.TabIndex = 4;
            this.bitcoinRB.TabStop = true;
            this.bitcoinRB.Text = "bitcoin";
            this.bitcoinRB.UseVisualStyleBackColor = true;
            this.bitcoinRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "%";
            // 
            // precioValue
            // 
            this.precioValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.precioValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioValue.Location = new System.Drawing.Point(39, 220);
            this.precioValue.Name = "precioValue";
            this.precioValue.Size = new System.Drawing.Size(100, 15);
            this.precioValue.TabIndex = 5;
            // 
            // FormaPagoPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 314);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ventanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaPagoPH";
            this.Text = "FormaPagoPH";
            this.ventanilla.ResumeLayout(false);
            this.ventanilla.PerformLayout();
            this.CerrarBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtnIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ventanilla;
        private System.Windows.Forms.Panel CerrarBtnPanel;
        private System.Windows.Forms.PictureBox CerrarBtnIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button guardarDatosBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ContadoRB;
        private System.Windows.Forms.RadioButton targetaCreditoRB;
        private System.Windows.Forms.RadioButton targetaDebitoRB;
        private System.Windows.Forms.RadioButton chequeRB;
        private System.Windows.Forms.RadioButton bitcoinRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox precioValue;
    }
}