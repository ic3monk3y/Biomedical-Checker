
namespace Instalador.Vistas
{
    partial class frmInstalacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstalacion));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFives = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblTexto1 = new System.Windows.Forms.Label();
            this.lblTexto2 = new System.Windows.Forms.Label();
            this.btnInstalar = new System.Windows.Forms.Button();
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
            this.pnlTop.Location = new System.Drawing.Point(3, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(493, 89);
            this.pnlTop.TabIndex = 2;
            // 
            // lblFives
            // 
            this.lblFives.AutoSize = true;
            this.lblFives.Font = new System.Drawing.Font("HP Simplified Jpan", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFives.Location = new System.Drawing.Point(195, 50);
            this.lblFives.Name = "lblFives";
            this.lblFives.Size = new System.Drawing.Size(197, 19);
            this.lblFives.TabIndex = 2;
            this.lblFives.Text = "Powered by Fives Software";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("HP Simplified Jpan", 15.2F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(165, 15);
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
            // lblTexto1
            // 
            this.lblTexto1.AutoSize = true;
            this.lblTexto1.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblTexto1.Location = new System.Drawing.Point(49, 105);
            this.lblTexto1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto1.Name = "lblTexto1";
            this.lblTexto1.Size = new System.Drawing.Size(289, 28);
            this.lblTexto1.TabIndex = 3;
            this.lblTexto1.Text = "Se instalara la aplicaciones en ";
            // 
            // lblTexto2
            // 
            this.lblTexto2.AutoSize = true;
            this.lblTexto2.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblTexto2.Location = new System.Drawing.Point(49, 130);
            this.lblTexto2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTexto2.Name = "lblTexto2";
            this.lblTexto2.Size = new System.Drawing.Size(165, 28);
            this.lblTexto2.TabIndex = 4;
            this.lblTexto2.Text = "C:\\FivesChecker\\";
            // 
            // btnInstalar
            // 
            this.btnInstalar.Font = new System.Drawing.Font("HP Simplified Jpan", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstalar.Location = new System.Drawing.Point(358, 219);
            this.btnInstalar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInstalar.Name = "btnInstalar";
            this.btnInstalar.Size = new System.Drawing.Size(115, 26);
            this.btnInstalar.TabIndex = 6;
            this.btnInstalar.Text = "Instalar";
            this.btnInstalar.UseVisualStyleBackColor = true;
            this.btnInstalar.Click += new System.EventHandler(this.btnInstalar_Click);
            // 
            // frmInstalacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 258);
            this.Controls.Add(this.btnInstalar);
            this.Controls.Add(this.lblTexto2);
            this.Controls.Add(this.lblTexto1);
            this.Controls.Add(this.pnlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInstalacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalacion";
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
        private System.Windows.Forms.Label lblTexto1;
        private System.Windows.Forms.Label lblTexto2;
        private System.Windows.Forms.Button btnInstalar;
    }
}