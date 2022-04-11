using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhanVienBL
    {
        private static NhanVienBL _Instance;
        public static NhanVienBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVienBL();
                }
                return _Instance;
            }
        }
        private NhanVienBL() { }
    }
}
