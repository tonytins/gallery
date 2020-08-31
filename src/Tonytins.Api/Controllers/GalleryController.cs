using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tonytins.Models;

namespace Tonytins.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GalleryController : ControllerBase
    {
        [HttpGet]
        public async Task<GalleryModel[]> Get()
        {
            var lstGallery = new List<GalleryModel>();
            var db = DataAccess.Firestore;
            var col = db.Collection("gallery");

            var galleryQuerySnapshot = await col.GetSnapshotAsync();
            foreach (var gallerySnapshot in galleryQuerySnapshot)
            {
                if (gallerySnapshot.Exists)
                {
                    var image = gallerySnapshot.ToDictionary();
                    var fireModel = JsonSerializer.Serialize(image);
                    var newModel = JsonSerializer.Deserialize<GalleryModel>(fireModel);
                    lstGallery.Add(newModel);
                }
            }

            return lstGallery.ToArray();
        }
    }
}
