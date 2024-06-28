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
    public class Comment
    {
        static HttpRequest request = null;

        static Comment()
        {
            request = new HttpRequest(ConfigurationManager.AppSettings["Key"]);
        }

        public static Task<CommentResModel> GetImageComments(string id, CommentSortType type = CommentSortType.BEST)
        {
            string url = $"https://api.imgur.com/3/gallery/{id}/comments/{type.ToString().ToLower()}";
            return request.GetAsync<CommentResModel>(url);
        }

        public static Task<SingleCommentResModel> GetSingleComment(string commentid)
        {
            string url = $"https://api.imgur.com/3/comment/{commentid}";
            return request.GetAsync<SingleCommentResModel>(url);
        }
        public static Task<PostResModel> CreateComment(CommentRequestModel commentRequest)
        {
            string url = "https://api.imgur.com/3/comment";
            return request.PostAsync<PostResModel>(url, commentRequest);
        }

        public static Task<PostResModel> CommentInComment(CommentRequestModel commentRequest)
        {
            string url = "https://api.imgur.com/3/comment";
            return request.PostAsync<PostResModel>(url, commentRequest);
        }

        public static Task<PostResModel> CommentReply(string commentID, CommentRequestModel commentRequest)
        {
            string url = $"https://api.imgur.com/3/comment/{commentID}";
            return request.PostAsync<PostResModel>(url, commentRequest);
        }

        public static Task<PostResModel> CommentDeletion(string commentID)
        {
            string url = $"https://api.imgur.com/3/comment/{commentID}";
            return request.DeleteAsync<PostResModel>(url);
        }

        public static Task<PostResModel> CommentVote(string commentID, VoteTypes voteTypes)
        {
            string url = $"https://api.imgur.com/3/comment/{commentID}/vote/{voteTypes}";
            return request.PostAsync<PostResModel>(url);
        }

    }
}
