using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
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
        public Models.RepoDetails details { get; set; }
        public IList<Models.RepoDetails> detailsl { get; set; }

        public void OnGet()
        {

            string url = "https://api.github.com/repos/Ziemek93/webapi";

            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nothing");

            var content = client.DownloadString(url);

            content = "[" + content + "]";
            Debug.WriteLine(content);
            var serializer = new DataContractJsonSerializer(typeof(List<RepoDetails>));

            var ms = new MemoryStream(Encoding.Unicode.GetBytes(content));

            var contributors = (List<RepoDetails>)serializer.ReadObject(ms);
            contributors.ForEach(Console.WriteLine);

            Debug.WriteLine(contributors[0].Created_at + "  L_____________________");



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
    [DataContract]
    internal class Contributor1
    {
        [DataMember(Name = "login")]
        public string Login { get; set; }
        [DataMember(Name = "contributions")]
        public short Contributions { get; set; }

        public override string ToString()
        {
            return $"{Login,20}: {Contributions} contributions";
        }
    }
    [DataContract]
    public partial class Contributor2
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created_at")]
        public string Created_at { get; set; }

        [DataMember(Name = "pushed_at")]
        public string Pushed_at { get; set; }



        public override string ToString()
        {
            return $"Name: {Name} \n Created at: {Created_at} \n Pushed at {Pushed_at}";
        }
    }




}
