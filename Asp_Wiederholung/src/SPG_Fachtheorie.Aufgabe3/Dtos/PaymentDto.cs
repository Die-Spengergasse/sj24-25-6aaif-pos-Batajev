namespace SPG_Fachtheorie.Aufgabe3.Dtos
{
    public class PaymentDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateTime PaymentDateTime { get; set; }
    public int CashDeskNumber { get; set; }
    public string PaymentType { get; set; } = default!;
    public decimal TotalAmount { get; set; }


public PaymentDto(int id, string firstName, string lastName, DateTime paymentDateTime, int cashDeskNumber, string paymentType, decimal totalAmount)
{
    Id = id;
    FirstName = firstName;
    LastName = lastName;
    PaymentDateTime = paymentDateTime;
    CashDeskNumber = cashDeskNumber;
    PaymentType = paymentType;
    TotalAmount = totalAmount;
}



}
}