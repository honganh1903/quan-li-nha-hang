using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiSanPhamBL
    {
        private static LoaiSanPhamBL _Instance;
        public static LoaiSanPhamBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new LoaiSanPhamBL();
                }
                return _Instance;
            }
        }
        private LoaiSanPhamBL() { }
    }
}
