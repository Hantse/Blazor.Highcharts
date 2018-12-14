using Blazor.Highcharts.Typing;
using Microsoft.AspNetCore.Blazor.Components;

namespace Blazor.Highcharts
{
    public class ChartTypedComponentModel : BlazorComponent
    {
        [Parameter]
        protected ChartModel ChartModel { get; set; }
    }
}