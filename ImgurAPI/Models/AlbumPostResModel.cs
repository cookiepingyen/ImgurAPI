using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    public class AlbumPostResModel
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }


        public class Data
        {
            public string id { get; set; }
            public string deletehash { get; set; }
        }

    }
}
