using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Group
    {
        public string Name { get; set; }
        public int GroupId { get; set; }
        public List<Wishlist> Wishlist { get; set; }
    }
}
