using System.ComponentModel.DataAnnotations;

namespace BootCampWebApi.Models
{
    public class Assessment
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Topic { get; set; } = string.Empty;
    }
}
