#pragma checksum "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5076dc100b39c67e2ad891e3e3bc9aa010cb78c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UpdateBlog), @"mvc.1.0.view", @"/Views/Admin/UpdateBlog.cshtml")]
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
#line 1 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\_ViewImports.cshtml"
using SocialScoutingNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\_ViewImports.cshtml"
using SocialScoutingNetwork.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5076dc100b39c67e2ad891e3e3bc9aa010cb78c", @"/Views/Admin/UpdateBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f018920ef40d6f4c703f47d34ddff9d290e662", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UpdateBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
  
    ViewData["Title"] = "UpdateBlog";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <div class=\"ibox \">\r\n            <div class=\"ibox-title\">\r\n                <h5>Blog Güncelleme </h5>\r\n            </div>\r\n            <div class=\"ibox-content\">\r\n");
#nullable restore
#line 14 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
                 using (Html.BeginForm("UpdateBlog", "Admin", FormMethod.Post, new { @class = "", enctype = "multipart/form-data" }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
               Write(Html.HiddenFor(x => x.BlogID, new { @class = "form-control", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-group  row\">\r\n                        <label class=\"col-sm-2 col-form-label\">Blog Başlığı</label>\r\n\r\n                        <div class=\"col-sm-3\">");
#nullable restore
#line 20 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
                                         Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Blog Alanı</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 26 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
                                         Write(Html.TextBoxFor(x => x.BlogContent, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Resim</label>

                        <div class=""col-sm-3"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 1537, "\"", 1570, 2);
            WriteAttributeValue("", 1543, "/BlogImageFiles/", 1543, 16, true);
#nullable restore
#line 33 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
WriteAttributeValue("", 1559, ViewBag.pp, 1559, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"object-fit:fill; margin-bottom:5px;\" height=\"100\" width=\"100\"");
            BeginWriteAttribute("alt", " alt=\"", 1640, "\"", 1657, 1);
#nullable restore
#line 33 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
WriteAttributeValue("", 1646, ViewBag.pp, 1646, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /><br />\r\n                        ");
#nullable restore
#line 34 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
                   Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control", @style = "" , @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Blog Tarihi</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 40 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
                                         Write(Html.TextBoxFor(x => x.BlogCreateDate, new { @class = "form-control", @style = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group  row"">
                        <label class=""col-sm-2 col-form-label"">Yazar</label>

                        <div class=""col-sm-3"">");
#nullable restore
#line 46 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
                                         Write(Html.DropDownListFor(x => x.WriterID, (List<SelectListItem>)ViewBag.blog, new { @class = "form-control m-b", @style = "margin-top:8px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""form-group row"">
                        <div class=""col-sm-4 col-sm-offset-2"">
                            <button class=""btn btn-primary btn-sm"" type=""submit"">Blog Güncelle</button>
                        </div>
                    </div>
");
#nullable restore
#line 54 "C:\Users\selcu\Desktop\SocialScoutingNetwork\SocialScoutingNetwork\SocialScoutingNetwork\Views\Admin\UpdateBlog.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591