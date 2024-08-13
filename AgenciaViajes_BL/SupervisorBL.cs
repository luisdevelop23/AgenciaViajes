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
    public class SupervisorBL
    {
        SupervisorADO objsupervisorADO = new SupervisorADO();
        public DataTable ListarSupervisor()
        {
            return objsupervisorADO.ListarSupervisor();
        }
    }
}
