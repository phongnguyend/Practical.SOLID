namespace InterfaceSegregation.After
{
    internal interface INotificationService : IEmailNotificationService, ISmsNotificationService
    {
    }
}
