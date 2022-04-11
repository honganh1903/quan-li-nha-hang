using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
