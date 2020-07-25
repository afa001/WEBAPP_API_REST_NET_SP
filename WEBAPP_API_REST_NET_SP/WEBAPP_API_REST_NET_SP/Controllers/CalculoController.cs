using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WEBAPP_API_REST_NET_SP.Models;

namespace WEBAPP_API_REST_NET_SP.Controllers
{
    public class CalculoController : Controller
    {
        // GET: Calculo
        public ActionResult Index()
        {
            IEnumerable<Calculo> calculos;
            HttpResponseMessage response = GlobalVariables.webapiClient.GetAsync("Calculo").Result;
            calculos = response.Content.ReadAsAsync<IEnumerable<Calculo>>().Result;

            return View(calculos);
        }

        // GET: Calculo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Calculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Calculo/Create
        [HttpPost]
        public ActionResult Create(Calculo c)
        {
            try
            {
                // TODO: Add insert logic here
                HttpResponseMessage response = GlobalVariables.webapiClient.PostAsJsonAsync("Calculo", c).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calculo/Edit/5
        public ActionResult Edit(int id)
        {
            HttpResponseMessage response = GlobalVariables.webapiClient.GetAsync("Calculo/" + id).Result;
            Calculo c = response.Content.ReadAsAsync<Calculo>().Result;

            return View(c);
        }

        // POST: Calculo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Calculo calculo)
        {
            try
            {
                // TODO: Add update logic here
                HttpResponseMessage response = GlobalVariables.webapiClient.PutAsJsonAsync("Calculo/" + calculo.Id, calculo).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Calculo/Delete/5
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.webapiClient.GetAsync("Calculo/" + id).Result;
            Calculo c = response.Content.ReadAsAsync<Calculo>().Result;
            return View(c);
        }

        // POST: Calculo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Calculo calculo)
        {
            try
            {
                // TODO: Add delete logic here
                HttpResponseMessage response = GlobalVariables.webapiClient.DeleteAsync("Calculo/" + id).Result;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
