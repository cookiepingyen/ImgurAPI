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
    public class Vote
    {
        static HttpRequest request = null;
        static Vote()
        {
            request = new HttpRequest(ConfigurationManager.AppSettings["key"]);
        }

        public static Task<PostResModel> VoteImag(string galleryHash, VoteTypes vote)
        {
            string url = $"https://api.imgur.com/3/gallery/{galleryHash}/vote/{vote.ToString()}";
            return request.PostAsync<PostResModel>(url);

        }

    }
}
