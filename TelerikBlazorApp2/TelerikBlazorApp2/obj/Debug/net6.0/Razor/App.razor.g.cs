#pragma checksum "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59716640866c6d3f00ff43ca9dbde3c368715ffd"
// <auto-generated/>
#pragma warning disable 1591
namespace TelerikBlazorApp2
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using TelerikBlazorApp2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using TelerikBlazorApp2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 1 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\App.razor"
                      typeof(App).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.RouteView>(3);
                __builder2.AddAttribute(4, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(5, "DefaultLayout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 3 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.FocusOnNavigate>(7);
                __builder2.AddAttribute(8, "RouteData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 4 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\App.razor"
                                     routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(9, "Selector", "h1");
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(10, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(11);
                __builder2.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(13, "Not found");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(15);
                __builder2.AddAttribute(16, "Layout", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 8 "D:\R & D\My Dot Net Projects\BlazorProjectsRepo\TelerikBlazorApp2\TelerikBlazorApp2\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, "<p role=\"alert\">Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
