using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace GAMF.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseId { get; set; }
        [Display(Name = "Tárgy megnevezése")]
        [Required(ErrorMessage = "Tárgy megnevezése kitöltése kötelező!")]
        public string Title { get; set; }
        [Display(Name = "Tárgy kreditszám")]
        [Required(ErrorMessage = "Tárgy kreditszám kitöltése kötelező!")]
        public int Credits { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }

}
