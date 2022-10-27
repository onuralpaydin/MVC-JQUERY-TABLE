using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TEST.Models;
using TEST.VievModels;

namespace TEST.Controllers
{

    public class HomeController : Controller
    {
    List<PersonPetVM> VMlist = new List<PersonPetVM>();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DetailsJS()
        {
            int sayac = 1;
            for (int i = 0; i < 20; i++)
            {
                   
                PersonPetVM personPet = new PersonPetVM()
                {
                    PersonName = "Lorem",
                    PersonSurname = "Ipsum",
                    PersonBirthDate = DateTime.Now,
                    PersonGender = Gender.Man,
                    PetName = "Lorem",
                    PetType = "Lorem",
                    PetNumberOfFeet = 4,
                    PetAge = sayac,
                    PetGender = Gender.Man,
                    PetWeight = 10,
                    PetNutritionType = TypeOfNutrition.Omnivore

                };
                VMlist.Add(personPet);
                sayac++;
            }
            return View(VMlist);
        }
    }
}