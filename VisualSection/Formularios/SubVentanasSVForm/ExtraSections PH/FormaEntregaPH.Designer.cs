namespace VisualSection.Formularios.SubVentanasSVForm.ExtraSections_PH
{
    partial class FormaEntregaPH
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.zonaM = new System.Windows.Forms.RadioButton();
            this.zonaS = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RapidRB = new System.Windows.Forms.RadioButton();
            this.DomiyaRB = new System.Windows.Forms.RadioButton();
            this.DomiMaRB = new System.Windows.Forms.RadioButton();
            this.OtroRB = new System.Windows.Forms.RadioButton();
            this.NullRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.valorCompra = new System.Windows.Forms.TextBox();
            this.ventanilla.SuspendLayout();
            this.CerrarBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtnIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.ventanilla.Size = new System.Drawing.Size(352, 40);
            this.ventanilla.TabIndex = 0;
            this.ventanilla.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ventanilla_MouseDown);
            // 
            // CerrarBtnPanel
            // 
            this.CerrarBtnPanel.Controls.Add(this.CerrarBtnIcon);
            this.CerrarBtnPanel.Location = new System.Drawing.Point(312, 0);
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
            this.label1.Size = new System.Drawing.Size(166, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metodo de envio";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ventanilla_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.guardarDatosBtn);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.valorCompra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 274);
            this.panel2.TabIndex = 1;
            // 
            // guardarDatosBtn
            // 
            this.guardarDatosBtn.Location = new System.Drawing.Point(204, 205);
            this.guardarDatosBtn.Name = "guardarDatosBtn";
            this.guardarDatosBtn.Size = new System.Drawing.Size(116, 23);
            this.guardarDatosBtn.TabIndex = 12;
            this.guardarDatosBtn.Text = "Guardar Datos";
            this.guardarDatosBtn.UseVisualStyleBackColor = true;
            this.guardarDatosBtn.Click += new System.EventHandler(this.guardarDatosBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.zonaM);
            this.groupBox2.Controls.Add(this.zonaS);
            this.groupBox2.Location = new System.Drawing.Point(204, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(110, 88);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Zona donde vive";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(51, 17);
            this.radioButton6.TabIndex = 7;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Norte";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // zonaM
            // 
            this.zonaM.AutoSize = true;
            this.zonaM.Location = new System.Drawing.Point(6, 42);
            this.zonaM.Name = "zonaM";
            this.zonaM.Size = new System.Drawing.Size(79, 17);
            this.zonaM.TabIndex = 8;
            this.zonaM.TabStop = true;
            this.zonaM.Text = "zona media";
            this.zonaM.UseVisualStyleBackColor = true;
            this.zonaM.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // zonaS
            // 
            this.zonaS.AutoSize = true;
            this.zonaS.Location = new System.Drawing.Point(6, 65);
            this.zonaS.Name = "zonaS";
            this.zonaS.Size = new System.Drawing.Size(39, 17);
            this.zonaS.TabIndex = 9;
            this.zonaS.TabStop = true;
            this.zonaS.Text = "sur";
            this.zonaS.UseVisualStyleBackColor = true;
            this.zonaS.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RapidRB);
            this.groupBox1.Controls.Add(this.DomiyaRB);
            this.groupBox1.Controls.Add(this.DomiMaRB);
            this.groupBox1.Controls.Add(this.OtroRB);
            this.groupBox1.Controls.Add(this.NullRB);
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 190);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compañia de domicilio";
            // 
            // RapidRB
            // 
            this.RapidRB.AutoSize = true;
            this.RapidRB.Location = new System.Drawing.Point(13, 19);
            this.RapidRB.Name = "RapidRB";
            this.RapidRB.Size = new System.Drawing.Size(53, 17);
            this.RapidRB.TabIndex = 0;
            this.RapidRB.TabStop = true;
            this.RapidRB.Text = "Rapid";
            this.RapidRB.UseVisualStyleBackColor = true;
            this.RapidRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // DomiyaRB
            // 
            this.DomiyaRB.AutoSize = true;
            this.DomiyaRB.Location = new System.Drawing.Point(13, 52);
            this.DomiyaRB.Name = "DomiyaRB";
            this.DomiyaRB.Size = new System.Drawing.Size(86, 17);
            this.DomiyaRB.TabIndex = 1;
            this.DomiyaRB.TabStop = true;
            this.DomiyaRB.Text = "Domicilios ya";
            this.DomiyaRB.UseVisualStyleBackColor = true;
            this.DomiyaRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // DomiMaRB
            // 
            this.DomiMaRB.AutoSize = true;
            this.DomiMaRB.Location = new System.Drawing.Point(13, 84);
            this.DomiMaRB.Name = "DomiMaRB";
            this.DomiMaRB.Size = new System.Drawing.Size(104, 17);
            this.DomiMaRB.TabIndex = 2;
            this.DomiMaRB.TabStop = true;
            this.DomiMaRB.Text = "Domicilios Martin";
            this.DomiMaRB.UseVisualStyleBackColor = true;
            this.DomiMaRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // OtroRB
            // 
            this.OtroRB.AutoSize = true;
            this.OtroRB.Location = new System.Drawing.Point(13, 116);
            this.OtroRB.Name = "OtroRB";
            this.OtroRB.Size = new System.Drawing.Size(106, 17);
            this.OtroRB.TabIndex = 3;
            this.OtroRB.TabStop = true;
            this.OtroRB.Text = "otro (particulares)";
            this.OtroRB.UseVisualStyleBackColor = true;
            this.OtroRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // NullRB
            // 
            this.NullRB.AutoSize = true;
            this.NullRB.Location = new System.Drawing.Point(13, 149);
            this.NullRB.Name = "NullRB";
            this.NullRB.Size = new System.Drawing.Size(65, 17);
            this.NullRB.TabIndex = 4;
            this.NullRB.Text = "Ninguno";
            this.NullRB.UseVisualStyleBackColor = true;
            this.NullRB.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "$";
            // 
            // valorCompra
            // 
            this.valorCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valorCompra.Location = new System.Drawing.Point(220, 137);
            this.valorCompra.Name = "valorCompra";
            this.valorCompra.Size = new System.Drawing.Size(100, 13);
            this.valorCompra.TabIndex = 5;
            // 
            // FormaEntregaPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 314);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ventanilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormaEntregaPH";
            this.Text = "FormaEntregaPH";
            this.ventanilla.ResumeLayout(false);
            this.ventanilla.PerformLayout();
            this.CerrarBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtnIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ventanilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RapidRB;
        private System.Windows.Forms.RadioButton DomiMaRB;
        private System.Windows.Forms.RadioButton DomiyaRB;
        private System.Windows.Forms.RadioButton NullRB;
        private System.Windows.Forms.RadioButton OtroRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valorCompra;
        private System.Windows.Forms.RadioButton zonaS;
        private System.Windows.Forms.RadioButton zonaM;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button guardarDatosBtn;
        private System.Windows.Forms.Panel CerrarBtnPanel;
        private System.Windows.Forms.PictureBox CerrarBtnIcon;
    }
}