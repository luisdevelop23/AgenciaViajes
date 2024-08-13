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
    public class ActividadBL
    {
       ActividadADO objActividadADO = new ActividadADO();

        public DataTable ListarActividad()
        {
            return objActividadADO.ListarActividad();
        }
        public ActividadBE ConsultarActividad(String strCodigo)
        {
            return objActividadADO.ConsultarActividad(strCodigo);
        }
        public Boolean InsertarActividad(ActividadBE objActividadBE)
        {
            return objActividadADO.InsertarActividad(objActividadBE);
        }
        public Boolean ActualizarActividad(ActividadBE objActividadBE)
        {
            return objActividadADO.ActualizarActividad(objActividadBE);
        }
        public Boolean EliminarActividad(String strCodigo)
        {
            return objActividadADO.EliminarActividad(strCodigo);
        }
    }
}