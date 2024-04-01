using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoHub.Server.Models
{
    public class ChatServer
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("_Chat")]
        public int ChatId {  get; set; }

        [ForeignKey("_Server")]
        public int ServerId {  get; set; }

        public Chat _Chat { get; set; }

        public Server _Server { get; set; }

    }

}
