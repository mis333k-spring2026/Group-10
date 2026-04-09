using System.Net;
using System.Net.Mail;
using Team10FinalProject.Models;

namespace Team10FinalProject.Utilities
{
    public static class EmailMessaging
    {
        public static void SendEmail(string emailSubject, string emailBody, string recipientEmail)
        {
            string fromEmail = "mis333k.emaildemo@gmail.com";
            string appPassword = "REPLACE_WITH_REAL_APP_PASSWORD";
            string companyName = "Bevo's Tunes";

            if (string.IsNullOrWhiteSpace(recipientEmail))
            {
                return;
            }

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail, appPassword),
                EnableSsl = true
            };

            MailAddress senderEmail = new MailAddress(fromEmail, companyName);

            MailMessage message = new MailMessage
            {
                Subject = "Team 10: " + emailSubject,
                Sender = senderEmail,
                From = senderEmail,
                Body = emailBody
            };

            message.To.Add(new MailAddress(recipientEmail));
            client.Send(message);
        }

        public static void SendOrderConfirmation(string userEmail, Order order)
        {
            if (order == null || string.IsNullOrWhiteSpace(userEmail))
            {
                return;
            }

            decimal totalPrice = order.OrderDetails.Sum(od => od.Price);

            string customerName = order.Customer == null
                ? "Customer"
                : order.Customer.FirstName;

            string subject = $"Order Confirmation #{order.OrderNumber}";
            string body =
                $"Hello {customerName},\n\n" +
                $"Thank you for your order placed on {order.OrderDate:MMMM dd, yyyy}.\n" +
                $"Order Total: ${totalPrice:F2}\n\n" +
                "Order Details:\n";

            foreach (var item in order.OrderDetails)
            {
                string itemName = item.Song?.SongName ?? item.Album?.AlbumName ?? "Item";
                body += $"- {itemName}: ${item.Price:F2}\n";
            }

            SendEmail(subject, body, userEmail);
        }
    }
}