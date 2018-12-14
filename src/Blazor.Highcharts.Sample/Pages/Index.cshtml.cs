using Blazor.Highcharts.Typing;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor.Highcharts.Sample.Pages
{
    public class IndexModel : BlazorComponent
    {
        protected object ChartModel { get; set; }

        [Inject]
        public HttpClient Hc { get; set; }

        public IndexModel()
        {
        }

        protected override async Task OnInitAsync()
        {
            ChartModel = (await Hc.GetJsonAsync<object>("https://api.myjson.com/bins/18yqqc"));
            StateHasChanged();
        }
    }
}