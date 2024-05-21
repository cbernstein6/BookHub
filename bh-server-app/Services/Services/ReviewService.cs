using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using bh_server_app.DTOs;
using bh_server_app.Models;
using bh_server_app.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace bh_server_app.Services
{
    public class ReviewService : IReviewService
    {
        private readonly BookDbContext _context;
        private readonly IMapper _mapper;

        public ReviewService(BookDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ReviewDTO> GetReviewById(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            return _mapper.Map<ReviewDTO>(review);
        }

        public async Task<IEnumerable<ReviewDTO>> GetReviewsByBookId(int bookId)
        {
            var reviews = await _context.Reviews
                .Where(r => r.BookId == bookId)
                .ToListAsync();
            return _mapper.Map<IEnumerable<ReviewDTO>>(reviews);
        }

        public async Task<ReviewDTO> CreateReview(ReviewDTO reviewDTO)
        {
            var review = _mapper.Map<Review>(reviewDTO);
            _context.Reviews.Add(review);
            await _context.SaveChangesAsync();
            return _mapper.Map<ReviewDTO>(review);
        }

        public async Task<ReviewDTO> UpdateReview(int id, ReviewDTO reviewDTO)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null)
                return null;

            _mapper.Map(reviewDTO, review);
            await _context.SaveChangesAsync();
            return _mapper.Map<ReviewDTO>(review);
        }

        public async Task DeleteReview(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review != null)
            {
                _context.Reviews.Remove(review);
                await _context.SaveChangesAsync();
            }
        }
    }
}