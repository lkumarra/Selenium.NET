using SeleniumPOM.Config;
using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace SeleniumPOM.Utilities
{
    class MailUtil
    {
        public static void SendAttachedReport()
        {
            try
            {
                MailMessage mailMsg = new MailMessage();

                // To
                mailMsg.To.Add(new MailAddress(Constants.FROM_USER, Constants.FROM_USER_NAME));

                // From
                mailMsg.From = new MailAddress(Constants.TO_USER, Constants.TO_USER_NAME);

                // Subject and multipart/alternative Body
                mailMsg.Subject = Constants.SUBJECT;
                Attachment data = new Attachment(Constants.REPORT_PATH);
                mailMsg.Attachments.Add(data);

                // Init SmtpClient and send
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32(587));
                NetworkCredential credentials = new NetworkCredential(Constants.FROM_USER, Constants.PASSWORD);
                smtpClient.Credentials = credentials;
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMsg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
