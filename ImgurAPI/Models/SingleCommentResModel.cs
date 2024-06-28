using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ImgurAPI.Models.CommentResModel;

namespace ImgurAPI.Models
{
    public class SingleCommentResModel
    {
        public Comments data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }


    }
}
