namespace InterfaceSegregation.Before
{
    internal class AmazonNotificationService : INotificationService
    {
        public void SendEmail(Email email)
        {
            // TODO: send email
        }

        public void SendSms(Sms sms)
        {
            // TODO: send sms
        }
    }
}
