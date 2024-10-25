using Backend.Services;

namespace Backend.DTOs
{
    public interface IPostService
    {
        public Task<IEnumerable<PostDto>> Get();
    }
}
