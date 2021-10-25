#pragma checksum "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6df0407beb0b0c09458fbcdb749cf4ad5bcea10a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\_ViewImports.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6df0407beb0b0c09458fbcdb749cf4ad5bcea10a", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
  
	ViewData["Title"] = "List of Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
      
		foreach (Movie movie in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""col-md-4 col-xs-6 border-primary mb-3"">
				<div class=""card mb-3"" style=""max-width: 540px;"">
					<div class=""row g-0"">
						<div class=""col-md-12"">
							<div class=""card-header text-white bg-info"">
								<p class=""card-text"">
									<h5 class=""card-title"">
										");
#nullable restore
#line 18 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
                                   Write(movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t<a class=\"text-white float-right\"><i class=\"bi bi-pencil-square\"></i></a>\r\n\t\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 637, "\"", 658, 1);
#nullable restore
#line 25 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 643, movie.ImageURL, 643, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 672, "\"", 689, 1);
#nullable restore
#line 25 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
WriteAttributeValue("", 678, movie.Name, 678, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<div class=\"col-md-6\">\r\n\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t<p class=\"card-text\">");
#nullable restore
#line 29 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
                                                Write(movie.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<p class=\"card-text\"><b>Cinema: </b>");
#nullable restore
#line 30 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
                                                               Write(movie.Cinema.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 31 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
                                                                 Write(movie.MovieCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<p class=\"card-text\"><b>Start Date: </b>");
#nullable restore
#line 32 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
                                                                   Write(movie.StartDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<p class=\"card-text\"><b>End Date: </b>");
#nullable restore
#line 33 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
                                                                 Write(movie.EndDate.ToString("dd MMM yy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<p class=\"card-text \">\r\n\t\t\t\t\t\t\t\t\t<b>Status: </b>\r\n");
#nullable restore
#line 36 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
                                     if (DateTime.Now >= movie.StartDate && DateTime.Now <= movie.EndDate)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-success text-white\">AVAILABLE</span>\r\n");
#nullable restore
#line 39 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
									}
									else if (DateTime.Now > movie.EndDate)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-danger text-white\">EXPIRED</span>\r\n");
#nullable restore
#line 43 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
									}
									else
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-primary text-white\">UPCOMING</span>\r\n");
#nullable restore
#line 47 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"								</p>

							</div>
						</div>
						<div class=""col-md-12"">
							<div class=""card-footer "">
								<p class=""card-text"">
									<a class=""btn btn-outline-primary float-right""><i class=""bi bi-eye-fill""></i> Show Details</a>
									<a class=""btn btn-success text-white""><i class=""bi bi-cart-plus""></i> Add to Cart (Price ");
#nullable restore
#line 56 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
                                                                                                                        Write(movie.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</a>\r\n\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n");
#nullable restore
#line 63 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Movies\Index.cshtml"
		}
	

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
