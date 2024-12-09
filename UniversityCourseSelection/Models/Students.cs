using System.ComponentModel.DataAnnotations;

namespace UniversityCourseSelection.Models
{
    public class Students
    {
        [Key]
            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public int AdvisorsID { get; set; }
            public DateTime EnrollmentDate { get; set; }
           public Advisors Advisor { get; set; }
         public ICollection<StudentCourseSelections> StudentCourseSelection { get; set; } = new List<StudentCourseSelections>();
    }
}
