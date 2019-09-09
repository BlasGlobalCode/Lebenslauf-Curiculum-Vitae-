using System;
using System.Windows.Forms;
using System.IO;

namespace Curiculum_Vitae
{
	/// <summary>
	/// Description résumée de Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		string fileway;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox name;
		private System.Windows.Forms.TextBox vorname;
		private System.Windows.Forms.TextBox adresse;
		private System.Windows.Forms.TextBox plz;
		private System.Windows.Forms.TextBox stadt;
		private System.Windows.Forms.TextBox tel_fixe;
		private System.Windows.Forms.TextBox tel_port;
		private System.Windows.Forms.TextBox fax;
		private System.Windows.Forms.Button CreateObjectCV;
		private System.Windows.Forms.TextBox alter;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox email;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox ziel;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.ComboBox sexe;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.RichTextBox comp_prof;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.RichTextBox ausbildung;
		private System.Windows.Forms.RichTextBox centre_interet;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button ImgSrc;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button BtnSpeichern;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private PictureBox srcimg;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Button button3;
        private Button button2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private System.ComponentModel.IContainer components;

        public Form1()
		{
			//
			// Requis pour la prise en charge du Concepteur Windows Forms
			//
			InitializeComponent();

			//
			// TODO : ajoutez le code du constructeur après l'appel à InitializeComponent
			//
		}

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vorname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.alter = new System.Windows.Forms.TextBox();
            this.adresse = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.plz = new System.Windows.Forms.TextBox();
            this.stadt = new System.Windows.Forms.TextBox();
            this.tel_fixe = new System.Windows.Forms.TextBox();
            this.tel_port = new System.Windows.Forms.TextBox();
            this.fax = new System.Windows.Forms.TextBox();
            this.CreateObjectCV = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ziel = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.sexe = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comp_prof = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ausbildung = new System.Windows.Forms.RichTextBox();
            this.centre_interet = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ImgSrc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnSpeichern = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.srcimg = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.srcimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.DarkSlateGray;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(136, 34);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 19);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(256, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vorname :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // vorname
            // 
            this.vorname.BackColor = System.Drawing.Color.DarkSlateGray;
            this.vorname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vorname.ForeColor = System.Drawing.Color.White;
            this.vorname.Location = new System.Drawing.Point(368, 34);
            this.vorname.Name = "vorname";
            this.vorname.Size = new System.Drawing.Size(100, 19);
            this.vorname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alter :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(256, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adresse :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // alter
            // 
            this.alter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.alter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alter.ForeColor = System.Drawing.Color.White;
            this.alter.Location = new System.Drawing.Point(136, 66);
            this.alter.Name = "alter";
            this.alter.Size = new System.Drawing.Size(100, 19);
            this.alter.TabIndex = 6;
            // 
            // adresse
            // 
            this.adresse.BackColor = System.Drawing.Color.DarkSlateGray;
            this.adresse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adresse.ForeColor = System.Drawing.Color.White;
            this.adresse.Location = new System.Drawing.Point(368, 66);
            this.adresse.Name = "adresse";
            this.adresse.Size = new System.Drawing.Size(100, 19);
            this.adresse.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "PlZ :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(256, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Stadt :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefon (fix) :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(256, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tel. Mobil :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(16, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fax :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plz
            // 
            this.plz.BackColor = System.Drawing.Color.DarkSlateGray;
            this.plz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plz.ForeColor = System.Drawing.Color.White;
            this.plz.Location = new System.Drawing.Point(136, 98);
            this.plz.Name = "plz";
            this.plz.Size = new System.Drawing.Size(100, 19);
            this.plz.TabIndex = 13;
            // 
            // stadt
            // 
            this.stadt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.stadt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stadt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stadt.ForeColor = System.Drawing.Color.White;
            this.stadt.Location = new System.Drawing.Point(368, 98);
            this.stadt.Name = "stadt";
            this.stadt.Size = new System.Drawing.Size(100, 19);
            this.stadt.TabIndex = 14;
            // 
            // tel_fixe
            // 
            this.tel_fixe.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tel_fixe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel_fixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_fixe.ForeColor = System.Drawing.Color.White;
            this.tel_fixe.Location = new System.Drawing.Point(136, 130);
            this.tel_fixe.Name = "tel_fixe";
            this.tel_fixe.Size = new System.Drawing.Size(100, 19);
            this.tel_fixe.TabIndex = 15;
            // 
            // tel_port
            // 
            this.tel_port.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tel_port.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tel_port.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_port.ForeColor = System.Drawing.Color.White;
            this.tel_port.Location = new System.Drawing.Point(368, 130);
            this.tel_port.Name = "tel_port";
            this.tel_port.Size = new System.Drawing.Size(100, 19);
            this.tel_port.TabIndex = 16;
            // 
            // fax
            // 
            this.fax.BackColor = System.Drawing.Color.DarkSlateGray;
            this.fax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fax.ForeColor = System.Drawing.Color.White;
            this.fax.Location = new System.Drawing.Point(136, 162);
            this.fax.Name = "fax";
            this.fax.Size = new System.Drawing.Size(100, 19);
            this.fax.TabIndex = 17;
            // 
            // CreateObjectCV
            // 
            this.CreateObjectCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateObjectCV.ForeColor = System.Drawing.Color.White;
            this.CreateObjectCV.Location = new System.Drawing.Point(560, 610);
            this.CreateObjectCV.Name = "CreateObjectCV";
            this.CreateObjectCV.Size = new System.Drawing.Size(128, 32);
            this.CreateObjectCV.TabIndex = 99;
            this.CreateObjectCV.Text = "erstellen / Visualisieren";
            this.CreateObjectCV.Click += new System.EventHandler(this.CreateObjectCV_Click);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(256, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 19;
            this.label10.Text = "E-Mail :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.DarkSlateGray;
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.Location = new System.Drawing.Point(368, 162);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 19);
            this.email.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(488, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 24);
            this.label11.TabIndex = 21;
            this.label11.Text = "Bild";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(16, 194);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ziel : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ziel
            // 
            this.ziel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ziel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ziel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ziel.ForeColor = System.Drawing.Color.White;
            this.ziel.Location = new System.Drawing.Point(136, 194);
            this.ziel.Name = "ziel";
            this.ziel.Size = new System.Drawing.Size(552, 19);
            this.ziel.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(488, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 24;
            this.label13.Text = "Geschlecht :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sexe
            // 
            this.sexe.BackColor = System.Drawing.Color.DarkSlateGray;
            this.sexe.ForeColor = System.Drawing.Color.White;
            this.sexe.Items.AddRange(new object[] {
            "Feminin",
            "Maskulin"});
            this.sexe.Location = new System.Drawing.Point(592, 162);
            this.sexe.Name = "sexe";
            this.sexe.Size = new System.Drawing.Size(96, 21);
            this.sexe.Sorted = true;
            this.sexe.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(8, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 23);
            this.label14.TabIndex = 26;
            this.label14.Text = "Ausbildung :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comp_prof
            // 
            this.comp_prof.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comp_prof.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comp_prof.ForeColor = System.Drawing.Color.White;
            this.comp_prof.Location = new System.Drawing.Point(136, 226);
            this.comp_prof.Name = "comp_prof";
            this.comp_prof.Size = new System.Drawing.Size(552, 112);
            this.comp_prof.TabIndex = 27;
            this.comp_prof.Text = "";
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(8, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 32);
            this.label15.TabIndex = 28;
            this.label15.Text = "Persönliche Kompetenze:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ausbildung
            // 
            this.ausbildung.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ausbildung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ausbildung.ForeColor = System.Drawing.Color.White;
            this.ausbildung.Location = new System.Drawing.Point(136, 354);
            this.ausbildung.Name = "ausbildung";
            this.ausbildung.Size = new System.Drawing.Size(552, 112);
            this.ausbildung.TabIndex = 29;
            this.ausbildung.Text = "";
            // 
            // centre_interet
            // 
            this.centre_interet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.centre_interet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.centre_interet.ForeColor = System.Drawing.Color.White;
            this.centre_interet.Location = new System.Drawing.Point(136, 482);
            this.centre_interet.Name = "centre_interet";
            this.centre_interet.Size = new System.Drawing.Size(552, 112);
            this.centre_interet.TabIndex = 30;
            this.centre_interet.Text = "";
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(8, 482);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 24);
            this.label16.TabIndex = 31;
            this.label16.Text = "Interesse :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ImgSrc
            // 
            this.ImgSrc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImgSrc.ForeColor = System.Drawing.Color.White;
            this.ImgSrc.Location = new System.Drawing.Point(600, 34);
            this.ImgSrc.Name = "ImgSrc";
            this.ImgSrc.Size = new System.Drawing.Size(88, 23);
            this.ImgSrc.TabIndex = 100;
            this.ImgSrc.Text = "Duchsuchen";
            this.ImgSrc.Click += new System.EventHandler(this.ImgSrc_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(136, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 32);
            this.button1.TabIndex = 102;
            this.button1.Text = "Öffnen";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSpeichern
            // 
            this.BtnSpeichern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSpeichern.ForeColor = System.Drawing.Color.White;
            this.BtnSpeichern.Location = new System.Drawing.Point(352, 610);
            this.BtnSpeichern.Name = "BtnSpeichern";
            this.BtnSpeichern.Size = new System.Drawing.Size(128, 32);
            this.BtnSpeichern.TabIndex = 103;
            this.BtnSpeichern.Text = "Speichern";
            this.BtnSpeichern.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuGradientPanel1.Controls.Add(this.button3);
            this.bunifuGradientPanel1.Controls.Add(this.button2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.HotTrack;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.SpringGreen;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Maroon;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(696, 28);
            this.bunifuGradientPanel1.TabIndex = 105;
            // 
            // srcimg
            // 
            this.srcimg.Location = new System.Drawing.Point(592, 61);
            this.srcimg.Name = "srcimg";
            this.srcimg.Size = new System.Drawing.Size(95, 91);
            this.srcimg.TabIndex = 106;
            this.srcimg.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(660, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 26);
            this.button2.TabIndex = 107;
            this.button2.Text = "X";
            this.button2.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(599, -1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 27);
            this.button3.TabIndex = 108;
            this.button3.Text = "-";
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Curiculum_Vitae.Properties.Resources.circle_github_icon_icons_com_66826;
            this.pictureBox4.Location = new System.Drawing.Point(0, 648);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 32);
            this.pictureBox4.TabIndex = 112;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this.pictureBox4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(696, 680);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.srcimg);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.BtnSpeichern);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ImgSrc);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.centre_interet);
            this.Controls.Add(this.ausbildung);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comp_prof);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.sexe);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.ziel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CreateObjectCV);
            this.Controls.Add(this.fax);
            this.Controls.Add(this.tel_port);
            this.Controls.Add(this.tel_fixe);
            this.Controls.Add(this.stadt);
            this.Controls.Add(this.plz);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.adresse);
            this.Controls.Add(this.alter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vorname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lebenslauf";
            this.Closed += new System.EventHandler(this.Form1_Closing);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.srcimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// Einstiegspunkt der App.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		public void CreateObjectCV_Click(object sender, System.EventArgs e)
		{
            
            CV Nouveau = new CV(name.Text,
				vorname.Text,         alter.Text,       adresse.Text,
				plz.Text,    stadt.Text,     tel_fixe.Text,
				tel_port.Text,       fax.Text,       email.Text,
				ziel.Text,       comp_prof.Text, ausbildung.Text,
				centre_interet.Text, sexe.SelectedIndex, srcimg.Text);

			fileway = Nouveau._Datei;
			Nouveau.ComposeCV();
		}

		private void Form1_Closing(object sender, System.EventArgs e)
		{
			try
			{
				if(fileway != "" || fileway != null)
				{
					FileInfo fil = new FileInfo(fileway);
					if(fil.Exists)
					{
						fil.Delete();
					}
				}
			} 
			catch
			{
				Application.Exit();
			}
		}

		private void ImgSrc_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog myWindow = new OpenFileDialog();
			myWindow.Title = "Profil Bild";
			myWindow.ShowDialog();
            srcimg.Text = myWindow.FileName;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			// Speicherung der Daten
			Save Sfile = new Save(name.Text,
				vorname.Text,
                alter.Text,
                adresse.Text,
				plz.Text,    
                stadt.Text,
                tel_fixe.Text,
				tel_port.Text,
                fax.Text, 
                email.Text,
				ziel.Text,
                comp_prof.Text,
                ausbildung.Text,
				centre_interet.Text,
                sexe.SelectedIndex, 
                srcimg.Text);
			SaveFileDialog myWindow = new SaveFileDialog();
			myWindow.ShowDialog();
			Sfile.SaveFile(myWindow.FileName);
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			// Daten auslesen
			OpenFileDialog myWindow = new OpenFileDialog();
			myWindow.ShowDialog();
			StreamReader Fichier;
			try
			{
				Fichier = File.OpenText(myWindow.FileName);
				name.Text = Fichier.ReadLine();
				vorname.Text = Fichier.ReadLine();
				alter.Text = Fichier.ReadLine();
				adresse.Text = Fichier.ReadLine();
				plz.Text = Fichier.ReadLine();
				stadt.Text = Fichier.ReadLine();
				tel_fixe.Text = Fichier.ReadLine();
				tel_port.Text = Fichier.ReadLine();
				fax.Text = Fichier.ReadLine();
				email.Text = Fichier.ReadLine();
				sexe.SelectedIndex = System.Int32.Parse(Fichier.ReadLine());
				srcimg.Text = Fichier.ReadLine();
				ziel.Text = Fichier.ReadLine();
				comp_prof.Text = Fichier.ReadLine().Replace("<BR>","\n");
				ausbildung.Text = Fichier.ReadLine().Replace("<BR>","\n");
				centre_interet.Text = Fichier.ReadLine().Replace("<BR>","\n");
				Fichier.Close();
			}
			catch(Exception E)
			{
				MessageBox.Show("Ein Fehler ist aufgetreten.\nDie Ausgewählten Datei ist nicht Korrekt");
                MessageBox.Show(E.Message);
            }
		}

        private void Button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/BlasGlobalCode/Lebenslauf-Curiculum-Vitae-");
        }
    }
 

}