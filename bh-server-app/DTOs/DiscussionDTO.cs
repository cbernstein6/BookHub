using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bh_server_app.DTOs
{
    public class DiscussionDTO
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}