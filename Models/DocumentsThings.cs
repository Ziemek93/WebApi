using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public partial class DocumentsThings
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdFkd { get; set; }
        public int? IdFkt { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić prawidłową ilość.")]
        public int Ilosc { get; set; }

        public Documents IdFkdNavigation { get; set; }
        public Things IdFktNavigation { get; set; }

        //public virtual Documents Documents { get; set; }
        //public virtual Things Things { get; set; }

    }
}
