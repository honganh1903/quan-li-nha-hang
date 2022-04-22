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
    public class KhachHangBL
    {
        private static KhachHangBL _Instance;
        public static KhachHangBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhachHangBL();
                }
                return _Instance;
            }
        }
        private KhachHangBL() { }
        public DataTable GetDanhSachKhachHang()
        {
            return KhachHangDL.Instance.GetDanhSachKhachHang();
        }
        public DataTable GetDanhSachKhachHangHT()
        {
            return KhachHangDL.Instance.GetDanhSachKhachHangHT();
        }
        public DataTable GetDanhSachKhachHangDX()
        {
            return KhachHangDL.Instance.GetDanhSachKhachHangDX();
        }
        public bool ThemKhachHang(KhachHangDTO khDTO)
        {
            return KhachHangDL.Instance.ThemKhachHang(khDTO);
        }
        public bool SuaKhachHang(KhachHangDTO khDTO)
        {
            return KhachHangDL.Instance.SuaKhachHang(khDTO);
        }
        public bool XoaKhachHang(KhachHangDTO khDTO)
        {
            return KhachHangDL.Instance.XoaKhachHang(khDTO);
        }
        public DataTable GetDanhSachByName(string x)
        {
            return KhachHangDL.Instance.GetDanhSachByName(x);
        }
        public DataTable GetDanhSachByDC(string x)
        {
            return KhachHangDL.Instance.GetDanhSachByDC(x);
        }
        public DataTable GetDanhSachBySDT(string x)
        {
            return KhachHangDL.Instance.GetDanhSachBySDT(x);
        }
        public DataTable GetDanhSachByMail(string x)
        {
            return KhachHangDL.Instance.GetDanhSachByMail(x);
        }
        public DataTable GetDanhSachByGT(bool x)
        {
            return KhachHangDL.Instance.GetDanhSachByGT(x);
        }
        public DataTable GetDanhSachByNDK(DateTime x)
        {
            return KhachHangDL.Instance.GetDanhSachByNDK(x);
        }
    }
}
