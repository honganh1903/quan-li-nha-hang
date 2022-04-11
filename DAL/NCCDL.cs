using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
