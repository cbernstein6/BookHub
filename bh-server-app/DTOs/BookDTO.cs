using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bh_server_app.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ImagePath { get; set; }
        public string DownloadUrl { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Series { get; set; }
    }
}