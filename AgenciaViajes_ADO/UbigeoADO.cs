using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AgenciaViajes_ADO
{
    public class UbigeoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blNexo = false;

        public DataTable Ubigeo_Departamentos()
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_Departamentos";
                cmd.Parameters.Clear();
                SqlDataAdapter miAda;
                miAda = new SqlDataAdapter(cmd);
                miAda.Fill(dts, "Departamentos");
                return dts.Tables["Departamentos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Ubigeo_ProvinciasDepartamento(String strIdDepartamento)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_ProvinciasDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                SqlDataAdapter miAda;
                miAda = new SqlDataAdapter(cmd);
                miAda.Fill(dts, "Provincias");
                return dts.Tables["Provincias"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Ubigeo_DistritosProvinciaDepartamento(String strIdDepartamento, String strIdProvincia)
        {
            DataSet dts = new DataSet();
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_Ubigeo_DistritosProvinciaDepartamento";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdDepartamento", strIdDepartamento);
                cmd.Parameters.AddWithValue("@IdProvincia", strIdProvincia);
                SqlDataAdapter miAda;
                miAda = new SqlDataAdapter(cmd);
                miAda.Fill(dts, "Distritos");
                return dts.Tables["Distritos"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
