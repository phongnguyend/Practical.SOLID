namespace OpenClosed.After
{
    internal class PaymentService
    {
        private readonly IPaymentMethodHandlerFactory _paymentMethodHandlerFactory;

        public PaymentService(IPaymentMethodHandlerFactory paymentMethodHandlerFactory)
        {
            _paymentMethodHandlerFactory = paymentMethodHandlerFactory;
        }

        public void Pay(Guid orderId, PaymentMethod paymentMethod)
        {
            // TODO: get order 

            var paymentHandler = _paymentMethodHandlerFactory.GetPaymentMethodHandler(paymentMethod);
            paymentHandler.Handle();

            // TODO: save result
        }
    }
}
