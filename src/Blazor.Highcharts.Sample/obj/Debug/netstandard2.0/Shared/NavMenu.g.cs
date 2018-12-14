#pragma checksum "C:\Users\pgrasseels\Documents\Sources\Blazor.Highcharts\src\Blazor.Highcharts.Sample\Shared\NavMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beb0dac2d891654dfcc2e39a3a8bbd789c982b4b"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor.Highcharts.Sample.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using Blazor.Highcharts.Sample;
    using Blazor.Highcharts.Sample.Shared;
    public class NavMenu : NavMenuModel
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            builder.AddContent(2, "\n    ");
            builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"\">Blazor.Highcharts.Sample</a>\n    ");
            builder.OpenElement(4, "button");
            builder.AddAttribute(5, "class", "navbar-toggler");
            builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ToggleNavMenu));
            builder.AddMarkupContent(7, "\n        <span class=\"navbar-toggler-icon\"></span>\n    ");
            builder.CloseElement();
            builder.AddContent(8, "\n");
            builder.CloseElement();
            builder.AddContent(9, "\n\n");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", CollapseNavMenu ? "collapse" : null);
            builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(ToggleNavMenu));
            builder.AddContent(13, "\n    ");
            builder.OpenElement(14, "ul");
            builder.AddAttribute(15, "class", "nav flex-column");
            builder.AddContent(16, "\n        ");
            builder.OpenElement(17, "li");
            builder.AddAttribute(18, "class", "nav-item px-3");
            builder.AddContent(19, "\n            ");
            builder.OpenComponent<Microsoft.AspNetCore.Blazor.Routing.NavLink>(20);
            builder.AddAttribute(21, "class", "nav-link");
            builder.AddAttribute(22, "href", "");
            builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Blazor.Routing.NavLinkMatch>(NavLinkMatch.All));
            builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Blazor.RenderFragment)((builder2) => {
                builder2.AddMarkupContent(25, "\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\n            ");
            }
            ));
            builder.CloseComponent();
            builder.AddContent(26, "\n        ");
            builder.CloseElement();
            builder.AddContent(27, "\n    ");
            builder.CloseElement();
            builder.AddContent(28, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
