using System.ComponentModel.DataAnnotations;

namespace CourseApp.Web.Models
{
    public class Student
    {
        [Required(ErrorMessage ="İsim giriniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email adresi giriniz.")]
        [EmailAddress(ErrorMessage ="Email formatına uygun giriniz")]
        public string Mail { get; set; }
        [Required(ErrorMessage = "Telefon numarası giriniz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Kursa katılma durumu giriniz")]
        public bool? WillAttend { get; set; }
    }
}
