using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public User(string username, string email, string password)
        {
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
