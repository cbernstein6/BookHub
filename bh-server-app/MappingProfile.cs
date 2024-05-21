using AutoMapper;
using bh_server_app.DTOs;
using bh_server_app.Models;

namespace bh_server_app.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Review, ReviewDTO>().ReverseMap();
            CreateMap<Discussion, DiscussionDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Book, BookDTO>().ReverseMap();
        }
    }
}