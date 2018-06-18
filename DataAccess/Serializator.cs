using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataAccess
{
   public class Serializator<T> where T : class, new()
   {
      int fileCount = 0;
      public void SerializeToXml(T collection,string fileName)
      {
         Stream stream = File.OpenWrite(Environment.CurrentDirectory + fileName + ".xml");

         XmlSerializer serializer = new XmlSerializer(typeof(T));
         serializer.Serialize(stream, collection);

         stream.Close();

      }

      public void SerializeToJson(T collection, string fileName)
      {
         JsonSerializer serializer = new JsonSerializer();
         serializer.Converters.Add(new JavaScriptDateTimeConverter());
         serializer.NullValueHandling = NullValueHandling.Ignore;

         using (StreamWriter sw = new StreamWriter($"{fileCount++}.txt"))
         using (JsonWriter writer = new JsonTextWriter(sw))
         {
            serializer.Serialize(writer, collection);
         }
      }
   }
}
