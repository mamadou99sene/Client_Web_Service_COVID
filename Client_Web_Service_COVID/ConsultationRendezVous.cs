using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Client_Web_Service_COVID
{
    public partial class ConsultationRendezVous : Form
    {
        public ConsultationRendezVous()
        {
            InitializeComponent();
        }

        private async void ConsultationRendezVous_Load(object sender, EventArgs e)
        {
            RendezVs rendezV = await LoadRendezVous();
            List<RepresentationRv> list_rv = new List<RepresentationRv>(rendezV.ListRendezVous.Count);
            RepresentationRv representation=null;
            for (int i = 0; i < rendezV.ListRendezVous.Count; i++)
            {
                representation = new RepresentationRv();
                representation.Id = rendezV.ListRendezVous[i].Id;
                representation.Date = rendezV.ListRendezVous[i].Date;
                representation.Type = rendezV.ListRendezVous[i].Type;
                representation.StatusRv = rendezV.ListRendezVous[i].Status;
                representation.UserFirstName = rendezV.ListRendezVous[i].User.Prenom;
                representation.UserLastName = rendezV.ListRendezVous[i].User.Nom;
                representation.UserEmail = rendezV.ListRendezVous[i].User.Email;
                representation.StructureLocate = rendezV.ListRendezVous[i].Structuredesante.Localisation;
                representation.PhoneStructure = rendezV.ListRendezVous[i].Structuredesante.Telephone;
                list_rv.Add(representation);
            }
            this.dataGridView1.DataSource =list_rv;
        }
        public async Task<RendezVs> LoadRendezVous()
        {
            RendezVs AllRv = null;  
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://localhost:8080/REST_COVID_WEB_SERVICE/rs/rendezvous";
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        string xmlReponse = await response.Content.ReadAsStringAsync();
                        using (StringReader sr = new StringReader(xmlReponse))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(RendezVs));
                            AllRv = (RendezVs)serializer.Deserialize(sr);

                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return AllRv;
        }
    }

}
