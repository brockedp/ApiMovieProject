#pragma checksum "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f85a1760f8b4e59bcf50f9731fc96366f858f9cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FavoriteMovieList), @"mvc.1.0.view", @"/Views/Home/FavoriteMovieList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/FavoriteMovieList.cshtml", typeof(AspNetCore.Views_Home_FavoriteMovieList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f85a1760f8b4e59bcf50f9731fc96366f858f9cb", @"/Views/Home/FavoriteMovieList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaee496547394b9b8f631bd66700521ecd4450d3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FavoriteMovieList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FavoriteMovie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
  
    ViewData["Title"] = "FavoriteMovieList";

#line default
#line hidden
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(92, 243, true);
            WriteLiteral("\r\n<h1>Favorite Movie List</h1>\r\n\r\n<table class=\"table\">\r\n    <tr class=\"text-light\">\r\n        <th>Title</th>\r\n        <th>Year</th>\r\n        <th>Genre</th>\r\n        <th>Director</th>\r\n        <th>Actors</th>\r\n        <th>Plot</th>\r\n    </tr>\r\n");
            EndContext();
#line 19 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
     foreach (var movie in Model)
        {

#line default
#line hidden
            BeginContext(381, 41, true);
            WriteLiteral("    <tr class=\"text-light\">\r\n        <td>");
            EndContext();
            BeginContext(423, 11, false);
#line 22 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
       Write(movie.Title);

#line default
#line hidden
            EndContext();
            BeginContext(434, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(454, 10, false);
#line 23 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
       Write(movie.Year);

#line default
#line hidden
            EndContext();
            BeginContext(464, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(484, 11, false);
#line 24 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
       Write(movie.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(495, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(515, 14, false);
#line 25 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
       Write(movie.Director);

#line default
#line hidden
            EndContext();
            BeginContext(529, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(549, 12, false);
#line 26 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
       Write(movie.Actors);

#line default
#line hidden
            EndContext();
            BeginContext(561, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(581, 10, false);
#line 27 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
       Write(movie.Plot);

#line default
#line hidden
            EndContext();
            BeginContext(591, 21, true);
            WriteLiteral("</td>\r\n        <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 612, "\"", 654, 2);
            WriteAttributeValue("", 619, "/Home/DeleteMovie?Id=", 619, 21, true);
#line 28 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
WriteAttributeValue("", 640, movie.MovieId, 640, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(655, 70, true);
            WriteLiteral(">  <input type=\"submit\" value=\"Delete Movie?\" /></a></td>\r\n    </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
    }

#line default
#line hidden
            BeginContext(732, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
            BeginContext(743, 45, false);
#line 32 "C:\Users\Deno\Documents\Grand Circus\MovieAPI_UseThis\APIProject_Movie\MovieAPIProject\MovieAPIProject\Views\Home\FavoriteMovieList.cshtml"
Write(Html.ActionLink("Search for movies","Search"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FavoriteMovie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
