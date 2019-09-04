using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Pages.Documents
{
    public class DeleteModel : PageModel
    {
        private readonly WebApi.Models.MagazynContext _context;

        public DeleteModel(WebApi.Models.MagazynContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Documents Documents { get; set; }
        //public Models.DocumentsThings DocumentsThings { get; set; }
        public IList<Models.DocumentsThings> DocumentsThings { get; set; }


        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Documents = await _context.Documents
                .Include(d => d.IdFkuNavigation).FirstOrDefaultAsync(m => m.Id == id);

            if (Documents == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _context.DocumentsThings.RemoveRange(_context.DocumentsThings.Where(x => x.IdFkd == id));


            if (Documents != null)
            {
                //_context.DocumentsThings.Remove(DcTh);
                // await _context.SaveChangesAsync();

                _context.Documents.Remove(Documents);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
