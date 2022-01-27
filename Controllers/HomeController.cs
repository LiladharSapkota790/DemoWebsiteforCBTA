using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoWebsiteforCBTA.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.IO;

namespace DemoWebsiteforCBTA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

    }
}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Contact(EmailForm model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
        //        var message = new MailMessage();
        //        message.To.Add(new MailAddress("liladharsapkota12@gmail.com"));  // replace with valid value 
        //        message.From = new MailAddress("12001445@students.koi.edu.au");  // replace with valid value
        //        message.Subject = "Your email subject";
        //        message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
        //        message.IsBodyHtml = true;

        //        using (var smtp = new SmtpClient())
        //        {
        //            var credential = new NetworkCredential
        //            {
        //                UserName = "12001445@students.koi.edu.au",  // replace with valid value
        //                Password = "10510746Koi%*"  // replace with valid value
        //            };
        //            smtp.Credentials = credential;
                
        //            smtp.Host = "smtp.gmail.com";
        //            smtp.Port = 25;
        //            smtp.EnableSsl = true;
              
        //            await smtp.SendMailAsync(message);
        //            return RedirectToAction("Sent");
        //        }
        //    }
        //    return View(model);
        //}




        //public ActionResult Sent()
        //{
        //    return View();
        //}



        //public ActionResult SendMail()
        //{
        //    return View();
        //}


    
        //[HttpPost]
        //public ActionResult SendMail(EmailModel model)
        //{

        //    using(MailMessage Emailmessage = new MailMessage(model.email, model.To))
        //    {
        //        Emailmessage.Subject = model.Subject;
        //        Emailmessage.Body = model.body;

        //        if (model.PostedFile.ContentLength > 0)
        //        {
        //            string fileName = Path.GetFileName(model.PostedFile.FileName);

        //            Emailmessage.Attachments.Add(new Attachment(model.PostedFile.InputStream, fileName));
        //        }


        //        Emailmessage.IsBodyHtml=true;

        //        using (SmtpClient smtp = new SmtpClient())
        //        {
        //            smtp.Host = "smtp.gmail.com";
                                    
        //            //smtp.UseDefaultCredentials = false;
                    
        //            smtp.Port = 587;
        //            smtp.EnableSsl = true;
        //            NetworkCredential cred = new NetworkCredential(model.email, model.Password);
        //            smtp.Credentials = cred;
        //            smtp.Send(Emailmessage);

        //            ViewBag.Sendmessage = "Email Sent ";

        //        }



        //    }










//            return View();
//        }
//    }
//}