using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using bh_server_app.DTOs;
using bh_server_app.Models;
using bh_server_app.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace bh_server_app.Services.Services
{
    public class DiscussionService : IDiscussionService
    {
        private readonly BookDbContext _context;
        private readonly IMapper _mapper;

        public DiscussionService(BookDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<DiscussionDTO> GetDiscussionById(int id)
        {
            var discussion = await _context.Discussions.FindAsync(id);
            return _mapper.Map<DiscussionDTO>(discussion);
        }

        public async Task<IEnumerable<DiscussionDTO>> GetDiscussionsByBookId(int bookId)
        {
            var discussions = await _context.Discussions
                .Where(d => d.BookId == bookId)
                .ToListAsync();
            return _mapper.Map<IEnumerable<DiscussionDTO>>(discussions);
        }
        
        public void GetDiscussionsByUserId(int userId)
        {
            // var discussions = await _context.Discussions
            //     .Where(d => d.UserId == userId)
            //     .ToListAsync();
            // return _mapper.Map<IEnumerable<DiscussionDTO>>(discussions);
        }

        public async Task<DiscussionDTO> CreateDiscussion(DiscussionDTO discussionDTO)
        {
            var discussion = _mapper.Map<Discussion>(discussionDTO);
            _context.Discussions.Add(discussion);
            await _context.SaveChangesAsync();
            return _mapper.Map<DiscussionDTO>(discussion);
        }

        public async Task<DiscussionDTO> UpdateDiscussion(int id, DiscussionDTO discussionDTO)
        {
            var discussion = await _context.Discussions.FindAsync(id);
            if (discussion == null)
                return null;

            _mapper.Map(discussionDTO, discussion);
            await _context.SaveChangesAsync();
            return _mapper.Map<DiscussionDTO>(discussion);
        }

        public async Task DeleteDiscussion(int id)
        {
            var discussion = await _context.Discussions.FindAsync(id);
            if (discussion != null)
            {
                _context.Discussions.Remove(discussion);
                await _context.SaveChangesAsync();
            }
        }
    }
}