using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Instalador.Vistas
{
    public partial class frmDescargar : Form
    {
        DataTable datos = new DataTable();

        private string url = string.Empty;
        private string path = string.Empty;

        public frmDescargar(DataTable dt)
        {
            datos = dt;
            InitializeComponent();
            url = "http://25.100.247.255/FivesUpdates/FCV6.rar";
            path = @"C:\FivesChecker\"; 
            Console.WriteLine(url);
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            btnDesc.Enabled = false;
            lblEstDesc.Text = "Empezando la descarga de archivos...";
            if (!validarUrl(url))
                MessageBox.Show("No se logro conectar con el servidor de descargas.");
            else
            {
                if (!validarPath(path))
                    System.IO.Directory.CreateDirectory(path);

                if (!descargaRar(url, path))
                    MessageBox.Show("No se pudo decargar el archivo.");
            }
                
        }

        private void btnCont_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInstalacion frm = new frmInstalacion();
            frm.Closed += (s, args) => this.Close();
            frm.Show();
        }

        private bool descargaRar(string url, string path)
        {
            string pathEntero = path + "FCV6.rar";
            Console.WriteLine(pathEntero);
            using (WebClient client = new WebClient())
            {
                try
                {
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(Cargado);
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Cargado);
                    client.DownloadFileAsync(new Uri(url), pathEntero);
                    return true;
                }
                catch (WebException ex)
                {
                    //Console.WriteLine(ex);
                    return false;
                }
            }
        }
        private void Cargado(object sender, AsyncCompletedEventArgs e)
        {
            if(File.Exists(@"C:\FivesChecker\FCV6.rar"))
            {
                //DialogResult resultado = MessageBox.Show("Descarga completada.");
                lblEstDesc.Text = "Descarga completada.";
                btnCont.Visible = true;
                btnCont.Enabled = true;
                btnDesc.Visible = false;
            }
            
        }
        private void Cargado(object sender, DownloadProgressChangedEventArgs e)
        {
            barraDescarga.Value = e.ProgressPercentage;
        }

        private static bool validarPath(string path)
        {
            bool pathVal = Directory.Exists(path);
            if (pathVal)
                return true;
            else
                return false;
        }

        private static bool validarUrl(string url)
        {
            try
            {
                WebRequest request = WebRequest.Create(new Uri(url));
                request.Method = "HEAD";

                using (WebResponse response = request.GetResponse())
                {
                    Console.WriteLine("{0} {1}", response.ContentLength, response.ContentType);
                    return true;
                }
            }
            catch (WebException ex)
            {
                return false;
            }
        }
    }
}
