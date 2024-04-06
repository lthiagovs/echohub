using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoHub.Common.Models
{
    public class Friend
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("_User")]
        public int UserID { get; set; }

        [ForeignKey("_Friend")]
        public int FriendID {  get; set; }

        public User _User {  get; set; }

        public User _Friend {  get; set; }

    }

}
