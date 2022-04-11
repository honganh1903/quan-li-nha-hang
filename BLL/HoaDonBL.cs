using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBL
    {
        private static HoaDonBL _Instance;
        public static HoaDonBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HoaDonBL();
                }
                return _Instance;
            }
        }
        private HoaDonBL() { }
    }
}
