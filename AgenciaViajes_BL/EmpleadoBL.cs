using AgenciaViajes_ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgenciaViajes_ADO;
using AgenciaViajes_BE;

namespace AgenciaViajes_BL
{
    public class EmpleadoBL
    {
        EmpleadoADO objempleadoADO = new EmpleadoADO();

        public DataTable ListarEmpleado()
        {
            return objempleadoADO.ListarEmpleado();
        }
        public EmpleadoBE ConsultarEmpleado(String strCodigo)
        {
            return objempleadoADO.ConsultarEmpleado(strCodigo);
        }

        public Boolean InsertarEmpleado(EmpleadoBE objempleadoBE)
        {
            return objempleadoADO.InsertarEmpleado(objempleadoBE);
        }

        public Boolean ActualizarEmpleado(EmpleadoBE objempleadoBE)
        {
            return objempleadoADO.ActualizarEmpleado(objempleadoBE);
        }
        public Boolean EliminarEmpleado(String strCodigo)
        {
            return objempleadoADO.EliminarEmpleado(strCodigo);
        }
    }
}
