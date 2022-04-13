using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class NCCBL
    {
        private static NCCBL _Instance;
        public static NCCBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new NCCBL();
                }
                return _Instance;
            }
        }
        private NCCBL() { }
        public DataTable GetDanhSachNCC()
        {
            return NCCDL.Instance.GetDanhSachNCC();
        }
        public bool ThemNCC(NhaCungCapDTO nccDTO)
        {
            return NCCDL.Instance.ThemNCC(nccDTO);
        }
    }
}
