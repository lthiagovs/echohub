﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EchoHub.Server.Models
{
    class Message
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [ForeignKey("_Chat")]
        public int ChatId {  get; set; }

        public int _Chat {  get; set; }

    }

}
