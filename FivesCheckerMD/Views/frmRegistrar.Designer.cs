
namespace FivesCheckerMD.Vistas
{
    partial class frmRegistrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrar));
            this.labelMano = new System.Windows.Forms.Label();
            this.labelEmp = new System.Windows.Forms.Label();
            this.labelDedo = new System.Windows.Forms.Label();
            this.rdbtPulgar = new System.Windows.Forms.RadioButton();
            this.rdbtIndice = new System.Windows.Forms.RadioButton();
            this.rdbtMedio = new System.Windows.Forms.RadioButton();
            this.rdbtAnular = new System.Windows.Forms.RadioButton();
            this.rdbtMenique = new System.Windows.Forms.RadioButton();
            this.btnHuella = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGrd = new System.Windows.Forms.Button();
            this.cmbMano = new System.Windows.Forms.ComboBox();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.txtHuella = new System.Windows.Forms.TextBox();
            this.btnConf = new System.Windows.Forms.Button();
            this.btnSincro = new System.Windows.Forms.Button();
            this.txtPendientes = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // labelMano
            // 
            this.labelMano.AutoSize = true;
            this.labelMano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.labelMano.Location = new System.Drawing.Point(34, 140);
            this.labelMano.Name = "labelMano";
            this.labelMano.Size = new System.Drawing.Size(66, 25);
            this.labelMano.TabIndex = 11;
            this.labelMano.Text = "Mano";
            // 
            // labelEmp
            // 
            this.labelEmp.AutoSize = true;
            this.labelEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.labelEmp.Location = new System.Drawing.Point(34, 18);
            this.labelEmp.Name = "labelEmp";
            this.labelEmp.Size = new System.Drawing.Size(108, 25);
            this.labelEmp.TabIndex = 10;
            this.labelEmp.Text = "Empleado";
            // 
            // labelDedo
            // 
            this.labelDedo.AutoSize = true;
            this.labelDedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.labelDedo.Location = new System.Drawing.Point(34, 204);
            this.labelDedo.Name = "labelDedo";
            this.labelDedo.Size = new System.Drawing.Size(63, 25);
            this.labelDedo.TabIndex = 12;
            this.labelDedo.Text = "Dedo";
            // 
            // rdbtPulgar
            // 
            this.rdbtPulgar.AutoSize = true;
            this.rdbtPulgar.Location = new System.Drawing.Point(39, 234);
            this.rdbtPulgar.Name = "rdbtPulgar";
            this.rdbtPulgar.Size = new System.Drawing.Size(70, 21);
            this.rdbtPulgar.TabIndex = 5;
            this.rdbtPulgar.TabStop = true;
            this.rdbtPulgar.Text = "Pulgar";
            this.rdbtPulgar.UseVisualStyleBackColor = true;
            // 
            // rdbtIndice
            // 
            this.rdbtIndice.AutoSize = true;
            this.rdbtIndice.Location = new System.Drawing.Point(132, 234);
            this.rdbtIndice.Name = "rdbtIndice";
            this.rdbtIndice.Size = new System.Drawing.Size(66, 21);
            this.rdbtIndice.TabIndex = 6;
            this.rdbtIndice.TabStop = true;
            this.rdbtIndice.Text = "Indice";
            this.rdbtIndice.UseVisualStyleBackColor = true;
            // 
            // rdbtMedio
            // 
            this.rdbtMedio.AutoSize = true;
            this.rdbtMedio.Location = new System.Drawing.Point(228, 234);
            this.rdbtMedio.Name = "rdbtMedio";
            this.rdbtMedio.Size = new System.Drawing.Size(67, 21);
            this.rdbtMedio.TabIndex = 7;
            this.rdbtMedio.TabStop = true;
            this.rdbtMedio.Text = "Medio";
            this.rdbtMedio.UseVisualStyleBackColor = true;
            // 
            // rdbtAnular
            // 
            this.rdbtAnular.AutoSize = true;
            this.rdbtAnular.Location = new System.Drawing.Point(323, 234);
            this.rdbtAnular.Name = "rdbtAnular";
            this.rdbtAnular.Size = new System.Drawing.Size(70, 21);
            this.rdbtAnular.TabIndex = 8;
            this.rdbtAnular.TabStop = true;
            this.rdbtAnular.Text = "Anular";
            this.rdbtAnular.UseVisualStyleBackColor = true;
            // 
            // rdbtMenique
            // 
            this.rdbtMenique.AutoSize = true;
            this.rdbtMenique.Location = new System.Drawing.Point(420, 234);
            this.rdbtMenique.Name = "rdbtMenique";
            this.rdbtMenique.Size = new System.Drawing.Size(83, 21);
            this.rdbtMenique.TabIndex = 9;
            this.rdbtMenique.TabStop = true;
            this.rdbtMenique.Text = "Meñique";
            this.rdbtMenique.UseVisualStyleBackColor = true;
            // 
            // btnHuella
            // 
            this.btnHuella.Location = new System.Drawing.Point(400, 106);
            this.btnHuella.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuella.Name = "btnHuella";
            this.btnHuella.Size = new System.Drawing.Size(103, 28);
            this.btnHuella.TabIndex = 3;
            this.btnHuella.Text = "Capturar";
            this.btnHuella.UseVisualStyleBackColor = true;
            this.btnHuella.Click += new System.EventHandler(this.btnHuella_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F);
            this.label2.Location = new System.Drawing.Point(34, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Huella";
            // 
            // btnGrd
            // 
            this.btnGrd.Location = new System.Drawing.Point(39, 277);
            this.btnGrd.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrd.Name = "btnGrd";
            this.btnGrd.Size = new System.Drawing.Size(354, 28);
            this.btnGrd.TabIndex = 10;
            this.btnGrd.Text = "Guardar Huella";
            this.btnGrd.UseVisualStyleBackColor = true;
            this.btnGrd.Click += new System.EventHandler(this.btnGrd_Click);
            // 
            // cmbMano
            // 
            this.cmbMano.FormattingEnabled = true;
            this.cmbMano.Location = new System.Drawing.Point(39, 168);
            this.cmbMano.Name = "cmbMano";
            this.cmbMano.Size = new System.Drawing.Size(464, 24);
            this.cmbMano.TabIndex = 4;
            // 
            // cmbEmp
            // 
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(39, 46);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(464, 24);
            this.cmbEmp.TabIndex = 1;
            // 
            // txtHuella
            // 
            this.txtHuella.BackColor = System.Drawing.SystemColors.Window;
            this.txtHuella.Location = new System.Drawing.Point(39, 109);
            this.txtHuella.Name = "txtHuella";
            this.txtHuella.ReadOnly = true;
            this.txtHuella.Size = new System.Drawing.Size(354, 22);
            this.txtHuella.TabIndex = 2;
            // 
            // btnConf
            // 
            this.btnConf.Location = new System.Drawing.Point(400, 277);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(103, 28);
            this.btnConf.TabIndex = 11;
            this.btnConf.Text = "Configurar";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // btnSincro
            // 
            this.btnSincro.Location = new System.Drawing.Point(158, 317);
            this.btnSincro.Name = "btnSincro";
            this.btnSincro.Size = new System.Drawing.Size(345, 28);
            this.btnSincro.TabIndex = 12;
            this.btnSincro.Text = "Sincronizar";
            this.btnSincro.UseVisualStyleBackColor = true;
            this.btnSincro.Click += new System.EventHandler(this.btnSincro_Click);
            // 
            // txtPendientes
            // 
            this.txtPendientes.Location = new System.Drawing.Point(39, 320);
            this.txtPendientes.Name = "txtPendientes";
            this.txtPendientes.ReadOnly = true;
            this.txtPendientes.Size = new System.Drawing.Size(113, 22);
            this.txtPendientes.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 362);
            this.Controls.Add(this.txtPendientes);
            this.Controls.Add(this.btnSincro);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.txtHuella);
            this.Controls.Add(this.cmbMano);
            this.Controls.Add(this.btnGrd);
            this.Controls.Add(this.btnHuella);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbtMenique);
            this.Controls.Add(this.rdbtAnular);
            this.Controls.Add(this.rdbtMedio);
            this.Controls.Add(this.rdbtIndice);
            this.Controls.Add(this.rdbtPulgar);
            this.Controls.Add(this.labelDedo);
            this.Controls.Add(this.labelEmp);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.labelMano);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Huella";
            this.Load += new System.EventHandler(this.frmRegistrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMano;
        private System.Windows.Forms.Label labelEmp;
        private System.Windows.Forms.Label labelDedo;
        private System.Windows.Forms.RadioButton rdbtPulgar;
        private System.Windows.Forms.RadioButton rdbtIndice;
        private System.Windows.Forms.RadioButton rdbtMedio;
        private System.Windows.Forms.RadioButton rdbtAnular;
        private System.Windows.Forms.RadioButton rdbtMenique;
        private System.Windows.Forms.Button btnHuella;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGrd;
        private System.Windows.Forms.ComboBox cmbMano;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.TextBox txtHuella;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Button btnSincro;
        private System.Windows.Forms.TextBox txtPendientes;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}