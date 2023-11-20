using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

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
            this.button1 = new System.Windows.Forms.Button();
            this.listePrisonnier = new System.Windows.Forms.Panel();
            this.detailPrisonnierPanel = new System.Windows.Forms.Panel();
            this.detailPhoto = new System.Windows.Forms.PictureBox();
            this.detailNomPrenom = new System.Windows.Forms.Label();
            this.detailSortie = new System.Windows.Forms.Label();
            this.detailEntree = new System.Windows.Forms.Label();
            this.detailAdresse = new System.Windows.Forms.Label();
            this.detailGenre = new System.Windows.Forms.Label();
            this.detailID = new System.Windows.Forms.Label();
            this.detailNaissance = new System.Windows.Forms.Label();
            this.detailCellule = new System.Windows.Forms.Label();
            this.detailInfraction = new System.Windows.Forms.Label();
            this.afficherPrisonnier = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.listePrisonnier.SuspendLayout();
            this.detailPrisonnierPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(144, 3);
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
            this.header.Margin = new System.Windows.Forms.Padding(2, 3, 2, 4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(883, 39);
            this.header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Location = new System.Drawing.Point(653, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 26);
            this.panel1.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(157, 3);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(53, 19);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(2, 3);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            this.filterPanel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.filterPanel.MinimumSize = new System.Drawing.Size(152, 2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(152, 605);
            this.filterPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 561);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listePrisonnier
            // 
            this.listePrisonnier.AutoScroll = true;
            this.listePrisonnier.AutoSize = true;
            this.listePrisonnier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listePrisonnier.Controls.Add(this.detailPrisonnierPanel);
            this.listePrisonnier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listePrisonnier.Location = new System.Drawing.Point(152, 39);
            this.listePrisonnier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listePrisonnier.Name = "listePrisonnier";
            this.listePrisonnier.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.listePrisonnier.Size = new System.Drawing.Size(731, 605);
            this.listePrisonnier.TabIndex = 3;
            // 
            // detailPrisonnierPanel
            // 
            this.detailPrisonnierPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.detailPrisonnierPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailPrisonnierPanel.Controls.Add(this.detailInfraction);
            this.detailPrisonnierPanel.Controls.Add(this.detailCellule);
            this.detailPrisonnierPanel.Controls.Add(this.detailNaissance);
            this.detailPrisonnierPanel.Controls.Add(this.detailID);
            this.detailPrisonnierPanel.Controls.Add(this.detailGenre);
            this.detailPrisonnierPanel.Controls.Add(this.detailAdresse);
            this.detailPrisonnierPanel.Controls.Add(this.detailEntree);
            this.detailPrisonnierPanel.Controls.Add(this.detailSortie);
            this.detailPrisonnierPanel.Controls.Add(this.detailNomPrenom);
            this.detailPrisonnierPanel.Controls.Add(this.detailPhoto);
            this.detailPrisonnierPanel.Location = new System.Drawing.Point(-4, -1);
            this.detailPrisonnierPanel.Name = "detailPrisonnierPanel";
            this.detailPrisonnierPanel.Size = new System.Drawing.Size(734, 543);
            this.detailPrisonnierPanel.TabIndex = 0;
            // 
            // detailPhoto
            // 
            this.detailPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailPhoto.Location = new System.Drawing.Point(27, 27);
            this.detailPhoto.Name = "detailPhoto";
            this.detailPhoto.Size = new System.Drawing.Size(226, 309);
            this.detailPhoto.TabIndex = 0;
            this.detailPhoto.TabStop = false;
            // 
            // detailNomPrenom
            // 
            this.detailNomPrenom.AutoSize = true;
            this.detailNomPrenom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailNomPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailNomPrenom.Location = new System.Drawing.Point(272, 50);
            this.detailNomPrenom.Name = "detailNomPrenom";
            this.detailNomPrenom.Size = new System.Drawing.Size(171, 33);
            this.detailNomPrenom.TabIndex = 1;
            this.detailNomPrenom.Text = "John Danny";
            // 
            // detailSortie
            // 
            this.detailSortie.AutoSize = true;
            this.detailSortie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailSortie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailSortie.Location = new System.Drawing.Point(27, 413);
            this.detailSortie.Name = "detailSortie";
            this.detailSortie.Size = new System.Drawing.Size(301, 33);
            this.detailSortie.TabIndex = 2;
            this.detailSortie.Text = "Sortie le : \"xx/xx/xxxx\"";
            // 
            // detailEntree
            // 
            this.detailEntree.AutoSize = true;
            this.detailEntree.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailEntree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailEntree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailEntree.Location = new System.Drawing.Point(27, 366);
            this.detailEntree.Name = "detailEntree";
            this.detailEntree.Size = new System.Drawing.Size(301, 33);
            this.detailEntree.TabIndex = 3;
            this.detailEntree.Text = "Arrive le : \"xx/xx/xxxx\"";
            // 
            // detailAdresse
            // 
            this.detailAdresse.AutoSize = true;
            this.detailAdresse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailAdresse.Location = new System.Drawing.Point(272, 303);
            this.detailAdresse.Name = "detailAdresse";
            this.detailAdresse.Size = new System.Drawing.Size(276, 33);
            this.detailAdresse.TabIndex = 4;
            this.detailAdresse.Text = "123 rue de la Prison";
            // 
            // detailGenre
            // 
            this.detailGenre.AutoSize = true;
            this.detailGenre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailGenre.Location = new System.Drawing.Point(272, 172);
            this.detailGenre.Name = "detailGenre";
            this.detailGenre.Size = new System.Drawing.Size(115, 33);
            this.detailGenre.TabIndex = 5;
            this.detailGenre.Text = "Homme";
            this.detailGenre.Click += new System.EventHandler(this.detailGenre_Click);
            // 
            // detailID
            // 
            this.detailID.AutoSize = true;
            this.detailID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailID.Location = new System.Drawing.Point(272, 113);
            this.detailID.Name = "detailID";
            this.detailID.Size = new System.Drawing.Size(135, 33);
            this.detailID.TabIndex = 6;
            this.detailID.Text = "ID : \"xxx\"";
            this.detailID.Click += new System.EventHandler(this.label5_Click);
            // 
            // detailNaissance
            // 
            this.detailNaissance.AutoSize = true;
            this.detailNaissance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailNaissance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailNaissance.Location = new System.Drawing.Point(272, 234);
            this.detailNaissance.Name = "detailNaissance";
            this.detailNaissance.Size = new System.Drawing.Size(272, 33);
            this.detailNaissance.TabIndex = 7;
            this.detailNaissance.Text = "Ne le : \"\"xx/xx/xxxx\"";
            // 
            // detailCellule
            // 
            this.detailCellule.AutoSize = true;
            this.detailCellule.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailCellule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailCellule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailCellule.Location = new System.Drawing.Point(433, 113);
            this.detailCellule.Name = "detailCellule";
            this.detailCellule.Size = new System.Drawing.Size(236, 33);
            this.detailCellule.TabIndex = 8;
            this.detailCellule.Text = "N° Cellule : \"xxx\"";
            // 
            // detailInfraction
            // 
            this.detailInfraction.AutoSize = true;
            this.detailInfraction.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailInfraction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailInfraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailInfraction.Location = new System.Drawing.Point(27, 468);
            this.detailInfraction.Name = "detailInfraction";
            this.detailInfraction.Size = new System.Drawing.Size(379, 33);
            this.detailInfraction.TabIndex = 9;
            this.detailInfraction.Text = "Infraction commise : \"xxxxx\"";
            // 
            // afficherPrisonnier
            // 
            this.afficherPrisonnier.Location = new System.Drawing.Point(0, -1);
            this.afficherPrisonnier.Name = "afficherPrisonnier";
            this.afficherPrisonnier.Size = new System.Drawing.Size(112, 43);
            this.afficherPrisonnier.TabIndex = 10;
            this.afficherPrisonnier.Text = "afficherDetails";
            this.afficherPrisonnier.UseVisualStyleBackColor = true;
            this.afficherPrisonnier.Click += new System.EventHandler(this.afficherPrisonnier_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 644);
            this.Controls.Add(this.listePrisonnier);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.listePrisonnier.ResumeLayout(false);
            this.detailPrisonnierPanel.ResumeLayout(false);
            this.detailPrisonnierPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailPhoto)).EndInit();
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
        private Panel detailPrisonnierPanel;
        private PictureBox detailPhoto;
        private Label detailID;
        private Label detailGenre;
        private Label detailAdresse;
        private Label detailEntree;
        private Label detailSortie;
        private Label detailNomPrenom;
        private Label detailCellule;
        private Label detailNaissance;
        private Label detailInfraction;
        private Button afficherPrisonnier;
    }
}

