using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlashIo.Models
{
    public class OgPropertySet
    {
        private string _ogurl;
        private string _ogtype;
        private string _ogtitle;
        private string _ogDescription;
        private string _ogImage;

        public string Ogurl { get => _ogurl; set => _ogurl = value; }
        public string Ogtype { get => _ogtype; set => _ogtype = value; }
        public string Ogtitle { get => _ogtitle; set => _ogtitle = value; }
        public string OgDescription { get => _ogDescription; set => _ogDescription = value; }
        public string OgImage { get => _ogImage; set => _ogImage = value; }
    }
}