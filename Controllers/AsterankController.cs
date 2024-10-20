using AdministrativeManagementSystemWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AdministrativeManagementSystemWeb.Controllers
{
    public class AsterankController : Controller
    {
        // GET: AsterankController
        public async Task<ActionResult> Index()
        {
            string apiUrl = "https://www.asterank.com/api/skymorph/search?target=J99TS7A";

            List<skymorph> sky = new List<skymorph>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                var result = await response.Content.ReadAsStringAsync();

                // Deserialize into the wrapper class
                SkymorphResponse responseObject = JsonConvert.DeserializeObject<SkymorphResponse>(result);

                // Extract the results
                sky = responseObject.Results;
            }

            return View(sky);
        }


        // GET: AsterankController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AsterankController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AsterankController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AsterankController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AsterankController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AsterankController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AsterankController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
