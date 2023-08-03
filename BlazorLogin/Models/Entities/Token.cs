using System.ComponentModel.DataAnnotations;

namespace BlazorLogin.Models.Entities
{
    public class Token
    {
        public int Id { get; set; }

        [Required]
        public string TokenJWT { get; set; }

        [Required]
        public DateTime Vigencia { get; set; }
    }
}
