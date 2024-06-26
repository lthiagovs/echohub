﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoHub.Common.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("_Chat")]
        public int ChatId { get; set; }

        public Chat _Chat { get; set; }

        [ForeignKey("_User")]
        public int UserID {  get; set; }

        public User _User {  get; set; }

    }

}
