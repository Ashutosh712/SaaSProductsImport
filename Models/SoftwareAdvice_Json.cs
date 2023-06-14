using System;
using Newtonsoft.Json;

namespace SaaSProductsImport.Model
{
    public class SoftwareAdvice_Json
    {
        private string[] categories = Array.Empty<string>();
        private string twitter = string.Empty;
        private string title = string.Empty;

        [JsonProperty("categories")]
        public string[] Categories
        {
            get { return categories; }
            set { categories = value ?? Array.Empty<string>(); }
        }

        [JsonProperty("twitter")]
        public string Twitter
        {
            get { return twitter; }
            set { twitter = value ?? string.Empty; }
        }

        [JsonProperty("title")]
        public string Title
        {
            get { return title; }
            set { title = value ?? string.Empty; }
        }

    }
    public class RootObject
    {
        public SoftwareAdvice_Json[]? Products { get; set; }
    }
}
