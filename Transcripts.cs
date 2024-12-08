using System.ComponentModel.DataAnnotations;

namespace UniversityCourseSelection.Models
{
    public class Transcripts
    {
        [Key]
        public int TranscriptsID { get; set; }
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public double Grade { get; set; }
        public string Semester { get; set; }

        public Students Student { get; set; }
        public Courses Course { get; set; }
    }
}
