namespace OpenClosed.After
{
    internal class PaymentMethodHandlerFactory : IPaymentMethodHandlerFactory
    {
        public IPaymentMethodHandler GetPaymentMethodHandler(PaymentMethod paymentType)
        {
            return paymentType switch
            {
                PaymentMethod.Cash => new CashPaymentMethodHandler(),
                PaymentMethod.CreditCard => new CreditCardPaymentMethodHandler(),
                PaymentMethod.PayPal => new PayPalPaymentMethodHandler(),
                _ => new UnknownPaymentMethodHandler(),
            };
        }
    }
}
