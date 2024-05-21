using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bh_server_app.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        public string Message { get; set; }
        public int Likes { get; set; }
        public int BookId { get; set; }
    }
}