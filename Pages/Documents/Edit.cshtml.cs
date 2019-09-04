using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Pages.Documents
{
    public class EditModel : PageModel
    {
        private readonly WebApi.Models.MagazynContext _context;

        public EditModel(WebApi.Models.MagazynContext context)
        {
            _context = context;
        }

        public float nettoDokument = 0;
        public float bruttoDokument = 0;

        [BindProperty]
        public Models.Documents Documents { get; set; }

        //public IList<Models.Things> Things { get; set; }
        [BindProperty]
        public Models.DocumentsThings DocumentsThings { get; set; }
        public Models.Things Things { get; set; }

        public IList<Models.DocumentInfo> DocumentInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }



            var query = (from g in _context.DocumentsThings
                         from u in _context.Things.Where(a => a.Id == g.IdFkt).DefaultIfEmpty()
                         select new Models.DocumentInfo()
                         {
                             Id = g.Id,
                             NazwaArtykulu = u.NazwaArtykulu,
                             IdFkt = g.IdFkt,
                             IdFkd = g.IdFkd,
                             Ilosc = g.Ilosc,
                             CenaBrutto = u.CenaBrutto,
                             CenaNetto = u.CenaNetto
                         }
                            );
            query = query.Where(a => a.IdFkd == id).DefaultIfEmpty();




            Documents = await _context.Documents
                .Include(d => d.IdFkuNavigation).FirstOrDefaultAsync(m => m.Id == id);
            DocumentInfo = await query.AsNoTracking().ToListAsync();



            if (DocumentInfo.FirstOrNull() != null)
            {
                documentPrice();

            }
            if (Documents == null)
            {
                return NotFound();
            }

            ViewData["NazwaArtykulu"] = new SelectList(_context.Things, "Id", "NazwaArtykulu");
            ViewData["IdFku"] = new SelectList(_context.Users, "Id", "Login");
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {

            //Documents.Id = DocumentId ?? 0;
            //  var data = _context.Documents.First(a => a.Id == id)


            // { NumerKlienta = Documents.NumerKlienta, DataDokumentu = Documents.DataDokumentu, Nazwa = Documents.Nazwa };

            var update = _context.Documents.First(a => a.Id == Documents.Id);
            update.NumerKlienta = Documents.NumerKlienta;
            update.DataDokumentu = Documents.DataDokumentu;
            update.Nazwa = Documents.Nazwa;
            // _context.SaveChanges();
            //  _context.Attach(Documents).State = EntityState.Modified; // tu wchodzi wszystko z posta

            //   var author = context.Authors.First(a => a.AuthorId == 1);
            //   author.FirstName = "Bill";
            //   context.SaveChanges();
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentsExists(Things.Id)) //------
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }



        public async Task<IActionResult> OnPostAdd()
        {

            int IdT = Int32.Parse(Request.Form["Things.NazwaArtykulu"]);

            //Ilosc
            //Things = await _context.Things.FirstOrDefaultAsync(m => m.NazwaArtykulu == Things.NazwaArtykulu);

            if (_context.DocumentsThings.Any(dt => dt.IdFkd == Documents.Id && dt.IdFkt == IdT))
            {
                var update = _context.DocumentsThings.First(dt => dt.IdFkd == Documents.Id && dt.IdFkt == IdT);
                update.Ilosc += DocumentsThings.Ilosc;
            }
            else
            {
                var create = new DocumentsThings()
                {
                    IdFkd = Documents.Id,
                    IdFkt = Int32.Parse(Request.Form["Things.NazwaArtykulu"]),
                    Ilosc = DocumentsThings.Ilosc
                };

                int a = 1;

                _context.Entry(create).State = EntityState.Added;
            }

            // var variable = _context.DocumentsThings.First(a => a.IdFktNavigation.NazwaArtykulu == Things.NazwaArtykulu);

            //DocumentsThings.IdFkd = DocumentId ?? 0;

            //   DocumentsThings.IdFkt = _context.Things()
            //  _context.Attach(DocumentsThings).State = EntityState.Modified;

            //var dept = new Department()
            //{
            //    Name = "Designing"
            //};
            //context.Entry(dept).State = EntityState.Added;
            //context.SaveChanges();

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocumentsExists(Documents.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            //            query = query.Where(a => a.IdFkd == id).DefaultIfEmpty(); //oddzielenie rzeczy po otwartym id dokumentu

            return RedirectToPage("./Index");
            //return RedirectToPage("./Details/?id=" + IdD);
        }

        private bool DocumentsExists(int id)
        {
            return _context.Documents.Any(e => e.Id == id);
        }

        public void documentPrice()
        {

            int i = 0;
            while (i < DocumentInfo.Count)
            {
                nettoDokument += DocumentInfo[i].CenaNetto * DocumentInfo[i].Ilosc;
                bruttoDokument += DocumentInfo[i].CenaBrutto * DocumentInfo[i].Ilosc;
                i++;
            }
        }
    }
}
