using System.ComponentModel.DataAnnotations;

namespace EchoHub.Common.Models
{
    public class HubServer
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }



    }

}
