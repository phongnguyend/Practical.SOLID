namespace LiskovSubstitution.Before
{
    internal class AzureNotificationService : INotificationService
    {
        public void SendEmail(Email email)
        {
            throw new NotImplementedException();
        }

        public void SendSms(Sms sms)
        {
            // TODO: send sms
        }
    }
}
