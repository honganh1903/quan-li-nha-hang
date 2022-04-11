using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CTPNDL
    {
        private static CTPNDL _Instance;
        public static CTPNDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CTPNDL();
                }
                return _Instance;
            }
        }
        private CTPNDL() { }
    }
}
