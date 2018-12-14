using System.Collections.Generic;

namespace Blazor.Highcharts.Typing
{
    public class ChartModel
    {
        public Accessibility Accessibility { get; set; }
        public Annotations Annotations { get; set; }
        public Boost Boost { get; set; }
        public Chart Chart { get; set; }
        public List<string> Colors { get; set; }
        public List<Serie> Series { get; set; }
    }
}
