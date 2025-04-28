using System;
using System.ComponentModel.DataAnnotations;

namespace SPG_Fachtheorie.Aufgabe3.Models
{
    public class PaymentItem
{
    public int Id { get; set; }
    public string ArticleName { get; set; } = default!;
    public decimal Amount { get; set; }
    public decimal Price { get; set; }
    public Payment Payment { get; set; } = default!;
    
    // Neu:
    public DateTime LastUpdated { get; set; }
    public int PaymentId { get; set; }
}

} 