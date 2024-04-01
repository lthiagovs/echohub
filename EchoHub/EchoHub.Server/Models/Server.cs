using System.ComponentModel.DataAnnotations;

namespace EchoHub.Server.Models
{
    public class Server
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }



    }

}
