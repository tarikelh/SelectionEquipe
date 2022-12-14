using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelectionEquipe_Dev.Model;
using SelectionEquipe_Dev.Repository;
using SelectionEquipe_Dev.Service;

namespace SelectionEquipe_Dev
{
    public partial class GestionCoachsJoueurs : Form
    {
        private ISportService sportService;
        private IEquipeService equipeService;
        private IUtilisateurService utilisateurService;
        public GestionCoachsJoueurs()
        {
            InitializeComponent();
            lstSports.Items.Clear();
            lstEquipes.Items.Clear();
            sportService = new SportService(new SportRepository());
            equipeService = new EquipeService(new EquipeRepository());
            utilisateurService = new UtilisateurService(new UtilisateurRepository());
            List<Sport> sports = sportService.GetAll();
            foreach (Sport sport in sports)
            {
                lstSports.Items.Add(sport.NomSport);
            }
        }


        private void btnRetour_Click(object sender, EventArgs e)
        {
            GestionCoachsJoueurs.ActiveForm.Close();
        }

        private void radioBtnJoueur_CheckedChanged(object sender, EventArgs e)
        {
            lstUtilisateurs.Items.Clear();
            if (lstSports.SelectedItem != null)
            {
                Sport sportselect = sportService.FindByName((string)lstSports.SelectedItem);
                List<Utilisateur> utilisateursport = utilisateurService.GetUtilisateursbySport(sportselect);
                foreach (Utilisateur utilisateur in utilisateursport)
                {
                    if (utilisateur is Joueur && radioBtnJoueur.Checked)
                    {
                        lstUtilisateurs.Items.Add(utilisateur.ToString());
                    }
                }
            }
            else
            {
                List<Joueur> joueurs = utilisateurService.GetJoueurs();
                foreach (Joueur uj in joueurs)
                {
                    if (radioBtnJoueur.Checked)
                    {
                        lstUtilisateurs.Items.Add(uj.ToString());
                    }
                }
            }

        }

        private void radioBtnCoach_CheckedChanged(object sender, EventArgs e)
        {
            lstUtilisateurs.Items.Clear();
            if (lstSports.SelectedItem != null)
            {
                Sport sportselect = sportService.FindByName((string)lstSports.SelectedItem);
                List<Utilisateur> utilisateursport = utilisateurService.GetUtilisateursbySport(sportselect);
                foreach (Utilisateur utilisateur in utilisateursport)
                {
                    if (utilisateur is Coach && radioBtnCoach.Checked)
                    {
                        lstUtilisateurs.Items.Add(utilisateur.ToString());
                    }
                }
            }
            else
            {
                List<Coach> coaches = utilisateurService.GetCoaches();
                foreach (Coach uc in coaches)
                {
                    if (radioBtnCoach.Checked)
                    {
                        lstUtilisateurs.Items.Add(uc.ToString());
                    }
                }
            }
        }

        private void lstSports_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUtilisateurs.Items.Clear();
            Sport sportselect = sportService.FindByName((string)lstSports.SelectedItem);
            List<Utilisateur> utilisateursport = utilisateurService.GetUtilisateursbySport(sportselect);
            foreach(Utilisateur utilisateur in utilisateursport)
            {
                if(utilisateur is Coach && radioBtnCoach.Checked)
                {
                    lstUtilisateurs.Items.Add(utilisateur.ToString());
                }
                else if (utilisateur is Joueur && radioBtnJoueur.Checked)
                {
                    lstUtilisateurs.Items.Add(utilisateur.ToString());
                }
            }
        }


        private void Clear()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtNomEquipe.Text = "";
            lstEquipes.Items.Clear();
            //pictureAvatar.Image = null;
            //pictureAvatar.ImageLocation = "";
            //cmbProfile.SelectedIndex = -1;

            //btnAjouter.Text = "Ajouter";
            //btnSupprimer.Enabled = false;
            //txtLogin.Enabled = true;
        }
        private void GestionCoachsJoueurs_Load(object sender, EventArgs e)
        {
            BindDatagrid();
        }

        private void BindDatagrid()
        {
            dataGridUtilisateurs.DataSource = utilisateurService.GetAll();
            dataGridUtilisateurs.Columns["login"].Visible = false;
            dataGridUtilisateurs.Columns["sport"].Visible = false;
            dataGridUtilisateurs.Columns["sportid"].Visible = false;
            dataGridUtilisateurs.Columns["password"].Visible = false;


            dataGridUtilisateurs.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridUtilisateurs.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridUtilisateurs.Columns["Prenom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridUtilisateurs.Columns["id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUtilisateurs.Columns["Nom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUtilisateurs.Columns["Prenom"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridUtilisateurs.Columns["id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUtilisateurs.Columns["Nom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridUtilisateurs.Columns["Prenom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridUtilisateurs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridUtilisateurs.ReadOnly = true;

            dataGridUtilisateurs.ClearSelection();
        }

        private void dataGridUtilisateurs_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridUtilisateurs.SelectedRows.Count != 1)
            {
                Clear();
            }
            else
            {
                int? id = (int?)dataGridUtilisateurs.SelectedRows[0].Cells[0].Value;

                if (id != null)
                {
                    Utilisateur u = utilisateurService.GetById((int)id);
                    txtId.Text = u.Id.ToString();
                    txtNom.Text = u.Nom;
                    txtPrenom.Text = u.Prenom;

                }

                //btnModifier.Text = "Modifier";
                btnSupprimer.Enabled = true;
                //txtLogin.Enabled = false;
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridUtilisateurs.SelectedRows.Count != 1) return;

            int? id = (int)dataGridUtilisateurs.SelectedRows[0].Cells[0].Value;

            if (id != null)
            {
               utilisateurService.Delete((int)id);
            }
            BindDatagrid();
            Clear();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //Utilisateur u = new Utilisateur(Nom = txtNom.Text, Prenom = txtPrenom.Text);
            Utilisateur userdb = utilisateurService.GetById(Convert.ToInt32(txtId.Text));
            if (userdb != null)
            {
                userdb.Nom = txtNom.Text;
                userdb.Prenom = txtPrenom.Text;
            }
            utilisateurService.Update(userdb);
            BindDatagrid();
            Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
