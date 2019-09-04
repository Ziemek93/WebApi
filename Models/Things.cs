using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public partial class Things
    {
        public Things()
        {
            DocumentsThings = new HashSet<DocumentsThings>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić nazwę PRODUKTU.")]
        public string NazwaArtykulu { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić cenę NETTO.")]
        public float CenaNetto { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić cenę BRUTTO.")]
        public float CenaBrutto { get; set; }

        public ICollection<DocumentsThings> DocumentsThings { get; set; }


    }
}
