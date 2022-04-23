using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class KhachHangDL
    {
        private static KhachHangDL _Instance;
        public static KhachHangDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new KhachHangDL();
                }
                return _Instance;
            }
        }
        private KhachHangDL() { }
        #region Cập Nhật Doanh Số Khách Hàng
        public bool CapNhatDoanhSoKhachHang(int MAKH, decimal DOANHSO)
        {
            try
            {
                string sql = "UPDATE KHACHHANG SET DOANHSO=DOANHSO+@DOANHSO WHERE MAKH = @MAKH";
                SqlConnection con = DataAccess.Openconnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MAKH", MAKH);
                cmd.Parameters.AddWithValue("@DOANHSO", DOANHSO);
                cmd.Connection = con;
                int rows = cmd.ExecuteNonQuery();
                DataAccess.Disconnect(con);
                if (rows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Lỗi database: " + ex.Message);
                return false;
            }
        }
        #endregion

        #region Lấy Tên Khách Hàng
        public string GetTenKhachHang(string SDT)
        {
            try
            {
                string sql = "SELECT HOTEN FROM KHACHHANG WHERE SDT = '" + SDT + "' AND DAXOA=0";
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                string ten = dt.Rows[0][0].ToString();
                return ten;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion

        #region Lấy Tên Mã Khách Hàng
        public string GetTenMaKH(string SDT)
        {
            try
            {
                string sql = "SELECT MAKH FROM KHACHHANG WHERE SDT = '" + SDT + "' AND DAXOA=0";
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                string ten = dt.Rows[0][0].ToString();
                return ten;
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
