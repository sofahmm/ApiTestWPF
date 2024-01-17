using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestWPF
{
     class WeatherResponse
    {
        public string Name { get; set; }
        public MainInfo Main { get; set; }
    }
    class MainInfo
    {
        public float Temp { get; set; }
    }
}
