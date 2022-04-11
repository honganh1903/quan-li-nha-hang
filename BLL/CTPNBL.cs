using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CTPNBL
    {
        private static CTPNBL _Instance;
        public static CTPNBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CTPNBL();
                }
                return _Instance;
            }
        }
        private CTPNBL() { }
    }
}
