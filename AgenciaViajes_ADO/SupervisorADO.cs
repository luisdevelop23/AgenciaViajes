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
    public class SupervisorADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        Boolean blNexo = false;

        public DataTable ListarSupervisor()
        {
          
            try 
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarSupervisor";
                cmd.Parameters.Clear();
                SqlDataAdapter miAda;
                miAda = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                miAda.Fill(dts, "NombreEmpleado");
                return dts.Tables["NombreEmpleado"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
