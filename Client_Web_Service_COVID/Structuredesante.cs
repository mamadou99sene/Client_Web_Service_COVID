using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Client_Web_Service_COVID
{
    [XmlRoot("structuredesantes")]
    [JsonObject]
    public class Structuredesantes
    {
        [XmlElement("structuredesante")]
        [JsonProperty("structuredesante")]
        public List<Structuredesante> ListStructures { get; set; }
    }
    [XmlRoot("structuredesante")]
    [JsonObject]
    public class Structuredesante
    {
            [XmlElement("idStructuresante")]
        [JsonProperty("idStructuresante")]
        public int IdStructuresante { get;set;}
        [XmlElement("capacite")]
        [JsonProperty("capacite")]
        public int Capacite { get; set; }
        [XmlElement("localisation")]
        [JsonProperty("localisation")]
        public string Localisation { get;set; }
            [XmlElement("telephone")]
        [JsonProperty("telephone")]
        public string Telephone { get;set; }
            [XmlElement("typeTraitement")]
        [JsonProperty("typeTraitement")]
        public string TypeTraitement { get;set; }
            [XmlElement("typetest")]
        [JsonProperty("typetest")]
        public string Typetest { get;set; }
    }
}
