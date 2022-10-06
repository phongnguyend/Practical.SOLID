namespace InterfaceSegregation.Before
{
    internal class SmtpNotificationService : INotificationService
    {
        public void SendEmail(Email email)
        {
            // TODO: send email
        }

        public void SendSms(Sms sms)
        {
            throw new NotImplementedException();
        }
    }
}
