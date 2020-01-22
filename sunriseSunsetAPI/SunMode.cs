using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sunriseSunsetAPI
{
    class SunMode
    {
        public string Status { get; set; }
        public Results Results { get; set; }


    }

    public class Results
    {
        public string Sunrise { get; set; }
        public string Sunset { get; set; }
    }
}
