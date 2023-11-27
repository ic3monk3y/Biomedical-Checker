using System;
using System.Data;
using System.Windows.Forms;
using FivesCheckerMD.Views;
using FivesCheckerMD.Vistas;
using FivesCheckerMD.Function;
using System.Diagnostics;

namespace FivesCheckerMD
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Conexion conn = new Conexion();
            ActualizarApp appAct = new ActualizarApp();
            DataTable dt = new DataTable();
            
            //Sacamos la informacion de la app de la tabla Config
            dt = appAct.ConsultarInfoApp(conn);

            if (dt.Rows.Count > 0) //Por medio de la API validamos que haya una actualizacion disponible 
            { 
                appAct.ValidarActualizacionAppAsync(dt, conn).Wait();
                if (appAct.actAppBandera)
                {
                    MessageBox.Show("Hay una actualizacion disponible, es obligatroria su intstalacion.");
                    Process firstProc = new Process();
                    firstProc.StartInfo.FileName = @"C:\FivesChecker\FivesCheckerMD\Setup\Instalador.exe";
                    firstProc.EnableRaisingEvents = true;

                    firstProc.Start();//Incializamos Instalador.exe
                    firstProc.WaitForExit();//con esto hacemos que FivesCheckerMD.exe no inicie y nos permite remplazar los archivos durante la actualizacion
                }
                else
                    appRun();
            }
            else
            {
                //Si la consulta no retorna informacion significa que no existe la tabla Config o esta configurada con la informacion de la app
                MessageBox.Show("El Config no devolvio ningun registro.");
            }
        }

        //Funcion para arrancar la aplicacion 
        private static void appRun()
        {
            Splash spsc = new Splash();
            if (spsc.ShowDialog() == DialogResult.OK) //Splash screen que valida que la aplicacion se encuentre licenciada 
                Application.Run(new frmPrincipal());
            else
                Application.Run(new frmPopup());
        }
    }
}
