using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public partial class Documents
    {
        public Documents()
        {
            DocumentsThings = new HashSet<DocumentsThings>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdFku { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić numer klienta.")]
        public int? NumerKlienta { get; set; }
        [Required]
        public DateTime DataDokumentu { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić nazwę dokumentu.")]
        public string Nazwa { get; set; }

        //public virtual Users Users { get; set; }
        public Users IdFkuNavigation { get; set; }
        public ICollection<DocumentsThings> DocumentsThings { get; set; }
    }
}
