namespace InterfaceSegregation.After
{
    internal interface ISmsNotificationService
    {
        void SendSms(Sms email);
    }

    internal class Sms
    {
    }
}
