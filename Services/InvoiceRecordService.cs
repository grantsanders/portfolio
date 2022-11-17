﻿using portfolio.Models;
using System.Text.Json;

namespace portfolio.Services
{
    public class InvoiceRecordService
    {

        public InvoiceRecordService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public IEnumerable<InvoiceRecordModel> GetInvoices()
        {

            var client = new HttpClient() { BaseAddress = new Uri("https://granthum-api.azurewebsites.net") };

            var json = client.GetAsync("/api/invoicerecords").Result.Content.ReadAsStringAsync().Result;

            IEnumerable<InvoiceRecordModel> invoices = JsonSerializer.Deserialize<IEnumerable<InvoiceRecordModel>>(json,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return invoices;

        }
    }
}