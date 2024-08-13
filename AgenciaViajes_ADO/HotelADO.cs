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
    public class HotelADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarHotel()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarHotel";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Hoteles");
                return dts.Tables["Hoteles"];
            }
            catch (SqlException ex)
            {
                throw new Exception(message: ex.Message);
            }
        }
        public HotelBE ConsultarHotel(String strCodigo)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                HotelBE objHotelBE = new HotelBE();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarHotel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_hot", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();

                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objHotelBE.Cod_hot = dtr["Cod_hot"].ToString();
                    objHotelBE.Nom_hot = dtr["Nom_hot"].ToString();
                    objHotelBE.Dir_hot = dtr["Dir_hot"].ToString();              
                    objHotelBE.Pai_hot = dtr["Pai_hot"].ToString();
                    objHotelBE.Ciu_hot = dtr["Ciu_hot"].ToString();
                    objHotelBE.Cat_hot = Convert.ToInt16(dtr["Cat_hot"]);
                    objHotelBE.Pre_hab = Convert.ToSingle(dtr["Pre_hab"]);
                    objHotelBE.Est_hot = Convert.ToInt16(dtr["Est_hot"]);
                }
                dtr.Close();
                return objHotelBE;
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
        public Boolean InsertarHotel(HotelBE objHotelBE)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarHotel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nom_hot", objHotelBE.Nom_hot);
                cmd.Parameters.AddWithValue("@Dir_hot", objHotelBE.Dir_hot);
                cmd.Parameters.AddWithValue("@Pai_hot", objHotelBE.Pai_hot);
                cmd.Parameters.AddWithValue("@Cat_hot", objHotelBE.Cat_hot);
                cmd.Parameters.AddWithValue("@Pre_hab", objHotelBE.Pre_hab);
                cmd.Parameters.AddWithValue("@Ciu_hot", objHotelBE.Ciu_hot);
                cmd.Parameters.AddWithValue("@Usu_reg", objHotelBE.Usu_reg);
                cmd.Parameters.AddWithValue("@Est_hot", objHotelBE.Est_hot);
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
        public Boolean ActualizarHotel(HotelBE objHotelBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarHotel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_hot", objHotelBE.Cod_hot);
                cmd.Parameters.AddWithValue("@Nom_hot", objHotelBE.Nom_hot);
                cmd.Parameters.AddWithValue("@Dir_hot ", objHotelBE.Dir_hot);
                cmd.Parameters.AddWithValue("@Pai_hot", objHotelBE.Pai_hot);
                cmd.Parameters.AddWithValue("@Cat_hot", objHotelBE.Cat_hot);
                cmd.Parameters.AddWithValue("@Pre_hab", objHotelBE.Pre_hab);
                cmd.Parameters.AddWithValue("@Ciu_hot", objHotelBE.Ciu_hot);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objHotelBE.Usu_Ult_mod);
                cmd.Parameters.AddWithValue("@Est_hot", objHotelBE.Est_hot);

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
        public Boolean EliminarHotel(String strCodigo)
        {


            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarHotel";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_hot", strCodigo);

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
