#pragma checksum "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6efbfe58a0383a862cca38bd5c02da1e7512dd1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dashboard.cshtml", typeof(AspNetCore.Views_Home_Dashboard))]
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
#line 1 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/_ViewImports.cshtml"
using CsharpProject;

#line default
#line hidden
#line 2 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/_ViewImports.cshtml"
using CsharpProject.Models;

#line default
#line hidden
#line 1 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6efbfe58a0383a862cca38bd5c02da1e7512dd1", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ceea8665695a69e2e382be89ee0a5e66dcce89c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Property>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreatePropertyForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "LogAndReg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-image: url(\'https://i.pinimg.com/originals/98/d5/4e/98d54e8b54e06de35b73c42e05d00ba6.jpg\');  background-repeat: no-repeat;\n    background-attachment: fixed;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(76, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(99, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(100, 5058, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6efbfe58a0383a862cca38bd5c02da1e7512dd15137", async() => {
                BeginContext(282, 137, true);
                WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-8\">\n\t\t\t<h1>Here\'s a list of what we got!</h1>\n\t\t\t<h3>Click on the Property Title to see more</h3>\n");
                EndContext();
#line 16 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
  
	int? uid = Context.Session.GetInt32("UserId");

#line default
#line hidden
#line 19 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
         if (uid != null)
        {

#line default
#line hidden
                BeginContext(551, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(559, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6efbfe58a0383a862cca38bd5c02da1e7512dd16139", async() => {
                    BeginContext(594, 14, true);
                    WriteLiteral("Add a Property");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(612, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 22 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
		} else{

#line default
#line hidden
                BeginContext(623, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(631, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6efbfe58a0383a862cca38bd5c02da1e7512dd17843", async() => {
                    BeginContext(657, 41, true);
                    WriteLiteral("Sign In if you would like to add Property");
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
                BeginContext(702, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 24 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"

		}

#line default
#line hidden
                BeginContext(708, 52, true);
                WriteLiteral("    </div>\n</div>\n<div>\n<hr>\n<div class=\"row mb-2\">\n");
                EndContext();
#line 31 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
     foreach (Property property in Model)
        {
			string url = $"/property/{property.PropertyId}";
            string like = $"/property/{property.PropertyId}/like";
			string unlike = $"/property/{property.PropertyId}/unlike";
            string delete = $"property/{property.PropertyId}/delete";

#line default
#line hidden
                BeginContext(1060, 325, true);
                WriteLiteral(@"    <div class=""col-md-6"">
      <div class=""bg-light row no-gutters border rounded overflow-hidden flex-md-row mb-4 shadow-sm h-md-250 position-inline-block"" style=""height:300px; margin-bottom: 10px"">
        <div class=""col p-4 d-flex flex-column position-static"">
        	<strong class=""d-inline-block mb-2 text-primary"">");
                EndContext();
                BeginContext(1386, 20, false);
#line 40 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
                                                        Write(property.ListingType);

#line default
#line hidden
                EndContext();
                BeginContext(1406, 30, true);
                WriteLiteral("</strong>\n\t\t\t<h3 class=\"mb-0\">");
                EndContext();
                BeginContext(1437, 14, false);
#line 41 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
                        Write(property.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1451, 38, true);
                WriteLiteral("</h3>\n\t\t\t<div class=\"mb-1 text-muted\">");
                EndContext();
                BeginContext(1490, 18, false);
#line 42 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
                                    Write(property.CreatedAt);

#line default
#line hidden
                EndContext();
                BeginContext(1508, 43, true);
                WriteLiteral("</div>\n\t\t\t<p class=\"card-text mb-auto\">For ");
                EndContext();
                BeginContext(1552, 20, false);
#line 43 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
                                        Write(property.ListingType);

#line default
#line hidden
                EndContext();
                BeginContext(1572, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1574, 75, false);
#line 43 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
                                                              Write(property.Price.ToString("C", new System.Globalization.CultureInfo("en-US")));

#line default
#line hidden
                EndContext();
                BeginContext(1649, 37, true);
                WriteLiteral("</p>\n\t\t\t<p class=\"card-text mb-auto\">");
                EndContext();
                BeginContext(1687, 17, false);
#line 44 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
                                    Write(property.Bedrooms);

#line default
#line hidden
                EndContext();
                BeginContext(1704, 10, true);
                WriteLiteral(" bedrooms ");
                EndContext();
                BeginContext(1715, 14, false);
#line 44 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
                                                                Write(property.Baths);

#line default
#line hidden
                EndContext();
                BeginContext(1729, 140, true);
                WriteLiteral(" baths</p>\n            <p class=\"card-text mb-auto\" style=\"width:250px; white-space: nowrap; overflow: hidden; text-overflow:ellipsis;\">For ");
                EndContext();
                BeginContext(1870, 20, false);
#line 45 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
                                                                                                                            Write(property.Description);

#line default
#line hidden
                EndContext();
                BeginContext(1890, 10, true);
                WriteLiteral("</p>\n\t\t\t<a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 1900, "\"", 1911, 1);
#line 46 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1907, url, 1907, 4, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1912, 109, true);
                WriteLiteral(" class=\"stretched-link\">Continue reading</a>\n        </div>\n        <div class=\"col-auto d-none d-lg-block\">\n");
                EndContext();
                BeginContext(2232, 12, true);
                WriteLiteral("        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2244, "\"", 2266, 1);
#line 50 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 2250, property.ImgUrl, 2250, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2267, 55, true);
                WriteLiteral(" style=\"width:200px; height:300px; object-fit:cover\"/>\n");
                EndContext();
                BeginContext(2345, 39, true);
                WriteLiteral("        </div>\n      </div>\n    </div>\n");
                EndContext();
#line 55 "/Users/patrickhebert/Desktop/Developer/c#_stack/CSharpProject-master/Views/Home/Dashboard.cshtml"
            

		}

#line default
#line hidden
                BeginContext(2402, 1, true);
                WriteLiteral("\n");
                EndContext();
                BeginContext(2414, 42, true);
                WriteLiteral("\n\n</div>\n<!DOCTYPE html>\n<html lang=\"en\">\n");
                EndContext();
                BeginContext(2456, 274, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6efbfe58a0383a862cca38bd5c02da1e7512dd115857", async() => {
                    BeginContext(2462, 261, true);
                    WriteLiteral(@"
  <meta charset=""UTF-8"">
  <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
  <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
  <title>My Google Map</title>
  <style>
    #map{
      height:400px;
      width:100%;
    }
  </style>
");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2730, 2421, true);
                WriteLiteral(@"
  <div id=""map""></div>
  <script>
    function initMap(){
      // Map options
      var options = {
        zoom:9,
        center:{lat:33.6846,lng:-117.8265}
      }

      // New map
      var map = new google.maps.Map(document.getElementById('map'), options);

      // Listen for click on map
      google.maps.event.addListener(map, 'click', function(event){
        // Add marker
        addMarker({coords:event.latLng});
      });

      /*
      // Add marker
      var marker = new google.maps.Marker({
        position:{lat:42.4668,lng:-70.9495},
        map:map,
        icon:'https://developers.google.com/maps/documentation/javascript/examples/full/images/beachflag.png'
      });

      var infoWindow = new google.maps.InfoWindow({
        content:'<h1>Lynn MA</h1>'
      });

      marker.addListener('click', function(){
        infoWindow.open(map, marker);
      });
      */

      // Array of markers
      var markers = [
        {
          coords:{lat:33.5529879,lng:-117.8139701},
		  content:'<h");
                WriteLiteral(@"5>Perfect Southern California Home on the Beach</h5>'
        },
        {
          coords:{lat:33.9061979,lng:-117.813535},
		  content:'<h5>Glowing in the warmth of its Spanish exterior</h5>'
        },
        {
          coords:{lat:33.5583113,lng:-117.6785931},
		  content:'<h5>My Apartment</h5>'
        },
        {
          coords:{lat:33.5295751,lng:-117.7730467},
		  content:'<h5>Gorgeous Laguna Beach Property</h5>'
        }
      ];

      // Loop through markers
      for(var i = 0;i < markers.length;i++){
        // Add marker
        addMarker(markers[i]);
      }

      // Add Marker Function
      function addMarker(props){
        var marker = new google.maps.Marker({
          position:props.coords,
          map:map,
          //icon:props.iconImage
        });

        // Check for customicon
        if(props.iconImage){
          // Set icon image
          marker.setIcon(props.iconImage);
        }

        // Check content
        if(props.content){
          var infoWindow = new goog");
                WriteLiteral(@"le.maps.InfoWindow({
            content:props.content
          });

          marker.addListener('click', function(){
            infoWindow.open(map, marker);
          });
        }
      }
    }
  </script>
  <script async defer
    src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyBPGZ1a7Xc0EHhB-Q6CpEdFSzVKNhxlf14&callback=initMap"">
    </script>





</html>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5158, 6, true);
            WriteLiteral("\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Property>> Html { get; private set; }
    }
}
#pragma warning restore 1591
