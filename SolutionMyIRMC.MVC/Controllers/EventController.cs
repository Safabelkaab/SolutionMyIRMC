using SolutionMyIRMC.Domain;
using SolutionMyIRMC.Service;
using SolutionMyIRMC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SolutionMyIRMC.MVC.Controllers
{
    public class EventController : Controller
    {
        EventService es = new EventService();
        EvaluateEventService ees = new EvaluateEventService();

        public ActionResult AfficheEvent()
        {
            IEnumerable<Event> liste = es.afficher();
            return View(liste);

        }
        public ActionResult AddEvent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEvent(Event events, FormCollection formvalues)
        {
            try
            {
                
                events.titreEvent = formvalues["titreEvent"];
                events.descriptionEvent = formvalues["descriptionEvent"];
                events.telEvent = formvalues["telEvent"];
                es.addEvent(events.titreEvent, events.descriptionEvent, events.telEvent);
         
                return RedirectToAction("AfficheEvent");
            }
            catch
            {
                return View();

            }
        }


        public ActionResult Delete()
        {

            // es.GetById(idEvent);

            return View();
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult Delete(int idEvent)
        {

            es.delete(idEvent);
            return RedirectToAction("AfficheEvent");
        }

        //*************************evaluate Event********************************


        //create evalformEvent
        public ActionResult CreateEvalFormE()
        {
            
            return View();
        }


        [HttpPost]
        public ActionResult CreateEvalFormE(EvaluationEvent ee)
        {
            try
            {
                
                ees.Add(ee);
                ees.Commit();
                return RedirectToAction("AfficheEvalE");
            }
            catch
            {
                return View();
            }
        }



        public ActionResult AfficheEvalE()
        {
            return View(ees.GetMany());
        }


        // get pour supprimer
        public ActionResult DeleteEvalE(int IdEvalEvent)
        {
            EvaluationEvent ps = ees.GetById(IdEvalEvent);
            return View(ps);
        }

        //supprimer
        [HttpPost]
        public ActionResult DeleteEvalE(int IdEvalEvent, EvaluationEvent ps)
        {
            try
            {
                EvaluationEvent ee = new EvaluationEvent();
                ee = ees.GetById(IdEvalEvent);
                ees.Delete(ee);
                ees.Commit();

                return RedirectToAction("AfficheEvalE");
            }
            catch
            {
                return View();
            }
        }



    }



}