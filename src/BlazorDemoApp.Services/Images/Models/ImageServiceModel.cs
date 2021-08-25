namespace BlazorDemoApp.Services.Images.Models
{
    using System;

    public class ImageServiceModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string User { get; set; }

        public DateTime CreatedOn { get; set; }

        public int LikeCount { get; set; }
    }
}
