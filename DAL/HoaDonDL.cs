using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDL
    {
        private static HoaDonDL _Instance;
        public static HoaDonDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new HoaDonDL();
                }
                return _Instance;
            }
        }
        private HoaDonDL() { }
    }
}
