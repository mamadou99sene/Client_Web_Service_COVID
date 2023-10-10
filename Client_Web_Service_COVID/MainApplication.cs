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
using System.Net.Http.Headers;
using System.IO;

namespace Client_Web_Service_COVID
{
    public partial class MainApplication : Form
    {
        public MainApplication()
        {
            InitializeComponent();
        }

        private void MainApplication_Load(object sender, EventArgs e)
        {
            Chargement();
        }
        public async void Chargement()
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
                            /*foreach (Utilisateur u in utilisateurs.ListeUtilisateurs)
                             {
                                 Console.WriteLine($"Nom: {u.Nom}, Prénom: {u.Prenom}, Email: {u.Email}");
                             }*/
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

        private async void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                int idStructuresante = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["idStructuresante"].Value);
                //Console.WriteLine(idStructuresante);
                using (HttpClient client = new HttpClient())
                {
                    try
                    {
                        string url = $"http://localhost:8080/REST_COVID_WEB_SERVICE/rs/structures/{idStructuresante}";
                        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));
                        HttpResponseMessage response = await client.SendAsync(request);
                        if (response.IsSuccessStatusCode)
                        {
                            string xmlResponse = await response.Content.ReadAsStringAsync();
                            using (StringReader stringReader = new StringReader(xmlResponse))
                            {
                                XmlSerializer serialiser = new XmlSerializer(typeof(Structuredesante));
                                Structuredesante sante = (Structuredesante)serialiser.Deserialize(stringReader);
                                List<dynamic> list = new List<dynamic>();
                                list.Add(sante);
                                this.dataGridView1.DataSource = list;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Erreur ! la requete n'a pas aboutie");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur survenue : " + ex.Message);
                    }
                }

            }
        }

        private void nosStructuresDeSantéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chargement();
        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form = new Form1();
            form.Show();
        }

        private void prendreUnRendezVoussToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RendezVous rv = new RendezVous();
            rv.Show();
        }

        private void consulterMesRendezVousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultationRendezVous rendezVous = new ConsultationRendezVous();
            rendezVous.Show();
            //this.dataGridView1.DataSource = rendezVs.ListRendezVous;

        }

        private void localiserSurMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalisationMaps localiser=new LocalisationMaps();
            localiser.Show();
        }
    }
       
}
