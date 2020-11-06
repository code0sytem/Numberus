namespace VisualSection.Formularios.SubVentanasSVForm
{
    partial class FormatTextsDT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtsCB = new System.Windows.Forms.ComboBox();
            this.TextoModificado = new System.Windows.Forms.RichTextBox();
            this.TextoOriginal = new System.Windows.Forms.RichTextBox();
            this.AplicarBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subVentanilla = new System.Windows.Forms.Panel();
            this.cerrarPanel = new System.Windows.Forms.Panel();
            this.cerrarIcon = new System.Windows.Forms.PictureBox();
            this.LeerBtn = new System.Windows.Forms.Button();
            this.ContadorCaracterCB = new System.Windows.Forms.CheckBox();
            this.ContadorNumericoCB = new System.Windows.Forms.CheckBox();
            this.ContadorLetrasCB = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.subVentanilla.SuspendLayout();
            this.cerrarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerrarIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.ContadorLetrasCB);
            this.panel1.Controls.Add(this.ContadorNumericoCB);
            this.panel1.Controls.Add(this.ContadorCaracterCB);
            this.panel1.Controls.Add(this.LeerBtn);
            this.panel1.Controls.Add(this.txtsCB);
            this.panel1.Controls.Add(this.TextoModificado);
            this.panel1.Controls.Add(this.TextoOriginal);
            this.panel1.Controls.Add(this.AplicarBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.subVentanilla);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 668);
            this.panel1.TabIndex = 0;
            // 
            // txtsCB
            // 
            this.txtsCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsCB.FormattingEnabled = true;
            this.txtsCB.Location = new System.Drawing.Point(12, 434);
            this.txtsCB.Name = "txtsCB";
            this.txtsCB.Size = new System.Drawing.Size(219, 23);
            this.txtsCB.TabIndex = 12;
            // 
            // TextoModificado
            // 
            this.TextoModificado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextoModificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoModificado.Location = new System.Drawing.Point(489, 98);
            this.TextoModificado.Name = "TextoModificado";
            this.TextoModificado.Size = new System.Drawing.Size(476, 312);
            this.TextoModificado.TabIndex = 11;
            this.TextoModificado.Text = "";
            // 
            // TextoOriginal
            // 
            this.TextoOriginal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextoOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoOriginal.Location = new System.Drawing.Point(6, 98);
            this.TextoOriginal.Name = "TextoOriginal";
            this.TextoOriginal.Size = new System.Drawing.Size(468, 312);
            this.TextoOriginal.TabIndex = 10;
            this.TextoOriginal.Text = "";
            // 
            // AplicarBtn
            // 
            this.AplicarBtn.Location = new System.Drawing.Point(12, 551);
            this.AplicarBtn.Name = "AplicarBtn";
            this.AplicarBtn.Size = new System.Drawing.Size(73, 30);
            this.AplicarBtn.TabIndex = 9;
            this.AplicarBtn.Text = "Aplicar";
            this.AplicarBtn.UseVisualStyleBackColor = true;
            this.AplicarBtn.Click += new System.EventHandler(this.AplicarBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Modified Text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto original";
            // 
            // subVentanilla
            // 
            this.subVentanilla.BackColor = System.Drawing.Color.LightSteelBlue;
            this.subVentanilla.Controls.Add(this.cerrarPanel);
            this.subVentanilla.Dock = System.Windows.Forms.DockStyle.Top;
            this.subVentanilla.Location = new System.Drawing.Point(0, 0);
            this.subVentanilla.Name = "subVentanilla";
            this.subVentanilla.Size = new System.Drawing.Size(975, 40);
            this.subVentanilla.TabIndex = 2;
            // 
            // cerrarPanel
            // 
            this.cerrarPanel.Controls.Add(this.cerrarIcon);
            this.cerrarPanel.Location = new System.Drawing.Point(935, 0);
            this.cerrarPanel.Name = "cerrarPanel";
            this.cerrarPanel.Size = new System.Drawing.Size(40, 40);
            this.cerrarPanel.TabIndex = 0;
            // 
            // cerrarIcon
            // 
            this.cerrarIcon.Image = global::VisualSection.Properties.Resources.Transparent_X;
            this.cerrarIcon.Location = new System.Drawing.Point(10, 10);
            this.cerrarIcon.Name = "cerrarIcon";
            this.cerrarIcon.Size = new System.Drawing.Size(20, 20);
            this.cerrarIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrarIcon.TabIndex = 0;
            this.cerrarIcon.TabStop = false;
            this.cerrarIcon.Click += new System.EventHandler(this.cerrarIcon_Click);
            // 
            // LeerBtn
            // 
            this.LeerBtn.Location = new System.Drawing.Point(12, 463);
            this.LeerBtn.Name = "LeerBtn";
            this.LeerBtn.Size = new System.Drawing.Size(110, 26);
            this.LeerBtn.TabIndex = 13;
            this.LeerBtn.Text = "Leer archivo";
            this.LeerBtn.UseVisualStyleBackColor = true;
            this.LeerBtn.Click += new System.EventHandler(this.LeerBtn_Click);
            // 
            // ContadorCaracterCB
            // 
            this.ContadorCaracterCB.AutoSize = true;
            this.ContadorCaracterCB.Location = new System.Drawing.Point(12, 528);
            this.ContadorCaracterCB.Name = "ContadorCaracterCB";
            this.ContadorCaracterCB.Size = new System.Drawing.Size(137, 17);
            this.ContadorCaracterCB.TabIndex = 14;
            this.ContadorCaracterCB.Text = "Contador de caracteres";
            this.ContadorCaracterCB.UseVisualStyleBackColor = true;
            // 
            // ContadorNumericoCB
            // 
            this.ContadorNumericoCB.AutoSize = true;
            this.ContadorNumericoCB.Location = new System.Drawing.Point(155, 528);
            this.ContadorNumericoCB.Name = "ContadorNumericoCB";
            this.ContadorNumericoCB.Size = new System.Drawing.Size(127, 17);
            this.ContadorNumericoCB.TabIndex = 15;
            this.ContadorNumericoCB.Text = "Contador de numeros";
            this.ContadorNumericoCB.UseVisualStyleBackColor = true;
            // 
            // ContadorLetrasCB
            // 
            this.ContadorLetrasCB.AutoSize = true;
            this.ContadorLetrasCB.Location = new System.Drawing.Point(288, 528);
            this.ContadorLetrasCB.Name = "ContadorLetrasCB";
            this.ContadorLetrasCB.Size = new System.Drawing.Size(112, 17);
            this.ContadorLetrasCB.TabIndex = 16;
            this.ContadorLetrasCB.Text = "Contador de letras";
            this.ContadorLetrasCB.UseVisualStyleBackColor = true;
            // 
            // FormatTextsDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 668);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormatTextsDT";
            this.Text = "FormatTextsDT";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.subVentanilla.ResumeLayout(false);
            this.cerrarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cerrarIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel subVentanilla;
        private System.Windows.Forms.Panel cerrarPanel;
        private System.Windows.Forms.PictureBox cerrarIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AplicarBtn;
        private System.Windows.Forms.RichTextBox TextoOriginal;
        private System.Windows.Forms.RichTextBox TextoModificado;
        private System.Windows.Forms.ComboBox txtsCB;
        private System.Windows.Forms.Button LeerBtn;
        private System.Windows.Forms.CheckBox ContadorCaracterCB;
        private System.Windows.Forms.CheckBox ContadorNumericoCB;
        private System.Windows.Forms.CheckBox ContadorLetrasCB;
    }
}