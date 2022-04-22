using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

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
        #region Lấy danh sách khách hàng
        public DataTable GetDanhSachKhachHang()
        {
            try
            {
                string sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG ";
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
        #region Thêm Khách Hàng
        public bool ThemKhachHang(KhachHangDTO khDTO)
        {
            try
            {
                string sql = "INSERT INTO KHACHHANG VALUES(@HOTEN,@DIACHI,@SDT,@GIOITINH,@NGAYDANGKY,@EMAIL,@DOANHSO,@DAXOA)";
                SqlConnection con = DataAccess.Openconnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@HOTEN", khDTO.TenKH);
                cmd.Parameters.AddWithValue("@DIACHI", khDTO.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", khDTO.SDT);
                cmd.Parameters.AddWithValue("@GIOITINH", khDTO.GioiTinh);
                cmd.Parameters.AddWithValue("@NGAYDANGKY", khDTO.NgayDangKy);
                cmd.Parameters.AddWithValue("@EMAIL", khDTO.Email);
                cmd.Parameters.AddWithValue("@DOANHSO",khDTO.DoanhSo);
                cmd.Parameters.AddWithValue("@DAXOA",khDTO.DaXoa);
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
        #region Sửa Khách Hàng
        public bool SuaKhachHang(KhachHangDTO khDTO)
        {
            try
            {
                string sql = "UPDATE KHACHHANG SET HOTEN = @HOTEN,DIACHI = @DIACHI,SDT = @SDT,GIOITINH = @GIOITINH, NGAYDANGKY = @NGAYDANGKY, EMAIL = @EMAIL, DOANHSO = @DOANHSO, DAXOA = @DAXOA WHERE MAKH = @MAKH";
                SqlConnection con = DataAccess.Openconnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MAKH", khDTO.MaKH);
                cmd.Parameters.AddWithValue("@HOTEN", khDTO.TenKH);
                cmd.Parameters.AddWithValue("@DIACHI", khDTO.DiaChi);
                cmd.Parameters.AddWithValue("@SDT", khDTO.SDT);
                cmd.Parameters.AddWithValue("@GIOITINH", khDTO.GioiTinh);
                cmd.Parameters.AddWithValue("@NGAYDANGKY", khDTO.NgayDangKy);
                cmd.Parameters.AddWithValue("@EMAIL", khDTO.Email);
                cmd.Parameters.AddWithValue("@DOANHSO", khDTO.DoanhSo);
                cmd.Parameters.AddWithValue("@DAXOA", khDTO.DaXoa);
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
        #region Xóa khách hàng
        public bool XoaKhachHang(KhachHangDTO khDTO)
        {
            try
            {
                string sql = "UPDATE KHACHHANG SET DAXOA = @DAXOA WHERE MAKH = @MAKH";
                SqlConnection con = DataAccess.Openconnect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@MAKH", khDTO.MaKH);
                cmd.Parameters.AddWithValue("@DAXOA", khDTO.DaXoa);
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
        #region Lấy danh sách khách hàng theo tên
        public DataTable GetDanhSachByName(string x,int maDS)
        {
            try
            {
                string sql;
                if (maDS != -1)
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE HOTEN LIKE N'%" + x + "%' AND DAXOA ='" + maDS + "'";
                }
                else
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE HOTEN LIKE N'%" + x + "%'";
                }
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Lấy danh sách khách hàng theo địa chỉ
        public DataTable GetDanhSachByDC(string x,int maDS)
        {
            try
            {
                string sql;
                if (maDS != -1)
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE DIACHI LIKE N'%" + x + "%' AND DAXOA ='" + maDS + "'";
                }
                else
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE DIACHI LIKE N'%" + x + "%'";
                }
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Lấy danh sách khách hàng theo SĐT
        public DataTable GetDanhSachBySDT(string x,int maDS)
        {
            try
            {
                string sql;
                if (maDS != -1)
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE SDT LIKE N'%" + x + "%' AND DAXOA ='" + maDS + "'";
                }
                else
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE SDT LIKE N'%" + x + "%'";
                }
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Lấy danh sách khách hàng theo Giới tính
        public DataTable GetDanhSachByGT(bool x,int maDS)
        {
            try
            {
                string sql;
                if (maDS != -1)
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE GIOITINH = '" + x + "' AND DAXOA ='" + maDS + "'";
                }
                else
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE GIOITINH = '" + x + "'"; 
                }
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Lấy danh sách khách hàng theo Ngày đăng ký
        public DataTable GetDanhSachByNDK(DateTime x,int maDS)
        {
            try
            {
                string sql;
                if (maDS != -1)
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE NGAYDANGKY = '" + x + "' AND DAXOA ='" + maDS + "'";

                }
                else
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE NGAYDANGKY = '" + x + "'";

                }
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                return dt;

            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Lấy danh sách khách hàng theo Email
        public DataTable GetDanhSachByMail(string x,int maDS)
        {
            try
            {
                string sql;
                if (maDS != -1)
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE EMAIL LIKE N'%" + x + "%' AND DAXOA ='" + maDS + "'";
                }
                else
                {
                    sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE EMAIL LIKE N'%" + x + "%'";
                }
                DataTable dt = new DataTable();
                dt = DataAccess.GetTable(sql);
                return dt;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
        #endregion
        #region Lấy danh sách khách hàng hiên tại
        public DataTable GetDanhSachKhachHangHT()
        {
            try
            {
                string sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE DAXOA = '0'";
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
        #region Lấy danh sách khách hàng đã xóa
        public DataTable GetDanhSachKhachHangDX()
        {
            try
            {
                string sql = "SELECT MAKH as N'Mã khách hàng',HOTEN as N'Họ tên',DIACHI as N'Địa chỉ',SDT as N'SĐT',GIOITINH as N'Giới tính(Nam)',NGAYDANGKY as N'Ngày đăng ký',EMAIL as N'Email',DOANHSO as N'Doanh số',DAXOA as N'Đã xóa' FROM KHACHHANG WHERE DAXOA = '1'";
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
