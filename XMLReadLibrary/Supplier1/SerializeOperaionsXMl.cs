using System;
using System.IO;
using System.Threading;
using System.Xml.Serialization;

namespace XMLReadLibrary.XMLOperations
{
    public class SerializeOperaionsXML 
    {
        public SearchResult ReadXml()
        {

            SearchResult i = null;
           
            try
            {
                var randomiser = new Random();
                var randomNumber = randomiser.Next(10000);
                Thread.Sleep(randomNumber);

                XmlSerializer serializer = new XmlSerializer(typeof(SearchResult));
                StreamReader file = new StreamReader(Property.DataProviderXML);
                
                i = (SearchResult) serializer.Deserialize(file);
            }
            catch (FileNotFoundException)
            {
            }
            return i;
        }
    }
}
