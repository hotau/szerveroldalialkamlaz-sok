using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GAMF.Models
{
    public enum Grade { A, B, C, D, F }

    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        [Display(Name = "Tárgy azonosító")]
        public int CourseId { get; set; }
        [Display(Name = "Tanuló azonosító")]
        public int StudentId { get; set; }
        [Display(Name = "Ostályzat ")]
        public Grade? Grade { get; set; }
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

}
