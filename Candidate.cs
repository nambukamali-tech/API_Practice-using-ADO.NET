using System.ComponentModel.DataAnnotations;

namespace ADO.NET_APP.Models
{
    public class Candidate
    {
        [Key]
        public int CandidateID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Stack { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}
