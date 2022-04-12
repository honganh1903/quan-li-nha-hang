using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

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
    }
}
