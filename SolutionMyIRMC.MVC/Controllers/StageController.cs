using SolutionMyIRMC.Domain.Models;
using SolutionMyIRMC.MVC.Models;
using SolutionMyIRMC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.UI.WebControls;
using System.Net.Mime;

namespace SolutionMyIRMC.MVC.Controllers
{
    public class StageController : Controller
    {
        private IStageService service = new StageService();
        // GET: Stage
        public ActionResult Index(string searchTitle)
        {
            var stages = service.GetMany();
            List<StageViewModel> MaListe = new List<StageViewModel>();

            if (!String.IsNullOrEmpty(searchTitle))
            {
                stages = service.GetStageByTitre(searchTitle);
                //MaListe = MaListe.Where(m => m.Title.Contains(searchTitle)).ToList();
            }
            /*
            if (!String.IsNullOrEmpty(searchGenre))
            {
                films = myservice.GetFilmByGenre(searchGenre);
                //MaListe = MaListe.Where(m => m.Genre.Contains(searchGenre)).ToList();
            }
            */
            foreach (var f in stages)
            {
                MaListe.Add(new StageViewModel
                {

                    IdStage = f.IdStage,
                    Titre = f.Titre,
                    Competence = f.Competence,
                    DateDebut = f.DateDebut,
                    DateFin = f.DateFin,
                    Remuneration = f.Remuneration,
                    Salaire=f.Salaire,
                    lieu=f.lieu
                });
            }
            
            return View(MaListe);
        }
        

            public ActionResult ViewDocs(int id)
        {
            
            return View();
        }
        // GET: Stage/Details/5
        public ActionResult Details(int id)
        {
            var stage = service.GetById(id);
            StageViewModel st = new StageViewModel
                   {
                
                 IdStage= stage.IdStage,
                Titre = stage.Titre,
                Competence = stage.Competence,
                DateDebut = stage.DateDebut,
                DateFin = stage.DateFin,
                lieu = stage.lieu
                     };
            return View(st);
        }

        // GET: Stage/Createdoc
        public ActionResult Createdoc()
        {
            return View("CreateDoc");
        }
        
        public ActionResult Createstage(StageViewModel fvm)
        {
            try
            {
                stage f = new stage
                {
                    IdStage=fvm.IdStage,
                    Titre = fvm.Titre,
                    Competence = fvm.Competence,
                    DateDebut = fvm.DateDebut,
                    DateFin = fvm.DateFin,
                    Remuneration = fvm.Remuneration,
                    Salaire = fvm.Salaire,
                    lieu = fvm.lieu

                };
                service.Add(f);
                service.Commit();


                return View();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        // POST: Stage/Create
        [HttpPost]
        public ActionResult Create(StageViewModel fvm)
        {
            try
            {
                stage f = new stage
                {
                    Titre= fvm.Titre,
                    Competence = fvm.Competence,
                    DateDebut = fvm.DateDebut,
                    DateFin = fvm.DateFin,
                    lieu = fvm.lieu

                };
                service.Add(f);
                service.Commit();


                return View();
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }

        // GET: Stage/Edit/5
        public ActionResult Edit(int id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("MyIRMC-web/rest/IRMCdoc/"+id).Result;

            if (response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<DocumentViewModel>>().Result;
            }
            else
            {
                ViewBag.result = "error";
            }
            return View(ViewBag.result);
        }
       
        // POST: Stage/CreateDoc
        [HttpPost]
        public ActionResult CreateDoc(DocumentViewModel doc, HttpPostedFileBase Img)
        {
           // List<document> lst = Session[""] as List<document>; 

            doc.path = Img.FileName;
            
             /*stage st=service.GetStageById(id);
            doc.stage = st;
            
            st.listDocs = lst;*/
            
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.PostAsJsonAsync("MyIRMC-web/rest/IRMCdoc",doc).ContinueWith((postTask) => postTask.Result.EnsureSuccessStatusCode());
            
            var patht = Path.Combine(Server.MapPath("~/Content/Upload/"),
                Img.FileName);
            Img.SaveAs(patht);
            
            return View();
        }
        // POST: Stage/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stage/Delete/5
        public ActionResult Delete(int id)
        {
            stage stag = service.GetStageById(id);
            service.Delete(stag);
            return RedirectToAction("Index");
        }

        // POST: Stage/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        public ActionResult readPDF()
        {
            //System.Diagnostics.Process.Start(@"c:\Atelier2-JAX-RS client.pdf");
            //byte[] byteArray = System.IO.File.ReadAllBytes(@"c:/Atelier2-JAX-RS client.pdf");
            /*   string FilePath = Server.MapPath("~/Shared/Atelier2-JAX-RS client.pdf");
               WebClient User = new WebClient();
               Byte[] FileBuffer = User.DownloadData(FilePath);
               if (FileBuffer != null)
    {

                   Response.ContentType = "application/pdf";

                   Response.AddHeader("content-length", FileBuffer.Length.ToString());

                   Response.BinaryWrite(FileBuffer);

               }*/
            /*var fileStream = new FileStream("/Content/Upload/" + "Atelier2-JAX-RS client.pdf",
                                     FileMode.Open,
                                     FileAccess.Read
                                   );
            var fsResult = new FileStreamResult(fileStream, "application/pdf");
            return fsResult;*/
            Response.AddHeader("Content-Disposition", "inline; filename=" + "Atelier2-JAX-RSclient.pdf");
            return File("~/Content/Upload/Atelier2-JAX-RSclient.pdf", "application/pdf");

        }

        public ActionResult test()
        {
            var stages = service.GetMany();
            List<StageViewModel> MaListe = new List<StageViewModel>();
            foreach (var f in stages)
            {
                MaListe.Add(new StageViewModel
                {
                    IdStage=f.IdStage,
                    Titre = f.Titre,
                    lieu= f.lieu,
                    DateDebut = f.DateDebut,
                    DateFin = f.DateFin

                });
            }
            return View(MaListe);
          }
        [HttpGet]
        public JsonResult GetData()
        {

            myspdbContext ce = new myspdbContext();

            var Result = (from obj in ce.stages
                          select new
                          {
                              IdStage = obj.IdStage,
                              Competence = obj.Competence,
                              DateDebut = obj.DateDebut,
                              DateFin = obj.DateFin,
                              ImageLieu = obj.ImageLieu,
                              Remuneration = obj.Remuneration,
                              Salaire = obj.Salaire,
                              Titre = obj.Titre,
                              lieu = obj.lieu
                          });


            var result=Result.ToList();
            //var result = ce.stages.ToList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Docs()
        {
            int id=0;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:18080");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("MyIRMC-web/rest/IRMCdoc/"+id).Result;

            if(response.IsSuccessStatusCode)
            {
                ViewBag.result = response.Content.ReadAsAsync<IEnumerable<DocumentViewModel>>().Result;
            }
            else
            {
                ViewBag.result = "error";
            }
            return View(ViewBag.result);
        }


    }
}
