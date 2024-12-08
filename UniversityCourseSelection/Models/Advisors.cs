using System.ComponentModel.DataAnnotations;

namespace UniversityCourseSelection.Models
{
    public class Advisors
    {
        [Key]
        public int AdvisorsID { get; set; }
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public ICollection<Students> Student { get; set; }
    }
}
