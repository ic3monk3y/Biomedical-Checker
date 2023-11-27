
namespace Instalador.Vistas
{
    partial class frmInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicial));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblFives = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            btnContinuar = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            btnContinuar.Font = new System.Drawing.Font("HP Simplified Jpan", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnContinuar.Location = new System.Drawing.Point(380, 217);
            btnContinuar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new System.Drawing.Size(93, 30);
            btnContinuar.TabIndex = 1;
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
            this.pnlTop.Location = new System.Drawing.Point(1, 1);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(496, 89);
            this.pnlTop.TabIndex = 0;
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
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblText1.Location = new System.Drawing.Point(35, 114);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(380, 28);
            this.lblText1.TabIndex = 2;
            this.lblText1.Text = "Esta aplicacion le instalara en su equipo ";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblText2.Location = new System.Drawing.Point(35, 141);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(359, 28);
            this.lblText2.TabIndex = 4;
            this.lblText2.Text = "el checador biometrico y el servicio de ";
            // 
            // lblText3
            // 
            this.lblText3.AutoSize = true;
            this.lblText3.Font = new System.Drawing.Font("HP Simplified Jpan", 13F);
            this.lblText3.Location = new System.Drawing.Point(35, 167);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(327, 28);
            this.lblText3.TabIndex = 5;
            this.lblText3.Text = "sincronizacion de la bade de datos.";
            // 
            // frmInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 260);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(btnContinuar);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FivesChecker";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFives;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblText3;
    }
}