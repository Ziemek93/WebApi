using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApi.Pages.Documents
{
    public class IndexModel : PageModel
    {
        private readonly WebApi.Models.MagazynContext _context;

        public IndexModel(WebApi.Models.MagazynContext context)
        {
            _context = context;
        }

        public IList<Models.Documents> Documents { get; set; }



        public async Task OnGetAsync()
        {
            Documents = await _context.Documents
                .Include(d => d.IdFkuNavigation).ToListAsync();





        }



    }
}
