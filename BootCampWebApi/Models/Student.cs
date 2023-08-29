using System.ComponentModel.DataAnnotations;

namespace BootCampWebApi.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = String.Empty;
        [StringLength(30)]
        public string Email { get; set; } = String.Empty;
        [StringLength(30)]
        public string Phone { get; set; } = String.Empty;
    }
}
