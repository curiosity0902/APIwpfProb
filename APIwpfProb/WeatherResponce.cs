using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIwpfProb
{
        class WeatherResponse
        {
            public string Name { get; set; }
            public MainInfo Main { get; set; }
        }
        class MainInfo
        {
            public float Temp { get; set; }
            public string feels_like { get; set; }
            public int pressure { get; set; }
        }
}
