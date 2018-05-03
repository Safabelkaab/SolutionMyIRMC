using SolutionMyIRMC.Domain;
using SolutionMyIRMC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace SolutionMyIRMC.MVC.Controllers
{
    public class TenderController : Controller
    {
        TenderService ts = new TenderService();
        EvaluateTenderService ets = new EvaluateTenderService();
        public static int idTenderS;
        public ActionResult AfficheTender()
        {
            IEnumerable<Tender> liste = ts.afficher();
            return View(liste);

        }

        public ActionResult AddTender()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTender(Tender tenders, FormCollection formvalues)
        {
            try
            {

                tenders.titleTender = formvalues["titleTender"];
                tenders.description = formvalues["description"];
                tenders.contact = formvalues["contact"];
                tenders.sourceInformation = formvalues["sourceInformation"];
                ts.addTender(tenders.titleTender, tenders.description, tenders.contact, tenders.sourceInformation);
               
                return RedirectToAction("AfficheTender");
            }
            catch
            {
                return View();

            }
        }

        public ActionResult DeleteTender(int idTender)
        {

            ts.deleteTender(idTender);
            return RedirectToAction("AfficheTender");
        }


        // GET: Forum/Edit/5
        public ActionResult EditTender(int idTender)
        {

            Tender t = ts.GetById(idTender);

            return View(t);
        }
        // POST: Tender/Edit/5
        [HttpPost]
        public ActionResult EditTender(Tender t, FormCollection collection)
        {
            try
            {
                //forum f = null;
                //// TODO: Add update logic here
                //f = forumS.readForumById(id);

                t.titleTender = collection["titleTender"];
                t.description = collection["description"];
                t.contact = collection["contact"];
                t.sourceInformation = collection["sourceInformation"];

                if (ModelState.IsValid)
                {
                    ts.editTenders(t);
                    return RedirectToAction("AfficheTender");
                }
                return View("Edit", t);
            }
            catch
            {
                return View();
            }
        }

        //*************************evaluate tender********************************


        //create evalform
        public ActionResult CreateEvalFormT(int idTender)
        {
            idTenderS = idTender;
            return View();
        }


        [HttpPost]
        public ActionResult CreateEvalFormT(EvaluationTender et)
        {
            try
            {
                et.idTenderF = idTenderS;
                ets.Add(et);
                ets.Commit();
                var accountSid = "AC3dd0c68b89b6efc45c6f07f2bfc3d6d1";
                var authToken = "239a83796b595033ee1438e41f46c3ed";
                TwilioClient.Init(accountSid, authToken);
                var to = new PhoneNumber("+21652216635");
                var from = new PhoneNumber("+19495459437");
                var message = MessageResource.Create(to: to, from: from,
                    body: " Une evalution à été remplie ");
                Content(message.Sid);
                return RedirectToAction("AfficheEvalT");
            }
            catch
            {
                return View();
            }
        }



        public ActionResult AfficheEvalT()
        {
            return View(ets.GetMany());
        }


        // get pour supprimer
        public ActionResult DeleteEval(int IdEvalTender)
        {
            EvaluationTender ps = ets.GetById(IdEvalTender);
            return View(ps);
        }

        //supprimer
        [HttpPost]
        public ActionResult DeleteEval(int IdEvalTender, EvaluationTender ps)
        {
            try
            {
                EvaluationTender et = new EvaluationTender();
                et = ets.GetById(IdEvalTender);
                ets.Delete(et);
                ets.Commit();

                return RedirectToAction("AfficheEvalT");
            }
            catch
            {
                return View();
            }
        }




    }




}