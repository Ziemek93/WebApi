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


        //g.Id,
        //g.IdFkd,
        //g.IdFkt,
        //g.Ilosc,
        //u.NazwaArtykulu,
        //u.CenaBrutto,
        //u.CenaNetto

        // IQueryable<Models.DocumentsThings>;
        //var DocumentsThings = (from dt in _context.DocumentsThings
        //                       join t in _context.Things on dt.IdFkt equals t.Id
        //                       select new
        //                       {
        //                           IdFkd = dt.IdFkd,
        //                           IdFku = dt.IdFkd,
        //                           Ilosc = dt.Ilosc,
        //                           IdFkt = dt.Id,
        //                           NazwaArtykulu = t.NazwaArtykulu
        //                       }).ToList();



        //Documents_Things = DocumentsThings.AsNoTracking().ToListAsync();

        //var ThingsDataz = _context.Things;
        //foreach (Things d in ThingsDataz)
        //{

        //    _context.Entry(d).Collection(p => p.DocumentsThings).Load();

        //    foreach (DocumentsThings c in d.DocumentsThings)
        //    {
        //        Debug.WriteLine(c);
        //        //DocumentsThings.Add(c);

        //    }
        //}
        //NullReferenceException: Object reference not set to an instance of an objec
        //var departments = _context.Departments;
        //foreach (department d in departments)
        //{

        //    _context.Entry(d).Collection(p => p.Courses).Load();
        //    foreach (Course c in d.Courses)
        //    {

        //        courseList.Add(d.Name + c > Title);

        //    }

        //}

    }
}
