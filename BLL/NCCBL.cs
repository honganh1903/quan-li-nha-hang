using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
