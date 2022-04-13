using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;

namespace BLL
{
    public class PhieuNhapBL
    {
        private static PhieuNhapBL _Instance;
        public static PhieuNhapBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PhieuNhapBL();
                }
                return _Instance;
            }
        }
        private PhieuNhapBL() { }
        public DataTable GetDanhSachPhieuNhap()
        {
            return PhieuNhapDL.Instance.GetDanhSachPhieuNhap();
        }
        public bool ThemPhieuNhap(PhieuNhapDTO pnDTO)
        {
            return PhieuNhapDL.Instance.ThemPhieuNhap(pnDTO);
        }
        public int GetMAPNMax()
        {
            return PhieuNhapDL.Instance.GetMAPNMax();
        }
        public bool XoaPN(int MAPN)
        {
            return PhieuNhapDL.Instance.XoaPN(MAPN);
        }

        public bool XacNhan(int MaPhieu)
        {
            return PhieuNhapDL.Instance.XacNhan(MaPhieu);
        }
        public bool CapNhatSoLuong(int MaPhieu)
        {
            return PhieuNhapDL.Instance.CapNhatSoLuong(MaPhieu);
        }
    }
}
