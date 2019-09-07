using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Pages
{
    public class IndexModel : PageModel
    {

        private readonly WebApi.Models.MagazynContext _context;

        public IndexModel(WebApi.Models.MagazynContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Users Users { get; set; }

        public void OnGet()
        {




        }


        public async Task<IActionResult> OnPostLog()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            return RedirectToPage("./Index");

        }

        public async Task<IActionResult> OnPostCreate()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }


            //var hash = PasswordHash.ArgonHashString(yourPasswordString, Strength.Interactive)
            //if (PasswordHash.ArgonHashStringVerify(hash, yourPasswordString) {
            //}

            var create = new Users()
            {
                Name = Users.Name,
                Login = Users.Login,
                Password = Users.Password

            };

            int a = 1;

            _context.Entry(create).State = EntityState.Added;



            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                throw;

            }

            return RedirectToPage("/Index");
        }
    }


}
