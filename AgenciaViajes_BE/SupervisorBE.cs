using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViajes_BE
{
    public class SupervisorBE
    {
        public String Cod_cli { get; set; }
        public String Nom_cli { get; set; }
        public String Ape_cli { get; set; }
        public String Dni_cli { get; set; }
        public String Tef_cli { get; set; }
        public String Dir_cli { get; set; }
        public String Cor_cli { get; set; }
        public String Id_ubi { get; set; }
        public DateTime Fec_reg { get; set; }
        public String Usu_reg { get; set; }
        public DateTime Fec_ult_mod { get; set; }
        public String Usu_ult_mod { get; set; }
        public Int16 Est_cli { get; set; }
    }
}
