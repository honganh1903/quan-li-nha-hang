using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAL
{
    public class NCCDL
    {
        private static NCCDL _Instance;
        public static NCCDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NCCDL();
                }
                return _Instance;
            }
        }
        private NCCDL() { }
        #region Lấy Danh Sách NCC
        public DataTable GetDanhSachNCC()
        {
            try
            {
                DataTable dt = new DataTable();
                string sql = "SELECT MANCC AS N'Mã NCC',TENNCC AS N'Tên NCC',DIACHI AS N'Địa Chỉ NCC',SDT AS N'SĐT',Email AS 'Email' FROM NCC WHERE NGUNGHOPTAC=0";
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

        #region Thêm NCC
        public bool ThemNCC(NhaCungCapDTO nccDTO)
        {
            try
            {
                string sql = "INSERT INTO NCC(TENNCC,NGUNGHOPTAC) VALUES(N'" + nccDTO.TenNCC + "',0)";
                int rows = DataAccess.JustExcuteNoParameter(sql);
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
    }
}
