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
    public class NhanVienDL
    {
        private static NhanVienDL _Instance;
        public static NhanVienDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NhanVienDL();
                }
                return _Instance;
            }
        }
        private NhanVienDL() { }
        #region Lấy tên nhân viên
        public string GetTenNhanVien(int manv)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE MANV = '" + manv + "'";
            DataTable dt = new DataTable();
            dt = DataAccess.GetTable(sql);
            string ten = dt.Rows[0][1].ToString();
            return ten;
        }
        #endregion
    }
}
