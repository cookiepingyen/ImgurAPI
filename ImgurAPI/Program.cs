using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ImgurAPI.Enums;
using ImgurAPI.Models;
namespace ImgurAPI
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            #region GallerySearch
            Task<GalleryModel> galleryModel = Gallery.SearchGalleryByCondition("cats", 1, GallerySortType.top, GalleryWindowType.year);
            string result = (await galleryModel).data[0].title;

            Console.WriteLine(result);
            #endregion

            #region GetImage
            //ImageModel imageModel = await Image.GetImage("BDBZ083");

            //Console.WriteLine(imageModel.data.id);
            #endregion

            #region UploadImage
            //ImageUpload imageUpload = await Image.UploadImage("C:\\Users\\user\\Downloads\\main.png", "capabara", "capabara", "name", "the image of capybara");

            //Console.WriteLine(imageUpload.data.id);
            #endregion

            #region DeleteImage
            //string result = await Image.DeleteImage("5IS6xq7");
            //Console.WriteLine(result);
            #endregion

            #region Vote
            //var res = await Vote.VoteImag("xeIivGK", VoteTypes.up);
            //Console.WriteLine(res.status);
            #endregion

            #region CreateComment
            //CommentRequestModel commentRequestModel = new CommentRequestModel("7rGoVzF", "test");
            //var res = await Comment.CreateComment(commentRequestModel);
            //Console.WriteLine(res.status);
            #endregion

            #region CommentInComment
            //CommentRequestModel commentRequestModel = new CommentRequestModel("7rGoVzF", "test0214", "2379750313");
            //var res = await Comment.CreateComment(commentRequestModel);
            //Console.WriteLine(res.status);
            #endregion

            #region CommentReply
            //CommentRequestModel commentRequestModel = new CommentRequestModel("7rGoVzF", "reply test 0214");
            //var res = await Comment.CommentReply("2379751041", commentRequestModel);
            //Console.WriteLine(res.status);
            #endregion

            #region CommentDeletion
            //var res = await Comment.CommentDeletion("2376804532");
            //Console.WriteLine(res.status);
            #endregion

            Console.ReadKey();
        }
    }
}
