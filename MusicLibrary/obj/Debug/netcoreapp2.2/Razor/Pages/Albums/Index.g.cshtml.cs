#pragma checksum "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b69ed1591f3a615c62ef5b5201af6c4e65585f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MusicLibrary.Pages.Albums.Pages_Albums_Index), @"mvc.1.0.razor-page", @"/Pages/Albums/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Albums/Index.cshtml", typeof(MusicLibrary.Pages.Albums.Pages_Albums_Index), null)]
namespace MusicLibrary.Pages.Albums
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\_ViewImports.cshtml"
using MusicLibrary;

#line default
#line hidden
#line 3 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\_ViewImports.cshtml"
using MusicLibrary.Data;

#line default
#line hidden
#line 8 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
using MusicLibrary.Utility;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b69ed1591f3a615c62ef5b5201af6c4e65585f", @"/Pages/Albums/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6ab36d4bbabeee3eb2fb129a0c1804f047e9d23", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Albums_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_StatusMessage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-searchCriteria", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Songs/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", new global::Microsoft.AspNetCore.Html.HtmlString("Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn border", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn btn-light", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn btn-info active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::MusicLibrary.TagHelpers.PageLinkTagHelper __MusicLibrary_TagHelpers_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(171, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(175, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b0b69ed1591f3a615c62ef5b5201af6c4e65585f8448", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 11 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.StatusMessage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 23, true);
            WriteLiteral("\r\n<h1>Album list</h1>\r\n");
            EndContext();
#line 13 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
 if (User.IsInRole(SD.AdminEndUser))
{

#line default
#line hidden
            BeginContext(300, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(317, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b69ed1591f3a615c62ef5b5201af6c4e65585f10436", async() => {
                BeginContext(338, 13, true);
                WriteLiteral("Add new album");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 18 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
}

#line default
#line hidden
            BeginContext(370, 2262, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b69ed1591f3a615c62ef5b5201af6c4e65585f11953", async() => {
                BeginContext(406, 40, true);
                WriteLiteral("\r\n    <div>\r\n        <div>\r\n            ");
                EndContext();
                BeginContext(447, 144, false);
#line 22 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
       Write(Html.Editor("searchCriteria", new { htmlAttributes = new { @class = "form-control", placeholder = "Search...", style = "margin-bottom:10px" } }));

#line default
#line hidden
                EndContext();
                BeginContext(591, 146, true);
                WriteLiteral("\r\n        </div>\r\n        <button type=\"submit\" name=\"Submit\" value=\"Search\" class=\"btn btn-primary\" style=\"margin-bottom:10px;\">Search</button>\r\n");
                EndContext();
#line 25 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
         if (HttpContext.Request.Query["searchCriteria"].ToString() != "")
        {

#line default
#line hidden
                BeginContext(824, 15, true);
                WriteLiteral("            <p>");
                EndContext();
                BeginContext(839, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b69ed1591f3a615c62ef5b5201af6c4e65585f13353", async() => {
                    BeginContext(887, 15, true);
                    WriteLiteral("Clear searching");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-searchCriteria", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["searchCriteria"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(906, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
#line 28 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
        }

#line default
#line hidden
                BeginContext(923, 14, true);
                WriteLiteral("    </div>\r\n\r\n");
                EndContext();
#line 31 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
     if (Model.AlbumVM.AlbumList.Count == 0)
    {

#line default
#line hidden
                BeginContext(990, 55, true);
                WriteLiteral("        <p>No albums found. Please add new album.</p>\r\n");
                EndContext();
#line 34 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(1069, 79, true);
                WriteLiteral("        <div style=\"display:flex; flex-wrap:wrap; justify-content:center;\">\r\n\r\n");
                EndContext();
#line 39 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
             foreach (var item in Model.AlbumVM.AlbumList)
            {

#line default
#line hidden
                BeginContext(1223, 182, true);
                WriteLiteral("                <div style=\"width:200px; padding-bottom:10px; margin:10px; margin-top:30px; box-shadow: 0 4px 8px 0 rgba(0, 0, 0, 0.2); text-align:center;\">\r\n                    <img");
                EndContext();
                BeginWriteAttribute("src", " src=\'", 1405, "\'", 1457, 1);
#line 42 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
WriteAttributeValue("", 1411, Url.Content("~/covers/" + item.Name + ".jpg"), 1411, 46, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1458, 48, true);
                WriteLiteral(" + .jpg\' width=\"200\" />\r\n                    <b>");
                EndContext();
                BeginContext(1507, 39, false);
#line 43 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
                  Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1546, 34, true);
                WriteLiteral("</b><br />\r\n\r\n                    ");
                EndContext();
                BeginContext(1581, 41, false);
#line 45 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Artist));

#line default
#line hidden
                EndContext();
                BeginContext(1622, 30, true);
                WriteLiteral("<br />\r\n\r\n                    ");
                EndContext();
                BeginContext(1652, 72, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b69ed1591f3a615c62ef5b5201af6c4e65585f18169", async() => {
                    BeginContext(1710, 10, true);
                    WriteLiteral("View songs");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-albumId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 47 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
                                                        WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["albumId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-albumId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["albumId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1724, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
                     if (User.IsInRole(SD.AdminEndUser))
                    {

#line default
#line hidden
                BeginContext(1807, 60, true);
                WriteLiteral("                        <b> | </b>\r\n                        ");
                EndContext();
                BeginContext(1867, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b69ed1591f3a615c62ef5b5201af6c4e65585f21037", async() => {
                    BeginContext(1912, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 51 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
                                               WriteLiteral(item.Id);

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
                BeginContext(1920, 12, true);
                WriteLiteral("<b> | </b>\r\n");
                EndContext();
#line 52 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(1955, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 54 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
                     if (User.IsInRole(SD.AdminEndUser))
                    {

#line default
#line hidden
                BeginContext(2038, 24, true);
                WriteLiteral("                        ");
                EndContext();
                BeginContext(2062, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b69ed1591f3a615c62ef5b5201af6c4e65585f24104", async() => {
                    BeginContext(2109, 7, true);
                    WriteLiteral("Delete ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 56 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
                                                 WriteLiteral(item.Id);

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
                BeginContext(2120, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 57 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(2145, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
                EndContext();
#line 60 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
            }

#line default
#line hidden
                BeginContext(2186, 129, true);
                WriteLiteral("        </div>\r\n        <table style=\"margin-top:20px;\">\r\n            <tr>\r\n                <td cospan=\"5\">\r\n                    ");
                EndContext();
                BeginContext(2315, 237, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0b69ed1591f3a615c62ef5b5201af6c4e65585f27245", async() => {
                    BeginContext(2522, 24, true);
                    WriteLiteral("\r\n\r\n                    ");
                    EndContext();
                }
                );
                __MusicLibrary_TagHelpers_PageLinkTagHelper = CreateTagHelper<global::MusicLibrary.TagHelpers.PageLinkTagHelper>();
                __tagHelperExecutionContext.Add(__MusicLibrary_TagHelpers_PageLinkTagHelper);
#line 65 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"
__MusicLibrary_TagHelpers_PageLinkTagHelper.PageModel = Model.AlbumVM.PagingInfo;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __MusicLibrary_TagHelpers_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __MusicLibrary_TagHelpers_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __MusicLibrary_TagHelpers_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __MusicLibrary_TagHelpers_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2552, 64, true);
                WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
                EndContext();
#line 73 "C:\Users\kapib\source\repos\MusicLibrary\MusicLibrary\Pages\Albums\Index.cshtml"

    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MusicLibrary.Pages.Albums.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicLibrary.Pages.Albums.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MusicLibrary.Pages.Albums.IndexModel>)PageContext?.ViewData;
        public MusicLibrary.Pages.Albums.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
