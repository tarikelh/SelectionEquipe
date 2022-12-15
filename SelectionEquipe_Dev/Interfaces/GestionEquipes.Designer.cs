namespace SelectionEquipe_Dev
{
    partial class GestionEquipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEquipes));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listEquipe = new System.Windows.Forms.ListView();
            this.btRetour = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.txtAjouterEquipe = new System.Windows.Forms.TextBox();
            this.btAjouterEquipe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(585, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 33);
            this.label1.TabIndex = 7;
            this.label1.Text = "Admin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.User;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(588, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(77, 70);
            this.panel2.TabIndex = 6;
            // 
            // listEquipe
            // 
            this.listEquipe.HideSelection = false;
            this.listEquipe.Location = new System.Drawing.Point(13, 87);
            this.listEquipe.Margin = new System.Windows.Forms.Padding(4);
            this.listEquipe.Name = "listEquipe";
            this.listEquipe.Size = new System.Drawing.Size(261, 440);
            this.listEquipe.TabIndex = 8;
            this.listEquipe.UseCompatibleStateImageBehavior = false;
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btRetour.Location = new System.Drawing.Point(13, 569);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(75, 35);
            this.btRetour.TabIndex = 9;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            // 
            // btSupprimer
            // 
            this.btSupprimer.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btSupprimer.Location = new System.Drawing.Point(281, 219);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(131, 35);
            this.btSupprimer.TabIndex = 10;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            // 
            // txtAjouterEquipe
            // 
            this.txtAjouterEquipe.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtAjouterEquipe.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtAjouterEquipe.Location = new System.Drawing.Point(497, 281);
            this.txtAjouterEquipe.Name = "txtAjouterEquipe";
            this.txtAjouterEquipe.Size = new System.Drawing.Size(147, 26);
            this.txtAjouterEquipe.TabIndex = 11;
            this.txtAjouterEquipe.Text = "Nom d\'équipe";
            // 
            // btAjouterEquipe
            // 
            this.btAjouterEquipe.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btAjouterEquipe.Location = new System.Drawing.Point(523, 323);
            this.btAjouterEquipe.Name = "btAjouterEquipe";
            this.btAjouterEquipe.Size = new System.Drawing.Size(93, 35);
            this.btAjouterEquipe.TabIndex = 12;
            this.btAjouterEquipe.Text = "Ajouter";
            this.btAjouterEquipe.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Liste des équipes";
            // 
            // GestionEquipes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.fifa2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 616);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAjouterEquipe);
            this.Controls.Add(this.txtAjouterEquipe);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btRetour);
            this.Controls.Add(this.listEquipe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionEquipes";
            this.Text = "Gestion des équipes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listEquipe;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.TextBox txtAjouterEquipe;
        private System.Windows.Forms.Button btAjouterEquipe;
        private System.Windows.Forms.Label label2;
    }
}