﻿namespace DependencyInversion.After
{
    internal interface IEmailNotificationService
    {
        void SendEmail(Email email);
    }

    internal class Email
    {
    }
}
