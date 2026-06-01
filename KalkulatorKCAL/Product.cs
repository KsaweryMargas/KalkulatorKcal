using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorKCAL
{
    public class Product
    {
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbs { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Calories} kcal, B:{Protein} g, T:{Fat} g , W;{Carbs} g";
        }
    }
}
