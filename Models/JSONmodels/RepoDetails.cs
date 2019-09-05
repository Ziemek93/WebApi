using System.Runtime.Serialization;

namespace WebApi.Models
{
    [DataContract]
    public partial class RepoDetails
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "created_at")]
        public string Created_at { get; set; }

        [DataMember(Name = "pushed_at")]
        public string Pushed_at { get; set; }

    }
}
