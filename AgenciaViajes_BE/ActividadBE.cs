using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes_BE
{
    public class ActividadBE
    {
        public String Cod_act { get; set; }
        public String Nom_act { get; set; }
        public String Lug_act { get; set; }
        public String Pai_act { get; set; }
        public Single Pre_per_act { get; set; }
        public String Des_act { get; set; }
        public String Usu_Reg { get; set; }
        public DateTime Fec_reg { get; set; }
        public DateTime Fec_ult_mod { get; set; }
        public String Usu_ult_mod { get; set; }
        public Int16 Est_act { get; set; }
    }
}
