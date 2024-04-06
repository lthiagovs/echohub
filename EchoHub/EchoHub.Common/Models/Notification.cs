using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoHub.Common.Models
{
    public class Notification
    {

        [Key]
        public int Id { get; set; }

        [Required]
        public string Content {  get; set; }

        [ForeignKey("_User")]
        public int UserID {  get; set; }

        public User _User {  get; set; }

    }
}
