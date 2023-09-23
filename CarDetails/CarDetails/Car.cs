using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetails
{
    public class Car
    {
        public int CarId { get; set; }
        public string CarModel { get; set; }
        public  CarBrand BrandName { get; set; }
        public Color CarColor { get; set; }
        public double CarPrice { get; set; }
    }
}
