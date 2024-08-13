using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AgenciaViajes_BL;

namespace AgenciaViajes_ADO
{
    public class EmpleadoADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;

        public DataTable ListarEmpleado()
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarEmpleado";
                cmd.Parameters.Clear();

                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();
                ada.Fill(dts, "Empleados");
                return dts.Tables["Empleados"];
            }
            catch (Exception ex)
            {
                throw new Exception(message: ex.Message);
            }
        }
        public EmpleadoBE ConsultarEmpleado(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                EmpleadoBE objEmpleadoBE = new EmpleadoBE();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEmpleadoDetalle";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vCodEmp", strCodigo);
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objEmpleadoBE.Cod_emp = dtr["Cod_emp"].ToString();
                    objEmpleadoBE.Nom_emp = dtr["Nom_emp"].ToString();
                    objEmpleadoBE.Ape_emp = dtr["Ape_emp"].ToString();
                    objEmpleadoBE.Dni_emp = dtr["Dni_emp"].ToString();
                    objEmpleadoBE.Tef_emp = dtr["Tef_emp"].ToString();
                    objEmpleadoBE.Dir_emp = dtr["Dir_emp"].ToString();
                    objEmpleadoBE.Cor_emp = dtr["Cor_emp"].ToString();
                    objEmpleadoBE.Dni_emp = dtr["Dni_emp"].ToString();
                    objEmpleadoBE.Sue_emp = dtr["Sue_emp"].ToString();
                    objEmpleadoBE.Car_emp = Convert.ToInt16(dtr["Car_emp"]);
                    objEmpleadoBE.Est_emp = Convert.ToInt16(dtr["Est_emp"]);
                    objEmpleadoBE.Cod_sup = dtr["Cod_sup"].ToString();
                }
                dtr.Close();
                return objEmpleadoBE;
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


       public Boolean InsertarEmpleado(EmpleadoBE objEmpleadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vNomEmp",objEmpleadoBE.Nom_emp);
                cmd.Parameters.AddWithValue("@vApeEmp", objEmpleadoBE.Ape_emp);
                cmd.Parameters.AddWithValue("@vDNIEmp", objEmpleadoBE.Dni_emp);
                cmd.Parameters.AddWithValue("@vTefEmp", objEmpleadoBE.Tef_emp);
                cmd.Parameters.AddWithValue("@vDirEmp", objEmpleadoBE.Dir_emp);
                cmd.Parameters.AddWithValue("@vCorEmp", objEmpleadoBE.Cor_emp);
                cmd.Parameters.AddWithValue("@vSueEmp", objEmpleadoBE.Sue_emp);
                cmd.Parameters.AddWithValue("@vCarEmp", objEmpleadoBE.Car_emp);
                cmd.Parameters.AddWithValue("@vCodSup", objEmpleadoBE.Cod_sup);
                cmd.Parameters.AddWithValue("@vUsuReg", objEmpleadoBE.Usu_reg);
                cmd.Parameters.AddWithValue("@vEstEmp", objEmpleadoBE.Est_emp);
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

        public Boolean ActualizarEmpleado(EmpleadoBE objempleadoBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@vCodEmp", objempleadoBE.Cod_emp);
                cmd.Parameters.AddWithValue("@vNomEmp", objempleadoBE.Nom_emp);
                cmd.Parameters.AddWithValue("@vApeEmp", objempleadoBE.Ape_emp);
                cmd.Parameters.AddWithValue("@vDNIEmp", objempleadoBE.Dni_emp);
                cmd.Parameters.AddWithValue("@vTefEmp", objempleadoBE.Tef_emp);
                cmd.Parameters.AddWithValue("@vDirEmp", objempleadoBE.Dir_emp);
                cmd.Parameters.AddWithValue("@vCorEmp", objempleadoBE.Cor_emp);
                cmd.Parameters.AddWithValue("@vSueEmp", objempleadoBE.Sue_emp);
                cmd.Parameters.AddWithValue("@vCarEmp", objempleadoBE.Car_emp);
                cmd.Parameters.AddWithValue("@vCodSup", objempleadoBE.Cod_sup);
                cmd.Parameters.AddWithValue("@vUsuUltMod", objempleadoBE.Usu_ult_mod);
                cmd.Parameters.AddWithValue("@vEstEmp", objempleadoBE.Est_emp);


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

        public Boolean EliminarEmpleado(String strCodigo)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarEmpleado";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Cod_emp", strCodigo);

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
