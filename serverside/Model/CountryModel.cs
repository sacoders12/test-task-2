using serverside.Core;
using System;

namespace serverside.Model
{
    public class CountryModel : BaseModel
    {
        public string uuid { get; set; }    
        public string name { get; set; }
        public int longtitude { get; set; }
        public int latitude { get; set; }
    }
}
