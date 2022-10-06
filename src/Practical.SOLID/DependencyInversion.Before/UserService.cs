namespace DependencyInversion.After
{
    internal class UserService
    {
        private readonly SmtpNotificationService _emailNotificationService;

        public UserService()
        {
            _emailNotificationService = new SmtpNotificationService();
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
