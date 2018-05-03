using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.AspNet.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SolutionMyIRMC.MVC.Controllers
{
    public class SmsController : TwilioController
    {

        public ActionResult sendSmsAccept()
        {

             return RedirectToAction("Tender","AfficheEvalT");

        }
        public ActionResult sendSmsReject()
        {

            var accountSid = "AC91b36c6f03129c54d9883b964c524094";
            var authToken = "68895de11c8e42d79935d1afb62e8132";
            TwilioClient.Init(accountSid, authToken);
            var to = new PhoneNumber("+21652216635");
            var from = new PhoneNumber("+21652216635");
            var message = MessageResource.Create(to: to, from: from,
                body: " the Service that you want to Exchange was reject! you can chose another service.");

            return Content(message.Sid);

        }
        
    }
}