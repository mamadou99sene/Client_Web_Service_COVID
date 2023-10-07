using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Client_Web_Service_COVID
{
    public partial class MainApplication : Form
    {
        private List<Utilisateur> list;
        public MainApplication()
        {
            InitializeComponent();
        }

        private void MainApplication_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Chargement des info ...");
            //Chargement();
        }
        public async void Chargement()
        {
            try
            {
                list=new List<Utilisateur>();
                HttpClient client = new HttpClient();
                String url = "http://localhost:8080/REST_COVID_WEB_SERVICE/rs/utilisateurs";
                HttpResponseMessage responseMessage = await client.GetAsync(url);
                if(responseMessage.IsSuccessStatusCode) 
                {
                    String xmlResponse=await responseMessage.Content.ReadAsStringAsync();
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Utilisateur));
                    using (var stringReader = new System.IO.StringReader(xmlResponse))
                    {
                        var utilisateur = (Utilisateur)xmlSerializer.Deserialize(stringReader);
                        list.Add(utilisateur);
                        foreach (var u in list)
                        {
                            Console.WriteLine($"Nom: {u.Nom}, Prénom: {u.Prenom}, Email: {u.Email}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"La requête a échoué avec le code {responseMessage.StatusCode}");
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
