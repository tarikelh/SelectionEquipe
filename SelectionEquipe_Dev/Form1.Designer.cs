namespace SelectionEquipe_Dev
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInscription = new System.Windows.Forms.Button();
            this.txtPasswordI = new System.Windows.Forms.TextBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.lstRole = new System.Windows.Forms.ListBox();
            this.lstSport = new System.Windows.Forms.ListBox();
            this.txtLoginI = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordC = new System.Windows.Forms.TextBox();
            this.txtLoginC = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(22, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(929, 487);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mercato";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnInscription);
            this.groupBox3.Controls.Add(this.txtPasswordI);
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.lstRole);
            this.groupBox3.Controls.Add(this.lstSport);
            this.groupBox3.Controls.Add(this.txtLoginI);
            this.groupBox3.Controls.Add(this.txtPrenom);
            this.groupBox3.Controls.Add(this.txtNom);
            this.groupBox3.Location = new System.Drawing.Point(493, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 356);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inscription";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sport";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Role";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nom";
            // 
            // btnInscription
            // 
            this.btnInscription.Location = new System.Drawing.Point(80, 268);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(246, 31);
            this.btnInscription.TabIndex = 7;
            this.btnInscription.Text = "S\'incrire";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // txtPasswordI
            // 
            this.txtPasswordI.Location = new System.Drawing.Point(51, 198);
            this.txtPasswordI.Name = "txtPasswordI";
            this.txtPasswordI.PasswordChar = '*';
            this.txtPasswordI.Size = new System.Drawing.Size(127, 20);
            this.txtPasswordI.TabIndex = 6;
            // 
            // listBox3
            // 
            this.listBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listBox3.Location = new System.Drawing.Point(51, 198);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(127, 17);
            this.listBox3.TabIndex = 5;
            this.listBox3.Visible = false;
            // 
            // lstRole
            // 
            this.lstRole.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstRole.FormattingEnabled = true;
            this.lstRole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstRole.Location = new System.Drawing.Point(228, 155);
            this.lstRole.Name = "lstRole";
            this.lstRole.Size = new System.Drawing.Size(127, 17);
            this.lstRole.TabIndex = 4;
            // 
            // lstSport
            // 
            this.lstSport.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstSport.FormattingEnabled = true;
            this.lstSport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstSport.Location = new System.Drawing.Point(51, 155);
            this.lstSport.Name = "lstSport";
            this.lstSport.Size = new System.Drawing.Size(127, 17);
            this.lstSport.TabIndex = 3;
            // 
            // txtLoginI
            // 
            this.txtLoginI.Location = new System.Drawing.Point(51, 108);
            this.txtLoginI.Name = "txtLoginI";
            this.txtLoginI.Size = new System.Drawing.Size(127, 20);
            this.txtLoginI.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(228, 56);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(127, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(51, 56);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(127, 20);
            this.txtNom.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPasswordC);
            this.groupBox2.Controls.Add(this.txtLoginC);
            this.groupBox2.Controls.Add(this.btnConnexion);
            this.groupBox2.Location = new System.Drawing.Point(68, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 243);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connexion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Login";
            // 
            // txtPasswordC
            // 
            this.txtPasswordC.Location = new System.Drawing.Point(88, 125);
            this.txtPasswordC.Name = "txtPasswordC";
            this.txtPasswordC.PasswordChar = '*';
            this.txtPasswordC.Size = new System.Drawing.Size(127, 20);
            this.txtPasswordC.TabIndex = 10;
            // 
            // txtLoginC
            // 
            this.txtLoginC.Location = new System.Drawing.Point(88, 73);
            this.txtLoginC.Name = "txtLoginC";
            this.txtLoginC.Size = new System.Drawing.Size(127, 20);
            this.txtLoginC.TabIndex = 9;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(31, 182);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(246, 31);
            this.btnConnexion.TabIndex = 8;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectionEquipe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.TextBox txtPasswordI;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox lstRole;
        private System.Windows.Forms.ListBox lstSport;
        private System.Windows.Forms.TextBox txtLoginI;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordC;
        private System.Windows.Forms.TextBox txtLoginC;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}

