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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void connexion_Click_1(object sender, EventArgs e)
        {
            if (textBox_email.Text.Equals("") || textBox_Password.Text.Equals(""))
            {
                MessageBox.Show("Veuillez renseigner toutes le informations demandées");
            }
            else
            {
                string email=textBox_email.Text.Trim();
                string password=textBox_Password.Text.Trim();
                authentification(email, password);
               

            }
        }
        public async void authentification(string email,string password)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = "http://localhost:8080/REST_COVID_WEB_SERVICE/rs/utilisateurs/connexion/" + email + "/" + password;
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
                    request.Headers.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/xml"));
                    HttpResponseMessage response = await client.SendAsync(request);
                    if(response.IsSuccessStatusCode)
                    {
                        string xmlResponse=await response.Content.ReadAsStringAsync();
                        using (StringReader stringReader = new StringReader(xmlResponse)) 
                        {
                            XmlSerializer s=new XmlSerializer(typeof(Utilisateur));
                            Utilisateur u=(Utilisateur)s.Deserialize(stringReader);
                            if(u!=null)
                            {
                                this.Hide();
                                MainApplication main = new MainApplication();
                                main.Show();
                            }
                           
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Email ou password incorrecte !!!");
                }

            }
        }

        private void inscription_Click_1(object sender, EventArgs e)
        {
            Inscription inscription = new Inscription();
            inscription.Show();
        }
    }
}
