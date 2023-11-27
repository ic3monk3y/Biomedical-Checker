using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FivesCheckerMD.Function
{
    class CambioConfigFC
    {
        //Variable para validar si se entro en el Catch
        public bool actCatch = false;
        public DataTable spCambioConfigFC(string usuario, string contra, int sucursal, int acc, Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {
                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spCambioConfigFC", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dat.SelectCommand.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = usuario;
                    dat.SelectCommand.Parameters.Add("@Contrasena", SqlDbType.VarChar).Value = contra;
                    dat.SelectCommand.Parameters.Add("@Sucursal", SqlDbType.Int).Value = sucursal;
                    dat.SelectCommand.Parameters.Add("@Accion", SqlDbType.Int).Value = acc;

                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }
            }
            catch (Exception ex)
            {
                actCatch = true;
                MessageBox.Show(ex.Message);
            }
            return tabla;
        }
    }
}
