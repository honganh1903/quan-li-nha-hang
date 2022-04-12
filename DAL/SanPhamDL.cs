using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        #region
        public DataTable GetDanhSachSanPham()
        {
            try
            {
                string sql = "SELECT MASP as N'Mã SP',TENSP as N'Tên SP',MALOAISP as N'Mã Loại SP',DVT as N'ĐVT',MANCC as N'Mã NCC',NGAYSX as N'Ngày SX',NGAYHETHAN as N'Ngày Hết Hạn',SOLUONG as N'Số Lượng', DONGIANHAP as N'Đơn Giá Nhập', LOINHUAN as N'Lợi Nhuận', DONGIABAN as N'Đơn Giá Bán',KHUYENMAI as N'Khuyến Mãi',HINHANH as N'Hình Ảnh' FROM SanPham WHERE NGUNGKINHDOANH = '0'";
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
