using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    public class CommentRequestModel
    {
        public string image_id { get; set; }
        public string comment { get; set; }

        public string parent_id { get; set; }

        public CommentRequestModel(string ID, string comment)
        {
            this.image_id = ID;
            this.comment = comment;
        }

        public CommentRequestModel(string ID, string comment, string parent_id)
        {
            this.image_id = ID;
            this.comment = comment;
            this.parent_id = parent_id;
        }
    }
}
