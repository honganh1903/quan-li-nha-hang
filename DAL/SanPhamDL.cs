using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDL
    {
        private static SanPhamDL _Instance;
        public static SanPhamDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new SanPhamDL();
                }
                return _Instance;
            }
        }
        private SanPhamDL() { }
    }
}
