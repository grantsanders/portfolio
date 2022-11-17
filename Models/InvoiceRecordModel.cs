using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace portfolio.Models;

public class InvoiceRecordModel
{
    public InvoiceRecordModel()
    {

    }
    public string? Id { get; set; }
    public bool? ImportedSuccessfully { get; set; }
    public string? NumberOfInvoices { get; set; }
    public string? Created { get; set; }
    public string? Note { get; set; }

public override string ToString() => JsonSerializer.Serialize<InvoiceRecordModel>(this);

}


