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
        public bool NgungKinhDoanhSanPham(string MASP)
        {
            return SanPhamDL.Instance.NgungKinhDoanhSanPham(MASP);
        }
        public bool ThemSanPham(SanPhamDTO spDTO)
        {
            return SanPhamDL.Instance.ThemSanPham(spDTO);
        }
        public bool SuaSanPham(SanPhamDTO spDTO)
        {
            return SanPhamDL.Instance.SuaSanPham(spDTO);
        }
        public DataTable GetDanhSachSanPhamTheoBoLoc(string TENSP, string MALOAISP, string MANCC)
        {
            return SanPhamDL.Instance.GetDanhSachSanPhamTheoBoLoc(TENSP, MALOAISP, MANCC);
        }

        public DataTable GetDanhSachDVT()
        {
            return SanPhamDL.Instance.GetDanhSachDVT();
        }
        public bool CapNhatSoLuongKhiBanHang(int MaSP, int SoLuong)
        {
            return SanPhamDL.Instance.CapNhatSoLuongKhiBanHang(MaSP, SoLuong);
        }
    }
}
