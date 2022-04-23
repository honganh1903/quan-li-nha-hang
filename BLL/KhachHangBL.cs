using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

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
        public bool CapNhatDoanhSoKhachHang(int MAKH, decimal DOANHSO)
        {
            return KhachHangDL.Instance.CapNhatDoanhSoKhachHang(MAKH, DOANHSO);
        }
        public string GetTenKhachHang(string SDT)
        {
            return KhachHangDL.Instance.GetTenKhachHang(SDT);
        }
        public string GetTenMaKH(string SDT)
        {
            return KhachHangDL.Instance.GetTenMaKH(SDT);
        }
    }
}
