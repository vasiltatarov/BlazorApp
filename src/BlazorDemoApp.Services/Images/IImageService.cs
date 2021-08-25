namespace BlazorDemoApp.Services.Images
{
    using System.Collections.Generic;
    using Models;

    public interface IImageService
    {
        IEnumerable<ImageServiceModel> GetAll();
    }
}
