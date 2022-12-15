namespace SelectionEquipe_Dev
{
    partial class GestionCoachsJoueurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionCoachsJoueurs));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btModifier = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.btRetour = new System.Windows.Forms.Button();
            this.btSuprrimer = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBoxSelectJob = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listBoxSelectJob);
            this.groupBox1.Controls.Add(this.labelAdmin);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.btModifier);
            this.groupBox1.Controls.Add(this.txtNote);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.btRetour);
            this.groupBox1.Controls.Add(this.btSuprrimer);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion coachs/joueurs";
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Location = new System.Drawing.Point(601, 37);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(80, 33);
            this.labelAdmin.TabIndex = 8;
            this.labelAdmin.Text = "Admin";
            this.labelAdmin.Click += new System.EventHandler(this.labelAdmin_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.User;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(687, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 48);
            this.panel2.TabIndex = 7;
            // 
            // btModifier
            // 
            this.btModifier.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btModifier.Location = new System.Drawing.Point(578, 300);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(71, 27);
            this.btModifier.TabIndex = 6;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNote.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNote.Location = new System.Drawing.Point(554, 255);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(117, 26);
            this.txtNote.TabIndex = 5;
            this.txtNote.Text = "Note";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtPrenom.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtPrenom.Location = new System.Drawing.Point(554, 212);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(117, 26);
            this.txtPrenom.TabIndex = 4;
            this.txtPrenom.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtNom.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtNom.Location = new System.Drawing.Point(554, 169);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(117, 26);
            this.txtNom.TabIndex = 3;
            this.txtNom.Text = "Nom";
            // 
            // btRetour
            // 
            this.btRetour.Font = new System.Drawing.Font("Segoe Print", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btRetour.Location = new System.Drawing.Point(6, 440);
            this.btRetour.Name = "btRetour";
            this.btRetour.Size = new System.Drawing.Size(71, 27);
            this.btRetour.TabIndex = 2;
            this.btRetour.Text = "Retour";
            this.btRetour.UseVisualStyleBackColor = true;
            // 
            // btSuprrimer
            // 
            this.btSuprrimer.Font = new System.Drawing.Font("Segoe Print", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btSuprrimer.Location = new System.Drawing.Point(287, 119);
            this.btSuprrimer.Name = "btSuprrimer";
            this.btSuprrimer.Size = new System.Drawing.Size(137, 37);
            this.btSuprrimer.TabIndex = 1;
            this.btSuprrimer.Text = "Supprimer";
            this.btSuprrimer.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 81);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(233, 343);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBoxSelectJob
            // 
            this.listBoxSelectJob.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listBoxSelectJob.FormattingEnabled = true;
            this.listBoxSelectJob.ItemHeight = 19;
            this.listBoxSelectJob.Location = new System.Drawing.Point(68, 40);
            this.listBoxSelectJob.Name = "listBoxSelectJob";
            this.listBoxSelectJob.Size = new System.Drawing.Size(98, 23);
            this.listBoxSelectJob.TabIndex = 9;
            // 
            // GestionCoachsJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.fifa2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 497);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "GestionCoachsJoueurs";
            this.Text = "Gestion admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btRetour;
        private System.Windows.Forms.Button btSuprrimer;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox listBoxSelectJob;
    }
}