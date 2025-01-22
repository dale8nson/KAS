using System;
using System.ComponentModel.DataAnnotations;

namespace KAS.Models;

public class ChartOfAccounts
{
    [Key]
    public Int32 AccountID { get; set; }
    public string? AccountCode { get; set; }
    public string? AccountName { get; set; }
    public string? AccountType { get; set; }
    public string? ParentAccountID { get; set; }
    public bool IsActive { get; set; }
    public char NormalBalance { get; set; }
}
