using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace u23594561Prac1_test_.Controllers
{
	public class PeopleController : Controller
    {
        // GET: People

        public ActionResult ListPeople()
        {
            List<Models.PersonModel> people = new List<Models.PersonModel>();

            people.Add(new Models.PersonModel { StudentNumber = "u12345678", FirstName = "Scarlett", SurName = "Johansonn", EmailAddress = "scar.jo@tuks.co.za", MyLink = "~/Content/HTML/Scarlett.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u12345679", FirstName = "John", SurName = "Lennon", EmailAddress = "john.len@tuks.co.za", MyLink = "~/Content/HTML/John.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u12345677", FirstName = "Dakota", SurName = "Johnson", EmailAddress = "dak.jo@tuks.co.za", MyLink = "~/Content/HTML/Dakota.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u12345678", FirstName = "Lana", SurName = "Del Rey", EmailAddress = "lana.dr@tuks.co.za", MyLink = "~/Content/HTML/Lana.html" });
            people.Add(new Models.PersonModel { StudentNumber = "u12345678", FirstName = "Gwyneth", SurName = "Paltrow", EmailAddress = "gwyn.pal@tuks.co.za", MyLink = "~/Content/HTML/Gwyneth.html" });

            return View(people);

        }

    }
}