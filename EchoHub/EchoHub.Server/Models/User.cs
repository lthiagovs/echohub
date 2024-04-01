using System.ComponentModel.DataAnnotations;

namespace EchoHub.Server.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }


    }

}
