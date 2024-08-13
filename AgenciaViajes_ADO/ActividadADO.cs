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
    public class ActividadADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarActividad()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarActividad";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Actividades");
                return dts.Tables["Actividades"];
            }
            catch (SqlException ex)
            {
                throw new Exception(message: ex.Message);
            } 
        }
        public ActividadBE ConsultarActividad(String strCodigo)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                ActividadBE objproductoBE = new ActividadBE();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarActividad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_act", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objproductoBE.Cod_act = dtr["Cod_act"].ToString();
                    objproductoBE.Nom_act = dtr["Nom_act"].ToString();
                    objproductoBE.Des_act = dtr["Des_act"].ToString();
                    objproductoBE.Pre_per_act = Convert.ToSingle(dtr["Pre_per_act"]);
                    objproductoBE.Lug_act = dtr["Lug_act"].ToString();
                    objproductoBE.Pai_act = dtr["Pai_act"].ToString();
                    objproductoBE.Est_act = Convert.ToInt16(dtr["Est_act"]);
                }
                dtr.Close();
                return objproductoBE;
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
        public Boolean InsertarActividad(ActividadBE objActividadBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarActividad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Des_act", objActividadBE.Des_act);
                cmd.Parameters.AddWithValue("@Nom_act", objActividadBE.Nom_act);
                cmd.Parameters.AddWithValue("@Pre_per_act", objActividadBE.Pre_per_act);
                cmd.Parameters.AddWithValue("@Lug_act", objActividadBE.Lug_act);
                cmd.Parameters.AddWithValue("@Pai_act", objActividadBE.Pai_act);
                cmd.Parameters.AddWithValue("@Usu_reg", objActividadBE.Usu_Reg);
                cmd.Parameters.AddWithValue("@Est_act", objActividadBE.Est_act);

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
        public Boolean ActualizarActividad(ActividadBE objActividadBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarActividad";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_act", objActividadBE.Cod_act);
                cmd.Parameters.AddWithValue("@Des_act", objActividadBE.Des_act);
                cmd.Parameters.AddWithValue("@Nom_act", objActividadBE.Nom_act);
                cmd.Parameters.AddWithValue("@Pre_per_act", objActividadBE.Pre_per_act);
                cmd.Parameters.AddWithValue("@Lug_act", objActividadBE.Lug_act);
                cmd.Parameters.AddWithValue("@Pai_act", objActividadBE.Pai_act);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objActividadBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@Est_act", objActividadBE.Est_act);

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
            public Boolean EliminarActividad(String strCodigo)
            {


                try
                {
                    //Codifique
                    cnx.ConnectionString = MiConexion.GetCnx();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_EliminarActividad";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@Cod_act", strCodigo);

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

