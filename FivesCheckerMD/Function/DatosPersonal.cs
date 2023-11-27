using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FivesCheckerMD.Function
{
    class DatosPersonal
    {
        //Variable para validar si se entro en el Catch
        public bool actCatch = false;
        public static DataTable spDatosPersonal(String Personal,Conexion conn)
        {
            DataTable tabla = new DataTable();
            try
            {

                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spValidarPersonal", Conne);
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dat.SelectCommand.Parameters.Add("@Personal", SqlDbType.VarChar).Value = Personal;

                    dat.Fill(tabla);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();
                }

            }
            catch (Exception ex)
            {
                var trycathch = new DatosPersonal();
                trycathch.actCatch = true;
                //throw new ApplicationException(ex.Message);
                MessageBox.Show(ex.Message);
            }
            return tabla;
        }
    }
}
