using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoMonitoring
{
    public class Video_card
    {
        public int strength { get; set; }
        public bool isActive { get; set; }
        public int level { get; set; }
        public Video_card(int strength, int level)
        {
            this.strength = strength;
            isActive = false;
            this.level = level;
        }
        public Video_card() { }
        ~Video_card() { }
    }
}
