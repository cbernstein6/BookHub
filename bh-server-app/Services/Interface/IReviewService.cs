using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bh_server_app.DTOs;

namespace bh_server_app.Services.Interface
{
    public interface IReviewService
    {
        Task<ReviewDTO> GetReviewById(int id);
        Task<IEnumerable<ReviewDTO>> GetReviewsByBookId(int bookId);
        Task<ReviewDTO> CreateReview(ReviewDTO reviewDTO);
        Task<ReviewDTO> UpdateReview(int id, ReviewDTO reviewDTO);
        Task DeleteReview(int id);
    }
}