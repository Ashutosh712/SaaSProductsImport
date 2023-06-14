using System;
using YamlDotNet.Serialization;

namespace SaaSProductsImport.Model
{
    public class Capterra_Yaml
    {
        private string name = string.Empty;
        private string tags = string.Empty;
        private string twitter = string.Empty;

        [YamlMember(Alias = "name")]
        public string Name
        {
            get { return name; }
            set { name = value ?? string.Empty; }
        }
        [YamlMember(Alias = "twitter")]
        public string Twitter
        {
            get { return twitter; }
            set { twitter = value ?? string.Empty; }
        }

        [YamlMember(Alias = "tags")]
        public string Tags
        {
            get { return tags; }
            set { tags = value ?? string.Empty; }
        }
    }
}
