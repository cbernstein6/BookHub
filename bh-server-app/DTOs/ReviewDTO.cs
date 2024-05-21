using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bh_server_app.DTOs
{
    public class ReviewDTO
    {
        public int Score { get; set; }
        public string Message { get; set; }
        public int Likes { get; set; }
        public int BookId { get; set; }
    }
}