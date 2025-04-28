using SPG_Fachtheorie.Aufgabe3.Dtos;

namespace SPG_Fachtheorie.Aufgabe3.Services
{
    public class PaymentService : IPaymentService
    {
        public string ProcessPayment(PaymentDto dto)
        {
            
            return $"Zahlung erfolgreich: {dto.FirstName} {dto.LastName}, Betrag: {dto.TotalAmount} €";
        }
    }
}
