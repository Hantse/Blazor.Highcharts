using System.Threading.Tasks;

namespace Blazor.Highcharts.Typing
{
    public class Accessibility
    {
        public bool DescribeSingleSeries { get; set; }
        public bool? Enabled { get; set; }
        public KeyboardNavigation KeyboardNavigation { get; set; }
        public Task OnTableAnchorClick { get; set; }
        public string PointDateFormat { get; set; }
        // TODO : pointDateFormatter
        // TODO : pointDescriptionFormatter
        public bool? PointDescriptionThreshold { get; set; }
        // TODO : screenReaderSectionFormatter
        // TODO : seriesDescriptionFormatter
    }
}
