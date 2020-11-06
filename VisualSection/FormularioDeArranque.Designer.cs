namespace VisualSection
{
    partial class FormularioDeArranque
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsertxtBox = new System.Windows.Forms.TextBox();
            this.PasstxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IniciarSesionBtn = new System.Windows.Forms.Button();
            this.ShowEYE = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowEYE)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 55);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.controlMovimientos);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.ShowEYE);
            this.panel2.Controls.Add(this.IniciarSesionBtn);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.PasstxtBox);
            this.panel2.Controls.Add(this.UsertxtBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(655, 273);
            this.panel2.TabIndex = 1;
            // 
            // UsertxtBox
            // 
            this.UsertxtBox.BackColor = System.Drawing.Color.DarkGray;
            this.UsertxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsertxtBox.Font = new System.Drawing.Font("Lucida Bright", 9.75F);
            this.UsertxtBox.Location = new System.Drawing.Point(258, 110);
            this.UsertxtBox.Name = "UsertxtBox";
            this.UsertxtBox.Size = new System.Drawing.Size(204, 16);
            this.UsertxtBox.TabIndex = 0;
            // 
            // PasstxtBox
            // 
            this.PasstxtBox.BackColor = System.Drawing.Color.DarkGray;
            this.PasstxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasstxtBox.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasstxtBox.Location = new System.Drawing.Point(258, 158);
            this.PasstxtBox.Name = "PasstxtBox";
            this.PasstxtBox.PasswordChar = '·';
            this.PasstxtBox.Size = new System.Drawing.Size(204, 16);
            this.PasstxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F);
            this.label2.Location = new System.Drawing.Point(122, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(558, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Inicie sesion con su usuario o contraseña";
            // 
            // IniciarSesionBtn
            // 
            this.IniciarSesionBtn.BackColor = System.Drawing.Color.DimGray;
            this.IniciarSesionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IniciarSesionBtn.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniciarSesionBtn.Location = new System.Drawing.Point(258, 206);
            this.IniciarSesionBtn.Name = "IniciarSesionBtn";
            this.IniciarSesionBtn.Size = new System.Drawing.Size(149, 27);
            this.IniciarSesionBtn.TabIndex = 5;
            this.IniciarSesionBtn.Text = "Iniciar sesion";
            this.IniciarSesionBtn.UseVisualStyleBackColor = false;
            this.IniciarSesionBtn.Click += new System.EventHandler(this.IniciarSesionBtn_Click);
            // 
            // ShowEYE
            // 
            this.ShowEYE.Location = new System.Drawing.Point(483, 164);
            this.ShowEYE.Name = "ShowEYE";
            this.ShowEYE.Size = new System.Drawing.Size(61, 50);
            this.ShowEYE.TabIndex = 6;
            this.ShowEYE.TabStop = false;
            this.ShowEYE.Click += new System.EventHandler(this.ShowEYE_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(600, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(55, 55);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FormularioDeArranque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 328);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioDeArranque";
            this.Opacity = 0.95D;
            this.Text = "FormularioDeArranque";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowEYE)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasstxtBox;
        private System.Windows.Forms.TextBox UsertxtBox;
        private System.Windows.Forms.Button IniciarSesionBtn;
        private System.Windows.Forms.PictureBox ShowEYE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}