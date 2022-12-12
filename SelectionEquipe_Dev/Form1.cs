using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelectionEquipeWeb_Dev.Dtos;
using SelectionEquipeWeb_Dev.Model;
using SelectionEquipeWeb_Dev.Repository;
using SelectionEquipeWeb_Dev.Service;

namespace SelectionEquipeWeb_Dev
{
    public partial class Form1 : Form
    {
        private ISportService sportService;
        private IUtilisateurService utilisateurService;
        public Form1()
        {
            InitializeComponent();
            lstSport.Items.Clear();
            lstRole.Items.Clear();
            sportService = new SportService(new SportRepository());
            utilisateurService = new UtilisateurService(new UtilisateurRepository());
            List<Sport> sports = sportService.GetAll();
            foreach (string role in Enum.GetNames(typeof(Utilisateur.Role)))
            {
                lstRole.Items.Add(role);
            }
            foreach(Sport sport in sports)
            {
                lstSport.Items.Add(sport.NomSport);
                //lstSport.Items.Add(sport.NomSport);
            }
            
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            //Utilisateur utilisateur = new Admin()
            //{
            //    Nom = txtNom.Text,
            //    Prenom = txtPrenom.Text,
            //    Login = txtLoginI.Text,
            //    Password = txtPasswordI.Text
            //};
            Sport sp = sportService.FindByName((string)lstSport.SelectedItem);
            if (lstRole.Text.Equals("Coach"))
            {
                Utilisateur ucoach = new Coach()
                {
                    Nom = txtNom.Text,
                    Prenom = txtPrenom.Text,
                    Login = txtLoginI.Text,
                    Password = txtPasswordI.Text,
                    //Sport = sportService.FindByName((string)lstSport.SelectedItem),
                    SportId = sp.SportId
                };
                utilisateurService.Insert(ucoach);
            }
            else if (lstRole.Text.Equals("Joueur"))
            {
                Utilisateur ujoueur = new Joueur()
                {
                    Nom = txtNom.Text,
                    Prenom = txtPrenom.Text,
                    Login = txtLoginI.Text,
                    Password = txtPasswordI.Text,
                    //Sport = sportService.FindByName((string)lstSport.SelectedItem),
                    SportId = sp.SportId
                };
                utilisateurService.Insert(ujoueur);
            }
            
            Clear();
        }

        private void Clear()
        {
            txtNom.Text = txtPrenom.Text = txtLoginI.Text = txtPasswordI.Text = "";
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            LoginDTO loginDTO = new LoginDTO(txtLoginC.Text, txtPasswordC.Text);
            Utilisateur u = utilisateurService.CheckLogin(loginDTO);
            if (u != null)
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Login ou Password incorrecte");
            }
        }
    }
}
