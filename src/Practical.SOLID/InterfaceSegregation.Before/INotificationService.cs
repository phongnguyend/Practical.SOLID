namespace InterfaceSegregation.Before
{
    internal interface INotificationService
    {
        void SendEmail(Email email);

        void SendSms(Sms email);
    }

    internal class Email
    {
    }

    internal class Sms
    {
    }
}
