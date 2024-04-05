using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoHub.Common.Models
{
    public class UserServer
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("_User")]
        public int UserId { get; set; }

        [ForeignKey("_Server")]
        public int ServerId { get; set; }

        public User _User { get; set; }

        public HubServer _Server { get; set; }

    }

}
