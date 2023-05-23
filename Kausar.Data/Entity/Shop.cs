using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kausar.Data.Entity
{
    public class Shop : BaseEntity
    {
        public int Sellerid { get; set; }
        public User User { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string BannerImg { get; set; }
    }
}
