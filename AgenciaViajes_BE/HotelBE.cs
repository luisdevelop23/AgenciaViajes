using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes_BE
{
    public class HotelBE
    {
        public String Cod_hot { get; set; }
        public String Nom_hot { get; set; }
        public String Dir_hot { get; set; }
        public String Pai_hot { get; set; }
        public Int16 Cat_hot { get; set; }
        public Single Pre_hab { get; set; }
        public String Ciu_hot { get; set; }
        public DateTime Fec_reg { get; set; }
        public String Usu_reg { get; set; }
        public DateTime Fec_Ult_mod { get; set; }
        public String Usu_Ult_mod { get; set; }
        public Int16 Est_hot { get; set; }
       
    }
}
