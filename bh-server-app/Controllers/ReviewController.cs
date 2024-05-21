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
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        private readonly IMapper _mapper;

        public ReviewController(IReviewService reviewService, IMapper mapper)
        {
            _reviewService = reviewService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetReview(int id)
        {
            var review = await _reviewService.GetReviewById(id);
            if (review == null)
                return NotFound();

            return Ok(review);
        }

        [HttpGet("book/{bookId}")]
        public async Task<IActionResult> GetReviewsByBookId(int bookId)
        {
            var reviews = await _reviewService.GetReviewsByBookId(bookId);
            return Ok(reviews);
        }

        [HttpPost]
        public async void CreateReview(ReviewDTO reviewDTO)
        {
            var createdReview = await _reviewService.CreateReview(reviewDTO);
            // return CreatedAtAction(nameof(GetReview), new { id = createdReview.Id }, createdReview);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateReview(int id, ReviewDTO reviewDTO)
        {
            var updatedReview = await _reviewService.UpdateReview(id, reviewDTO);
            if (updatedReview == null)
                return NotFound();

            return Ok(updatedReview);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            await _reviewService.DeleteReview(id);
            return NoContent();
        }
    }
}