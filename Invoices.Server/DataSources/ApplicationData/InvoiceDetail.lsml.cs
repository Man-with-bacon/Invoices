using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class InvoiceDetail
    {

        partial void AmountDue_Compute(ref decimal? result)
        {
            // Set result to the desired field value

            result = Invoice.Customer.Storages.Sum(x => x.Price);

        }
    }
}
