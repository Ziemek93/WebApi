using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.Pages.Documents
{
    public class AboutModel : PageModel
    {
        //  public Models.RepoDetails RepoDetails { get; set; }
        public IList<Models.RepoDetails> RepoDetails { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            string url = "https://api.github.com/repos/Ziemek93/webapi";

            var client = new WebClient();
            client.Headers.Add("User-Agent", "Nothing");

            var content = client.DownloadString(url);

            content = "[" + content + "]";

            var serializer = new DataContractJsonSerializer(typeof(List<Models.RepoDetails>));

            var ms = new MemoryStream(Encoding.Unicode.GetBytes(content));

            var myData = (List<Models.RepoDetails>)serializer.ReadObject(ms);
            myData.ForEach(Console.WriteLine);
            RepoDetails = myData;
            Debug.WriteLine(RepoDetails[0].Name + " xxx");
            Debug.WriteLine(RepoDetails[0].Created_at + " xxx");
            Debug.WriteLine(RepoDetails[0].Pushed_at + " xxx");
            foreach (var x in myData)
            {

                Debug.WriteLine(x + "  L_____________________");
            }

            return Page();
        }
    }
}
