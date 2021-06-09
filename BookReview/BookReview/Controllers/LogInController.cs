using BookReview.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BookReview.Controllers
{
    public class LogInController : Controller
    {
            // GET: /<controller>/
            //en action index där jag har min inloggningssida
            public IActionResult Index()
            {
                return View();
            }


            [HttpPost]
            // asynkron för att sidan ska ta sig framåt. Skickar objektet user som var modell i index skickar också med en textsträng.
            public async Task<ActionResult> Index(User inloggning, string returnUrl = null)
            {
                //kolla användaren om den är behörig
                if (CheckUser(inloggning.Username, inloggning.Password) == true)
                {
                    //allt stämmer, logga in användaren
                    var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

                    identity.AddClaim(new Claim(ClaimTypes.Name, inloggning.Username));

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(identity));
                    //skicka användaren vidare till returnUrl om den finns annars till startsidan
                    if (returnUrl != null)
                        return Redirect(returnUrl);

                    else
                        return RedirectToAction("Index", "LoggedInUser");

                }
                else //om inloggningsuppgifterna inte stämmer skickas ett felmeddelande ut
                {
                    ViewBag.Message = "Felaktigt användarnamn eller lösenord";
                    return View();
                }
            }
            //en funktion som returnerar true och false, den kollar om det är rätt anv namn och lösenord.
            //Egentligen vill man kontollera mot en tabell i databasen men visste inte hur man skulle gå till väga så följde exemplet i genomgången
            private bool CheckUser(string username, string password)
            {
                if (username.ToUpper() == "ANNA" && password == "ANNA")
                    return true;
                else
                    return false;
            }
            //skrev ner den här koden för att kunna jobba med den senare, men i nulägen kan man inte logga ut:/

            public async Task<IActionResult> SignOut()
            {
                await HttpContext.SignOutAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToAction("Index", "home");
            }
        }
}
