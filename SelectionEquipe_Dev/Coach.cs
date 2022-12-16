using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionEquipe_Dev
{
    public partial class Coach : Form
    {
        public Coach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = listView2.SelectedItems[0].Text;

            listView1.Items.Add(item);

            // item.Text = listView2.SelectedItems.Cast<ListViewItem>().First().Text; 

            /*if (listView1.Items.Count == 1)
            {
                ListViewItem item = new ListViewItem();
                item.Text = listView2.SelectedItems[0].Text;

                if (listView1.Items != listView2.Items)
                {
                    listView1.Items.Add(item);          //listView1.Items.RemoveAt(sel_index);
                }
                else
                {
                    MessageBox.Show("Desoler le joueur à déjà été placer !");
                }
            }
            else
            {
                MessageBox.Show("Séléctionner le joueur à ajouter");
            }*/

        }



        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = textBox1.Text;
            item.SubItems.Add(textBox1.Text);

            listView2.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count == 1) 
            {
                int sel_index = listView1.SelectedIndices[0];
                listView1.Items.RemoveAt(sel_index);
            }
            else
            {
                MessageBox.Show("Sélectionner le joueur a supprimer !");
            }
           
        }
    }
}
