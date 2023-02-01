using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MongoDB.Driver;
using PROJEKAT_MONGODB.Model;
using Microsoft.AspNetCore.Http;
namespace PROJEKAT_MONGODB.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Sifra { get; set; }
        public string ErrorMessage { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPostLogin()
        {
            var client = new MongoClient("mongodb://localhost/?safe=true");
            var db = client.GetDatabase("SEVENSEAS");
            var collection = db.GetCollection<Korisnik>("korisnici");

            Korisnik k = collection.AsQueryable<Korisnik>().Where(x => x.Email == Email && x.Sifra == Sifra).FirstOrDefault();

            if (k == null)
            {
            ErrorMessage = "Invalid email address or password!";
            //return null;
            return Page();
            }
                HttpContext.Session.SetString("email", Email);
                ErrorMessage = "Uspesno logovan";
                //return new JsonResult(k);
                return RedirectToPage("/Index"); 
        }
    }
}
