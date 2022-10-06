namespace LiskovSubstitution.Before
{
    internal class UserService
    {
        private readonly INotificationService _notificationService;

        public UserService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Register(User user)
        {
            _notificationService.SendEmail(new Email());
        }

        public void SendOtp(User user)
        {
            _notificationService.SendSms(new Sms());
        }
    }

    internal class User
    {
    }
}
