using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AviaSalesApp.Common
{
    public class GeoPath
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Airport { get; set; }

        public override string ToString()
        {
            var localPathBuilder = new StringBuilder();

            localPathBuilder.Append(Country);
            localPathBuilder.Append(", ");
            localPathBuilder.Append(City);
            localPathBuilder.Append(", ");
            localPathBuilder.Append(Airport);

            return localPathBuilder.ToString();
        }

        public GeoPath(string airport, string city, string country)
        {
            Airport = airport;
            City = city;
            Country = country;
        }
    }
}
