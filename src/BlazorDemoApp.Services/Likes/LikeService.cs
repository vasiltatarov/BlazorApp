namespace BlazorDemoApp.Services.Likes
{
    using System.Linq;
    using System.Threading.Tasks;
    using Data;
    using Data.Models;

    public class LikeService : ILikeService
    {
        private readonly ApplicationDbContext _data;

        public LikeService(ApplicationDbContext data)
            => _data = data;

        public async Task Like(int imageId, string userId)
        {
            var like = _data.Likes.FirstOrDefault(x => x.ImageId == imageId && x.UserId == userId);

            if (like == null)
            {
                like = new Like
                {
                    ImageId = imageId,
                    UserId = userId,
                    IsActive = true,
                };

                await _data.Likes.AddAsync(like);
            }
            else
            {
                like.IsActive = !like.IsActive;
            }


            await _data.SaveChangesAsync();
        }
    }
}
