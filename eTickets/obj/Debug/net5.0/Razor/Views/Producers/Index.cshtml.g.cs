#pragma checksum "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d4da2383a76ee6c240d2770d8c85b3f7c104a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producers_Index), @"mvc.1.0.view", @"/Views/Producers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d4da2383a76ee6c240d2770d8c85b3f7c104a9", @"/Views/Producers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae36ea9afdbf4434090466b2ad951861827cd6f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Producers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Producer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
  
	ViewData["Title"] = "List of Producers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col-md-8 offset-md-2\">\r\n\r\n\t\t<table class=\"table\">\r\n\t\t\t<thead>\r\n\t\t\t\t<tr class=\"text-center\">\r\n\t\t\t\t\t<th>");
#nullable restore
#line 13 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 14 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 15 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>Actions</th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
#nullable restore
#line 20 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
                  
					foreach (Producer producer in Model)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\t<td class=\"align-middle\">\r\n\t\t\t\t\t\t\t\t<img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 595, "\"", 628, 1);
#nullable restore
#line 25 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
WriteAttributeValue("", 601, producer.ProfilePictureURL, 601, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 629, "\"", 653, 1);
#nullable restore
#line 25 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
WriteAttributeValue("", 635, producer.FullName, 635, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 150px\" />\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td class=\"align-middle\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 28 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
                           Write(Html.DisplayFor(i => producer.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t<td class=\"align-middle\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 31 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
                           Write(Html.DisplayFor(i => producer.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</td>
							<td class=""align-middle"">
								<a class=""btn btn-outline-primary""><i class=""bi bi-pencil-square""></i>Edit</a> |
								<a class=""btn btn-outline-info""><i class=""bi bi-eye""></i>Details</a> |
								<a class=""btn btn-danger text-white""><i class=""bi bi-trash""></i>Delete</a>
							</td>
						</tr>
");
#nullable restore
#line 39 "C:\Users\Xiaomi\Documents\C#\eTickets\eTickets\Views\Producers\Index.cshtml"
					}
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Producer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
