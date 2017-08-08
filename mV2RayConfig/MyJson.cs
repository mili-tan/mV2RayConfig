using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mV2RayConfig
{
    public class MyJson
    {
        public static string FormatJsonString(string Str)
        {
            JsonSerializer serializer = new JsonSerializer();
            TextReader textRead = new StringReader(Str);
            JsonTextReader jsonRead = new JsonTextReader(textRead);
            object obj = serializer.Deserialize(jsonRead);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return Str;
            }
        }
    }
}
