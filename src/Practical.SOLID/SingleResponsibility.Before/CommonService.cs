namespace SingleResponsibility.Before
{
    internal class CommonService
    {
        void AddUser(User user)
        {
            // TODO: Validate user

            // TODO: Open SqlConnection
            // TODO: ....
        }

        void UpdateUser(User user)
        {
            // TODO: 
        }

        void AddCustomer(Customer customer)
        {
            // TODO: 
        }

        void UpdateCustomer(Customer customer)
        {
            // TODO: 
        }

        void SendMessage(string fromEmail, string toEmail, string body, string fromNumber, string toNumber, string message)
        {
            if (!string.IsNullOrEmpty(fromEmail) && !string.IsNullOrEmpty(toEmail))
            {
                // TODO: send email
            }

            // TODO: send sms
        }
    }
}
