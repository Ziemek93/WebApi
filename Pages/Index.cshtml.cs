using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
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

        public Models.Users Users { get; set; }


        public void OnGet()
        {

            string url = "https://api.github.com/repos/Ziemek93/webapi";

            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nothing");

            var content = client.DownloadString(url);

            content = "[" + content + "]";

            var serializer = new DataContractJsonSerializer(typeof(List<RepoDetails>));

            var ms = new MemoryStream(Encoding.Unicode.GetBytes(content));

            var contributors = (List<RepoDetails>)serializer.ReadObject(ms);
            contributors.ForEach(Console.WriteLine);


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

            //int IdT = Int32.Parse(Request.Form["Things.NazwaArtykulu"]);

            //if (_context.DocumentsThings.Any(dt => dt.IdFkd == Documents.Id && dt.IdFkt == IdT))
            //{
            //    var update = _context.DocumentsThings.First(dt => dt.IdFkd == Documents.Id && dt.IdFkt == IdT);
            //    update.Ilosc += DocumentsThings.Ilosc;
            //}
            //else
            //{
            //    var create = new DocumentsThings()
            //    {
            //        IdFkd = Documents.Id,
            //        IdFkt = Int32.Parse(Request.Form["Things.NazwaArtykulu"]),
            //        Ilosc = DocumentsThings.Ilosc
            //    };

            //    int a = 1;

            //    _context.Entry(create).State = EntityState.Added;
            //}


            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!DocumentsExists(Documents.Id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return RedirectToPage("./Index");
        }
    }




}
