using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhanVienDL
    {
        private static NhanVienDL _Instance;
        public static NhanVienDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVienDL();
                }
                return _Instance;
            }
        }
        private NhanVienDL() { }
    }
}
