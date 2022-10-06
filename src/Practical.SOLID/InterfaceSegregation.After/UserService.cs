namespace InterfaceSegregation.After
{
    internal class UserService
    {
        private readonly IEmailNotificationService _emailNotificationService;

        public UserService(IEmailNotificationService emailNotificationService)
        {
            _emailNotificationService = emailNotificationService;
        }

        public void Register(User user)
        {
            _emailNotificationService.SendEmail(new Email());
        }
    }

    internal class User
    {
    }
}
