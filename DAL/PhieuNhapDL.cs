using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    public class PhieuNhapDL
    {
        private static PhieuNhapDL _Instance;
        public static PhieuNhapDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new PhieuNhapDL();
                }
                return _Instance;
            }
        }
        private PhieuNhapDL() { }
        #region Lấy Danh Sách Phiếu Nhập
        public DataTable GetDanhSachPhieuNhap()
        {
            try
            {
                string sql = "SELECT MAPHIEU AS N'Mã Phiếu', NGAYLAP AS N'Ngày Lập', MANCC AS N'Mã NCC', MANV AS N'Mã Nhân Viên', DANHAP AS N'Đã Nhập' FROM PHIEUNHAP pn WHERE DANHAP=0 AND pn.MAPHIEU IN (SELECT MAPHIEU FROM CHITIETPHIEUNHAP)";
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                return dt;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi database: " + ex.Message);
                return null;
            }
        }
        #endregion
    }
}
