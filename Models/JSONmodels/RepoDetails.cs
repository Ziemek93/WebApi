using System.Runtime.Serialization;

namespace WebApi.Models
{
    public partial class RepoDetails //model do przechowywania danych JSON
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created_at")]
        public string Created_at { get; set; }

        [DataMember(Name = "pushed_at")]
        public string Pushed_at { get; set; }



        //public override string ToString()
        //{
        //    return $"Name: {Name} \n Created at: {Created_at} \n Pushed at {Pushed_at}";
        //}
    }
}
