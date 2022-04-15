using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

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
        #region Lấy Danh Sách Loại Sản Phẩm
        public DataTable GetDanhSachLoaiSanPham()
        {
            try
            {
                string sql = "SELECT MALOAISP AS N'Mã Loại SP', TENLOAISP AS N'Tên Loại SP' FROM LOAISANPHAM WHERE NGUNGKINHDOANH=0";
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
