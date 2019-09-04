using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public Models.Users Users { get; set; }

        //public async Task OnGetAsync()
        //{

        //    //Users = await _context.Users.ToListAsync();
        //}

        public void search()
        {
            var context = new MagazynContext();
            // var studentWithGrade = context.Things.Include(s => s.DocumentsThings).FirstOrDefault();

        }


        //public void OnGet()
        //{

        //}
    }
}
