# SaaSProductsImport

To import the Json & Yaml data from files by command line tool.

***** Installation of packages ******
Right click on solution -> Manage NuGet Packages.

Install NewtonSoft.json to import the json data
Install YamlDotNet to import the Yaml data

we can also use System.Text.Json to import the json data for Serialize & Deserialize of json data.

***** To exceute the code***** 

Go to exe file folder & open the cmd. Run the below command to execute the code

Input in Command line : solution.exe import <source> <filepath>

Input for SaaS capterra Product imports is 
$ SaaSProductsImport.exe import capterra feed-products/capterra.yaml

Input for SaaS softwareadvice Product imports is 
$ SaaSProductsImport.exe import softwareadvice feed-products/softwareadvice.json

****** Other extensions to import the file ********

Add new file in model folder & declare the fields and validation on it.
Add new file in controller folder & add logic to de-serialize the data.




