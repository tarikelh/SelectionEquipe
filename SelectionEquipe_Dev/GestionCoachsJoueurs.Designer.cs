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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridUtilisateurs = new System.Windows.Forms.DataGridView();
            this.lstUtilisateurs = new System.Windows.Forms.ListView();
            this.lstSports = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstEquipes = new System.Windows.Forms.ListBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.txtNomEquipe = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.radioBtnJoueur = new System.Windows.Forms.RadioButton();
            this.radioBtnCoach = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUtilisateurs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridUtilisateurs);
            this.groupBox1.Controls.Add(this.lstUtilisateurs);
            this.groupBox1.Controls.Add(this.lstSports);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnRetour);
            this.groupBox1.Controls.Add(this.btnSupprimer);
            this.groupBox1.Controls.Add(this.radioBtnJoueur);
            this.groupBox1.Controls.Add(this.radioBtnCoach);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 537);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des Coachs - Joueurs";
            // 
            // dataGridUtilisateurs
            // 
            this.dataGridUtilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUtilisateurs.Location = new System.Drawing.Point(28, 78);
            this.dataGridUtilisateurs.Name = "dataGridUtilisateurs";
            this.dataGridUtilisateurs.Size = new System.Drawing.Size(363, 416);
            this.dataGridUtilisateurs.TabIndex = 15;
            this.dataGridUtilisateurs.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridUtilisateurs_RowStateChanged);
            // 
            // lstUtilisateurs
            // 
            this.lstUtilisateurs.HideSelection = false;
            this.lstUtilisateurs.Location = new System.Drawing.Point(28, 78);
            this.lstUtilisateurs.Name = "lstUtilisateurs";
            this.lstUtilisateurs.Size = new System.Drawing.Size(352, 416);
            this.lstUtilisateurs.TabIndex = 14;
            this.lstUtilisateurs.UseCompatibleStateImageBehavior = false;
            // 
            // lstSports
            // 
            this.lstSports.FormattingEnabled = true;
            this.lstSports.Location = new System.Drawing.Point(196, 42);
            this.lstSports.Name = "lstSports";
            this.lstSports.Size = new System.Drawing.Size(95, 17);
            this.lstSports.TabIndex = 13;
            this.lstSports.SelectedIndexChanged += new System.EventHandler(this.lstSports_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.lstEquipes);
            this.groupBox2.Controls.Add(this.btnModifier);
            this.groupBox2.Controls.Add(this.txtNomEquipe);
            this.groupBox2.Controls.Add(this.txtPrenom);
            this.groupBox2.Controls.Add(this.txtNom);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(593, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 244);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lstEquipes
            // 
            this.lstEquipes.FormattingEnabled = true;
            this.lstEquipes.Location = new System.Drawing.Point(146, 135);
            this.lstEquipes.Name = "lstEquipes";
            this.lstEquipes.Size = new System.Drawing.Size(108, 17);
            this.lstEquipes.TabIndex = 12;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(119, 173);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(120, 31);
            this.btnModifier.TabIndex = 11;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // txtNomEquipe
            // 
            this.txtNomEquipe.Location = new System.Drawing.Point(146, 131);
            this.txtNomEquipe.Name = "txtNomEquipe";
            this.txtNomEquipe.Size = new System.Drawing.Size(108, 20);
            this.txtNomEquipe.TabIndex = 10;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(146, 96);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(108, 20);
            this.txtPrenom.TabIndex = 9;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(146, 59);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(108, 20);
            this.txtNom.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Equipe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(28, 500);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(112, 31);
            this.btnRetour.TabIndex = 4;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Enabled = false;
            this.btnSupprimer.Location = new System.Drawing.Point(436, 241);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(120, 31);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // radioBtnJoueur
            // 
            this.radioBtnJoueur.AutoSize = true;
            this.radioBtnJoueur.Location = new System.Drawing.Point(90, 42);
            this.radioBtnJoueur.Name = "radioBtnJoueur";
            this.radioBtnJoueur.Size = new System.Drawing.Size(57, 17);
            this.radioBtnJoueur.TabIndex = 2;
            this.radioBtnJoueur.Text = "Joueur";
            this.radioBtnJoueur.UseVisualStyleBackColor = true;
            this.radioBtnJoueur.CheckedChanged += new System.EventHandler(this.radioBtnJoueur_CheckedChanged);
            // 
            // radioBtnCoach
            // 
            this.radioBtnCoach.AutoSize = true;
            this.radioBtnCoach.Location = new System.Drawing.Point(28, 42);
            this.radioBtnCoach.Name = "radioBtnCoach";
            this.radioBtnCoach.Size = new System.Drawing.Size(56, 17);
            this.radioBtnCoach.TabIndex = 1;
            this.radioBtnCoach.Text = "Coach";
            this.radioBtnCoach.UseVisualStyleBackColor = true;
            this.radioBtnCoach.CheckedChanged += new System.EventHandler(this.radioBtnCoach_CheckedChanged);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(146, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(108, 20);
            this.txtId.TabIndex = 13;
            // 
            // GestionCoachsJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "GestionCoachsJoueurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionCoachsJoueurs";
            this.Load += new System.EventHandler(this.GestionCoachsJoueurs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUtilisateurs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.RadioButton radioBtnJoueur;
        private System.Windows.Forms.RadioButton radioBtnCoach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox txtNomEquipe;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.ListBox lstEquipes;
        private System.Windows.Forms.ListBox lstSports;
        private System.Windows.Forms.ListView lstUtilisateurs;
        private System.Windows.Forms.DataGridView dataGridUtilisateurs;
        private System.Windows.Forms.TextBox txtId;
    }
}