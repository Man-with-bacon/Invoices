using System;
using System.Linq;
using System.IO;
using System.IO.IsolatedStorage;
using System.Collections.Generic;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Presentation.Extensions;
namespace LightSwitchApplication
{
    public partial class MainScreen
    {
        partial void Invoicebtn_Execute()
        {

            //Invoice invoice = new Invoice();
            Invoice invoice = Customers.SelectedItem.Invoices.AddNew();

            invoice.InvoiceDate = DateTime.Today.Date;

            invoice.CreateDetail();

            this.Customers.SelectedItem.Invoices.Add(invoice);
            this.Customers.SelectedItem.Invoices.Select(inv => inv.Id = invoice.Id);
            //this.DataWorkspace.ApplicationData.SaveChanges();
            this.Application.ShowNewInvoiceScreen();
        }
    }
}
