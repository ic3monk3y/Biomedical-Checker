using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Instalador.Funciones
{
    class Conexion
    {
        public static SqlConnection con { get; set; }
        public string Server { get; set; }
        public string DB { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string TiempoConexion { get; set; }
        public string Estatus { get; set; }
        class conexion
        {
        }


        public SqlConnection ConeccionBD()
        {
            string[] resultado = DescifrarConfig();
            string Con = string.Empty,
                   bdDesc = string.Empty,
                   usrDesc = string.Empty,
                   passDesc = string.Empty;

            bdDesc = resultado[0];
            usrDesc = resultado[1];
            passDesc = resultado[2];

            try
            {
                string strcon = String.Empty;
                //string strcon = System.Configuration.ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;                
                if (string.IsNullOrEmpty(TiempoConexion))
                {
                    strcon = "user id=" + usrDesc + ";" +
                                 "password=" + passDesc + ";" +
                                 "server=" + Server + ";" +
                                 "Integrated Security=false;" +
                                 "database=" + bdDesc + ";" +
                                 "connection timeout=60;";
                }
                else
                {
                    strcon = "user id=" + usrDesc + ";" +
                                 "password=" + passDesc + ";" +
                                 "server=" + Server + ";" +
                                 "Integrated Security=false;" +
                                 "database=" + bdDesc + ";" +
                                 "connection timeout=" + TiempoConexion + ";";
                }


                con = new SqlConnection(strcon);
                con.Open();

                return con;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Catch Conexion" + ex.Message);
                //Console.WriteLine("Catch Conexion" + ex.Message);
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Catch Conexion" + ex.Message);
                //Console.WriteLine("Catch Conexion" + ex.Message);
                return con;
            }
        }

        public Conexion Conexionbd()
        {
            Conexion objConn;
            string[] resultado = DescifrarConfig();
            string Con = string.Empty,
                   bdDesc = string.Empty,
                   usrDesc = string.Empty,
                   passDesc = string.Empty;

            bdDesc = resultado[0];
            usrDesc = resultado[1];
            passDesc = resultado[2];

            if (string.IsNullOrEmpty(Server) || string.IsNullOrEmpty(DB) || string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Pass))
            {
                //MessageBox.Show("Hubo un error de conexion con la base de datos.");
                Console.WriteLine("Hubo un error de conexion con la base de datos.");
            }

            objConn = new Conexion();
            objConn.Server = Server;
            objConn.DB = bdDesc;
            objConn.User = usrDesc;
            objConn.Pass = passDesc;
            objConn.TiempoConexion = "60";

            using (SqlConnection Conne = objConn.ConeccionBD())
            {
                if (Conne.State != ConnectionState.Open || !string.IsNullOrEmpty(objConn.Estatus))
                    Con = objConn.Estatus;

                if (Conne.State != ConnectionState.Closed)
                {
                    Conne.Close();
                    Con = "0";
                }

            }
            return objConn;
        }

        public bool ValidarConexion()
        {
            string[] resultado = DescifrarConfig();
            string connetionString = null;
            SqlConnection cnn;

            connetionString = "Data Source="+ Server +";Initial Catalog="+ resultado[0] + ";UserID="+ resultado[1] + ";Password="+ resultado[2];

            cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        private string[] DescifrarConfig()
        {
            string[] resultado = null;
            ConfigINI conf = new ConfigINI();
            Encrypt desencrypt = new Encrypt();

            string bdDesc = String.Empty,
                   usrDesc = String.Empty,
                   passDesc = String.Empty;

            string Server = conf.ReadString("CONFDB", "SERVER", "");
            string DB = conf.ReadString("CONFDB", "BASEDATOS", "");
            string User = conf.ReadString("CONFDB", "USUARIO", "");
            string Pass = conf.ReadString("CONFDB", "PASSWORD", "");

            resultado = desencrypt.DesEncrypt(DB, User, Pass);

            return resultado;
        }
    }
}
