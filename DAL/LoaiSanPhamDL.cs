using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class LoaiSanPhamDL
    {
        private static LoaiSanPhamDL _Instance;
        public static LoaiSanPhamDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoaiSanPhamDL();
                }
                return _Instance;
            }
        }
        private LoaiSanPhamDL() { }
    }
}
