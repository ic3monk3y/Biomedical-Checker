using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Instalador.Funciones
{
    class spActInfoApp
    {

        //Variable para validar si se entro en el Catch
        public bool actCatch = false;
        public static DataTable spActVer(int EmpresaID, string version, Conexion conn)
        {
            DataTable tabla = new DataTable();
            Console.WriteLine("Empresa ID = {0}, Version = {1}", EmpresaID, version);
            try
            {
                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spActInfoApp", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;
                    dat.SelectCommand.Parameters.Add("@ConfigID", SqlDbType.Int).Value = EmpresaID;
                    dat.SelectCommand.Parameters.Add("@NuevaVersion", SqlDbType.VarChar).Value = version;

                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (Exception ex)
            {
                //actCatch = true;
                MessageBox.Show(ex.Message);
            }
            return tabla;
        }
    }
}
