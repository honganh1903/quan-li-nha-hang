using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CTHDDL
    {
        private static CTHDDL _Instance;
        public static CTHDDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CTHDDL();
                }
                return _Instance;
            }
        }
        private CTHDDL() { }
    }
}
