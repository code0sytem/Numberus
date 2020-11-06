namespace VisualSection.Formularios
{
    partial class VentanaPrincipalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipalForm));
            this.VentanillaMovible = new System.Windows.Forms.Panel();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.Xpanel = new System.Windows.Forms.Panel();
            this.XpictureBox = new System.Windows.Forms.PictureBox();
            this.PanelBase = new System.Windows.Forms.Panel();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.OptionsPanel = new System.Windows.Forms.Panel();
            this.ParcialHeladeriaBtn = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FormatTexts = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConfigBtn = new System.Windows.Forms.PictureBox();
            this.MatricesString = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlesTextos = new System.Windows.Forms.Panel();
            this.CTIcon = new System.Windows.Forms.PictureBox();
            this.CTtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OptionsDisplayerPanel = new System.Windows.Forms.Panel();
            this.OptionsDisplayer = new System.Windows.Forms.PictureBox();
            this.VentanillaMovible.SuspendLayout();
            this.MinimizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            this.Xpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XpictureBox)).BeginInit();
            this.PanelBase.SuspendLayout();
            this.OptionsPanel.SuspendLayout();
            this.ParcialHeladeriaBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.FormatTexts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ConfigBtn)).BeginInit();
            this.MatricesString.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ControlesTextos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTIcon)).BeginInit();
            this.OptionsDisplayerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionsDisplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // VentanillaMovible
            // 
            this.VentanillaMovible.BackColor = System.Drawing.Color.LightSteelBlue;
            this.VentanillaMovible.Controls.Add(this.MinimizePanel);
            this.VentanillaMovible.Controls.Add(this.Xpanel);
            this.VentanillaMovible.Dock = System.Windows.Forms.DockStyle.Top;
            this.VentanillaMovible.Location = new System.Drawing.Point(0, 0);
            this.VentanillaMovible.Name = "VentanillaMovible";
            this.VentanillaMovible.Size = new System.Drawing.Size(1260, 42);
            this.VentanillaMovible.TabIndex = 0;
            this.VentanillaMovible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VMMouseDown);
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.Controls.Add(this.MinimizePictureBox);
            this.MinimizePanel.Location = new System.Drawing.Point(1136, 0);
            this.MinimizePanel.Name = "MinimizePanel";
            this.MinimizePanel.Size = new System.Drawing.Size(62, 42);
            this.MinimizePanel.TabIndex = 1;
            this.MinimizePanel.Click += new System.EventHandler(this.MinimizarBtn);
            this.MinimizePanel.MouseEnter += new System.EventHandler(this.DarkerStyle);
            this.MinimizePanel.MouseLeave += new System.EventHandler(this.NoNDarkerStyle);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.MinimizePictureBox.Image = global::VisualSection.Properties.Resources.horizontal_line;
            this.MinimizePictureBox.Location = new System.Drawing.Point(15, 5);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(32, 32);
            this.MinimizePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePictureBox.TabIndex = 0;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizarBtn);
            this.MinimizePictureBox.MouseEnter += new System.EventHandler(this.DarkerStyle);
            this.MinimizePictureBox.MouseLeave += new System.EventHandler(this.NoNDarkerStyle);
            // 
            // Xpanel
            // 
            this.Xpanel.Controls.Add(this.XpictureBox);
            this.Xpanel.Location = new System.Drawing.Point(1198, 0);
            this.Xpanel.Name = "Xpanel";
            this.Xpanel.Size = new System.Drawing.Size(62, 42);
            this.Xpanel.TabIndex = 0;
            this.Xpanel.Click += new System.EventHandler(this.closeWindow);
            this.Xpanel.MouseEnter += new System.EventHandler(this.RedLightME);
            this.Xpanel.MouseLeave += new System.EventHandler(this.NoNRedLightME);
            // 
            // XpictureBox
            // 
            this.XpictureBox.BackColor = System.Drawing.Color.LightSteelBlue;
            this.XpictureBox.Image = global::VisualSection.Properties.Resources.Transparent_X;
            this.XpictureBox.Location = new System.Drawing.Point(15, 5);
            this.XpictureBox.Name = "XpictureBox";
            this.XpictureBox.Size = new System.Drawing.Size(32, 32);
            this.XpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.XpictureBox.TabIndex = 0;
            this.XpictureBox.TabStop = false;
            this.XpictureBox.Click += new System.EventHandler(this.closeWindow);
            this.XpictureBox.MouseEnter += new System.EventHandler(this.RedLightME);
            this.XpictureBox.MouseLeave += new System.EventHandler(this.NoNRedLightME);
            // 
            // PanelBase
            // 
            this.PanelBase.BackColor = System.Drawing.Color.AliceBlue;
            this.PanelBase.Controls.Add(this.PanelPrincipal);
            this.PanelBase.Controls.Add(this.OptionsPanel);
            this.PanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBase.Location = new System.Drawing.Point(0, 42);
            this.PanelBase.Name = "PanelBase";
            this.PanelBase.Size = new System.Drawing.Size(1260, 668);
            this.PanelBase.TabIndex = 1;
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(76, 0);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1184, 668);
            this.PanelPrincipal.TabIndex = 2;
            // 
            // OptionsPanel
            // 
            this.OptionsPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.OptionsPanel.Controls.Add(this.ParcialHeladeriaBtn);
            this.OptionsPanel.Controls.Add(this.FormatTexts);
            this.OptionsPanel.Controls.Add(this.panel1);
            this.OptionsPanel.Controls.Add(this.MatricesString);
            this.OptionsPanel.Controls.Add(this.ControlesTextos);
            this.OptionsPanel.Controls.Add(this.label1);
            this.OptionsPanel.Controls.Add(this.OptionsDisplayerPanel);
            this.OptionsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.OptionsPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionsPanel.Name = "OptionsPanel";
            this.OptionsPanel.Size = new System.Drawing.Size(76, 668);
            this.OptionsPanel.TabIndex = 1;
            // 
            // ParcialHeladeriaBtn
            // 
            this.ParcialHeladeriaBtn.Controls.Add(this.pictureBox3);
            this.ParcialHeladeriaBtn.Controls.Add(this.label4);
            this.ParcialHeladeriaBtn.Location = new System.Drawing.Point(0, 247);
            this.ParcialHeladeriaBtn.Name = "ParcialHeladeriaBtn";
            this.ParcialHeladeriaBtn.Size = new System.Drawing.Size(285, 56);
            this.ParcialHeladeriaBtn.TabIndex = 7;
            this.ParcialHeladeriaBtn.Click += new System.EventHandler(this.ParcialHeladeriaBtn_Click);
            this.ParcialHeladeriaBtn.MouseEnter += new System.EventHandler(this.ParcialHeladeriaBtn_MouseEnter);
            this.ParcialHeladeriaBtn.MouseLeave += new System.EventHandler(this.ParcialHeladeriaBtn_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VisualSection.Properties.Resources.Transparent_X;
            this.pictureBox3.Location = new System.Drawing.Point(19, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.ParcialHeladeriaBtn_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.ParcialHeladeriaBtn_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.ParcialHeladeriaBtn_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "ParcialHeladeria";
            this.label4.Click += new System.EventHandler(this.ParcialHeladeriaBtn_Click);
            this.label4.MouseEnter += new System.EventHandler(this.ParcialHeladeriaBtn_MouseEnter);
            this.label4.MouseLeave += new System.EventHandler(this.ParcialHeladeriaBtn_MouseLeave);
            // 
            // FormatTexts
            // 
            this.FormatTexts.Controls.Add(this.pictureBox2);
            this.FormatTexts.Controls.Add(this.label3);
            this.FormatTexts.Location = new System.Drawing.Point(0, 194);
            this.FormatTexts.Name = "FormatTexts";
            this.FormatTexts.Size = new System.Drawing.Size(285, 56);
            this.FormatTexts.TabIndex = 6;
            this.FormatTexts.Click += new System.EventHandler(this.FormatTexts_Click);
            this.FormatTexts.MouseEnter += new System.EventHandler(this.FT_Select);
            this.FormatTexts.MouseLeave += new System.EventHandler(this.FT_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VisualSection.Properties.Resources.Transparent_X;
            this.pictureBox2.Location = new System.Drawing.Point(19, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.FormatTexts_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.FT_Select);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.FT_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "FormatTexts";
            this.label3.Click += new System.EventHandler(this.FormatTexts_Click);
            this.label3.MouseEnter += new System.EventHandler(this.FT_Select);
            this.label3.MouseLeave += new System.EventHandler(this.FT_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConfigBtn);
            this.panel1.Location = new System.Drawing.Point(0, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 76);
            this.panel1.TabIndex = 5;
            // 
            // ConfigBtn
            // 
            this.ConfigBtn.Image = ((System.Drawing.Image)(resources.GetObject("ConfigBtn.Image")));
            this.ConfigBtn.Location = new System.Drawing.Point(18, 18);
            this.ConfigBtn.Name = "ConfigBtn";
            this.ConfigBtn.Size = new System.Drawing.Size(40, 40);
            this.ConfigBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConfigBtn.TabIndex = 0;
            this.ConfigBtn.TabStop = false;
            this.ConfigBtn.Click += new System.EventHandler(this.ConfigBtn_Click);
            this.ConfigBtn.MouseEnter += new System.EventHandler(this.Setting_enter);
            this.ConfigBtn.MouseLeave += new System.EventHandler(this.Setting_leave);
            // 
            // MatricesString
            // 
            this.MatricesString.Controls.Add(this.pictureBox1);
            this.MatricesString.Controls.Add(this.label2);
            this.MatricesString.Location = new System.Drawing.Point(0, 138);
            this.MatricesString.Name = "MatricesString";
            this.MatricesString.Size = new System.Drawing.Size(285, 56);
            this.MatricesString.TabIndex = 4;
            this.MatricesString.Click += new System.EventHandler(this.MatricesString_Click);
            this.MatricesString.MouseEnter += new System.EventHandler(this.MS_Select);
            this.MatricesString.MouseLeave += new System.EventHandler(this.MS_NoNSelect);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VisualSection.Properties.Resources.Transparent_X;
            this.pictureBox1.Location = new System.Drawing.Point(19, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.MatricesString_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.MS_Select);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.MS_NoNSelect);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Matrices - String";
            this.label2.Click += new System.EventHandler(this.MatricesString_Click);
            this.label2.MouseEnter += new System.EventHandler(this.MS_Select);
            this.label2.MouseLeave += new System.EventHandler(this.MS_NoNSelect);
            // 
            // ControlesTextos
            // 
            this.ControlesTextos.Controls.Add(this.CTIcon);
            this.ControlesTextos.Controls.Add(this.CTtxt);
            this.ControlesTextos.Location = new System.Drawing.Point(0, 82);
            this.ControlesTextos.Name = "ControlesTextos";
            this.ControlesTextos.Size = new System.Drawing.Size(285, 56);
            this.ControlesTextos.TabIndex = 3;
            this.ControlesTextos.Click += new System.EventHandler(this.CTIBtn);
            this.ControlesTextos.MouseEnter += new System.EventHandler(this.ME_EfectoComun);
            this.ControlesTextos.MouseLeave += new System.EventHandler(this.ML_EfectoComun);
            // 
            // CTIcon
            // 
            this.CTIcon.Image = global::VisualSection.Properties.Resources.Transparent_X;
            this.CTIcon.Location = new System.Drawing.Point(19, 11);
            this.CTIcon.Name = "CTIcon";
            this.CTIcon.Size = new System.Drawing.Size(36, 36);
            this.CTIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CTIcon.TabIndex = 1;
            this.CTIcon.TabStop = false;
            this.CTIcon.Click += new System.EventHandler(this.CTIBtn);
            this.CTIcon.MouseEnter += new System.EventHandler(this.ME_EfectoComun);
            this.CTIcon.MouseLeave += new System.EventHandler(this.ML_EfectoComun);
            // 
            // CTtxt
            // 
            this.CTtxt.AutoSize = true;
            this.CTtxt.Font = new System.Drawing.Font("Lucida Sans Typewriter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTtxt.Location = new System.Drawing.Point(72, 18);
            this.CTtxt.Name = "CTtxt";
            this.CTtxt.Size = new System.Drawing.Size(208, 22);
            this.CTtxt.TabIndex = 0;
            this.CTtxt.Text = "Controles de texto";
            this.CTtxt.Click += new System.EventHandler(this.CTIBtn);
            this.CTtxt.MouseEnter += new System.EventHandler(this.ME_EfectoComun);
            this.CTtxt.MouseLeave += new System.EventHandler(this.ML_EfectoComun);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "76-285";
            // 
            // OptionsDisplayerPanel
            // 
            this.OptionsDisplayerPanel.Controls.Add(this.OptionsDisplayer);
            this.OptionsDisplayerPanel.Location = new System.Drawing.Point(0, 0);
            this.OptionsDisplayerPanel.Name = "OptionsDisplayerPanel";
            this.OptionsDisplayerPanel.Size = new System.Drawing.Size(76, 76);
            this.OptionsDisplayerPanel.TabIndex = 1;
            // 
            // OptionsDisplayer
            // 
            this.OptionsDisplayer.Image = global::VisualSection.Properties.Resources.tres_lineas;
            this.OptionsDisplayer.Location = new System.Drawing.Point(18, 18);
            this.OptionsDisplayer.Name = "OptionsDisplayer";
            this.OptionsDisplayer.Size = new System.Drawing.Size(40, 40);
            this.OptionsDisplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OptionsDisplayer.TabIndex = 0;
            this.OptionsDisplayer.TabStop = false;
            this.OptionsDisplayer.Click += new System.EventHandler(this.OptionDisplayerBtn);
            // 
            // VentanaPrincipalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 710);
            this.Controls.Add(this.PanelBase);
            this.Controls.Add(this.VentanillaMovible);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaPrincipalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipalForm";
            this.VentanillaMovible.ResumeLayout(false);
            this.MinimizePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            this.Xpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.XpictureBox)).EndInit();
            this.PanelBase.ResumeLayout(false);
            this.OptionsPanel.ResumeLayout(false);
            this.OptionsPanel.PerformLayout();
            this.ParcialHeladeriaBtn.ResumeLayout(false);
            this.ParcialHeladeriaBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.FormatTexts.ResumeLayout(false);
            this.FormatTexts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ConfigBtn)).EndInit();
            this.MatricesString.ResumeLayout(false);
            this.MatricesString.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ControlesTextos.ResumeLayout(false);
            this.ControlesTextos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CTIcon)).EndInit();
            this.OptionsDisplayerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OptionsDisplayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel VentanillaMovible;
        private System.Windows.Forms.Panel Xpanel;
        private System.Windows.Forms.PictureBox XpictureBox;
        private System.Windows.Forms.Panel PanelBase;
        private System.Windows.Forms.Panel OptionsPanel;
        private System.Windows.Forms.Panel OptionsDisplayerPanel;
        private System.Windows.Forms.PictureBox OptionsDisplayer;
        private System.Windows.Forms.Panel MinimizePanel;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ControlesTextos;
        private System.Windows.Forms.PictureBox CTIcon;
        private System.Windows.Forms.Label CTtxt;
        private System.Windows.Forms.Panel MatricesString;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ConfigBtn;
        private System.Windows.Forms.Panel FormatTexts;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel ParcialHeladeriaBtn;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}