namespace LiskovSubstitution.After
{
    internal class UserService
    {
        private readonly IEmailNotificationService _emailNotificationService;
        private readonly ISmsNotificationService _smsNotificationService;

        public UserService(IEmailNotificationService emailNotificationService,
            ISmsNotificationService smsNotificationService)
        {
            _emailNotificationService = emailNotificationService;
            _smsNotificationService = smsNotificationService;
        }

        public void Register(User user)
        {
            _emailNotificationService.SendEmail(new Email());
        }

        public void SendOtp(User user)
        {
            _smsNotificationService.SendSms(new Sms());
        }
    }

    internal class User
    {
    }
}
