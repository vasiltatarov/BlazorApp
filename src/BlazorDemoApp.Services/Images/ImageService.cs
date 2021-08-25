namespace BlazorDemoApp.Services.Images
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Models;

    public class ImageService : IImageService
    {
        private readonly ApplicationDbContext _data;

        public ImageService(ApplicationDbContext data)
            => _data = data;

        public IEnumerable<ImageServiceModel> GetAll()
            => _data
                .Images
                .OrderByDescending(x => x.CreatedOn)
                .Select(x => new ImageServiceModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    User = x.User.UserName,
                    CreatedOn = x.CreatedOn,
                    LikeCount = x.Likes.Count(l => l.IsActive),
                })
                .ToList();
    }
}
