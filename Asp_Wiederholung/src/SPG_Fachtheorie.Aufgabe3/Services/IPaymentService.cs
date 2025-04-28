using SPG_Fachtheorie.Aufgabe3.Dtos;

namespace SPG_Fachtheorie.Aufgabe3.Services
{
    public interface IPaymentService
    {
        string ProcessPayment(PaymentDto dto);
    }
}
