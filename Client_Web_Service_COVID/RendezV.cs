using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Client_Web_Service_COVID
{
    [XmlRoot("rendezvouss")]
    [JsonObject]
    public class RendezVs
    {
        [XmlElement("rendezvous")]
        [JsonProperty("rendezvous")]
        public List<RendezV> ListRendezVous { get; set; }
    }
    [XmlRoot("rendezvous")]
    [JsonObject]
    public class RendezV
    {
        [XmlElement("idRendezvous")]
        [JsonProperty("idRendezvous")]
        public int Id { get; set; }
        [XmlElement("date")]
        [JsonProperty("date")]
        public DateTime Date { get; set; }
        [XmlElement("heure")]
        [JsonProperty("heure")]
        public DateTime Heure { get; set; }
        [XmlElement("typerendezvous")]
        [JsonProperty("typerendezvous")]
        public string Type { get; set; }
        [XmlElement("status")]
        [JsonProperty("status")]
        public string Status { get; set; }
        [XmlElement("utilisateur")]
        [JsonProperty("utilisateur")]
        public Utilisateur User { get; set; }
        [XmlElement("structuredesante")]
        [JsonProperty("structuredesante")]
        public Structuredesante Structuredesante { get; set; }
    }
}
 