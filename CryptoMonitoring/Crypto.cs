using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMonitoring
{
    internal class Crypto
    {
        public string name { get; set; }
        public double count { get; set; }

        public Crypto(string name, double count)
        {
            this.name = name;
            this.count = count;
        }
        ~Crypto() { }
    }
}
