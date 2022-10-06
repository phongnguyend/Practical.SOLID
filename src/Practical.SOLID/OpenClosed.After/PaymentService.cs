namespace OpenClosed.After
{
    internal class PaymentService
    {
        void Pay(Guid orderId, PaymentMethod paymentMethod)
        {
            // TODO: get order 

            switch (paymentMethod)
            {
                case PaymentMethod.Cash:
                    // TODO: 
                    break;
                case PaymentMethod.CreditCard:
                    // TODO: 
                    break;
                case PaymentMethod.PayPal:
                    // TODO: 
                    break;
                default:
                    break;
            }

            // TODO: save result
        }
    }
}
