#pragma checksum "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99c4df9b521234c39c3792dd2e5574d63bba334c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Matches_Details), @"mvc.1.0.view", @"/Views/Matches/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Matches/Details.cshtml", typeof(AspNetCore.Views_Matches_Details))]
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
#line 1 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\_ViewImports.cshtml"
using FootballStatisticsManagementApp;

#line default
#line hidden
#line 2 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\_ViewImports.cshtml"
using FootballStatisticsManagementApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99c4df9b521234c39c3792dd2e5574d63bba334c", @"/Views/Matches/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"545b757c822766db7cb637d431a30e9838c9dbb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Matches_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FootballStatisticsManagementApp.Models.Match>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 111, true);
            WriteLiteral("\n<h2>Details</h2>\n\n<div>\n    <h4>Match</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(205, 44, false);
#line 14 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(249, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(290, 40, false);
#line 17 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayFor(model => model.Location));

#line default
#line hidden
            EndContext();
            BeginContext(330, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(371, 40, false);
#line 20 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(411, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(452, 36, false);
#line 23 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(488, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(529, 44, false);
#line 26 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AwayTeam));

#line default
#line hidden
            EndContext();
            BeginContext(573, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(614, 45, false);
#line 29 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayFor(model => model.AwayTeam.Name));

#line default
#line hidden
            EndContext();
            BeginContext(659, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(700, 44, false);
#line 32 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomeTeam));

#line default
#line hidden
            EndContext();
            BeginContext(744, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(785, 45, false);
#line 35 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayFor(model => model.HomeTeam.Name));

#line default
#line hidden
            EndContext();
            BeginContext(830, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(871, 42, false);
#line 38 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.League));

#line default
#line hidden
            EndContext();
            BeginContext(913, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(954, 43, false);
#line 41 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
       Write(Html.DisplayFor(model => model.League.Year));

#line default
#line hidden
            EndContext();
            BeginContext(997, 42, true);
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            EndContext();
            BeginContext(1039, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "090b0c926fa4437eac68af9bd5d1b6a6", async() => {
                BeginContext(1090, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\qiang\Desktop\SD6503_Final_Project\Final Project Presentation\SD6503_Project-master\Football-Statistics-Management-App-with-Testing\FootballStatisticsManagementApp\Views\Matches\Details.cshtml"
                           WriteLiteral(Model.MatchId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1098, 7, true);
            WriteLiteral(" |\n    ");
            EndContext();
            BeginContext(1105, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c8de8a779d34959a2fcd2717c62d5f4", async() => {
                BeginContext(1127, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1143, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FootballStatisticsManagementApp.Models.Match> Html { get; private set; }
    }
}
#pragma warning restore 1591