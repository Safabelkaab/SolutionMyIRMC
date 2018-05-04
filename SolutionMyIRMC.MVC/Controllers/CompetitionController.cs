
using SolutionMyIRMC.Domain.Models;
using SolutionMyIRMC.MVC.Models;
using SolutionMyIRMC.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SolutionMyIRMC.MVC.Controllers
{
    public class CompetitionController : Controller
    {
        private ICompetitionService service = new CompetitionService();

        // GET: Competition
        public ActionResult Index(String searchTitle)
        {
            var competitions = service.GetMany();
            List<CompetitionViewModel> MaListe = new List<CompetitionViewModel>();

            if (!String.IsNullOrEmpty(searchTitle))
            {
                competitions = service.GetCompetitionByTitre(searchTitle);
                // MaListe = MaListe.Where(m => m.Title.Contains(searchTitle)).ToList();
            }
            /*
            if (!String.IsNullOrEmpty(searchGenre))
            {
                films = myservice.GetFilmByGenre(searchGenre);
                //MaListe = MaListe.Where(m => m.Genre.Contains(searchGenre)).ToList();
            }
            */
            foreach (var f in competitions)
            {
                MaListe.Add(new CompetitionViewModel
                {
                    titre= f.titre,
                    name = f.name,
                    ville = f.ville,
                    lieu = f.lieu,
                    date = f.date,
                    prix = f.prix
                });
            }

            return View(MaListe);
        }

        // GET: Competition/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Competition/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Competition/Create
        [HttpPost]
        public ActionResult Create(CompetitionViewModel fvm )
        {
            competition f = new competition
            {
                id=fvm.id ,
                titre = fvm.titre,
                name = fvm.name,
                ville = fvm.ville,
                lieu = fvm.lieu,
                date= fvm.date,
                prix=fvm.prix

            };
            service.Add(f);
            service.Commit();


            return View();
        }

        // GET: Competition/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Competition/Edit/5
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

        // GET: Competition/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Competition/Delete/5
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
    }
}
