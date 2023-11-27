namespace FivesCheckerMD.Views
{
    partial class frmPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPopup));
            this.panelTop = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.PictureBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtclvA = new System.Windows.Forms.TextBox();
            this.btnHWid = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtclvB = new System.Windows.Forms.TextBox();
            this.txtclvC = new System.Windows.Forms.TextBox();
            this.txtclvD = new System.Windows.Forms.TextBox();
            this.txtclvF = new System.Windows.Forms.TextBox();
            this.txtclvE = new System.Windows.Forms.TextBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.Controls.Add(this.closeBtn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(638, 35);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(610, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 26);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 1;
            this.closeBtn.TabStop = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Label7
            // 
            this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(13, 154);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(46, 17);
            this.Label7.TabIndex = 43;
            this.Label7.Text = "Llave:";
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(13, 63);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 17);
            this.Label1.TabIndex = 33;
            this.Label1.Text = "ID Lector:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(96, 63);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.MaxLength = 8;
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(529, 22);
            this.txtID.TabIndex = 32;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegistrar.Location = new System.Drawing.Point(406, 197);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(219, 28);
            this.btnRegistrar.TabIndex = 31;
            this.btnRegistrar.Text = "Registrar Llave";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtclvA
            // 
            this.txtclvA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclvA.BackColor = System.Drawing.Color.White;
            this.txtclvA.Location = new System.Drawing.Point(96, 152);
            this.txtclvA.Margin = new System.Windows.Forms.Padding(4);
            this.txtclvA.MaxLength = 6;
            this.txtclvA.Name = "txtclvA";
            this.txtclvA.Size = new System.Drawing.Size(70, 22);
            this.txtclvA.TabIndex = 44;
            this.txtclvA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtclvA_KeyUp);
            // 
            // btnHWid
            // 
            this.btnHWid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHWid.Location = new System.Drawing.Point(407, 103);
            this.btnHWid.Margin = new System.Windows.Forms.Padding(4);
            this.btnHWid.Name = "btnHWid";
            this.btnHWid.Size = new System.Drawing.Size(218, 28);
            this.btnHWid.TabIndex = 45;
            this.btnHWid.Text = "Obtener ID";
            this.btnHWid.UseVisualStyleBackColor = true;
            this.btnHWid.Click += new System.EventHandler(this.btnHWid_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(171, 154);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(13, 17);
            this.Label2.TabIndex = 46;
            this.Label2.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 154);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(260, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "-";
            // 
            // txtclvB
            // 
            this.txtclvB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclvB.BackColor = System.Drawing.Color.White;
            this.txtclvB.Location = new System.Drawing.Point(186, 152);
            this.txtclvB.Margin = new System.Windows.Forms.Padding(4);
            this.txtclvB.MaxLength = 6;
            this.txtclvB.Name = "txtclvB";
            this.txtclvB.Size = new System.Drawing.Size(70, 22);
            this.txtclvB.TabIndex = 55;
            this.txtclvB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtclvB_KeyUp);
            // 
            // txtclvC
            // 
            this.txtclvC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclvC.BackColor = System.Drawing.Color.White;
            this.txtclvC.Location = new System.Drawing.Point(276, 152);
            this.txtclvC.Margin = new System.Windows.Forms.Padding(4);
            this.txtclvC.MaxLength = 6;
            this.txtclvC.Name = "txtclvC";
            this.txtclvC.Size = new System.Drawing.Size(70, 22);
            this.txtclvC.TabIndex = 56;
            this.txtclvC.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtclvC_KeyUp);
            // 
            // txtclvD
            // 
            this.txtclvD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclvD.BackColor = System.Drawing.Color.White;
            this.txtclvD.Location = new System.Drawing.Point(366, 152);
            this.txtclvD.Margin = new System.Windows.Forms.Padding(4);
            this.txtclvD.MaxLength = 6;
            this.txtclvD.Name = "txtclvD";
            this.txtclvD.Size = new System.Drawing.Size(70, 22);
            this.txtclvD.TabIndex = 57;
            this.txtclvD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtclvD_KeyUp);
            // 
            // txtclvF
            // 
            this.txtclvF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclvF.BackColor = System.Drawing.Color.White;
            this.txtclvF.Location = new System.Drawing.Point(555, 152);
            this.txtclvF.Margin = new System.Windows.Forms.Padding(4);
            this.txtclvF.MaxLength = 6;
            this.txtclvF.Name = "txtclvF";
            this.txtclvF.Size = new System.Drawing.Size(70, 22);
            this.txtclvF.TabIndex = 58;
            this.txtclvF.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtclvF_KeyUp);
            // 
            // txtclvE
            // 
            this.txtclvE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtclvE.BackColor = System.Drawing.Color.White;
            this.txtclvE.Location = new System.Drawing.Point(458, 152);
            this.txtclvE.Margin = new System.Windows.Forms.Padding(4);
            this.txtclvE.MaxLength = 6;
            this.txtclvE.Name = "txtclvE";
            this.txtclvE.Size = new System.Drawing.Size(70, 22);
            this.txtclvE.TabIndex = 59;
            this.txtclvE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtclvE_KeyUp);
            // 
            // frmPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 238);
            this.Controls.Add(this.txtclvE);
            this.Controls.Add(this.txtclvF);
            this.Controls.Add(this.txtclvD);
            this.Controls.Add(this.txtclvC);
            this.Controls.Add(this.txtclvB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.btnHWid);
            this.Controls.Add(this.txtclvA);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnRegistrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConfirmacion";
            this.Shown += new System.EventHandler(this.frmPopup_Shown);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox closeBtn;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtID;
        internal System.Windows.Forms.Button btnRegistrar;
        internal System.Windows.Forms.TextBox txtclvA;
        internal System.Windows.Forms.Button btnHWid;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtclvB;
        internal System.Windows.Forms.TextBox txtclvC;
        internal System.Windows.Forms.TextBox txtclvD;
        internal System.Windows.Forms.TextBox txtclvF;
        internal System.Windows.Forms.TextBox txtclvE;
    }
}