using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDL
    {
        private static KhachHangDL _Instance;
        public static KhachHangDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhachHangDL();
                }
                return _Instance;
            }
        }
        private KhachHangDL() { }
    }
}
