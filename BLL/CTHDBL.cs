using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CTHDBL
    {
        private static CTHDBL _Instance;
        public static CTHDBL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CTHDBL();
                }
                return _Instance;
            }
        }
        private CTHDBL() { }
    }
}
