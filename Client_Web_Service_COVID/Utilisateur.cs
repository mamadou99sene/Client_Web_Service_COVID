using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Client_Web_Service_COVID
{
    [JsonObject]
    [XmlRoot("utilisateurs")]
    public class Utilisateurs
    {
        [XmlElement("utilisateur")]
        public List<Utilisateur> ListeUtilisateurs { get; set; }
    }
    [XmlRoot("utilisateur")]
    [JsonObject]
    public class Utilisateur
    {
        [XmlElement("idUtilisateur")]
        [JsonProperty("idUtilisateur")]
        public int Id { get; set; }
        [XmlElement("prenom")]
        [JsonProperty("prenom")]
        public string Prenom { get;set; }
        [XmlElement("nom")]
        [JsonProperty("nom")]
        public string Nom { get;set; }
        [XmlElement("email")]
        [JsonProperty("email")]
        public string Email { get; set;}
        [XmlElement("phone")]
        [JsonProperty("phone")]
        public string Telephone { get;set; }
        [XmlElement("password")]
        [JsonProperty("password")]
        public string Password { get;set; }
    }
}
