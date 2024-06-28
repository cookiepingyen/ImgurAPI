using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    public class GalleryImage
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }

        public class Data
        {
            public string id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
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
            public string account_url { get; set; }
            public int account_id { get; set; }
            public bool is_ad { get; set; }
            public bool in_most_viral { get; set; }
            public bool has_sound { get; set; }
            public Tag[] tags { get; set; }
            public int ad_type { get; set; }
            public string ad_url { get; set; }
            public int edited { get; set; }
            public bool in_gallery { get; set; }
            public object topic { get; set; }
            public int topic_id { get; set; }
            public string link { get; set; }
            public int mp4_size { get; set; }
            public string mp4 { get; set; }
            public string gifv { get; set; }
            public string hls { get; set; }
            public Processing processing { get; set; }
            public Ad_Config ad_config { get; set; }
            public int comment_count { get; set; }
            public int favorite_count { get; set; }
            public int ups { get; set; }
            public int downs { get; set; }
            public int points { get; set; }
            public int score { get; set; }
            public bool is_album { get; set; }
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
            public int nsfw_score { get; set; }
        }

        public class Tag
        {
            public string name { get; set; }
            public string display_name { get; set; }
            public int followers { get; set; }
            public int total_items { get; set; }
            public bool following { get; set; }
            public bool is_whitelisted { get; set; }
            public string background_hash { get; set; }
            public object thumbnail_hash { get; set; }
            public object accent { get; set; }
            public bool background_is_animated { get; set; }
            public bool thumbnail_is_animated { get; set; }
            public bool is_promoted { get; set; }
            public string description { get; set; }
            public object logo_hash { get; set; }
            public object logo_destination_url { get; set; }
            public Description_Annotations description_annotations { get; set; }
        }

        public class Description_Annotations
        {
        }

    }
}
