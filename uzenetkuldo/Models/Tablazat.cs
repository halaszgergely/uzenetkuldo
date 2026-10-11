using System.Runtime.Serialization;

namespace uzenetkuldo.Models
{
    [DataContract]
    public class Tablazat
    {
        [DataMember]
        public int Id { get; set; }
    }
}