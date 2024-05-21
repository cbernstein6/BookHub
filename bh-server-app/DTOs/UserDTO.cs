using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bh_server_app.DTOs
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public List<string> Genres { get; set; }
        public int FavouritesCount { get; set; }
        public int ReadingCount { get; set; }
    }
}