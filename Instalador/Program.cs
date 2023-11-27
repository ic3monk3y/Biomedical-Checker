using System;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Instalador.Funciones;

namespace Instalador
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Conexion conn = new Conexion();
            ActualizarApp appAct = new ActualizarApp();
            DataTable dt = new DataTable();

            bool appInstalada = File.Exists(@"C:\FivesChecker\FivesCheckerMD\FivesCheckerMD.exe");

            dt = appAct.ConsultarInfoApp(conn);

            if (appAct.infoConfigBandera && appInstalada) // validamos que haya una actualizacion disponible y que la aplicacion ya este instalada.
            {
                appAct.ValidarActualizacionAppAsync(dt, conn).Wait();
                if (appAct.actAppBandera)
                    Application.Run(new Vistas.frmActualizar(dt));
                else
                    Application.Run(new Vistas.frmReparar());
            }
            else
            {
                if (!appInstalada) // validamos que la aplicacion no este instalada 
                    Application.Run(new Vistas.frmInicial(dt));
                else
                    Application.Run(new Vistas.frmReparar());
            }
            

        }
    }
}
