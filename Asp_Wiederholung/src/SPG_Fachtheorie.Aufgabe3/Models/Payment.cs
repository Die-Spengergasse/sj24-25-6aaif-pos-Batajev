using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SPG_Fachtheorie.Aufgabe3.Models;


namespace SPG_Fachtheorie.Aufgabe3.Models
{
    public class Payment
{
    public int Id { get; set; }
    public CashDesk CashDesk { get; set; } = default!;
    public DateTime PaymentDateTime { get; set; }
    public Employee Employee { get; set; } = default!;
    public PaymentType PaymentType { get; set; }
    public List<PaymentItem> PaymentItems { get; set; } = new();

    // Neu:
    public bool? Confirmed { get; set; }
}

} 