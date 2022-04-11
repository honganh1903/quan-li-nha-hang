using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
