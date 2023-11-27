
namespace Instalador.Vistas
{
    partial class frmReparar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReparar));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFives = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
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
            this.pnlTop.Location = new System.Drawing.Point(3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(435, 89);
            this.pnlTop.TabIndex = 1;
            // 
            // lblFives
            // 
            this.lblFives.AutoSize = true;
            this.lblFives.Font = new System.Drawing.Font("HP Simplified Jpan", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFives.Location = new System.Drawing.Point(153, 51);
            this.lblFives.Name = "lblFives";
            this.lblFives.Size = new System.Drawing.Size(190, 18);
            this.lblFives.TabIndex = 2;
            this.lblFives.Text = "Powered by Fives Software";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("HP Simplified Jpan", 15.2F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(123, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 33);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Checador Biometrico";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(0, 0);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(113, 89);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // frmReparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReparar";
            this.Text = "frmReparar";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFives;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}