using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Web_Service_COVID
{
    internal class RepresentationRv
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string StructureLocate { get; set; }
        public string StatusRv { get; set; }    
        public string PhoneStructure { get; set; }
    }
}
