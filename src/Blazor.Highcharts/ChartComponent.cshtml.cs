using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Blazor.Highcharts
{
    public class ChartComponentModel : BlazorComponent
    {
        [Parameter]
        protected object ChartModel { get; set; }

        public ChartComponentModel()
        {

        }

        protected override Task OnParametersSetAsync()
        {
            if (ChartModel != null)
            {
                return JSRuntime.Current.InvokeAsync<dynamic>("highCharts.init", ChartModel);
            }

            return base.OnParametersSetAsync();
        }
    }
}