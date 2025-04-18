using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Traversal_Core.Models;

namespace Traversal_Core.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(MailRequest mailrequest)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddress = new MailboxAddress("Admin", "traversalcore2@gmail.com");

            mimeMessage.From.Add(mailboxAddress);
            MailboxAddress mailboxAddressTo=new MailboxAddress("User",mailrequest.ReceiverMail);
            
            mimeMessage.To.Add(mailboxAddressTo);
            var bodyBuilder=new BodyBuilder();
            bodyBuilder.TextBody = mailrequest.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();
            mimeMessage.Subject = mailrequest.Subject;

           SmtpClient client=new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("traversalcore2@gmail.com", "fhvevuwmjwlkpnzm");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
