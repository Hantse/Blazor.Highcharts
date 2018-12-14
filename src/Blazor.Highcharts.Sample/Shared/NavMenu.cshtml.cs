using Microsoft.AspNetCore.Blazor.Components;

namespace Blazor.Highcharts.Sample.Shared
{
    public class NavMenuModel : BlazorComponent
    {
        public bool CollapseNavMenu { get; set; }
        public void ToggleNavMenu()
        {
            CollapseNavMenu = !CollapseNavMenu;
        }
    }
}