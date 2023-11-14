using MySql.Data.MySqlClient;
using System;
using System.Configuration;

namespace ClackosProj2
{
    partial class Form1
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
            this.title = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.afficherPrisonnier = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listePrisonnier = new System.Windows.Forms.Panel();
            this.detailsPrisonnier = new System.Windows.Forms.Panel();
            this.Nom = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.detailNom = new System.Windows.Forms.Label();
            this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.detailID = new System.Windows.Forms.Label();
            this.detailArrive = new System.Windows.Forms.Label();
            this.detailDepart = new System.Windows.Forms.Label();
            this.detailStatut = new System.Windows.Forms.Label();
            this.detailNaissance = new System.Windows.Forms.Label();
            this.detailPrenom = new System.Windows.Forms.Label();
            this.detailGenre = new System.Windows.Forms.Label();
            this.detailAdresse = new System.Windows.Forms.Label();
            this.detailInfraction = new System.Windows.Forms.Label();
            this.detailCellule = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.listePrisonnier.SuspendLayout();
            this.detailsPrisonnier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(144, 2);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(224, 27);
            this.title.TabIndex = 0;
            this.title.Text = "PrYson V2 APP EDITION";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Controls.Add(this.panel1);
            this.header.Controls.Add(this.title);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(884, 39);
            this.header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Location = new System.Drawing.Point(652, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 26);
            this.panel1.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(158, 2);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(52, 19);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(2, 2);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(152, 20);
            this.searchBox.TabIndex = 1;
            // 
            // filterPanel
            // 
            this.filterPanel.AutoSize = true;
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.afficherPrisonnier);
            this.filterPanel.Controls.Add(this.button1);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterPanel.Location = new System.Drawing.Point(0, 39);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(153, 814);
            this.filterPanel.TabIndex = 2;
            // 
            // afficherPrisonnier
            // 
            this.afficherPrisonnier.Location = new System.Drawing.Point(11, 341);
            this.afficherPrisonnier.Name = "afficherPrisonnier";
            this.afficherPrisonnier.Size = new System.Drawing.Size(136, 51);
            this.afficherPrisonnier.TabIndex = 1;
            this.afficherPrisonnier.Text = "afficherPrisonnier";
            this.afficherPrisonnier.UseVisualStyleBackColor = true;
            this.afficherPrisonnier.Click += new System.EventHandler(this.afficherPrisonnier_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 275);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listePrisonnier
            // 
            this.listePrisonnier.AutoScroll = true;
            this.listePrisonnier.AutoSize = true;
            this.listePrisonnier.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listePrisonnier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.listePrisonnier.Controls.Add(this.detailsPrisonnier);
            this.listePrisonnier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listePrisonnier.Location = new System.Drawing.Point(153, 39);
            this.listePrisonnier.Margin = new System.Windows.Forms.Padding(2);
            this.listePrisonnier.Name = "listePrisonnier";
            this.listePrisonnier.Size = new System.Drawing.Size(731, 814);
            this.listePrisonnier.TabIndex = 3;
            // 
            // detailsPrisonnier
            // 
            this.detailsPrisonnier.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.detailsPrisonnier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailsPrisonnier.CausesValidation = false;
            this.detailsPrisonnier.Controls.Add(this.panel2);
            this.detailsPrisonnier.Controls.Add(this.Nom);
            this.detailsPrisonnier.Controls.Add(this.pictureBox1);
            this.detailsPrisonnier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.detailsPrisonnier.Location = new System.Drawing.Point(0, -2);
            this.detailsPrisonnier.Name = "detailsPrisonnier";
            this.detailsPrisonnier.Size = new System.Drawing.Size(729, 459);
            this.detailsPrisonnier.TabIndex = 0;
            this.detailsPrisonnier.Paint += new System.Windows.Forms.PaintEventHandler(this.detailsPrisonnier_Paint);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.BackColor = System.Drawing.SystemColors.Control;
            this.Nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nom.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.Nom.Location = new System.Drawing.Point(245, 42);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(2, 15);
            this.Nom.TabIndex = 1;
            this.Nom.Click += new System.EventHandler(this.Nom_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 299);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.CausesValidation = false;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(-2, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 415);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Corbel", 8.25F);
            this.label1.Location = new System.Drawing.Point(245, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 15);
            this.label1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(185, 299);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.CausesValidation = false;
            this.panel3.Controls.Add(this.detailCellule);
            this.panel3.Controls.Add(this.detailInfraction);
            this.panel3.Controls.Add(this.detailAdresse);
            this.panel3.Controls.Add(this.detailGenre);
            this.panel3.Controls.Add(this.detailPrenom);
            this.panel3.Controls.Add(this.detailNaissance);
            this.panel3.Controls.Add(this.detailStatut);
            this.panel3.Controls.Add(this.detailDepart);
            this.panel3.Controls.Add(this.detailArrive);
            this.panel3.Controls.Add(this.detailID);
            this.panel3.Controls.Add(this.detailNom);
            this.panel3.Controls.Add(this.pictureBoxPhoto);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 415);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // detailNom
            // 
            this.detailNom.AutoSize = true;
            this.detailNom.BackColor = System.Drawing.SystemColors.Control;
            this.detailNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailNom.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailNom.Location = new System.Drawing.Point(245, 26);
            this.detailNom.Name = "detailNom";
            this.detailNom.Size = new System.Drawing.Size(56, 31);
            this.detailNom.TabIndex = 1;
            this.detailNom.Text = "Test";
            this.detailNom.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBoxPhoto
            // 
            this.pictureBoxPhoto.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPhoto.Name = "pictureBoxPhoto";
            this.pictureBoxPhoto.Size = new System.Drawing.Size(185, 299);
            this.pictureBoxPhoto.TabIndex = 0;
            this.pictureBoxPhoto.TabStop = false;
            // 
            // detailID
            // 
            this.detailID.AutoSize = true;
            this.detailID.BackColor = System.Drawing.SystemColors.Control;
            this.detailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailID.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailID.Location = new System.Drawing.Point(484, 29);
            this.detailID.Name = "detailID";
            this.detailID.Size = new System.Drawing.Size(56, 31);
            this.detailID.TabIndex = 2;
            this.detailID.Text = "Test";
            // 
            // detailArrive
            // 
            this.detailArrive.AutoSize = true;
            this.detailArrive.BackColor = System.Drawing.SystemColors.Control;
            this.detailArrive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailArrive.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailArrive.Location = new System.Drawing.Point(245, 96);
            this.detailArrive.Name = "detailArrive";
            this.detailArrive.Size = new System.Drawing.Size(56, 31);
            this.detailArrive.TabIndex = 3;
            this.detailArrive.Text = "Test";
            // 
            // detailDepart
            // 
            this.detailDepart.AutoSize = true;
            this.detailDepart.BackColor = System.Drawing.SystemColors.Control;
            this.detailDepart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailDepart.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailDepart.Location = new System.Drawing.Point(374, 96);
            this.detailDepart.Name = "detailDepart";
            this.detailDepart.Size = new System.Drawing.Size(56, 31);
            this.detailDepart.TabIndex = 4;
            this.detailDepart.Text = "Test";
            // 
            // detailStatut
            // 
            this.detailStatut.AutoSize = true;
            this.detailStatut.BackColor = System.Drawing.SystemColors.Control;
            this.detailStatut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailStatut.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailStatut.Location = new System.Drawing.Point(484, 96);
            this.detailStatut.Name = "detailStatut";
            this.detailStatut.Size = new System.Drawing.Size(56, 31);
            this.detailStatut.TabIndex = 5;
            this.detailStatut.Text = "Test";
            // 
            // detailNaissance
            // 
            this.detailNaissance.AutoSize = true;
            this.detailNaissance.BackColor = System.Drawing.SystemColors.Control;
            this.detailNaissance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailNaissance.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailNaissance.Location = new System.Drawing.Point(245, 191);
            this.detailNaissance.Name = "detailNaissance";
            this.detailNaissance.Size = new System.Drawing.Size(56, 31);
            this.detailNaissance.TabIndex = 6;
            this.detailNaissance.Text = "Test";
            // 
            // detailPrenom
            // 
            this.detailPrenom.AutoSize = true;
            this.detailPrenom.BackColor = System.Drawing.SystemColors.Control;
            this.detailPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailPrenom.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailPrenom.Location = new System.Drawing.Point(374, 29);
            this.detailPrenom.Name = "detailPrenom";
            this.detailPrenom.Size = new System.Drawing.Size(56, 31);
            this.detailPrenom.TabIndex = 7;
            this.detailPrenom.Text = "Test";
            // 
            // detailGenre
            // 
            this.detailGenre.AutoSize = true;
            this.detailGenre.BackColor = System.Drawing.SystemColors.Control;
            this.detailGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailGenre.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailGenre.Location = new System.Drawing.Point(374, 191);
            this.detailGenre.Name = "detailGenre";
            this.detailGenre.Size = new System.Drawing.Size(56, 31);
            this.detailGenre.TabIndex = 8;
            this.detailGenre.Text = "Test";
            // 
            // detailAdresse
            // 
            this.detailAdresse.AutoSize = true;
            this.detailAdresse.BackColor = System.Drawing.SystemColors.Control;
            this.detailAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailAdresse.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailAdresse.Location = new System.Drawing.Point(484, 191);
            this.detailAdresse.Name = "detailAdresse";
            this.detailAdresse.Size = new System.Drawing.Size(56, 31);
            this.detailAdresse.TabIndex = 9;
            this.detailAdresse.Text = "Test";
            // 
            // detailInfraction
            // 
            this.detailInfraction.AutoSize = true;
            this.detailInfraction.BackColor = System.Drawing.SystemColors.Control;
            this.detailInfraction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailInfraction.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailInfraction.Location = new System.Drawing.Point(245, 289);
            this.detailInfraction.Name = "detailInfraction";
            this.detailInfraction.Size = new System.Drawing.Size(56, 31);
            this.detailInfraction.TabIndex = 10;
            this.detailInfraction.Text = "Test";
            // 
            // detailCellule
            // 
            this.detailCellule.AutoSize = true;
            this.detailCellule.BackColor = System.Drawing.SystemColors.Control;
            this.detailCellule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailCellule.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailCellule.Location = new System.Drawing.Point(374, 289);
            this.detailCellule.Name = "detailCellule";
            this.detailCellule.Size = new System.Drawing.Size(56, 31);
            this.detailCellule.TabIndex = 11;
            this.detailCellule.Text = "Test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 853);
            this.Controls.Add(this.listePrisonnier);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.header);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.listePrisonnier.ResumeLayout(false);
            this.detailsPrisonnier.ResumeLayout(false);
            this.detailsPrisonnier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel listePrisonnier;
        private System.Windows.Forms.Button afficherPrisonnier;
        private System.Windows.Forms.Panel detailsPrisonnier;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label detailNom;
        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label detailGenre;
        private System.Windows.Forms.Label detailPrenom;
        private System.Windows.Forms.Label detailNaissance;
        private System.Windows.Forms.Label detailStatut;
        private System.Windows.Forms.Label detailDepart;
        private System.Windows.Forms.Label detailArrive;
        private System.Windows.Forms.Label detailID;
        private System.Windows.Forms.Label detailCellule;
        private System.Windows.Forms.Label detailInfraction;
        private System.Windows.Forms.Label detailAdresse;
    }
}

