using System;
using System.Data.SqlClient;
using System.Data;

namespace SincroEjecucion.Entidades
{
    class Conexion : IDisposable
    {
        public static SqlConnection con { get; set; }
        public string Server { get; set; }
        public string DB { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
        public string TiempoConexion { get; set; }
        public string Estatus { get; set; }

        public Conexion objConn;

        class conexion
        {
        }

        public SqlConnection Conexionbd()
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

            if (string.IsNullOrEmpty(Server) || string.IsNullOrEmpty(DB) || string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Pass))
            {
                Console.WriteLine("Hubo un error de conexion con la base de datos.");
            }

            objConn = new Conexion();
            objConn.Server = Server;
            objConn.DB = bdDesc;
            objConn.User = usrDesc;
            objConn.Pass = passDesc;
            objConn.TiempoConexion = "60";

            try
            {
                string strcon = String.Empty;
                if (string.IsNullOrEmpty(TiempoConexion))
                {
                    strcon = "user id=" + usrDesc + ";" +
                             "password=" + passDesc + ";" +
                             "server=" + Server + ";" +
                             "Integrated Security=false;" +
                             "database=" + bdDesc + ";" +
                             "connection timeout=0;";
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
                //MessageBox.Show("Catch Conexion" + ex.Message);
                Console.WriteLine("Catch Conexion" + ex.Message);
                return con;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Catch Conexion" + ex.Message);
                Console.WriteLine("Catch Conexion" + ex.Message);
                return con;
            }
        }

        public bool validarConn()
        {
            objConn = new Conexion();
            string Con = String.Empty;

            using (SqlConnection Conne = objConn.Conexionbd())
            {
                if (Conne.State != ConnectionState.Open || !string.IsNullOrEmpty(objConn.Estatus))
                    Con = objConn.Estatus;

                if (Conne.State != ConnectionState.Closed)
                {
                    Conne.Close();
                    return true;
                }
                else
                    return false;
            }
        }

        public string slctSucursal()
        {
            string resultado = string.Empty;
            try
            {
                using (SqlConnection Conne = Conexionbd())
                {
                    string cadena = "Select SincroID From Config Where ID = 1";
                    SqlCommand comando = new SqlCommand(cadena, Conne);
                    SqlDataReader registros = comando.ExecuteReader();
                    while (registros.Read())
                    {
                        resultado = registros["SincroID"].ToString();
                    }

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
            }
            return resultado;
        }

        void IDisposable.Dispose() { }
        public void Dispose() { }
    }
}
