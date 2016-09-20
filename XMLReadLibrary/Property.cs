using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace XMLReadLibrary
{
    public class Property
    { 
        public static string DataProviderXML = System.Web.Hosting.HostingEnvironment.MapPath("~\\Data\\hotelProvider1.XML");
        public static string DataProviderJsonOne = System.Web.Hosting.HostingEnvironment.MapPath( "~\\Data\\hotelProvider2.JSON");
        public static string DataProviderJsonTwo = System.Web.Hosting.HostingEnvironment.MapPath( "~\\Data\\hotelProvider3.JSON");
    }
}
