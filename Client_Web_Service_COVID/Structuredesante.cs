using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Client_Web_Service_COVID
{
    [XmlRoot("structuredesantes")]
    public class Structuredesantes
    {
        [XmlElement("structuredesante")]
        public List<Structuredesante> ListStructures { get; set; }
    }
    [XmlRoot("structuredesante")]
    public class Structuredesante
    {
            [XmlElement("idStructuresante")]
        public int IdStructuresante { get;set;}
        [XmlElement("capacite")]
        public int Capacite { get; set; }
        [XmlElement("localisation")]
        public string Localisation { get;set; }
            [XmlElement("telephone")]
        public string Telephone { get;set; }
            [XmlElement("typeTraitement")]
        public string TypeTraitement { get;set; }
            [XmlElement("typetest")]
        public string Typetest { get;set; }
    }
}
