using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using Team10FinalProject.Models;

namespace Team10FinalProject.Utilities
{
    public static class EmailMessaging
    {
        // Gmail account your team uses to SEND the emails
        private const string FromEmail = "KindKGroup10@gmail.com";
        private const string AppPassword = "rekeqpbksohwjwja";
        private const string CompanyName = "BevosTunes";

        // TA clarification: all project emails should be delivered to one inbox for grading
        private const string GradingInbox = "KindKGroup10@gmail.com";

        private const string SubjectPrefix = "Team 10: ";

        public static void SendEmail(string emailSubject, string emailBody, string intendedRecipientEmail, bool isHtml = false)
        {
            if (string.IsNullOrWhiteSpace(emailSubject) || string.IsNullOrWhiteSpace(emailBody))
            {
                return;
            }

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(FromEmail, AppPassword),
                EnableSsl = true
            };

            MailAddress senderEmail = new MailAddress(FromEmail, CompanyName);

            MailMessage message = new MailMessage
            {
                Subject = SubjectPrefix + emailSubject,
                Sender = senderEmail,
                From = senderEmail,
                Body = BuildDeliveredBody(intendedRecipientEmail, emailBody, isHtml),
                IsBodyHtml = isHtml
            };

            // TA clarification: send to one inbox, even for different users
            message.To.Add(new MailAddress(GradingInbox));

            client.Send(message);
        }

        private static string BuildDeliveredBody(string intendedRecipientEmail, string originalBody, bool isHtml = false)
        {
            if (isHtml)
            {
                return $"<p><strong>Intended Recipient:</strong> {intendedRecipientEmail}</p><hr>{originalBody}";
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Intended Recipient: {intendedRecipientEmail}");
            sb.AppendLine();
            sb.Append(originalBody);
            return sb.ToString();
        }

        public static void SendAccountCreationEmail(AppUser customer)
        {
            if (customer == null || string.IsNullOrWhiteSpace(customer.Email))
            {
                return;
            }

            string subject = "Account Created";

            string body =
                $"Hello {customer.FirstName}," + Environment.NewLine + Environment.NewLine +
                "Your Bevo's Tunes account has been created." + Environment.NewLine + Environment.NewLine +
                "Thank you," + Environment.NewLine +
                "Bevo's Tunes";

            SendEmail(subject, body, customer.Email);
        }

        // Non-gift order email to purchasing customer
        public static void SendOrderConfirmationEmail(
            Order order,
            string refundLink,
            string recommendedGenre = "",
            string recommendedArtistName = "")
        {
            if (order == null || order.Customer == null || string.IsNullOrWhiteSpace(order.Customer.Email))
            {
                return;
            }

            string subject = $"Order Confirmation #{order.OrderNumber}";

            StringBuilder body = new StringBuilder();
            body.AppendLine($"<p>Hello {order.Customer.FirstName},</p>");
            body.AppendLine($"<p>Your order has been completed.<br>");
            body.AppendLine($"Order Number: {order.OrderNumber}<br>");
            body.AppendLine($"Order Date: {order.OrderDate:MMMM dd, yyyy}</p>");
            body.AppendLine("<p><strong>Purchased Music:</strong><br>");
            body.Append(BuildPurchasedItemsListHtml(order));
            body.AppendLine("</p>");
            body.AppendLine($"<p><strong>Order Total: {GetOrderTotal(order):C2}</strong></p>");
            if (!string.IsNullOrWhiteSpace(recommendedGenre) && !string.IsNullOrWhiteSpace(recommendedArtistName))
            {
                body.AppendLine("Recommended Artist:");
                body.AppendLine($"Since you purchased music in the genre {recommendedGenre},");
                body.AppendLine($"we recommend trying {recommendedArtistName}, one of our highest-rated artists in that genre.");
                body.AppendLine();
            }
            body.AppendLine($"<p>If this order was made incorrectly, click the link below to request a refund:</p>");
            body.AppendLine($"<p><a href=\"{refundLink}\">Cancel / Refund This Order</a></p>");
            body.AppendLine("<p>Thank you,<br>Bevo's Tunes</p>");

            SendEmail(subject, body.ToString(), order.Customer.Email, isHtml: true);
        }

        // Gift order email to gift-giver
        public static void SendGiftPurchaserConfirmationEmail(Order order, string refundLink)
        {
            if (order == null || order.Customer == null || string.IsNullOrWhiteSpace(order.Customer.Email))
            {
                return;
            }

            string recipientEmail = order.Friend?.Email ?? "Gift Recipient";

            string subject = $"Gift Order Confirmation #{order.OrderNumber}";

            StringBuilder body = new StringBuilder();
            body.AppendLine($"Hello {order.Customer.FirstName},");
            body.AppendLine($"<p>Hello {order.Customer.FirstName},</p>");
            body.AppendLine($"<p>Your gift order has been completed.<br>");
            body.AppendLine($"Order Number: {order.OrderNumber}<br>");
            body.AppendLine($"Order Date: {order.OrderDate:MMMM dd, yyyy}<br>");
            body.AppendLine($"Recipient: {recipientEmail}</p>");
            body.AppendLine("<p><strong>Purchased Music:</strong><br>");
            body.Append(BuildPurchasedItemsListHtml(order));
            body.AppendLine("</p>");
            body.AppendLine($"<p><strong>Order Total: {GetOrderTotal(order):C2}</strong></p>");
            body.AppendLine($"<p>If this order was made incorrectly, click the link below to request a refund:</p>");
            body.AppendLine($"<p><a href=\"{refundLink}\">Cancel / Refund This Order</a></p>");
            body.AppendLine("<p>Thank you,<br>Bevo's Tunes</p>");

            SendEmail(subject, body.ToString(), order.Customer.Email, isHtml: true);
        }

        // Gift order email to gift recipient with recommendation
        public static void SendGiftRecipientEmail(Order order, string recommendedGenre, string recommendedArtistName)
        {
            if (order == null || order.Friend == null || string.IsNullOrWhiteSpace(order.Friend.Email))
            {
                return;
            }

            string giftGiverName = order.Customer == null
                ? "A customer"
                : $"{order.Customer.FirstName} {order.Customer.LastName}";

            string subject = $"Gift Received #{order.OrderNumber}";

            StringBuilder body = new StringBuilder();
            body.AppendLine("Hello,");
            body.AppendLine();
            body.AppendLine($"{giftGiverName} bought you music from Bevo's Tunes.");
            body.AppendLine($"Order Number: {order.OrderNumber}");
            body.AppendLine();
            body.AppendLine("Gifted Music:");
            body.Append(BuildPurchasedItemsList(order));
            body.AppendLine();

            if (!string.IsNullOrWhiteSpace(recommendedGenre) && !string.IsNullOrWhiteSpace(recommendedArtistName))
            {
                body.AppendLine($"Recommendation: Based on your purchase in the genre {recommendedGenre},");
                body.AppendLine($"you may also enjoy music by {recommendedArtistName}.");
                body.AppendLine();
            }

            body.AppendLine("Thank you,");
            body.AppendLine("Bevo's Tunes");

            SendEmail(subject, body.ToString(), order.Friend.Email);
        }

        // Refund email to one person
        public static void SendRefundEmail(Order order, string recipientEmail)
        {
            if (order == null || string.IsNullOrWhiteSpace(recipientEmail))
            {
                return;
            }

            string subject = $"Order Refunded #{order.OrderNumber}";

            StringBuilder body = new StringBuilder();
            body.AppendLine("Hello,");
            body.AppendLine();
            body.AppendLine($"Order #{order.OrderNumber} has been refunded.");
            body.AppendLine("The music from this order has been removed from the account.");
            body.AppendLine();
            body.AppendLine("Thank you,");
            body.AppendLine("Bevo's Tunes");

            SendEmail(subject, body.ToString(), recipientEmail);
        }

        private static decimal GetOrderTotal(Order order)
        {
            if (order.OrderDetails == null || order.OrderDetails.Count == 0)
            {
                return 0m;
            }

            return order.OrderDetails.Sum(od => od.Price);
        }

        private static string BuildPurchasedItemsListHtml(Order order)
        {
            if (order.OrderDetails == null || order.OrderDetails.Count == 0)
                return "No items found<br>";

            var sb = new StringBuilder();
            foreach (OrderDetail item in order.OrderDetails)
            {
                string name = item.Song?.SongName ?? item.Album?.AlbumName ?? "Item";
                sb.AppendLine($"{name}: {item.Price:C2}<br>");
            }
            return sb.ToString();
        }

        private static string BuildPurchasedItemsList(Order order)
        {
            StringBuilder sb = new StringBuilder();

            if (order.OrderDetails == null || order.OrderDetails.Count == 0)
            {
                sb.AppendLine("- No items found");
                return sb.ToString();
            }

            foreach (OrderDetail item in order.OrderDetails)
            {
                string itemName = item.Song?.SongName ?? item.Album?.AlbumName ?? "Item";
                sb.AppendLine($"- {itemName}: {item.Price:C2}");
            }

            return sb.ToString();
        }
    }
}