
namespace FivesCheckerMD.Views
{
    partial class frmProbarSp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProbarSp));
            this.btnSPValidarPersonal = new System.Windows.Forms.Button();
            this.btnSPRegistroHuella = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSPValidarPersonal
            // 
            this.btnSPValidarPersonal.Location = new System.Drawing.Point(92, 26);
            this.btnSPValidarPersonal.Name = "btnSPValidarPersonal";
            this.btnSPValidarPersonal.Size = new System.Drawing.Size(336, 33);
            this.btnSPValidarPersonal.TabIndex = 0;
            this.btnSPValidarPersonal.Text = "Probar SP validar Personal ";
            this.btnSPValidarPersonal.UseVisualStyleBackColor = true;
            this.btnSPValidarPersonal.Click += new System.EventHandler(this.btnSPValidarPersonal_Click);
            // 
            // btnSPRegistroHuella
            // 
            this.btnSPRegistroHuella.Location = new System.Drawing.Point(92, 93);
            this.btnSPRegistroHuella.Name = "btnSPRegistroHuella";
            this.btnSPRegistroHuella.Size = new System.Drawing.Size(336, 33);
            this.btnSPRegistroHuella.TabIndex = 1;
            this.btnSPRegistroHuella.Text = "Probar SP Registrar Huella";
            this.btnSPRegistroHuella.UseVisualStyleBackColor = true;
            this.btnSPRegistroHuella.Click += new System.EventHandler(this.btnSPRegistroHuella_Click);
            // 
            // frmProbarSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 153);
            this.Controls.Add(this.btnSPRegistroHuella);
            this.Controls.Add(this.btnSPValidarPersonal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProbarSp";
            this.Text = "frmProbarSp";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSPValidarPersonal;
        private System.Windows.Forms.Button btnSPRegistroHuella;
    }
}