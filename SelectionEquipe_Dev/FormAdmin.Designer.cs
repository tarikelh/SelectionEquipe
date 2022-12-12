namespace SelectionEquipeWeb_Dev
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
            this.btnGCoachJoueur = new System.Windows.Forms.Button();
            this.btnGEquipe = new System.Windows.Forms.Button();
            this.btnGSport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGCoachJoueur
            // 
            this.btnGCoachJoueur.Location = new System.Drawing.Point(359, 126);
            this.btnGCoachJoueur.Name = "btnGCoachJoueur";
            this.btnGCoachJoueur.Size = new System.Drawing.Size(201, 51);
            this.btnGCoachJoueur.TabIndex = 0;
            this.btnGCoachJoueur.Text = "GESTION COACHS/JOUEURS";
            this.btnGCoachJoueur.UseVisualStyleBackColor = true;
            this.btnGCoachJoueur.Click += new System.EventHandler(this.btnGCoachJoueur_Click);
            // 
            // btnGEquipe
            // 
            this.btnGEquipe.Location = new System.Drawing.Point(359, 207);
            this.btnGEquipe.Name = "btnGEquipe";
            this.btnGEquipe.Size = new System.Drawing.Size(201, 51);
            this.btnGEquipe.TabIndex = 1;
            this.btnGEquipe.Text = "GESTION EQUIPES";
            this.btnGEquipe.UseVisualStyleBackColor = true;
            this.btnGEquipe.Click += new System.EventHandler(this.btnGEquipe_Click);
            // 
            // btnGSport
            // 
            this.btnGSport.Location = new System.Drawing.Point(359, 285);
            this.btnGSport.Name = "btnGSport";
            this.btnGSport.Size = new System.Drawing.Size(201, 51);
            this.btnGSport.TabIndex = 2;
            this.btnGSport.Text = "GESTION SPORTS";
            this.btnGSport.UseVisualStyleBackColor = true;
            this.btnGSport.Click += new System.EventHandler(this.btnGSport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGSport);
            this.groupBox1.Controls.Add(this.btnGEquipe);
            this.groupBox1.Controls.Add(this.btnGCoachJoueur);
            this.groupBox1.Location = new System.Drawing.Point(27, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(921, 510);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mercato";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAdmin";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormAdmin";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGCoachJoueur;
        private System.Windows.Forms.Button btnGEquipe;
        private System.Windows.Forms.Button btnGSport;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}