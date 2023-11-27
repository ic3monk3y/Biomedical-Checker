
namespace Instalador.Vistas
{
    partial class frmActualizar
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
            System.Windows.Forms.Button btnContinuar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizar));
            this.lblText3 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFives = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            btnContinuar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblText3.Location = new System.Drawing.Point(35, 166);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(239, 35);
            this.lblText3.TabIndex = 10;
            this.lblText3.Text = "de la bade de datos.";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblText2.Location = new System.Drawing.Point(35, 140);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(484, 35);
            this.lblText2.TabIndex = 9;
            this.lblText2.Text = "biometrico y el servicio de  sincronizacion";
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblText1.Location = new System.Drawing.Point(35, 113);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(469, 35);
            this.lblText1.TabIndex = 8;
            this.lblText1.Text = "Se actualizara su aplicacion de checador";
            // 
            // btnContinuar
            // 
            btnContinuar.Font = new System.Drawing.Font("HP Simplified Jpan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnContinuar.Location = new System.Drawing.Point(380, 216);
            btnContinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new System.Drawing.Size(93, 30);
            btnContinuar.TabIndex = 7;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = true;
            btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
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
            this.pnlTop.Size = new System.Drawing.Size(496, 89);
            this.pnlTop.TabIndex = 6;
            // 
            // lblFives
            // 
            this.lblFives.AutoSize = true;
            this.lblFives.Font = new System.Drawing.Font("HP Simplified Jpan", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblFives.Location = new System.Drawing.Point(199, 50);
            this.lblFives.Name = "lblFives";
            this.lblFives.Size = new System.Drawing.Size(197, 19);
            this.lblFives.TabIndex = 2;
            this.lblFives.Text = "Powered by Fives Software";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("HP Simplified Jpan", 15.2F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(169, 15);
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
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 265);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(btnContinuar);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmActualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmActualizar";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblFives;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox imgLogo;
    }
}