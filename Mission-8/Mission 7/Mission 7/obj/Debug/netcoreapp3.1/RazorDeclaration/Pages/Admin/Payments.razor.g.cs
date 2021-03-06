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
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/payments")]
    public partial class Payments : OwningComponentBase<IPaymentRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Matthias\Documents\GitHub\BookStore\Mission-8\Mission 7\Mission 7\Pages\Admin\Payments.razor"
         
    public IPaymentRepository repo => Service;

    public IEnumerable<Payment> AllPayments { get; set; }
    public IEnumerable<Payment> UncollectedPayments { get; set; }
    public IEnumerable<Payment> CollectedPayments { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        AllPayments = await repo.Payments.ToListAsync();
        UncollectedPayments = AllPayments.Where(x => !x.PaymentRecieved);
        CollectedPayments = AllPayments.Where(x => x.PaymentRecieved);
    }

    public void CollectedPayment(int id) => UpdatePayment(id, true);

    public void ResetPayment(int id) => UpdatePayment(id, false);

    private void UpdatePayment (int id, bool paid)
    {
        Payment p = repo.Payments.FirstOrDefault(x => x.PaymentId == id);
        p.PaymentRecieved = paid;
        repo.SavePayment(p);
    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
