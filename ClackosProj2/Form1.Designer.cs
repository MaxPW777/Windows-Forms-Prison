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
            this.CloseWindow = new System.Windows.Forms.Button();
            this.detailInfraction = new System.Windows.Forms.Label();
            this.detailCellule = new System.Windows.Forms.Label();
            this.detailNaissance = new System.Windows.Forms.Label();
            this.detailID = new System.Windows.Forms.Label();
            this.detailGenre = new System.Windows.Forms.Label();
            this.detailAdresse = new System.Windows.Forms.Label();
            this.detailEntree = new System.Windows.Forms.Label();
            this.detailSortie = new System.Windows.Forms.Label();
            this.detailNomPrenom = new System.Windows.Forms.Label();
            this.detailPhoto = new System.Windows.Forms.PictureBox();
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
            this.title.ForeColor = System.Drawing.SystemColors.Control;
            this.title.Location = new System.Drawing.Point(216, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(324, 39);
            this.title.TabIndex = 0;
            this.title.Text = "PrYson V2 APP EDITION";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.header.Controls.Add(this.panel1);
            this.header.Controls.Add(this.title);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(3, 5, 3, 6);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1324, 60);
            this.header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Location = new System.Drawing.Point(980, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 40);
            this.panel1.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(236, 5);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(80, 29);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(3, 5);
            this.searchBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(226, 26);
            this.searchBox.TabIndex = 1;
            // 
            // filterPanel
            // 
            this.filterPanel.AutoSize = true;
            this.filterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.button1);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterPanel.Location = new System.Drawing.Point(0, 60);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(8);
            this.filterPanel.MinimumSize = new System.Drawing.Size(227, 2);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(227, 931);
            this.filterPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 864);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generer Prisonniers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listePrisonnier
            // 
            this.listePrisonnier.AutoScroll = true;
            this.listePrisonnier.AutoSize = true;
            this.listePrisonnier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listePrisonnier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listePrisonnier.Controls.Add(this.detailPrisonnierPanel);
            this.listePrisonnier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listePrisonnier.Location = new System.Drawing.Point(227, 60);
            this.listePrisonnier.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.listePrisonnier.Name = "listePrisonnier";
            this.listePrisonnier.Padding = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.listePrisonnier.Size = new System.Drawing.Size(1097, 931);
            this.listePrisonnier.TabIndex = 3;
            // 
            // detailPrisonnierPanel
            // 
            this.detailPrisonnierPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.detailPrisonnierPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailPrisonnierPanel.Controls.Add(this.CloseWindow);
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
            this.detailPrisonnierPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailPrisonnierPanel.Location = new System.Drawing.Point(10, 9);
            this.detailPrisonnierPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailPrisonnierPanel.Name = "detailPrisonnierPanel";
            this.detailPrisonnierPanel.Size = new System.Drawing.Size(1075, 911);
            this.detailPrisonnierPanel.TabIndex = 0;
            this.detailPrisonnierPanel.Visible = false;
            // 
            // CloseWindow
            // 
            this.CloseWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseWindow.BackColor = System.Drawing.Color.Salmon;
            this.CloseWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseWindow.ForeColor = System.Drawing.SystemColors.Control;
            this.CloseWindow.Location = new System.Drawing.Point(1024, 3);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(46, 46);
            this.CloseWindow.TabIndex = 10;
            this.CloseWindow.Text = "X";
            this.CloseWindow.UseVisualStyleBackColor = false;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click_1);
            // 
            // detailInfraction
            // 
            this.detailInfraction.AutoSize = true;
            this.detailInfraction.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailInfraction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailInfraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailInfraction.Location = new System.Drawing.Point(615, 113);
            this.detailInfraction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailInfraction.Name = "detailInfraction";
            this.detailInfraction.Size = new System.Drawing.Size(380, 49);
            this.detailInfraction.TabIndex = 9;
            this.detailInfraction.Text = "Infraction : \"xxxxx\"";
            // 
            // detailCellule
            // 
            this.detailCellule.AutoSize = true;
            this.detailCellule.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailCellule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailCellule.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailCellule.Location = new System.Drawing.Point(408, 181);
            this.detailCellule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailCellule.Name = "detailCellule";
            this.detailCellule.Size = new System.Drawing.Size(352, 49);
            this.detailCellule.TabIndex = 8;
            this.detailCellule.Text = "N° Cellule : \"xxx\"";
            // 
            // detailNaissance
            // 
            this.detailNaissance.AutoSize = true;
            this.detailNaissance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailNaissance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailNaissance.Location = new System.Drawing.Point(408, 341);
            this.detailNaissance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailNaissance.Name = "detailNaissance";
            this.detailNaissance.Size = new System.Drawing.Size(408, 49);
            this.detailNaissance.TabIndex = 7;
            this.detailNaissance.Text = "Ne le : \"\"xx/xx/xxxx\"";
            // 
            // detailID
            // 
            this.detailID.AutoSize = true;
            this.detailID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailID.Location = new System.Drawing.Point(408, 113);
            this.detailID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailID.Name = "detailID";
            this.detailID.Size = new System.Drawing.Size(199, 49);
            this.detailID.TabIndex = 6;
            this.detailID.Text = "ID : \"xxx\"";
            // 
            // detailGenre
            // 
            this.detailGenre.AutoSize = true;
            this.detailGenre.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailGenre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailGenre.Location = new System.Drawing.Point(408, 265);
            this.detailGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailGenre.Name = "detailGenre";
            this.detailGenre.Size = new System.Drawing.Size(286, 49);
            this.detailGenre.TabIndex = 5;
            this.detailGenre.Text = "Sexe: homme";
            // 
            // detailAdresse
            // 
            this.detailAdresse.AutoSize = true;
            this.detailAdresse.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailAdresse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailAdresse.Location = new System.Drawing.Point(408, 418);
            this.detailAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailAdresse.Name = "detailAdresse";
            this.detailAdresse.Size = new System.Drawing.Size(412, 49);
            this.detailAdresse.TabIndex = 4;
            this.detailAdresse.Text = "123 rue de la Prison";
            // 
            // detailEntree
            // 
            this.detailEntree.AutoSize = true;
            this.detailEntree.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailEntree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailEntree.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailEntree.Location = new System.Drawing.Point(40, 535);
            this.detailEntree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailEntree.Name = "detailEntree";
            this.detailEntree.Size = new System.Drawing.Size(452, 49);
            this.detailEntree.TabIndex = 3;
            this.detailEntree.Text = "Arrive le : \"xx/xx/xxxx\"";
            // 
            // detailSortie
            // 
            this.detailSortie.AutoSize = true;
            this.detailSortie.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailSortie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailSortie.Location = new System.Drawing.Point(500, 535);
            this.detailSortie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailSortie.Name = "detailSortie";
            this.detailSortie.Size = new System.Drawing.Size(451, 49);
            this.detailSortie.TabIndex = 2;
            this.detailSortie.Text = "Sortie le : \"xx/xx/xxxx\"";
            // 
            // detailNomPrenom
            // 
            this.detailNomPrenom.AutoSize = true;
            this.detailNomPrenom.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.detailNomPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.detailNomPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailNomPrenom.Location = new System.Drawing.Point(408, 42);
            this.detailNomPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detailNomPrenom.Name = "detailNomPrenom";
            this.detailNomPrenom.Size = new System.Drawing.Size(253, 49);
            this.detailNomPrenom.TabIndex = 1;
            this.detailNomPrenom.Text = "John Danny";
            // 
            // detailPhoto
            // 
            this.detailPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.detailPhoto.Location = new System.Drawing.Point(40, 71);
            this.detailPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.detailPhoto.Name = "detailPhoto";
            this.detailPhoto.Size = new System.Drawing.Size(337, 359);
            this.detailPhoto.TabIndex = 0;
            this.detailPhoto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 991);
            this.Controls.Add(this.listePrisonnier);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
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
        private Button CloseWindow;
    }
}

