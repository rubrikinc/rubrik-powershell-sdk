using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Rubrik.SecurityCloud.NetSDK.Library
{
    public class LibraryHelper
    {
        public static string GetEmbeddedGrahQLOperation(string operationName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resouceName = assembly.GetManifestResourceNames().Where(n => n.ToLower().Contains($"{operationName.ToLower()}.graphql")).FirstOrDefault();

            var results = assembly.GetManifestResourceNames();
            Stream stream = assembly.GetManifestResourceStream(resouceName);
            StreamReader reader = new StreamReader(stream);

            return reader.ReadToEnd();
        }
    }
}

