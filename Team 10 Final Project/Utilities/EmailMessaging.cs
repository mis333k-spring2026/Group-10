using System;
using System.Net;
using System.Net.Mail;
using Team10FinalProject.Models;
using Team10FinalProject.DAL;

namespace Team10FinalProject.Utilities
{

    public static class EmailMessaging
    {
        // Base method for sending any email
        public static void SendEmail(string emailSubject, string emailBody, string recipientEmail)
        {
            string fromEmail = "mis333k.emaildemo@gmail.com";  // Your demo Gmail
            string appPassword = "wbtnpoazawoazpvd";            // App password for demo Gmail
            string companyName = "Longhorn Code Academy";

            // Configure SMTP client
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail, appPassword),
                EnableSsl = true
            };

            // Prepare the message
            MailAddress senderEmail = new MailAddress(fromEmail, companyName);
            MailMessage message = new MailMessage
            {
                Subject = "Team XX - " + emailSubject,
                Sender = senderEmail,
                From = senderEmail,
                Body = emailBody + "\n\nThank you for your order!\n\n- Longhorn Code Academy"
            };

            // Add recipient dynamically
            message.To.Add(new MailAddress(recipientEmail));

            // Send email
            client.Send(message);
        }

        // Wrapper for sending order confirmations
        public static void SendOrderConfirmation(string userEmail, Order order)
        {
            if (order == null) throw new ArgumentNullException(nameof(order));
            if (string.IsNullOrEmpty(userEmail)) throw new ArgumentNullException(nameof(userEmail));

            string subject = $"Order Confirmation #{order.OrderID}";
            string body =
                $"Hello {order.Customer.FirstName},\n\n" +
                $"Thank you for your order placed on {order.OrderDate:MMMM dd, yyyy}.\n" +
                $"Order Total: ${order.TotalPrice:F2}\n\n" +
                "Order Details:\n";

            // Include each item in the order
            foreach (var item in order.OrderDetails)
            {
                body += $"- {item.Song.SongName} x {item.Quantity} @ ${item.UnitPrice:F2}\n";
            }

            // Send using base SendEmail method
            SendEmail(subject, body, userEmail);
        }
    }
}