#pragma checksum "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f829b7756da0c13c33ea106979a72e39d355e9dc"
// <auto-generated/>
#pragma warning disable 1591
namespace Mission_7.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\_Imports.razor"
using Mission_7.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/books/details/{id:long}")]
    public partial class Details : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"bg-info text-white text-center p-1\">Details</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "tbody");
            __builder.AddMarkupContent(4, "\r\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddMarkupContent(6, "<th>Book ID:</th>");
            __builder.AddContent(7, 
#nullable restore
#line 8 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                              book.BookId

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "<th>Title:</th>");
            __builder.AddContent(12, 
#nullable restore
#line 9 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                            book.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "<th>Author:</th>");
            __builder.AddContent(17, 
#nullable restore
#line 10 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                             book.Author

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "<th>Publisher:</th>");
            __builder.AddContent(22, 
#nullable restore
#line 11 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                                book.Publisher

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "<th>Isbn:</th>");
            __builder.AddContent(27, 
#nullable restore
#line 12 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                           book.Isbn

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(28, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "tr");
            __builder.AddMarkupContent(31, "<th>Classification:</th>");
            __builder.AddContent(32, 
#nullable restore
#line 13 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                                     book.Classification

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(33, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "tr");
            __builder.AddMarkupContent(36, "<th>Category:</th>");
            __builder.AddContent(37, 
#nullable restore
#line 14 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                               book.Category

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.OpenElement(40, "tr");
            __builder.AddMarkupContent(41, "<th>Page Count:</th>");
            __builder.AddContent(42, 
#nullable restore
#line 15 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                                 book.PageCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(43, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n        ");
            __builder.OpenElement(45, "tr");
            __builder.AddMarkupContent(46, "<th>Price:</th>");
            __builder.AddContent(47, 
#nullable restore
#line 16 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                            book.Price

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(48, "<td></td>");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(52);
            __builder.AddAttribute(53, "class", "btn btn-warning");
            __builder.AddAttribute(54, "href", 
#nullable restore
#line 21 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
                                        EditUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(56, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(58);
            __builder.AddAttribute(59, "class", "btn btn-secondary");
            __builder.AddAttribute(60, "href", "/admin/projects");
            __builder.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(62, "Back");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Details.razor"
       

    [Inject]
    public IBookstoreRepository repo { get; set; }

    [Parameter]
    public long Id { get; set; }

    public Book book { get; set; }

    protected override void OnParametersSet()
    {
        book = repo.Books.FirstOrDefault(x => x.BookId == Id);
    }

    public string EditUrl => $"/admin/books/edit/{book.BookId}";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
