using HttpUtility;
using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ImgurAPI
{
    public class Album
    {
        static HttpRequest request = null;


        static Album()
        {
            request = new HttpRequest(ConfigurationManager.AppSettings["Key"]);
        }


        public static Task<AlbumModel> GetAlbum(string albumHash)
        {
            return request.GetAsync<AlbumModel>($"https://api.imgur.com/3/image/{albumHash}");
        }

        public static Task<AlbumsModel> GetAlbums(string userName)
        {
            return request.GetAsync<AlbumsModel>($"https://api.imgur.com/3/account/{userName}/albums");
        }

        public static Task<AlbumImagesModel> GetAlbumImages(string albumHash)
        {
            return request.GetAsync<AlbumImagesModel>($"https://api.imgur.com/3/album/{albumHash}/images");
        }

        public static Task<AlbumPostResModel> PostAlbum(string albumTitle, params string[] ids)
        {
            string url = "https://api.imgur.com/3/album";


            MultipartFormDataContent formcontent = new MultipartFormDataContent();
            formcontent.Add(new StringContent(albumTitle), "title");
            foreach (string id in ids)
            {
                formcontent.Add(new StringContent(id), "ids[]");
            }
            return request.PostAsync<AlbumPostResModel>(url, formcontent);

        }

        public static Task<string> AddPostToAlbum(string albumHash, string imageId)
        {
            string url = $"https://api.imgur.com/3/album/{albumHash}/add";
            MultipartFormDataContent formcontent = new MultipartFormDataContent();
            formcontent.Add(new StringContent(imageId), "ids[]");
            return request.PostAsync<string>(url, formcontent);
        }

    }
}
