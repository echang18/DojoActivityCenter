#pragma checksum "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc397d73366673dec96d08f891729366ad9b611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/_ViewImports.cshtml"
using DojoActivityCenter;

#line default
#line hidden
#line 2 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/_ViewImports.cshtml"
using DojoActivityCenter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc397d73366673dec96d08f891729366ad9b611", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e72ab6140e435fa7efd67238cade4d60e8f980", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
  
    ViewData["Title"] = "Dojo Activity Center";

#line default
#line hidden
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(66, 473, true);
            WriteLiteral(@"
<div class=""jumbotron"">
    <h1>Dojo Activity Center</h1>
    <br>
    <a href=""/logout"" class=""btn btn-danger"">Logout</a>
</div>

<table class=""table"">
    <thead>
        <tr>    
        <th scope=""col"">Activity</th>
        <th scope=""col"">Date and Time</th>
        <th scope=""col"">Duration</th>
        <th scope=""col"">Event Coordinator</th>
        <th scope=""col"">No. of Participants</th>
        <th scope=""col"">Action</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
     foreach(Plan plan in ViewBag.Plans)
    {

#line default
#line hidden
            BeginContext(586, 31, true);
            WriteLiteral("        <tr>\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 617, "\"", 642, 2);
            WriteAttributeValue("", 624, "/view/", 624, 6, true);
#line 28 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 630, plan.PlanId, 630, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(643, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(645, 14, false);
#line 28 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
                                        Write(plan.PlanTitle);

#line default
#line hidden
            EndContext();
            BeginContext(659, 26, true);
            WriteLiteral("</a></td>\n            <td>");
            EndContext();
            BeginContext(686, 14, false);
#line 29 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
           Write(plan.PlanStart);

#line default
#line hidden
            EndContext();
            BeginContext(700, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(723, 17, false);
#line 30 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
           Write(plan.PlanDuration);

#line default
#line hidden
            EndContext();
            BeginContext(740, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(742, 17, false);
#line 30 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
                              Write(plan.DurationTime);

#line default
#line hidden
            EndContext();
            BeginContext(759, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(782, 17, false);
#line 31 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
           Write(plan.Planner.Name);

#line default
#line hidden
            EndContext();
            BeginContext(799, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(822, 22, false);
#line 32 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
           Write(plan.Attendees.Count());

#line default
#line hidden
            EndContext();
            BeginContext(844, 23, true);
            WriteLiteral("</td>\n            <td>\n");
            EndContext();
#line 34 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
              
                if(@ViewBag.UserId == @plan.PlannerId)
                    {

#line default
#line hidden
            BeginContext(959, 26, true);
            WriteLiteral("                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 985, "\"", 1012, 2);
            WriteAttributeValue("", 992, "/delete/", 992, 8, true);
#line 37 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1000, plan.PlanId, 1000, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1013, 33, true);
            WriteLiteral(" class=\"btn btn-info\">Delete</a>\n");
            EndContext();
#line 38 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
                    }
                    else
                    {
                        bool joined = false;
                        foreach(Join j in @plan.Attendees)
                        {
                            if(j.UserId == @ViewBag.UserId)
                            {
                                joined = true;
                            }
                        }
                        if(joined)
                        {

#line default
#line hidden
            BeginContext(1499, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1529, "\"", 1555, 2);
            WriteAttributeValue("", 1536, "/leave/", 1536, 7, true);
#line 51 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1543, plan.PlanId, 1543, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1556, 35, true);
            WriteLiteral(" class=\"btn btn-primary\">Leave</a>\n");
            EndContext();
#line 52 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1672, 30, true);
            WriteLiteral("                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1702, "\"", 1727, 2);
            WriteAttributeValue("", 1709, "/join/", 1709, 6, true);
#line 55 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
WriteAttributeValue("", 1715, plan.PlanId, 1715, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1728, 34, true);
            WriteLiteral(" class=\"btn btn-primary\">Join</a>\n");
            EndContext();
#line 56 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
                        }
                    } 
                

#line default
#line hidden
            BeginContext(1829, 32, true);
            WriteLiteral("            </td>\n        </tr>\n");
            EndContext();
#line 61 "/Users/erickchang/Desktop/coding_dojo/c_sharp_exam/DojoActivityCenter/Views/Home/Home.cshtml"
    }

#line default
#line hidden
            BeginContext(1867, 87, true);
            WriteLiteral("    </tbody>\n</table>\n\n<a href=\"/plan/new\" class=\"btn btn-success\">Add New Activity</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plan> Html { get; private set; }
    }
}
#pragma warning restore 1591