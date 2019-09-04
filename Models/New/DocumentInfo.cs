namespace WebApi.Models
{
    public partial class DocumentInfo
    {


        public int Id { get; set; }
        public string NazwaArtykulu { get; set; }
        public float CenaNetto { get; set; }
        public float CenaBrutto { get; set; }
        public int Ilosc { get; set; }
        public int? IdFkd { get; set; }
        public int? IdFkt { get; set; }

        //public ICollection<DocumentsThings> DocumentsThings { get; set; }
        //public ICollection<DocumentsThings> Things { get; set; }

    }
}
