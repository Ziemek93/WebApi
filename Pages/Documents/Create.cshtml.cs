using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace WebApi.Pages.Documents
{
    public class CreateModel : PageModel
    {
        private readonly WebApi.Models.MagazynContext _context;

        public CreateModel(WebApi.Models.MagazynContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["IdFku"] = new SelectList(_context.Users, "Id", "Login");
            return Page();
        }

        [BindProperty]
        public Models.Documents Documents { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Documents.Add(Documents);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
