using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bh_server_app.DTOs;

namespace bh_server_app.Services.Interface
{
    public interface IDiscussionService
    {
        Task<DiscussionDTO> GetDiscussionById(int id);
        // Task<IEnumerable<DiscussionDTO>> GetDiscussionsByUserId(int userId);
        void GetDiscussionsByUserId(int userId);
        Task<IEnumerable<DiscussionDTO>> GetDiscussionsByBookId(int bookId);
        DiscussionDTO CreateDiscussion(DiscussionDTO discussionDTO);
        Task<DiscussionDTO> UpdateDiscussion(int id, DiscussionDTO discussionDTO);
        Task DeleteDiscussion(int id);
    }
}