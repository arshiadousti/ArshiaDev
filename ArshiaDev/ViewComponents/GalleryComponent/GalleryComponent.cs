using ArshiaDev.Core.Interfaces;
using ArshiaDev.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArshiaDev.ViewComponents.GalleryComponent
{
    public class GalleryComponent:ViewComponent
    {
        IGallery galleryRepository;
        public GalleryComponent(IGallery _gallery)
        {
            galleryRepository = _gallery;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            IEnumerable<Gallery> galleries = await galleryRepository.GetGalleriesByPostId(id);
            return await Task.FromResult((IViewComponentResult)View("GalleryComponent", galleries));
        }
    }
}
