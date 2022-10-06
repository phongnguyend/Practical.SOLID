namespace DependencyInversion.After
{
    internal class SmtpNotificationService : IEmailNotificationService
    {
        public void SendEmail(Email email)
        {
            // TODO: send email
        }
    }
}
