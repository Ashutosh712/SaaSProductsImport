using System;
using System.IO;
using SaaSProductsImport.Controller;

namespace SaasProductImporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Please provide a command in the format 'import <source> <file>'.");
                return;
            }

            string command = args[0].ToLower();

            if (!command.StartsWith("import"))
            {
                Console.WriteLine("Invalid command. Please use the 'import' command to import a file.");
                return;
            }

            if (args.Length < 3)
            {
                Console.WriteLine("Please provide the file name and path.");
                return;
            }
            string source = args[1];
            string filePath = args[2];

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string fileExtension = Path.GetExtension(filePath);

            if (fileExtension.Equals(".json", StringComparison.OrdinalIgnoreCase) && source.Equals("softwareadvice",StringComparison.OrdinalIgnoreCase))
            {
                ImportSoftwareAdviceJson.ImportSoftwareAdviceJsonFile(filePath);
            }
            else if (fileExtension.Equals(".yaml", StringComparison.OrdinalIgnoreCase) && source.Equals("capterra", StringComparison.OrdinalIgnoreCase))
            {
                ImportCapterraYaml.ImportCapterraYamlFile(filePath);
            }
            else
            {
                Console.WriteLine("Unsupported file format. Only JSON and YAML files are supported.");
            }

        }

    }
}
