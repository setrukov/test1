using Aquality.Selenium.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject5.Utils
{
    internal class JsonUtils
    {
        public static string GetValue(string fileName, string key)
        {
            const string fileExt = ".json";
            JsonSettingsFile _ConfigFile = new JsonSettingsFile(fileName + fileExt);
            return _ConfigFile.GetValue<string>(key);
        }
    }
}
