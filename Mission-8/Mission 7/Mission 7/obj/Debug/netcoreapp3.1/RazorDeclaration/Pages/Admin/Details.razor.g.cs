// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
