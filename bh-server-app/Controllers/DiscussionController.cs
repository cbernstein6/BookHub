using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using bh_server_app.DTOs;
using bh_server_app.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace bh_server_app.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DiscussionController : ControllerBase
    {
        private readonly IDiscussionService _discussionService;
        private readonly IMapper _mapper;

        public DiscussionController(IDiscussionService discussionService, IMapper mapper)
        {
            _discussionService = discussionService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscussion(int id)
        {
            var discussion = await _discussionService.GetDiscussionById(id);
            if (discussion == null)
                return NotFound();

            return Ok(discussion);
        }

        [HttpGet("book/{bookId}")]
        public async Task<IActionResult> GetDiscussionsByBookId(int bookId)
        {
            var discussions = await _discussionService.GetDiscussionsByBookId(bookId);
            return Ok(discussions);
        }

        [HttpPost]
        public DiscussionDTO CreateDiscussion(DiscussionDTO discussionDTO)
        {
            var createdDiscussion = _discussionService.CreateDiscussion(discussionDTO);
            return createdDiscussion;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDiscussion(int id, DiscussionDTO discussionDTO)
        {
            var updatedDiscussion = await _discussionService.UpdateDiscussion(id, discussionDTO);
            if (updatedDiscussion == null)
                return NotFound();

            return Ok(updatedDiscussion);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscussion(int id)
        {
            await _discussionService.DeleteDiscussion(id);
            return NoContent();
        }
    }
}