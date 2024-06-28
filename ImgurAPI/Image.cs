using HttpUtility;
using ImgurAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI
{
    public class Image
    {
        static HttpRequest request = null;

        static Image()
        {
            request = new HttpRequest(ConfigurationManager.AppSettings["key"]);
        }

        public static Task<ImageModel> GetImage(string imageHash)
        {
            return request.GetAsync<ImageModel>($"https://api.imgur.com/3/image/{imageHash}");
        }

        public static Task<AlbumImagesModel> GetAccountImages()
        {
            return request.GetAsync<AlbumImagesModel>("https://api.imgur.com/3/account/me/images");
        }

        public static Task<ImageUpload> UploadImage(string filePath, string fileName, string title, string name, string description = null)
        {
            string url = "https://api.imgur.com/3/upload";
            Stream fileStream = File.OpenRead(filePath);
            StreamContent streamContent = new StreamContent(fileStream);

            MultipartFormDataContent formcontent = new MultipartFormDataContent();
            formcontent.Add(streamContent, "image", fileName);
            formcontent.Add(new StringContent(title), "title");
            formcontent.Add(new StringContent(name), "name");
            formcontent.Add(new StringContent(description), "description");

            return request.PostAsync<ImageUpload>(url, formcontent);
        }

        public static Task<object> ShareImage(string imageID, string title)
        {
            string url = $"https://api.imgur.com/3/gallery/image/{imageID}";

            MultipartFormDataContent formcontent = new MultipartFormDataContent();
            formcontent.Add(new StringContent(title), "title");
            //formcontent.Add(new StringContent("1"), "terms");
            return request.PostAsync<object>(url, formcontent);

        }

        public static Task<string> DeleteImage(string imageHash)
        {
            return request.DeleteAsync($"https://api.imgur.com/3/image/{imageHash}");
        }

    }
}
