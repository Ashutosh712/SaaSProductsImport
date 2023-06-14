using Newtonsoft.Json;
using SaaSProductsImport.Model;
using System;


namespace SaaSProductsImport.Controller
{
    public class ImportSoftwareAdviceJson
    {
        public static void ImportSoftwareAdviceJsonFile(string filePath)
        {
            try
            {
                string content = File.ReadAllText(filePath);

                // Parse the JSON content
                RootObject data = JsonConvert.DeserializeObject<RootObject>(content);

                if (data.Products != null)
                {
                    foreach (SoftwareAdvice_Json product in data.Products)
                    {
                        Console.WriteLine($"Importing: Title: \"{product.Title}\"; Categories: {string.Join(", ", product.Categories)}; Twitter: {product.Twitter}");

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
