using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FivesCheckerMD.Function
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
            ConfigINI conf = new ConfigINI();
            Encrypt desencrypt = new Encrypt();

            string bdDesc = String.Empty,
                   usrDesc = String.Empty,
                   passDesc = String.Empty;

            string Server = conf.ReadString("CONFDB", "SERVER", "");
            string DB = conf.ReadString("CONFDB", "BASEDATOS", "");
            string User = conf.ReadString("CONFDB", "USUARIO", "");
            string Pass = conf.ReadString("CONFDB", "PASSWORD", "");
            string Con = String.Empty;

            string[] resultado = desencrypt.DesEncrypt(DB, User, Pass);

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
            ConfigINI conf = new ConfigINI();
            Encrypt desencrypt = new Encrypt();

            string bdDesc = String.Empty,
                   usrDesc = String.Empty,
                   passDesc = String.Empty;

            string Server = conf.ReadString("CONFDB", "SERVER", "");
            string DB = conf.ReadString("CONFDB", "BASEDATOS", "");
            string User = conf.ReadString("CONFDB", "USUARIO", "");
            string Pass = conf.ReadString("CONFDB", "PASSWORD", "");
            string Con = String.Empty;

            string[] resultado = desencrypt.DesEncrypt(DB, User, Pass);

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

        public string IDEmpresa()
        {
            ConfigINI conf = new ConfigINI();
            String idempstr = conf.ReadString("CONFDB","IDEmpresa","");
            if (string.IsNullOrEmpty(idempstr))
            {
                Console.WriteLine("No se consiguio el ID de la empresa.");
                return idempstr;
            }
            else
            {
                return idempstr;
            }
        }
    }
}

