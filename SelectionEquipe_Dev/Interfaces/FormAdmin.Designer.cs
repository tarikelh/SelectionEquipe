namespace SelectionEquipe_Dev
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.btnGCoachJoueur = new System.Windows.Forms.Button();
            this.btnGEquipe = new System.Windows.Forms.Button();
            this.btnGSport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGCoachJoueur
            // 
            this.btnGCoachJoueur.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.Fifa;
            this.btnGCoachJoueur.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGCoachJoueur.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGCoachJoueur.Location = new System.Drawing.Point(307, 80);
            this.btnGCoachJoueur.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGCoachJoueur.Name = "btnGCoachJoueur";
            this.btnGCoachJoueur.Size = new System.Drawing.Size(235, 76);
            this.btnGCoachJoueur.TabIndex = 0;
            this.btnGCoachJoueur.Text = "GESTION COACHS/JOUEURS";
            this.btnGCoachJoueur.UseVisualStyleBackColor = true;
            this.btnGCoachJoueur.Click += new System.EventHandler(this.btnGCoachJoueur_Click);
            // 
            // btnGEquipe
            // 
            this.btnGEquipe.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.Fifa;
            this.btnGEquipe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGEquipe.Location = new System.Drawing.Point(307, 172);
            this.btnGEquipe.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGEquipe.Name = "btnGEquipe";
            this.btnGEquipe.Size = new System.Drawing.Size(235, 76);
            this.btnGEquipe.TabIndex = 1;
            this.btnGEquipe.Text = "GESTION EQUIPES";
            this.btnGEquipe.UseVisualStyleBackColor = true;
            this.btnGEquipe.Click += new System.EventHandler(this.btnGEquipe_Click);
            // 
            // btnGSport
            // 
            this.btnGSport.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.Fifa;
            this.btnGSport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGSport.Location = new System.Drawing.Point(307, 264);
            this.btnGSport.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnGSport.Name = "btnGSport";
            this.btnGSport.Size = new System.Drawing.Size(235, 76);
            this.btnGSport.TabIndex = 2;
            this.btnGSport.Text = "GESTION SPORTS";
            this.btnGSport.UseVisualStyleBackColor = true;
            this.btnGSport.Click += new System.EventHandler(this.btnGSport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnGSport);
            this.groupBox1.Controls.Add(this.btnGEquipe);
            this.groupBox1.Controls.Add(this.btnGCoachJoueur);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(26, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(837, 386);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu principal ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(84, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mercato";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.emoji;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(23, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 48);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.User;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(818, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 48);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(572, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Menu Administrateur";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.fifa2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(898, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormAdmin";
            this.Padding = new System.Windows.Forms.Padding(20, 25, 20, 25);
            this.Text = "Menu Admin";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGCoachJoueur;
        private System.Windows.Forms.Button btnGEquipe;
        private System.Windows.Forms.Button btnGSport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}