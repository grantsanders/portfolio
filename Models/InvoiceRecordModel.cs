using System;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace portfolio.Models;

public class InvoiceRecordModel
{
    public InvoiceRecordModel()
    {

    }

    [DisplayName("Database ID")]
    public string? Id { get; set; }
    [DisplayName("Imported Successfully")]
    public bool? ImportedSuccessfully { get; set; }
    [DisplayName("Number of Invoices")]
    public string? NumberOfInvoices { get; set; }
    [DisplayName("Created on")]
    public string? Created { get; set; }
    public string? Note { get; set; }

public override string ToString() => JsonSerializer.Serialize<InvoiceRecordModel>(this);

}


