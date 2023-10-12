using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Client_Web_Service_COVID
{
    public partial class RendezVous : Form
    {
        public RendezVous()
        {
            InitializeComponent();
        }

        private async void buttonEnregistrementRV_Click(object sender, EventArgs e)
        {
            if(ComboBoxIdentite.Text.Trim().Equals("") || ComboBoxStructure.Text.Trim().Equals("") || ComboBoxTypeRV.Text.Trim().Equals(""))
            {
                MessageBox.Show("veuiller donner toutes les informations requises");
            }
            else
            {
                try
                {
                    string emailUtilisateur = this.ComboBoxIdentite.Text;
                    int idStructure=Convert.ToInt32((string) this.ComboBoxStructure.Text);
                    string typeRV= this.ComboBoxTypeRV.Text;
                    string status = "EN COURS DE TRAITEMENT";
                    DateTime date=this.dateTimeRV.Value.ToUniversalTime();
                    Utilisateur utilisateur =await GetUtilisateur(emailUtilisateur);
                    Structuredesante structure=await GetStructure(idStructure);
                    if(utilisateur != null && structure!=null) 
                    {
                        RendezV rv = new RendezV
                        {
                            Date = date,
                            Type = typeRV,
                            User = utilisateur,
                            Status= status,
                            Structuredesante = structure,
                            Heure = new DateTime()

                            

                        };
                        string JsonRV=JsonConvert.SerializeObject(rv);
                        using(HttpClient client=new HttpClient())
                        {
                            string url = "http://localhost:8080/REST_COVID_WEB_SERVICE/rs/rendezvous";
                            var content = new StringContent(JsonRV, Encoding.UTF8, "application/json");
                            HttpResponseMessage response =await client.PostAsync(url, content);
                            if(response.IsSuccessStatusCode)
                            {
                                MessageBox.Show("Votre rendez est bien enregistré, vous serez informer en cas de traitement");
                                this.Hide();
                                MainApplication main=new MainApplication(); 
                                main.Show();
                            }
                            else
                            {
                                MessageBox.Show($"Erreur lor de l'enregistrement. code server " + response.StatusCode);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Donnes recupereée nulles");
                    }
                    
                    
                }
                catch(Exception ex) 
                {
                    
                }   
                
            }
        }

        private void RendezVous_Load(object sender, EventArgs e)
        {
            LoadUser();
            LoadStructureOfHealthy();
            LoadTypeRv();
        }
        public async void LoadUser()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://localhost:8080/REST_COVID_WEB_SERVICE/rs/utilisateurs";
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
                    HttpResponseMessage response = await client.SendAsync(request);
                    if(response.IsSuccessStatusCode)
                    {
                        string xmlResponse=await response.Content.ReadAsStringAsync();
                        using(StringReader stringReader = new StringReader(xmlResponse))
                        {
                            XmlSerializer serializer=new XmlSerializer(typeof(Utilisateurs));
                            Utilisateurs u=(Utilisateurs)serializer.Deserialize(stringReader);
                            List<string> allUser = new List<string>();
                            for(int i=0;i<u.ListeUtilisateurs.Count;i++)
                            {
                                allUser.Add(u.ListeUtilisateurs[i].Email);
                            }
                            this.ComboBoxIdentite.DataSource = allUser;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur de chargement des utiliateurs " + ex.Message);
                }
            }
        }

        public async void LoadStructureOfHealthy()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://localhost:8080/REST_COVID_WEB_SERVICE/rs/structures";
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        string xmlResponse = await response.Content.ReadAsStringAsync();
                        using (StringReader stringReader = new StringReader(xmlResponse))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(Structuredesantes));
                            Structuredesantes structuredesantes = (Structuredesantes)serializer.Deserialize(stringReader);
                            List<int> allStructure = new List<int>();
                            for (int i = 0; i < structuredesantes.ListStructures.Count; i++)
                            {
                                allStructure.Add(structuredesantes.ListStructures[i].IdStructuresante);
                            }
                            this.ComboBoxStructure.DataSource = allStructure;


                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des structures de santé " + ex.Message);
                }
            }
        }
        public void LoadTypeRv()
        {
            string type1 = "TEST COVID";
            string type2 = "VACCINATION";
            List<string> types = new List<string>();
            types.Add(type1);
            types.Add(type2);
            this.ComboBoxTypeRV.DataSource= types;
        }
        public async Task<Utilisateur> GetUtilisateur(string email)
        {
            Utilisateur u = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://localhost:8080/REST_COVID_WEB_SERVICE/rs/utilisateurs/"+email;
                   HttpRequestMessage request= new HttpRequestMessage(HttpMethod.Post, url);
                    request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
                    HttpResponseMessage response = await client.SendAsync(request);
                    if(response.IsSuccessStatusCode)
                    {
                        string xmlResponse= await response.Content.ReadAsStringAsync();
                        using(StringReader reader = new StringReader(xmlResponse))
                        {
                            XmlSerializer serializer=new XmlSerializer(typeof(Utilisateur));
                            u =(Utilisateur) serializer.Deserialize(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return u;
        }
        public async Task<Structuredesante> GetStructure(int idStructure)
        {
            Structuredesante struturedesante = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string url = $"http://localhost:8080/REST_COVID_WEB_SERVICE/rs/structures/" + idStructure;
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        string xmlResponse = await response.Content.ReadAsStringAsync();
                        using (StringReader reader = new StringReader(xmlResponse))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(Structuredesante));
                            struturedesante = (Structuredesante)serializer.Deserialize(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return struturedesante;
        }

    }
}
