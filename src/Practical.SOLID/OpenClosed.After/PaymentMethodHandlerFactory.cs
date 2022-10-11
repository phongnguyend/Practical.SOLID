namespace OpenClosed.After
{
    internal class PaymentMethodHandlerFactory : IPaymentMethodHandlerFactory
    {
        public IPaymentMethodHandler GetPaymentMethodHandler(PaymentMethod paymentMethod)
        {
            return paymentMethod switch
            {
                PaymentMethod.Cash => new CashPaymentMethodHandler(),
                PaymentMethod.CreditCard => new CreditCardPaymentMethodHandler(),
                PaymentMethod.PayPal => new PayPalPaymentMethodHandler(),
                _ => new UnknownPaymentMethodHandler(),
            };
        }
    }
}
