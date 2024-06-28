using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    public class ImageModel
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }

        public class Data
        {
            public string id { get; set; }
            public object title { get; set; }
            public object description { get; set; }
            public int datetime { get; set; }
            public string type { get; set; }
            public bool animated { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int size { get; set; }
            public int views { get; set; }
            public long bandwidth { get; set; }
            public object vote { get; set; }
            public bool favorite { get; set; }
            public bool nsfw { get; set; }
            public string section { get; set; }
            public object account_url { get; set; }
            public object account_id { get; set; }
            public bool is_ad { get; set; }
            public bool in_most_viral { get; set; }
            public bool has_sound { get; set; }
            public object[] tags { get; set; }
            public int ad_type { get; set; }
            public string ad_url { get; set; }
            public string edited { get; set; }
            public bool in_gallery { get; set; }
            public string link { get; set; }
            public int mp4_size { get; set; }
            public string mp4 { get; set; }
            public string gifv { get; set; }
            public string hls { get; set; }
            public Processing processing { get; set; }
            public Ad_Config ad_config { get; set; }
        }

        public class Processing
        {
            public string status { get; set; }
        }

        public class Ad_Config
        {
            public string[] safeFlags { get; set; }
            public object[] highRiskFlags { get; set; }
            public object[] unsafeFlags { get; set; }
            public object[] wallUnsafeFlags { get; set; }
            public bool showsAds { get; set; }
            public int showAdLevel { get; set; }
            public string[] safe_flags { get; set; }
            public object[] high_risk_flags { get; set; }
            public object[] unsafe_flags { get; set; }
            public object[] wall_unsafe_flags { get; set; }
            public bool show_ads { get; set; }
            public int show_ad_level { get; set; }
            public int? nsfw_score { get; set; }
        }

    }
}
