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
      public void SerializeToXml(T collection)
      {
         Stream stream = File.OpenWrite(Environment.CurrentDirectory + $"\\Data {++fileCount}.xml");

         XmlSerializer serializer = new XmlSerializer(typeof(T));
         serializer.Serialize(stream, collection);

         stream.Close();

      }
   }
}
