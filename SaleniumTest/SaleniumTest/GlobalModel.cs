using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SaleniumTest
{
    public class Siteinfo
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Url { get; set; }
        public string BusinessName { get; set; }

        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer Xml = new XmlSerializer(typeof(Siteinfo));
                Xml.Serialize(stream, this);
            }
        }
        public static Siteinfo LoadFromFile(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer Xml = new XmlSerializer(typeof(Siteinfo));
   
    
               return (Siteinfo)Xml.Deserialize(stream);

            }

        }
    }
}
