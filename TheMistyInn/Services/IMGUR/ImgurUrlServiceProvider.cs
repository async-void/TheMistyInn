using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMistyInn.Services.IMGUR
{
    public class ImgurUrlServiceProvider
    {
        public static Dictionary<string, string> Links { get; set; } = new()
        {
            { "not_found", "https://i.imgur.com/BlC9X8b.png" },
            { "alchemy", "https://i.imgur.com/WT70IY8.png" },
            { "blacksmith", "https://i.imgur.com/d8iyOOT.png" },
            { "fishing", "https://i.imgur.com/7fGCMRl.png" },
            { "diplomacy", "https://i.imgur.com/BnbpwkP.png" },
            { "carpentry", "https://i.imgur.com/IjklWIl.png" },
            { "farming", "https://i.imgur.com/1PicRiS.png" },
            { "tailoring", "https://i.imgur.com/9heG2ue.png" },
            { "hunting", "https://i.imgur.com/q1M5PsM.png" },
            { "mining", "https://i.imgur.com/RDqF31P.png" }
        };

        public static string GetLinkPath(string name)
        {
            return Links.TryGetValue(name, out var path) ? path : Links["not_found"];
        }
    }
}
