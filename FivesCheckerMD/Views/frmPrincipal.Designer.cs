namespace FivesCheckerMD.Vistas
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panelBackFoto = new System.Windows.Forms.Panel();
            this.FotoPersonal = new System.Windows.Forms.PictureBox();
            this.picProfileBack = new System.Windows.Forms.PictureBox();
            this.picTop = new System.Windows.Forms.PictureBox();
            this.picBottom = new System.Windows.Forms.PictureBox();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.lblFecha2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.linklblFivesSoft = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.copyright = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHora2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIncidencia = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPuesto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblRegistro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCaptura = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblHora = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.PanelPrincipal.SuspendLayout();
            this.panelBackFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).BeginInit();
            this.panelLateral.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Size = new System.Drawing.Size(1570, 1248);
            // 
            // Prompt
            // 
            this.Prompt.Margin = new System.Windows.Forms.Padding(5);
            this.Prompt.Size = new System.Drawing.Size(1832, 22);
            this.Prompt.Text = "No se puede iniciar la captura";
            // 
            // StatusText
            // 
            this.StatusText.Size = new System.Drawing.Size(1832, 844);
            this.StatusText.Text = resources.GetString("StatusText.Text");
            // 
            // StatusLine
            // 
            this.StatusLine.Location = new System.Drawing.Point(60, 1339);
            this.StatusLine.Size = new System.Drawing.Size(2977, 231);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(3076, 1434);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.Color.White;
            this.PanelPrincipal.Controls.Add(this.panelBackFoto);
            this.PanelPrincipal.Controls.Add(this.panelLateral);
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1827, 946);
            this.PanelPrincipal.TabIndex = 0;
            // 
            // panelBackFoto
            // 
            this.panelBackFoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBackFoto.Controls.Add(this.FotoPersonal);
            this.panelBackFoto.Controls.Add(this.picProfileBack);
            this.panelBackFoto.Controls.Add(this.picTop);
            this.panelBackFoto.Controls.Add(this.picBottom);
            this.panelBackFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBackFoto.Location = new System.Drawing.Point(0, 0);
            this.panelBackFoto.Margin = new System.Windows.Forms.Padding(4);
            this.panelBackFoto.Name = "panelBackFoto";
            this.panelBackFoto.Size = new System.Drawing.Size(1263, 946);
            this.panelBackFoto.TabIndex = 2;
            // 
            // FotoPersonal
            // 
            this.FotoPersonal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FotoPersonal.BackColor = System.Drawing.Color.Transparent;
            this.FotoPersonal.Image = ((System.Drawing.Image)(resources.GetObject("FotoPersonal.Image")));
            this.FotoPersonal.Location = new System.Drawing.Point(423, 305);
            this.FotoPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.FotoPersonal.Name = "FotoPersonal";
            this.FotoPersonal.Size = new System.Drawing.Size(433, 375);
            this.FotoPersonal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FotoPersonal.TabIndex = 0;
            this.FotoPersonal.TabStop = false;
            // 
            // picProfileBack
            // 
            this.picProfileBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picProfileBack.Image = ((System.Drawing.Image)(resources.GetObject("picProfileBack.Image")));
            this.picProfileBack.Location = new System.Drawing.Point(371, 251);
            this.picProfileBack.Name = "picProfileBack";
            this.picProfileBack.Size = new System.Drawing.Size(542, 484);
            this.picProfileBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileBack.TabIndex = 12;
            this.picProfileBack.TabStop = false;
            // 
            // picTop
            // 
            this.picTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.picTop.Location = new System.Drawing.Point(0, 0);
            this.picTop.Name = "picTop";
            this.picTop.Size = new System.Drawing.Size(1263, 420);
            this.picTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTop.TabIndex = 10;
            this.picTop.TabStop = false;
            // 
            // picBottom
            // 
            this.picBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.picBottom.Location = new System.Drawing.Point(0, 595);
            this.picBottom.Name = "picBottom";
            this.picBottom.Size = new System.Drawing.Size(1263, 351);
            this.picBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBottom.TabIndex = 9;
            this.picBottom.TabStop = false;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelLateral.Controls.Add(this.lblFecha2);
            this.panelLateral.Controls.Add(this.linklblFivesSoft);
            this.panelLateral.Controls.Add(this.panel2);
            this.panelLateral.Controls.Add(this.copyright);
            this.panelLateral.Controls.Add(this.panel1);
            this.panelLateral.Controls.Add(this.txtCaptura);
            this.panelLateral.Controls.Add(this.lblFecha);
            this.panelLateral.Controls.Add(this.lblHora);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateral.Location = new System.Drawing.Point(1263, 0);
            this.panelLateral.Margin = new System.Windows.Forms.Padding(4);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(564, 946);
            this.panelLateral.TabIndex = 0;
            // 
            // lblFecha2
            // 
            this.lblFecha2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblFecha2.AutoSize = true;
            this.lblFecha2.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha2.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblFecha2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha2.Location = new System.Drawing.Point(13, 810);
            this.lblFecha2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha2.Name = "lblFecha2";
            this.lblFecha2.Size = new System.Drawing.Size(105, 45);
            this.lblFecha2.TabIndex = 10;
            this.lblFecha2.Text = "Fecha";
            // 
            // linklblFivesSoft
            // 
            this.linklblFivesSoft.ActiveLinkColor = System.Drawing.Color.DeepSkyBlue;
            this.linklblFivesSoft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linklblFivesSoft.AutoSize = true;
            this.linklblFivesSoft.BackColor = System.Drawing.Color.Transparent;
            this.linklblFivesSoft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.linklblFivesSoft.LinkColor = System.Drawing.Color.Black;
            this.linklblFivesSoft.Location = new System.Drawing.Point(361, 923);
            this.linklblFivesSoft.Name = "linklblFivesSoft";
            this.linklblFivesSoft.Size = new System.Drawing.Size(188, 18);
            this.linklblFivesSoft.TabIndex = 11;
            this.linklblFivesSoft.TabStop = true;
            this.linklblFivesSoft.Text = "Powered by FivesSoftware ";
            this.linklblFivesSoft.VisitedLinkColor = System.Drawing.Color.Black;
            this.linklblFivesSoft.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblFivesSoft_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.bunifuImageButton2);
            this.panel2.Controls.Add(this.picLogo);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 167);
            this.panel2.TabIndex = 7;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(533, 4);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(27, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click_1);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(498, 4);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(27, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 4;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click_1);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(42, 34);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(431, 104);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // copyright
            // 
            this.copyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.copyright.Location = new System.Drawing.Point(350, 1308);
            this.copyright.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(211, 23);
            this.copyright.TabIndex = 1;
            this.copyright.Text = "Powered by FivesSoftware";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblHora2);
            this.panel1.Controls.Add(this.txtIncidencia);
            this.panel1.Controls.Add(this.lblPuesto);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblRegistro);
            this.panel1.Location = new System.Drawing.Point(4, 231);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 575);
            this.panel1.TabIndex = 3;
            // 
            // lblHora2
            // 
            this.lblHora2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHora2.BackColor = System.Drawing.Color.Transparent;
            this.lblHora2.Font = new System.Drawing.Font("Segoe UI", 42F, System.Drawing.FontStyle.Bold);
            this.lblHora2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora2.Location = new System.Drawing.Point(-4, 485);
            this.lblHora2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora2.Name = "lblHora2";
            this.lblHora2.Size = new System.Drawing.Size(560, 90);
            this.lblHora2.TabIndex = 9;
            this.lblHora2.Text = "Hora";
            this.lblHora2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtIncidencia
            // 
            this.txtIncidencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIncidencia.BackColor = System.Drawing.Color.Transparent;
            this.txtIncidencia.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.txtIncidencia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtIncidencia.Location = new System.Drawing.Point(4, 290);
            this.txtIncidencia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtIncidencia.Name = "txtIncidencia";
            this.txtIncidencia.Size = new System.Drawing.Size(514, 133);
            this.txtIncidencia.TabIndex = 5;
            this.txtIncidencia.Text = "Registro:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblPuesto.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPuesto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPuesto.Location = new System.Drawing.Point(4, 150);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(514, 143);
            this.lblPuesto.TabIndex = 3;
            this.lblPuesto.Text = "Puesto:";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNombre.Location = new System.Drawing.Point(4, 15);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(514, 140);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblRegistro
            // 
            this.lblRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Bold);
            this.lblRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegistro.Location = new System.Drawing.Point(-2, -30);
            this.lblRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(543, 555);
            this.lblRegistro.TabIndex = 6;
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCaptura
            // 
            this.txtCaptura.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCaptura.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCaptura.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCaptura.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaptura.Location = new System.Drawing.Point(0, 872);
            this.txtCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.txtCaptura.Name = "txtCaptura";
            this.txtCaptura.PasswordChar = '*';
            this.txtCaptura.Size = new System.Drawing.Size(568, 74);
            this.txtCaptura.TabIndex = 1;
            this.txtCaptura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaptura_KeyPress);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFecha.Location = new System.Drawing.Point(38, 1266);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(105, 45);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHora.Location = new System.Drawing.Point(27, 1174);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(544, 90);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 946);
            this.Controls.Add(this.PanelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(703, 441);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load_1);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.Controls.SetChildIndex(this.StatusLabel, 0);
            this.Controls.SetChildIndex(this.StatusText, 0);
            this.Controls.SetChildIndex(this.StatusLine, 0);
            this.Controls.SetChildIndex(this.CloseButton, 0);
            this.Controls.SetChildIndex(this.Picture, 0);
            this.Controls.SetChildIndex(this.PromptLabel, 0);
            this.Controls.SetChildIndex(this.Prompt, 0);
            this.Controls.SetChildIndex(this.PanelPrincipal, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.PanelPrincipal.ResumeLayout(false);
            this.panelBackFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FotoPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBottom)).EndInit();
            this.panelLateral.ResumeLayout(false);
            this.panelLateral.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelPrincipal;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHora;
        private System.Windows.Forms.Panel panelBackFoto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private System.Windows.Forms.Panel panelLateral;
        private Bunifu.Framework.UI.BunifuCustomLabel copyright;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCaptura;
        private System.Windows.Forms.PictureBox picBottom;
        private System.Windows.Forms.PictureBox picTop;
        private System.Windows.Forms.PictureBox picProfileBack;
        private System.Windows.Forms.PictureBox FotoPersonal;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCustomLabel lblPuesto;
        public Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        public Bunifu.Framework.UI.BunifuCustomLabel txtIncidencia;
        public Bunifu.Framework.UI.BunifuCustomLabel lblRegistro;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblHora2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.LinkLabel linklblFivesSoft;
    }
}