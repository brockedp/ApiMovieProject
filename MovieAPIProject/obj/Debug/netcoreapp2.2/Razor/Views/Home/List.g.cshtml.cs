#pragma checksum "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "494ea44810c57bca1d755a445750779bb8ebf77c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/List.cshtml", typeof(AspNetCore.Views_Home_List))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\_ViewImports.cshtml"
using MovieAPIProject;

#line default
#line hidden
#line 2 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\_ViewImports.cshtml"
using MovieAPIProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"494ea44810c57bca1d755a445750779bb8ebf77c", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaee496547394b9b8f631bd66700521ecd4450d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieAPIProject.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml"
  
    ViewData["title"] = "List";

#line default
#line hidden
            BeginContext(40, 25, true);
            WriteLiteral("\r\n<h1>Movie List</h1>\r\n\r\n");
            EndContext();
            BeginContext(102, 259, true);
            WriteLiteral(@"
<table class=""table"" >
    <tr class=""text-light"">
        <th>Title</th>
        <th>Year</th>
        <th>Genre</th>
        <th>Director</th>
        <th>Actors</th>
        <th>Plot</th>
    </tr>
    
    <tr class=""text-light"">
        <td>");
            EndContext();
            BeginContext(362, 11, false);
#line 20 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(373, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(393, 10, false);
#line 21 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml"
       Write(Model.Year);

#line default
#line hidden
            EndContext();
            BeginContext(403, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(423, 11, false);
#line 22 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml"
       Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(434, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(454, 14, false);
#line 23 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml"
       Write(Model.Director);

#line default
#line hidden
            EndContext();
            BeginContext(468, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(488, 12, false);
#line 24 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml"
       Write(Model.Actors);

#line default
#line hidden
            EndContext();
            BeginContext(500, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(520, 10, false);
#line 25 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml"
       Write(Model.Plot);

#line default
#line hidden
            EndContext();
            BeginContext(530, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(550, 63, false);
#line 26 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\List.cshtml"
       Write(Html.ActionLink("Add To Favorites", "AddFavoriteMovies", Model));

#line default
#line hidden
            EndContext();
            BeginContext(613, 34, true);
            WriteLiteral("</td>\r\n    </tr>\r\n    \r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieAPIProject.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
