
namespace Instalador.Vistas
{
    partial class frmDescargar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescargar));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFives = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.barraDescarga = new System.Windows.Forms.ProgressBar();
            this.lblEstDesc = new System.Windows.Forms.Label();
            this.btnDesc = new System.Windows.Forms.Button();
            this.btnCont = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MistyRose;
            this.pnlTop.Controls.Add(this.lblFives);
            this.pnlTop.Controls.Add(this.lblTitulo);
            this.pnlTop.Controls.Add(this.imgLogo);
            this.pnlTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.pnlTop.Location = new System.Drawing.Point(1, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(494, 89);
            this.pnlTop.TabIndex = 1;
            // 
            // lblFives
            // 
            this.lblFives.AutoSize = true;
            this.lblFives.Font = new System.Drawing.Font("HP Simplified Jpan", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFives.Location = new System.Drawing.Point(196, 50);
            this.lblFives.Name = "lblFives";
            this.lblFives.Size = new System.Drawing.Size(197, 19);
            this.lblFives.TabIndex = 2;
            this.lblFives.Text = "Powered by Fives Software";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("HP Simplified Jpan", 15.2F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(166, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Checador Biometrico";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(113, 89);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // barraDescarga
            // 
            this.barraDescarga.Location = new System.Drawing.Point(17, 154);
            this.barraDescarga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barraDescarga.Name = "barraDescarga";
            this.barraDescarga.Size = new System.Drawing.Size(442, 41);
            this.barraDescarga.TabIndex = 2;
            // 
            // lblEstDesc
            // 
            this.lblEstDesc.AutoSize = true;
            this.lblEstDesc.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblEstDesc.Location = new System.Drawing.Point(12, 116);
            this.lblEstDesc.Name = "lblEstDesc";
            this.lblEstDesc.Size = new System.Drawing.Size(459, 35);
            this.lblEstDesc.TabIndex = 3;
            this.lblEstDesc.Text = "Esperando para descarga de archivos...";
            // 
            // btnDesc
            // 
            this.btnDesc.Font = new System.Drawing.Font("HP Simplified Jpan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesc.Location = new System.Drawing.Point(366, 222);
            this.btnDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(93, 30);
            this.btnDesc.TabIndex = 5;
            this.btnDesc.Text = "Descargar";
            this.btnDesc.UseVisualStyleBackColor = true;
            this.btnDesc.Click += new System.EventHandler(this.btnDesc_Click);
            // 
            // btnCont
            // 
            this.btnCont.Enabled = false;
            this.btnCont.Font = new System.Drawing.Font("HP Simplified Jpan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCont.Location = new System.Drawing.Point(366, 222);
            this.btnCont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(93, 30);
            this.btnCont.TabIndex = 6;
            this.btnCont.Text = "Continuar";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Visible = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // frmDescargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 273);
            this.Controls.Add(this.btnDesc);
            this.Controls.Add(this.lblEstDesc);
            this.Controls.Add(this.barraDescarga);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.btnCont);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmDescargar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Descarga";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFives;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.ProgressBar barraDescarga;
        private System.Windows.Forms.Label lblEstDesc;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Button btnCont;
    }
}