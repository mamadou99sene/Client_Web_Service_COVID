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

namespace Client_Web_Service_COVID
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private  async void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            if (!textPrenom.Text.Equals("") && !textNom.Text.Equals("") && !textEmail.Text.Equals("") && !textTelephone.Text.Equals("") && !textPassword.Text.Equals(""))
            {
                string Prenom = textPrenom.Text.Trim();
                string Nom = textNom.Text.Trim();
                string Email = textEmail.Text.Trim();
                string Password = textPassword.Text.Trim();
                string Telephone = textTelephone.Text.Trim();
                Utilisateur user = new Utilisateur
                {
                    Prenom = Prenom,
                    Nom = Nom,
                    Email = Email,
                    Telephone = Telephone,
                    Password = Password,
                };

               string jsonUtilisateur = Newtonsoft.Json.JsonConvert.SerializeObject(user); 
               using(HttpClient client=new HttpClient())
                {
                    try
                    {
                        string url = "http://localhost:8080/REST_COVID_WEB_SERVICE/rs/utilisateurs";
                        //creation de la requete http avec le contenu json
                        var content=new StringContent(jsonUtilisateur,Encoding.UTF8,"application/json");
                        //effectuer la POST request
                        HttpResponseMessage response = await client.PostAsync(url,content);
                        if(response.IsSuccessStatusCode)
                        {
                            MessageBox.Show("Enregistrement de l'utilisateur effectué avec succès");
                        }
                        else
                        {
                            MessageBox.Show($"Erreur lors de l'enregistrement de l'utilisateur :{response.StatusCode}");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir toutes les innformations svp !!");
            }
        }
    }
}
