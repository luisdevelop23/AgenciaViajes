using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AgenciaViajes_BE;

namespace AgenciaViajes_ADO
{
    public class ClienteADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarCliente()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarClientes";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Clientes");
                return dts.Tables["Clientes"];
            }
            catch (SqlException ex)
            {
                throw new Exception(message: ex.Message);
            }
        }

        public ClienteBE ConsultarCliente (String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                ClienteBE objClienteBE = new ClienteBE();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_cli", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objClienteBE.Cod_cli = dtr["Cod_cli"].ToString();
                    objClienteBE.Nom_cli = dtr["Nom_cli"].ToString();
                    objClienteBE.Ape_cli = dtr["Ape_cli"].ToString();
                    objClienteBE.Dni_cli = dtr["Dni_cli"].ToString();
                    objClienteBE.Tef_cli = dtr["Tef_cli"].ToString();
                    objClienteBE.Dir_cli = dtr["Dir_cli"].ToString();
                    objClienteBE.Cor_cli = dtr["Cor_cli"].ToString();
                    objClienteBE.Id_ubi = dtr["Id_ubi"].ToString();
                    objClienteBE.Est_cli = Convert.ToInt16(dtr["Est_cli"]);
                }
                dtr.Close();
                return objClienteBE;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
            }
        }

        public Boolean InsertarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nom_cli", objClienteBE.Nom_cli);
                cmd.Parameters.AddWithValue("@Ape_cli", objClienteBE.Ape_cli);
                cmd.Parameters.AddWithValue("@Dni_cli", objClienteBE.Dni_cli);
                cmd.Parameters.AddWithValue("@Tef_cli", objClienteBE.Tef_cli);
                cmd.Parameters.AddWithValue("@Dir_cli", objClienteBE.Dir_cli);
                cmd.Parameters.AddWithValue("@Cor_cli", objClienteBE.Cor_cli);
                cmd.Parameters.AddWithValue("@Id_ubi", objClienteBE.Id_ubi);
                cmd.Parameters.AddWithValue("@Usu_reg", objClienteBE.Usu_reg);
                cmd.Parameters.AddWithValue("@Est_cli", objClienteBE.Est_cli);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean ActualizarCliente(ClienteBE objClienteBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_cli", objClienteBE.Cod_cli);
                cmd.Parameters.AddWithValue("@Nom_cli", objClienteBE.Nom_cli);
                cmd.Parameters.AddWithValue("@Ape_cli", objClienteBE.Ape_cli);
                cmd.Parameters.AddWithValue("@Dni_cli", objClienteBE.Dni_cli);
                cmd.Parameters.AddWithValue("@Tef_cli", objClienteBE.Tef_cli);
                cmd.Parameters.AddWithValue("@Dir_cli", objClienteBE.Dir_cli);
                cmd.Parameters.AddWithValue("@Cor_cli", objClienteBE.Cor_cli);
                cmd.Parameters.AddWithValue("@Id_ubi", objClienteBE.Id_ubi);
                cmd.Parameters.AddWithValue("@Usu_ult_mod", objClienteBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@Est_cli", objClienteBE.Est_cli);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }

        public Boolean EliminarCliente(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarCliente";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_cli", strCodigo);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }


        }
    }
    
}
