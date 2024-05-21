using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bh_server_app.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public List<string> Genres { get; set; }
        public List<Book> Favourites { get; set; }
        public int ReadingCount { get; set; }
    

    }
}