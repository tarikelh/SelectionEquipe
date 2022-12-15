namespace SelectionEquipe_Dev.Pages
{
    partial class FormJoueur
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
            System.Windows.Forms.Button Quitter;
            System.Windows.Forms.Button btDemission;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJoueur));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewJoueur = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            Quitter = new System.Windows.Forms.Button();
            btDemission = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Quitter
            // 
            Quitter.BackColor = System.Drawing.Color.Transparent;
            Quitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Quitter.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Quitter.ForeColor = System.Drawing.SystemColors.ControlText;
            Quitter.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            Quitter.Location = new System.Drawing.Point(620, 345);
            Quitter.Name = "Quitter";
            Quitter.Size = new System.Drawing.Size(93, 36);
            Quitter.TabIndex = 1;
            Quitter.Text = "Quitter";
            Quitter.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(btDemission);
            this.groupBox1.Controls.Add(Quitter);
            this.groupBox1.Controls.Add(this.listViewJoueur);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(8, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.groupBox1.Size = new System.Drawing.Size(722, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste des convoqués";
            // 
            // listViewJoueur
            // 
            this.listViewJoueur.Font = new System.Drawing.Font("Segoe Print", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.listViewJoueur.HideSelection = false;
            this.listViewJoueur.Location = new System.Drawing.Point(9, 45);
            this.listViewJoueur.Name = "listViewJoueur";
            this.listViewJoueur.Size = new System.Drawing.Size(238, 336);
            this.listViewJoueur.TabIndex = 0;
            this.listViewJoueur.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(78, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mercato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(529, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "Profil Joueur";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.User;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(675, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 48);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.emoji;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(17, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 48);
            this.panel1.TabIndex = 1;
            // 
            // btDemission
            // 
            btDemission.BackColor = System.Drawing.Color.Transparent;
            btDemission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btDemission.Font = new System.Drawing.Font("Segoe Print", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            btDemission.ForeColor = System.Drawing.SystemColors.ControlText;
            btDemission.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btDemission.Location = new System.Drawing.Point(533, 293);
            btDemission.Name = "btDemission";
            btDemission.Size = new System.Drawing.Size(180, 46);
            btDemission.TabIndex = 2;
            btDemission.Text = "Demande de démission";
            btDemission.UseVisualStyleBackColor = false;
            // 
            // FormJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::SelectionEquipe_Dev.Properties.Resources.fifa2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "FormJoueur";
            this.Text = "Profil joueur";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewJoueur;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}