using System;
using System.Collections.Generic;
using System.Text;

namespace BarberAppDLL.Models.ViewModels
{
    public class MapViewModel
    {
        public List<string> Lats { get; set; }
        public List<string> Longs { get; set; }
        public List<string> Captions { get; set; }
        public List<string> Names { get; set; }

        public string CenterLat { get; set; }
        public string CenterLon { get; set; }
        public string Scale { get; set; }
        public string Zoom { get; set; }
    }

    public class MapMark {

        public string Lat { get; set; }
        public string Lon { get; set; }
        public string Caption { get; set; }
        public string Name { get; set; }

    }

    
}
