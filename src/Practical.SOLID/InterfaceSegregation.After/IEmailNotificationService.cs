﻿namespace InterfaceSegregation.After
{
    internal interface IEmailNotificationService
    {
        void SendEmail(Email email);
    }

    internal class Email
    {
    }
}
