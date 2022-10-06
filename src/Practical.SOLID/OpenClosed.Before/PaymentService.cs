namespace OpenClosed.Before
{
    public class PaymentService
    {
        public void Pay(Guid orderId, PaymentMethod paymentMethod)
        {
            // TODO: get order 

            switch (paymentMethod)
            {
                case PaymentMethod.Cash:
                    // TODO: Implement Cash flow
                    break;
                case PaymentMethod.CreditCard:
                    // TODO: Implement Credit Card flow
                    break;
                case PaymentMethod.PayPal:
                    // TODO: Implement PayPal flow
                    break;
                default:
                    break;
            }

            // TODO: save result
        }
    }
}
