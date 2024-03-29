﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    class InvoiceConsolePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine("Invoice Details:\nID: {0}\nDescription: {1}\n" +
                              "Original Amount: {2}\nTax: {3}%\nDiscount: {4}%\n" +
                              "TaxAmount: {5}\nDiscountAmount: {6}\n" +
                              "Total Amount: {7}", invoice.ID, invoice.Description, invoice.Amount, invoice.Tax, invoice.Discount,
                              invoice.CalculateTax(), invoice.CalculateDiscount(), invoice.FinalAmount());

        }
    }
}
