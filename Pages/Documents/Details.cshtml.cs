﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace WebApi.Pages.Documents
{


    public class DetailsModel : PageModel
    {
        private readonly WebApi.Models.MagazynContext _context;
        Regex regexItem = new Regex("^[a-zA-Z0-9 ]*$");

        public DetailsModel(WebApi.Models.MagazynContext context)
        {
            _context = context;
        }

        public Models.DocumentsThings DocumentsThingsModel { get; set; }

        public Models.Documents Documents { get; set; }
        public IList<Models.Things> Things { get; set; }
        public IList<Models.DocumentsThings> DocumentsThings { get; set; }

        public float nettoDokument = 0;
        public float bruttoDokument = 0;

        public IList<Models.DocumentInfo> DocumentInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || !regexItem.IsMatch(id.ToString()))
            {
                return NotFound();
            }

            Documents = await _context.Documents
                .Include(d => d.IdFkuNavigation).FirstOrDefaultAsync(m => m.Id == id);

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
                             ).Where(a => a.IdFkd == id);
            query = query.Where(a => a.IdFkd == id).DefaultIfEmpty();


            DocumentInfo = await query.AsNoTracking().ToListAsync();


            if (DocumentInfo.FirstOrNull() != null)
            {
                documentPrice();
            }



            if (Documents == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task<IActionResult> OnGetRemove(int? id)
        {



            if (id == null || !regexItem.IsMatch(id.ToString()))
            {
                return NotFound();
            }

            DocumentsThingsModel = await _context.DocumentsThings.FindAsync(id);

            if (DocumentsThingsModel != null)
            {
                _context.DocumentsThings.Remove(DocumentsThingsModel);
                await _context.SaveChangesAsync();
            }

            return Redirect("./Index");
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
