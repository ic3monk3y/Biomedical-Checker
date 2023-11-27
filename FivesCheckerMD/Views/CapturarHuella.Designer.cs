namespace FivesCheckerMD.Vistas
{
    partial class CapturarHuella
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
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Location = new System.Drawing.Point(7, 15);
            this.Picture.Size = new System.Drawing.Size(329, 368);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Location = new System.Drawing.Point(355, 67);
            // 
            // Prompt
            // 
            this.Prompt.Location = new System.Drawing.Point(358, 34);
            this.Prompt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Prompt.Size = new System.Drawing.Size(396, 22);
            this.Prompt.Text = "No se puede iniciar la captura";
            // 
            // StatusText
            // 
            this.StatusText.Location = new System.Drawing.Point(358, 88);
            this.StatusText.Size = new System.Drawing.Size(381, 295);
            this.StatusText.Text = "El Lector de huellas ha sido conectado\r\n";
            // 
            // StatusLine
            // 
            this.StatusLine.Location = new System.Drawing.Point(0, 387);
            this.StatusLine.Size = new System.Drawing.Size(631, 48);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(639, 407);
            // 
            // CapturarHuella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 448);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(697, 429);
            this.Name = "CapturarHuella";
            this.Text = "CapturarHuella";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}