
namespace FivesCheckerMD.Views
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.txtContra = new System.Windows.Forms.MaskedTextBox();
            this.lblUsr = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblScrl = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.MaskedTextBox();
            this.cmbSuc = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblConfir = new System.Windows.Forms.Label();
            this.txtConfirmacion = new System.Windows.Forms.MaskedTextBox();
            this.chckContra = new System.Windows.Forms.CheckBox();
            this.chckConfir = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(15, 95);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(297, 22);
            this.txtContra.TabIndex = 2;
            // 
            // lblUsr
            // 
            this.lblUsr.AutoSize = true;
            this.lblUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblUsr.Location = new System.Drawing.Point(12, 9);
            this.lblUsr.Name = "lblUsr";
            this.lblUsr.Size = new System.Drawing.Size(86, 25);
            this.lblUsr.TabIndex = 4;
            this.lblUsr.Text = "Usuario";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblContra.Location = new System.Drawing.Point(12, 67);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(123, 25);
            this.lblContra.TabIndex = 5;
            this.lblContra.Text = "Contraseña";
            // 
            // lblScrl
            // 
            this.lblScrl.AutoSize = true;
            this.lblScrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblScrl.Location = new System.Drawing.Point(10, 185);
            this.lblScrl.Name = "lblScrl";
            this.lblScrl.Size = new System.Drawing.Size(96, 25);
            this.lblScrl.TabIndex = 6;
            this.lblScrl.Text = "Sucursal";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(15, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(321, 22);
            this.txtUsuario.TabIndex = 1;
            // 
            // cmbSuc
            // 
            this.cmbSuc.FormattingEnabled = true;
            this.cmbSuc.Location = new System.Drawing.Point(15, 213);
            this.cmbSuc.Name = "cmbSuc";
            this.cmbSuc.Size = new System.Drawing.Size(321, 24);
            this.cmbSuc.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(15, 257);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(321, 26);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblConfir
            // 
            this.lblConfir.AutoSize = true;
            this.lblConfir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.lblConfir.Location = new System.Drawing.Point(12, 126);
            this.lblConfir.Name = "lblConfir";
            this.lblConfir.Size = new System.Drawing.Size(251, 25);
            this.lblConfir.TabIndex = 11;
            this.lblConfir.Text = "Confirmacion contraseña";
            // 
            // txtConfirmacion
            // 
            this.txtConfirmacion.Location = new System.Drawing.Point(15, 154);
            this.txtConfirmacion.Name = "txtConfirmacion";
            this.txtConfirmacion.PasswordChar = '*';
            this.txtConfirmacion.Size = new System.Drawing.Size(297, 22);
            this.txtConfirmacion.TabIndex = 3;
            // 
            // chckContra
            // 
            this.chckContra.AutoSize = true;
            this.chckContra.Location = new System.Drawing.Point(318, 95);
            this.chckContra.Name = "chckContra";
            this.chckContra.Size = new System.Drawing.Size(18, 17);
            this.chckContra.TabIndex = 12;
            this.chckContra.UseVisualStyleBackColor = true;
            this.chckContra.CheckedChanged += new System.EventHandler(this.chckContra_CheckedChanged);
            // 
            // chckConfir
            // 
            this.chckConfir.AutoSize = true;
            this.chckConfir.Location = new System.Drawing.Point(318, 154);
            this.chckConfir.Name = "chckConfir";
            this.chckConfir.Size = new System.Drawing.Size(18, 17);
            this.chckConfir.TabIndex = 13;
            this.chckConfir.UseVisualStyleBackColor = true;
            this.chckConfir.CheckedChanged += new System.EventHandler(this.chckConfir_CheckedChanged);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 302);
            this.Controls.Add(this.chckConfir);
            this.Controls.Add(this.chckContra);
            this.Controls.Add(this.lblConfir);
            this.Controls.Add(this.txtConfirmacion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbSuc);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblScrl);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsr);
            this.Controls.Add(this.txtContra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtContra;
        private System.Windows.Forms.Label lblUsr;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblScrl;
        private System.Windows.Forms.MaskedTextBox txtUsuario;
        private System.Windows.Forms.ComboBox cmbSuc;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblConfir;
        private System.Windows.Forms.MaskedTextBox txtConfirmacion;
        private System.Windows.Forms.CheckBox chckContra;
        private System.Windows.Forms.CheckBox chckConfir;
    }
}