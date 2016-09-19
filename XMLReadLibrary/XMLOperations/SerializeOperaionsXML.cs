using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
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
