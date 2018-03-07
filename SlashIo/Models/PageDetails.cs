using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlashIo.Models
{
    public class PageDetails
    {
        private string _currentPrefix;

        private bool _imagesAreUrlProvided;

        private OgPropertySet _propSet;

        private List<string> _imageUrls;


        public string CurrentPrefix { get => _currentPrefix; set => _currentPrefix = value; }
        public bool ImagesAreUrlProvided { get => _imagesAreUrlProvided; set => _imagesAreUrlProvided = value; }
        public List<string> ImageUrls { get => _imageUrls; set => _imageUrls = value; }
        public OgPropertySet PropSet { get => _propSet; set => _propSet = value; }
    }
}