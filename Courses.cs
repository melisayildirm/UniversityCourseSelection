using System.ComponentModel.DataAnnotations;

namespace UniversityCourseSelection.Models
{
    public class Courses
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseCode { get; set; }
        public bool IsMandatory { get; set; }
        public int Credit { get; set; }
        public string Department { get; set; }
        public ICollection<StudentCourseSelections> StudentCourseSelections { get; set; } = new List<StudentCourseSelections>();
    }
}
