﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.SocialMediaDto
{
    public class GetSocialMediaDto
    {
        public int Social_Media_ID { get; set; }
        public string? Social_Media_Title { get; set; }
        public string? Social_Media_Url { get; set; }
        public string? Social_Media_Icon { get; set; }
    }
}