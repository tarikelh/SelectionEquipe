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
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = textBox1.Text;
            item.SubItems.Add(textBox2.Text);

            listView1.Items.Add(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedIndices.Count == 1)
            {
                int selectedindex = listView1.SelectedIndices[0];
                listView1.Items[selectedindex].Remove();
            }
            else
            {
                MessageBox.Show("Selectionner une seule ligne svp !");
            }

            /*  int supp_index = listView1.SelectedIndices[0];
            listView1.SelectedIndices.Remove(supp_index);       */

            // listView1.SelectedIndices.Clear();

            /*if (listView1.SelectedIndices.Count == 1)
            {
                int sup_index = listView1.SelectedIndices[0];
                listView1.Items.RemoveAt(sup_index);
            }
            else if(listView1.SelectedIndices.Count > 1)
            {
                int del_index = listView1.SelectedIndices[0];
            }
            else
            {
                MessageBox.Show(" Selectionner une seule ligne !")
            }*/

        }
    }
}
