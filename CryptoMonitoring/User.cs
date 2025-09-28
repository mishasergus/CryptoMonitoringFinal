using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoMonitoring
{
    internal class User
    {
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public double balance { get; set; }
        public List<Crypto> cryptos { get; set; }
        public List<bool> achievements { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public List<Video_card> video_cards { get; set; }
        public List<cooling_sistem> cooling_sistems { get; set; }
        public User(string username, string email, string password)
        {
            this.video_cards = new List<Video_card> { };
            video_cards.Add(new Video_card(5000, 1));
            this.cooling_sistems = new List<cooling_sistem> { };
            this.description = "-";
            this.image = "D:\\ITSTEP\\C#\\CryptoMonitoring-Tests-master\\CryptoMonitoring\\Resources\\profile_img.png";
            this.username = username;
            this.email = email;
            this.password = password;
            this.balance = 100.0;
            this.achievements = new List<bool> { false, false, false, false, false, false, false, false, false, false };
            cryptos = new List<Crypto>();
        }

        ~User(){}
    }
}
