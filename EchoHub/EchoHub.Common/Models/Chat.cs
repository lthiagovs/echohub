using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoHub.Common.Models
{
    public class Chat
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("_Server")]
        public int ServerId { get; set; }

        public HubServer _Server { get; set; }


    }

}
