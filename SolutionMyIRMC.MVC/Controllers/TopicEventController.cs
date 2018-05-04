using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolutionMyIRMC.Service;
using SolutionMyIRMC.Domain;
using System.Data.Entity;
using SolutionMyIRMC.Data.Models;

namespace SolutionMyIRMC.MVC.Controllers
{
    public class TopicEventController : Controller
    {
        CommentEventService ces = new CommentEventService();
        TopicService sss = new TopicService();
        EventService rs = new EventService();

        // GET: TopicEvent

        public ActionResult AfficheTopicEvent()
        {
            var ctx = new IRMCContext();
           
           
            return View(ctx.topicEvents.Include(p => p.commentEvents).ToList());
        }

        public ActionResult CreateTopic()
        {
            ViewBag.events = new SelectList(rs.GetMany(), "idEvent", "titreEvent");
            return View();
        }
        [HttpPost]
        public ActionResult CreateTopic(TopicEvent t)
        {
            try
            {
               
                sss.Add(t);
                sss.Commit();
                return RedirectToAction("AfficheTopicEvent");
            }
            catch
            {

                return View();
            }
        }


        public ActionResult CommentTopic(int idTopic)
        {
            return View();
        }

        [HttpPost]
        public ActionResult CommentTopic(int idTopic, CommentEvent com)
        {
         
            com.idTopicF = idTopic;
            com.idUserF = UserController.user.idUser;
            ces.Add(com);
            ces.Commit();
            return RedirectToAction("AfficheTopicEvent");
        }

        public ActionResult CommentLike(int idComment)
        {
            CommentEvent c1 = new CommentEvent();
            c1 = ces.GetById(idComment);
            c1.isliked = true;
            ces.Update(c1);
            ces.Commit();
            return RedirectToAction("AfficheTopicEvent");
        }

        public ActionResult CommentDisLike(int idComment)
        {
            CommentEvent c1 = new CommentEvent();
            c1= ces.GetById(idComment);
            c1.isliked = false; 
            ces.Update(c1);
            ces.Commit();
            return RedirectToAction("AfficheTopicEvent");
        }

        public ActionResult DeleteTopic(int idTopic)
        {
            TopicEvent te = sss.GetById(idTopic);
            return View(te);
        }

        [HttpPost]
        public ActionResult DeleteTopic(int idTopic, TopicEvent te)
        {
            try
            {
                TopicEvent r1 = new TopicEvent();
                r1 = sss.GetById(idTopic);
                sss.Delete(r1);
                sss.Commit();

                return RedirectToAction("AfficheTopicEvent");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EditComment(int idComment)
        {
            CommentEvent p = ces.GetById(idComment);

            return View(p);
        }




        // POST
        [HttpPost]
        public ActionResult EditComment(int idComment, CommentEvent st)
        {
            try
            {


                CommentEvent rec = ces.Get(e => e.idComment == idComment);
                rec.textComment = st.textComment;
                ces.Update(rec);
                ces.Commit();

                return RedirectToAction("AfficheTopicEvent");

            }
            catch
            {
                return View();
            }
        }


    }
}