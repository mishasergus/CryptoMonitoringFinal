using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMonitoring
{
    public class cooling_sistem
    {
        public int level { get; set; }
        public int cooling_power { get; set; }
        public bool isActive { get; set; }
        public cooling_sistem(int level)
        {
            this.level = level;
            cooling_power = level * 5;
            isActive = false;
        }

        public cooling_sistem() { }
        ~cooling_sistem() { }
    }
}
