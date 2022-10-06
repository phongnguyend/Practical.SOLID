namespace LiskovSubstitution.After
{
    internal interface INotificationService : IEmailNotificationService, ISmsNotificationService
    {
    }
}
