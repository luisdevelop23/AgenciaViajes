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
    public class HotelBL
    {
        HotelADO objHotelADO = new HotelADO();

        public DataTable ListarHotel()
        {
            return objHotelADO.ListarHotel();
        }
        public HotelBE ConsultarHotel(String strCodigo)
        {
            return objHotelADO.ConsultarHotel(strCodigo);
        }
        public Boolean InsertarHotel(HotelBE objHotelBE)
        {
            return objHotelADO.InsertarHotel(objHotelBE);
        }
        public Boolean ActualizarHotel(HotelBE objHotelBE)
        {
            return objHotelADO.ActualizarHotel(objHotelBE);
        }
        public Boolean EliminarHotel(String strCodigo)
        {
            return objHotelADO.EliminarHotel(strCodigo);
        }
    }
}
    
