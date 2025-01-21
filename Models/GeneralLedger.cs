namespace KAS.Models;

public class GeneralLedger
{
    public long TransactionID { get; set; }
    public DateOnly EntryDate { get; set; }
    public string? ReferenceNumber { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedDate { get; set; }
    public string? CreatedBy { get; set; }
    public bool IsPosted { get; set; }
    public required string AccountCode { get; set; }
    public required string AccountName { get; set; }
    public required string AccountCodeType { get; set; }
    public float DebitAmount { get; set; }
    public float CreditAmount { get; set; }
    public string? LineDescription { get; set; }
}
