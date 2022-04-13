using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

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
        public DataTable GetDanhSachSanPham()
        {
            return  SanPhamDL.Instance.GetDanhSachSanPham();
        }
        public DataTable GetDanhSachSanPhamTheoNCC(int MANCC)
        {
            return SanPhamDL.Instance.GetDanhSachSanPhamTheoNCC(MANCC);
        }
        public string GetTenSP(int MASP)
        {
            return SanPhamDL.Instance.GetTenSP(MASP);
        }

    }
}
