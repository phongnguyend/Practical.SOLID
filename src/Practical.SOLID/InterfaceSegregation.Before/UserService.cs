namespace InterfaceSegregation.Before
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
    }

    internal class User
    {
    }
}
