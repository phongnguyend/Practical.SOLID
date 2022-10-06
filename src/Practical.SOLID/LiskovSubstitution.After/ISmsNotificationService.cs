namespace LiskovSubstitution.After
{
    internal interface ISmsNotificationService
    {
        void SendSms(Sms email);
    }

    internal class Sms
    {
    }
}
