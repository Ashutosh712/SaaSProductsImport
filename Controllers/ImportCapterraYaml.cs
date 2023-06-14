using System;
using SaaSProductsImport.Model;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;


namespace SaaSProductsImport.Controller
{
    public class ImportCapterraYaml
    {
        public static void ImportCapterraYamlFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);

                // Parse the YAML content
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .Build();

                var products = deserializer.Deserialize<List<Capterra_Yaml>>(content);
                if (products != null)
                {
                    // Import the products
                    foreach (var product in products)
                    {
                        Console.WriteLine($"Importing: Name: \"{product.Name}\"; Tags: {product.Tags}; Twitter: {product.Twitter}");

                    }
                }
                else
                {
                    Console.WriteLine("No record found");

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}

