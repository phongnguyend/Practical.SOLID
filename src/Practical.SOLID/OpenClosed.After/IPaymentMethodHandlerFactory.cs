namespace OpenClosed.After
{
    internal interface IPaymentMethodHandlerFactory
    {
        IPaymentMethodHandler GetPaymentMethodHandler(PaymentMethod paymentMethod);
    }
}
