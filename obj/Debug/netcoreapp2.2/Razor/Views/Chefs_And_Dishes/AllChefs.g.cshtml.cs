#pragma checksum "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\Chefs_And_Dishes\AllChefs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a9a1f86f77d239f5e1c2c3d45486e71ceabb5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chefs_And_Dishes_AllChefs), @"mvc.1.0.view", @"/Views/Chefs_And_Dishes/AllChefs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chefs_And_Dishes/AllChefs.cshtml", typeof(AspNetCore.Views_Chefs_And_Dishes_AllChefs))]
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
#line 1 "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\_ViewImports.cshtml"
using chef_and_dishes;

#line default
#line hidden
#line 2 "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\_ViewImports.cshtml"
using chef_and_dishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a9a1f86f77d239f5e1c2c3d45486e71ceabb5a", @"/Views/Chefs_And_Dishes/AllChefs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"273d3fff1007cb4225ca9c0e716f7931f6c0b231", @"/Views/_ViewImports.cshtml")]
    public class Views_Chefs_And_Dishes_AllChefs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Chef>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllDishes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Chefs_And_Dishes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NewChefView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(19, 54, true);
            WriteLiteral("\r\n<nav>\r\n  <div>\r\n    <h1 class=\"text-center\">Chefs | ");
            EndContext();
            BeginContext(73, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a9a1f86f77d239f5e1c2c3d45486e71ceabb5a4370", async() => {
                BeginContext(133, 6, true);
                WriteLiteral("Dishes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(143, 19, true);
            WriteLiteral("</h1>\r\n  </div>\r\n  ");
            EndContext();
            BeginContext(162, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a9a1f86f77d239f5e1c2c3d45486e71ceabb5a5965", async() => {
                BeginContext(224, 10, true);
                WriteLiteral("Add a Chef");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(238, 250, true);
            WriteLiteral("\r\n</nav>\r\n\r\n<h3>Check out our roster of Chefs</h3>\r\n<hr>\r\n<table class=\"table table-striped table-hover\">\r\n  <thead class=\"thead-dark\">\r\n    <tr>\r\n      <th>Name</th>\r\n      <th>Age</th>\r\n      <th># of Dishes</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
            EndContext();
#line 21 "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\Chefs_And_Dishes\AllChefs.cshtml"
     foreach(var chef in Model)
    {

#line default
#line hidden
            BeginContext(528, 24, true);
            WriteLiteral("      <tr>\r\n        <td>");
            EndContext();
            BeginContext(553, 14, false);
#line 24 "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\Chefs_And_Dishes\AllChefs.cshtml"
       Write(chef.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(567, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(569, 13, false);
#line 24 "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\Chefs_And_Dishes\AllChefs.cshtml"
                       Write(chef.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(582, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(603, 41, false);
#line 25 "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\Chefs_And_Dishes\AllChefs.cshtml"
        Write(DateTime.Now.Year - chef.DateOfBirth.Year);

#line default
#line hidden
            EndContext();
            BeginContext(645, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(665, 24, false);
#line 26 "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\Chefs_And_Dishes\AllChefs.cshtml"
       Write(chef.CreatedDishes.Count);

#line default
#line hidden
            EndContext();
            BeginContext(689, 20, true);
            WriteLiteral("</td>\r\n      </tr>\r\n");
            EndContext();
#line 28 "C:\Users\MTanzil\Documents\CodingDojo\csharp_stack\ORM\entity_framework\chef_and_dishes\Views\Chefs_And_Dishes\AllChefs.cshtml"
    }

#line default
#line hidden
            BeginContext(716, 22, true);
            WriteLiteral("  </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Chef>> Html { get; private set; }
    }
}
#pragma warning restore 1591