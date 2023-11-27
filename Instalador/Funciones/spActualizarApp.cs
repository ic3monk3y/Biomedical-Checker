using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Instalador.Funciones
{
    class spActualizarApp
    {
        //Variable para validar si se entro en el Catch
        public bool actCatch = false;
        public static DataTable spActApp(string query, DataTable data, Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spActualizarApp", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dat.SelectCommand.Parameters.Add("@Qry", SqlDbType.VarChar).Value = query;
                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (Exception ex)
            {
                DataTable sucursalDt = slctSucursal(conn);
                string sucursal = sucursalDt.Rows[0]["SincroID"].ToString();
                MessageBox.Show(ex.Message);
                ActualizarApp.SpErrorLog(data, sucursal, query,"2714", ex.Message).Wait();
            }
            return tabla;
        }
        private static DataTable slctSucursal(Conexion conn)
        {
            DataTable resultado = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    string cadena = "select SincroID from Config";
                    SqlCommand comando = new SqlCommand(cadena, Conne);
                    SqlDataReader registros = comando.ExecuteReader();
                    resultado.Load(registros);

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
    }
}
