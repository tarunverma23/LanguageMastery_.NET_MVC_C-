using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;


namespace LanguageMastery.Utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";
        private const string Path = "C:\\Users\\admin\\Desktop\\Language_Mastery.txt";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("tarun.verma.23.tv@gmail.com", "Language Mastery");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var bytes = File.ReadAllBytes(Path);
            var file = Convert.ToBase64String(bytes);
            msg.AddAttachment("Language_Mastery.txt", file);
            var response = client.SendEmailAsync(msg);
        }

    }
}