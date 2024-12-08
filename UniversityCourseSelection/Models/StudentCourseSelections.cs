using System.ComponentModel.DataAnnotations;

namespace UniversityCourseSelection.Models
{
    public class StudentCourseSelections
    {
        [Key]
        public int SelectionID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public DateTime SelectionDate { get; set; }
        public bool IsApproved { get; set; }

        public Students Student { get; set; }
        public Courses Course { get; set; }
      
    }
}
