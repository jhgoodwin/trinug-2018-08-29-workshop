using System;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Customer.Data.Tests
{
    public class ResourceHelper
    {
        private static readonly string DataFolderNamespace = $"{typeof(ResourceHelper).Namespace}.Data";

        private static string ReadTestFileString(string resourceName)
        {
            var assembly = typeof(ResourceHelper).GetTypeInfo().Assembly;
            using (var stream = assembly.GetManifestResourceStream(resourceName))
            {
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
        
        public static T ReadTestObject<T>(string dataSubPath)
        {
            return JsonConvert.DeserializeObject<T>(ReadTestFileString($"{DataFolderNamespace}.{dataSubPath}.json"));
        }
        
    }
}