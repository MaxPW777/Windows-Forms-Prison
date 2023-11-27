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
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listePrisonnier = new System.Windows.Forms.Panel();
            this.allInfo = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.textBoxPhoto = new System.Windows.Forms.TextBox();
            this.textBoxExit = new System.Windows.Forms.TextBox();
            this.textBoxEntry = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxBirth = new System.Windows.Forms.TextBox();
            this.textBoxPrenom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.InfractionBox = new System.Windows.Forms.ComboBox();
            this.textBoxDetail = new System.Windows.Forms.TextBox();
            this.textBoxPeine = new System.Windows.Forms.TextBox();
            this.BoxCellules = new System.Windows.Forms.ComboBox();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.listePrisonnier.SuspendLayout();
            this.allInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(192, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(271, 33);
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
            this.header.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1178, 48);
            this.header.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Location = new System.Drawing.Point(870, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 32);
            this.panel1.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(210, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(70, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(3, 3);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(201, 22);
            this.searchBox.TabIndex = 1;
            // 
            // filterPanel
            // 
            this.filterPanel.AutoSize = true;
            this.filterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterPanel.Controls.Add(this.button3);
            this.filterPanel.Controls.Add(this.button1);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.filterPanel.Location = new System.Drawing.Point(0, 48);
            this.filterPanel.Margin = new System.Windows.Forms.Padding(6);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(204, 1002);
            this.filterPanel.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 56);
            this.button3.TabIndex = 1;
            this.button3.Text = "Add Prisoner";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 51);
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
            this.listePrisonnier.Controls.Add(this.allInfo);
            this.listePrisonnier.Controls.Add(this.button2);
            this.listePrisonnier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listePrisonnier.Location = new System.Drawing.Point(204, 48);
            this.listePrisonnier.Name = "listePrisonnier";
            this.listePrisonnier.Size = new System.Drawing.Size(974, 1002);
            this.listePrisonnier.TabIndex = 3;
            // 
            // allInfo
            // 
            this.allInfo.AutoSize = true;
            this.allInfo.BackColor = System.Drawing.SystemColors.Info;
            this.allInfo.Controls.Add(this.BoxCellules);
            this.allInfo.Controls.Add(this.textBoxPeine);
            this.allInfo.Controls.Add(this.textBoxDetail);
            this.allInfo.Controls.Add(this.InfractionBox);
            this.allInfo.Controls.Add(this.button4);
            this.allInfo.Controls.Add(this.textBoxStatus);
            this.allInfo.Controls.Add(this.textBoxPhoto);
            this.allInfo.Controls.Add(this.textBoxExit);
            this.allInfo.Controls.Add(this.textBoxEntry);
            this.allInfo.Controls.Add(this.textBoxAdress);
            this.allInfo.Controls.Add(this.textBoxGender);
            this.allInfo.Controls.Add(this.textBoxBirth);
            this.allInfo.Controls.Add(this.textBoxPrenom);
            this.allInfo.Controls.Add(this.textBoxNom);
            this.allInfo.Location = new System.Drawing.Point(258, 84);
            this.allInfo.Name = "allInfo";
            this.allInfo.Size = new System.Drawing.Size(655, 866);
            this.allInfo.TabIndex = 1;
            this.allInfo.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(261, 785);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "ADD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(25, 450);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(239, 22);
            this.textBoxStatus.TabIndex = 8;
            this.textBoxStatus.Text = "Condamné";
            // 
            // textBoxPhoto
            // 
            this.textBoxPhoto.Location = new System.Drawing.Point(25, 400);
            this.textBoxPhoto.Name = "textBoxPhoto";
            this.textBoxPhoto.Size = new System.Drawing.Size(239, 22);
            this.textBoxPhoto.TabIndex = 7;
            this.textBoxPhoto.Text = "photo_ludo.png";
            // 
            // textBoxExit
            // 
            this.textBoxExit.Location = new System.Drawing.Point(25, 350);
            this.textBoxExit.Name = "textBoxExit";
            this.textBoxExit.Size = new System.Drawing.Size(239, 22);
            this.textBoxExit.TabIndex = 6;
            this.textBoxExit.Text = "2025-12-04";
            // 
            // textBoxEntry
            // 
            this.textBoxEntry.Location = new System.Drawing.Point(25, 300);
            this.textBoxEntry.Name = "textBoxEntry";
            this.textBoxEntry.Size = new System.Drawing.Size(239, 22);
            this.textBoxEntry.TabIndex = 5;
            this.textBoxEntry.Text = "2021-02-24";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(25, 250);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(239, 22);
            this.textBoxAdress.TabIndex = 4;
            this.textBoxAdress.Text = "Homme";
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(25, 200);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(239, 22);
            this.textBoxGender.TabIndex = 3;
            this.textBoxGender.Text = "635 avenue jean leonardi";
            // 
            // textBoxBirth
            // 
            this.textBoxBirth.Location = new System.Drawing.Point(25, 150);
            this.textBoxBirth.Name = "textBoxBirth";
            this.textBoxBirth.Size = new System.Drawing.Size(239, 22);
            this.textBoxBirth.TabIndex = 2;
            this.textBoxBirth.Text = "2000-09-17";
            // 
            // textBoxPrenom
            // 
            this.textBoxPrenom.Location = new System.Drawing.Point(25, 100);
            this.textBoxPrenom.Name = "textBoxPrenom";
            this.textBoxPrenom.Size = new System.Drawing.Size(239, 22);
            this.textBoxPrenom.TabIndex = 1;
            this.textBoxPrenom.Text = "ludovic";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(25, 50);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(239, 22);
            this.textBoxNom.TabIndex = 0;
            this.textBoxNom.Text = "gernay";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InfractionBox
            // 
            this.InfractionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InfractionBox.FormattingEnabled = true;
            this.InfractionBox.Items.AddRange(new object[] {
            "Vol",
            "Meurte",
            "Vandalisme",
            "Harcèlement",
            "Fraude"});
            this.InfractionBox.Location = new System.Drawing.Point(25, 497);
            this.InfractionBox.Name = "InfractionBox";
            this.InfractionBox.Size = new System.Drawing.Size(239, 24);
            this.InfractionBox.TabIndex = 10;
            // 
            // textBoxDetail
            // 
            this.textBoxDetail.Location = new System.Drawing.Point(25, 545);
            this.textBoxDetail.Name = "textBoxDetail";
            this.textBoxDetail.Size = new System.Drawing.Size(570, 22);
            this.textBoxDetail.TabIndex = 11;
            // 
            // textBoxPeine
            // 
            this.textBoxPeine.Location = new System.Drawing.Point(25, 602);
            this.textBoxPeine.Name = "textBoxPeine";
            this.textBoxPeine.Size = new System.Drawing.Size(239, 22);
            this.textBoxPeine.TabIndex = 12;
            // 
            // BoxCellules
            // 
            this.BoxCellules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxCellules.FormattingEnabled = true;
            this.BoxCellules.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105"});
            this.BoxCellules.Location = new System.Drawing.Point(25, 666);
            this.BoxCellules.Name = "BoxCellules";
            this.BoxCellules.Size = new System.Drawing.Size(121, 24);
            this.BoxCellules.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 1050);
            this.Controls.Add(this.listePrisonnier);
            this.Controls.Add(this.filterPanel);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.filterPanel.ResumeLayout(false);
            this.listePrisonnier.ResumeLayout(false);
            this.listePrisonnier.PerformLayout();
            this.allInfo.ResumeLayout(false);
            this.allInfo.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel allInfo;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxBirth;
        private System.Windows.Forms.TextBox textBoxPrenom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.TextBox textBoxPhoto;
        private System.Windows.Forms.TextBox textBoxExit;
        private System.Windows.Forms.TextBox textBoxEntry;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox InfractionBox;
        private System.Windows.Forms.TextBox textBoxDetail;
        private System.Windows.Forms.ComboBox BoxCellules;
        private System.Windows.Forms.TextBox textBoxPeine;
    }
}

