using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Security.Authentication;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instalador.Funciones
{
    class ActualizarApp
    {
        public bool infoConfigBandera = false,
                    actAppBandera = false,
                    errorLogBandera = false;

        public DataTable ConsultarInfoApp(Conexion conn) 
        {
            DataTable infoConfig = new DataTable();

            try
            {
                using (SqlConnection Conne = conn.ConeccionBD())
                {
                    SqlDataAdapter dat = new SqlDataAdapter("spInfoApp", Conne); 
                    dat.SelectCommand.CommandType = CommandType.StoredProcedure;

                    dat.Fill(infoConfig);

                    if (Conne.State != ConnectionState.Closed)
                        Conne.Close();

                    infoConfigBandera = true;
                }
            }
            catch (Exception ex)
            {
                infoConfigBandera = false;
                MessageBox.Show(ex.Message);
            }

            return infoConfig;
        }

        public async Task ValidarActualizacionAppAsync(DataTable dtConfig, Conexion conn)
        {
            try
            {
                foreach (DataRow row in dtConfig.Rows)
                {
                    var values = new List<KeyValuePair<string, string>>();
                    foreach (DataColumn column in dtConfig.Columns)
                    {
                        values.Add(new KeyValuePair<string, string>(column.ToString(), row[column].ToString()));
                        Console.WriteLine(row[column]);
                    }
                    values.Add(new KeyValuePair<string, string>("tipo", "spValidarNuevaVersionAPP"));

                    var content = new FormUrlEncodedContent(values);
                    using (var handler = new HttpClientHandler())
                    {
                        handler.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;
                        handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                        using (var client = new HttpClient(handler))
                        {
                            try
                            {
                                var response = client.PostAsync(row["UrlApp"].ToString(), content).GetAwaiter().GetResult();
                                string responseString = await response.Content.ReadAsStringAsync();
                                List<ValidarVerAppViewModel> Respuesta = JsonConvert.DeserializeObject<List<ValidarVerAppViewModel>>(responseString);
                                int Ok = Respuesta[0].Ok;
                                string Empresa = Respuesta[0].EmpresaApp;
                                string Version = Respuesta[0].VersionApp;

                                Console.WriteLine(Version);

                                Funciones.spActInfoApp.spActVer(Convert.ToInt32(row["EmpresaID"]), Version, conn);

                                if (Ok == 1)
                                    actAppBandera = false;
                                if (Ok == 0)
                                    actAppBandera = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                actAppBandera = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                actAppBandera = false;
            }
        }

        public async Task ActualizarBackEnd (DataTable dtConfig, Conexion conn)
        {
            try
            {
                foreach (DataRow row in dtConfig.Rows)
                {
                    var values = new List<KeyValuePair<string, string>>();
                    foreach (DataColumn column in dtConfig.Columns)
                    {
                        values.Add(new KeyValuePair<string, string>(column.ToString(), row[column].ToString()));
                        Console.WriteLine(row[column]);
                    }
                    values.Add(new KeyValuePair<string, string>("tipo", "spConsultaSpsNuevaVersions"));

                    var content = new FormUrlEncodedContent(values);
                    using (var handler = new HttpClientHandler())
                    {
                        handler.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;
                        handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                        using (var client = new HttpClient(handler))
                        {
                            try
                            {
                                var response = client.PostAsync(row["UrlApp"].ToString(), content).GetAwaiter().GetResult();
                                string responseString = await response.Content.ReadAsStringAsync();
                                List<ConsultaSpsViewModel> Respuesta = JsonConvert.DeserializeObject<List<ConsultaSpsViewModel>>(responseString);
                               foreach (var sp in Respuesta)
                               {
                                    Console.WriteLine("SP = {0}", sp.Sp);
                                    Funciones.spActualizarApp.spActApp(sp.Sp, dtConfig, conn);
                               }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                actAppBandera = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                actAppBandera = false;
            }
        }

        public static async Task SpErrorLog (DataTable dtConfig, string sucursal, string Sp, string Error, string Mensaje)
        {
            try
            {
                foreach (DataRow row in dtConfig.Rows)
                {
                    var values = new List<KeyValuePair<string, string>>();
                    foreach (DataColumn column in dtConfig.Columns)
                    {
                        values.Add(new KeyValuePair<string, string>(column.ToString(), row[column].ToString()));
                        Console.WriteLine(row[column]);
                    }
                    Console.WriteLine("Sucursal = {0}, Sp = {1}, Error = {2}, Mensaje = {3}",sucursal,Sp,Error,Mensaje);
                    values.Add(new KeyValuePair<string, string>("Sucursal", sucursal));
                    values.Add(new KeyValuePair<string, string>("Sp",Sp));
                    values.Add(new KeyValuePair<string, string>("Error", Error));
                    values.Add(new KeyValuePair<string, string>("Mensaje", Mensaje));
                    values.Add(new KeyValuePair<string, string>("tipo", "spRegistrarErrorActualizarApp"));

                    var content = new FormUrlEncodedContent(values);
                    using (var handler = new HttpClientHandler())
                    {
                        handler.SslProtocols = SslProtocols.Tls12 | SslProtocols.Tls11 | SslProtocols.Tls;
                        handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                        using (var client = new HttpClient(handler))
                        {
                            try
                            {
                                var response = client.PostAsync(row["UrlApp"].ToString(), content).GetAwaiter().GetResult();
                                string responseString = await response.Content.ReadAsStringAsync();
                                List<ErrorLogViewModel> Respuesta = JsonConvert.DeserializeObject<List<ErrorLogViewModel>>(responseString);
                                foreach (var jsResponse in Respuesta)
                                {
                                    Console.WriteLine("Mensaje = {0}", jsResponse.Mensaje);
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
