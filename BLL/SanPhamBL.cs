using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBL
    {
        private static SanPhamBL _Instance;
        public static SanPhamBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SanPhamBL();
                }
                return _Instance;
            }
        }
        private SanPhamBL() { }
    }
}
