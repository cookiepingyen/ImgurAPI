using HttpUtility;
using ImgurAPI.Enums;
using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImgurAPI
{
    public class Gallery
    {
        static HttpRequest request = null;
        static Gallery()
        {
            request = new HttpRequest(ConfigurationManager.AppSettings["key"]);
        }
        public static Task<GalleryModel> SearchGallery(int page)
        {
            string url = $"https://api.imgur.com/3/gallery/hot/viral/top/{page}";
            return request.GetAsync<GalleryModel>(url);
        }

        //public static Task<GalleryModel> SearchGalleryByCondition(int page, bool showViral = false, bool mature = false, bool album_previews = false)
        //{
        //    string url = $"https://api.imgur.com/3/gallery/hot/viral/top/{page}";

        //    Dictionary<string, string> dictionary = new Dictionary<string, string>();
        //    dictionary.Add("showViral", showViral.ToString());
        //    dictionary.Add("mature", mature.ToString());
        //    dictionary.Add("album_previews", album_previews.ToString());

        //    return request.GetAsync<GalleryModel>(url, dictionary);
        //}

        public static Task<GalleryModel> SearchGalleryByCondition(string q, int page, GallerySortType sort, GalleryWindowType window = GalleryWindowType.all)
        {
            string url = $"https://api.imgur.com/3/gallery/search/{sort}/{window}/{page}?q={q}";
            return request.GetAsync<GalleryModel>(url);
        }


        public static Task<GalleryAlbum> GetAlbum(string galleryHash)
        {
            string url = $"https://api.imgur.com/3/gallery/album/{galleryHash}";
            return request.GetAsync<GalleryAlbum>(url);
        }

        public static Task<GalleryImage> GetImage(string galleryImageHash)
        {
            string url = $"https://api.imgur.com/3/gallery/album/{galleryImageHash}";
            return request.GetAsync<GalleryImage>(url);
        }
    }
}
