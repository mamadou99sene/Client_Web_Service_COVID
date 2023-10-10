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
    public partial class LocalisationMaps : Form
    {
        public LocalisationMaps()
        {
            InitializeComponent();
        }

        private void LocalisationMaps_Load(object sender, EventArgs e)
        {
            ChargementStructure();

        }
        public async void ChargementStructure()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    String url = "http://localhost:8080/REST_COVID_WEB_SERVICE/rs/structures";
                    //effectuer une requête vers l'URL du serveur
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                    HttpResponseMessage response = await client.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {

                        //lecture du contenu de la reponse
                        String xmlResponse = await response.Content.ReadAsStringAsync();
                        // Désérialisez la réponse XML en objets C#
                        using (var stringReader = new StringReader(xmlResponse))
                        {
                            XmlSerializer serializer = new XmlSerializer(typeof(Structuredesantes));
                            Structuredesantes structuredesantes = (Structuredesantes)serializer.Deserialize(stringReader);
                            
                            this.dataGridView1.DataSource = structuredesantes.ListStructures;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"La requête a échoué avec le code {response.StatusCode}");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                string localisation = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["localisation"].Value);
                string typeTraitement = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Typetraitement"].Value);
                Console.WriteLine(typeTraitement);
                try
                {
                    StringBuilder adresse = new StringBuilder();
                    adresse.Append("http://maps.google.com/maps?q=");
                    if(localisation!=string.Empty)
                    {
                        adresse.Append(localisation +","+"+");
                    }
                    if (typeTraitement != string.Empty)
                    {
                        adresse.Append(typeTraitement + "," + "+");
                    }
                    webBrowser1.Navigate(adresse.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Impossible de charger google maps "+ex.Message);
                }
            }

        }
    }
}
