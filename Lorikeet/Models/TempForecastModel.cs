using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lorikeet.Models
{
    public class TempForecastModel
    {
        public DateTime date { get; set; }
        public double min { get; set; }
        public double max { get; set; }
        public string condition { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
