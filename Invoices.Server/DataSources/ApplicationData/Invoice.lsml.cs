using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
namespace LightSwitchApplication
{
    public partial class Invoice
    {
        //partial void InvoiceDate_Compute(ref DateTime result)
        //{
        //    // Set result to the desired field value
        //    result = DateTime.Today.Date;

        //}

        partial void DueDate_Compute(ref DateTime result)
        {
            // Set result to the desired field value
            result = InvoiceDate.AddMonths(1);
        }

        //partial void InvoiceID_Compute(ref string result)
        //{
        //    // Set result to the desired field value
        //    //result = (string.Concat(InvoiceDate, Customer.CustomerNumber));
           
        //}

        //partial void Total_Compute(ref decimal result)
        //{
        //    // Set result to the desired field value
        //    result = Customer.Storages.Sum(x => x.Price);

        //}
       
        public void CreateDetail()
        {

        
            foreach (var unit in this.Customer.Storages)
            {
                InvoiceDetail detail = this.InvoiceDetails.AddNew();
                detail.AmountDue = unit.Price;
                //this.Total += detail.AmountDue;
                
                

                
                
            }
        }

       
    }
}
