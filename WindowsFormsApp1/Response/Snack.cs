using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Response
{
    public class Item
    {
        public string title { get; set; }
        public string link { get; set; }
        public string image { get; set; }
        public string lprice { get; set; }
        public string hprice { get; set; }
        public string mallName { get; set; }
        public string productId { get; set; }
        public string productType { get; set; }
    }

    public class Snack
    {
        public string lastBuildDate { get; set; }
        public int total { get; set; }
        public int start { get; set; }
        public int display { get; set; }
        public List<Item> items { get; set; }
    }
}
