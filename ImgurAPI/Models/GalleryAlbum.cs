﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImgurAPI.Models
{
    public class GalleryAlbum
    {
        public Data data { get; set; }
        public bool success { get; set; }
        public int status { get; set; }

        public class Data
        {
            public string id { get; set; }
            public string title { get; set; }
            public object description { get; set; }
            public int datetime { get; set; }
            public string cover { get; set; }
            public int cover_width { get; set; }
            public int cover_height { get; set; }
            public string account_url { get; set; }
            public int account_id { get; set; }
            public string privacy { get; set; }
            public string layout { get; set; }
            public int views { get; set; }
            public string link { get; set; }
            public int ups { get; set; }
            public int downs { get; set; }
            public int points { get; set; }
            public int score { get; set; }
            public bool is_album { get; set; }
            public object vote { get; set; }
            public bool favorite { get; set; }
            public bool nsfw { get; set; }
            public string section { get; set; }
            public int comment_count { get; set; }
            public int favorite_count { get; set; }
            public object topic { get; set; }
            public object topic_id { get; set; }
            public int images_count { get; set; }
            public bool in_gallery { get; set; }
            public bool is_ad { get; set; }
            public object[] tags { get; set; }
            public int ad_type { get; set; }
            public string ad_url { get; set; }
            public bool in_most_viral { get; set; }
            public bool include_album_ads { get; set; }
            public Image[] images { get; set; }
            public Ad_Config ad_config { get; set; }
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
            public float nsfw_score { get; set; }
        }

        public class Image
        {
            public string id { get; set; }
            public object title { get; set; }
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
            public object nsfw { get; set; }
            public object section { get; set; }
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
            public object comment_count { get; set; }
            public object favorite_count { get; set; }
            public object ups { get; set; }
            public object downs { get; set; }
            public object points { get; set; }
            public object score { get; set; }
        }

    }
}
