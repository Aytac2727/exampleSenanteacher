using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples
{
    public class Product
    {
        public string name;
        public double price;
        public double percent;
        public string description;

        public string GetDescriptionAsSeo()
        {
            return description.ToLower().Replace("ə", "e").Replace("ç", "c").Replace("ş", "s").Replace("ö", "o").Replace("ğ", "g").Replace("ü","u");
        }
        public double CalculateEDV()
        {
            percent = (price * 18) / 100;
            return percent;
        }

    }
}
