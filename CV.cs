using System;
using System.IO;
using System.Text;

namespace Curiculum_Vitae
{
	/// <summary>
	/// Description résumée de CV.
	/// </summary>
	public class CV
	{
		// Déclarations des variables principales
		Random _Zufal = new Random();      // Création d'un Objet de tupe Random
		//---------------------------------------------------------------
		private System.String _Name;         // Nom de la personne
		private System.String _Vorname;      // Prénom de la personne
		private System.String _Alter;         // Âge de la personne
		private System.String _Adresse;     // Adresse de la personne
		private System.String _Plz; // Code Postal de la personne
		private System.String _Stadt;       // Ville de la personne
		private System.String _Num_fix;     // Téléphone Fixe de la personne
		private System.String _Num_port;    // Télépgone Mobile de la personne
		private System.String _Num_fax;     // Fax de la personne
		private System.String _Email;       // Adresse E-Mail de la personne
		private System.String[] _Geschlecht = 
			new System.String[2];          // Sexe de la personne
		private System.String _Photo;       // Photo de la personne
		private System.String _Ssexe;       // Sexe (string) de la personne
		//----------------------------------------------------------------
		private System.String _Ziel;    // Objectif de la personne
		private System.String _Kompetenz; // Compétences Professionnelles de la personne
		private System.String _Ausbildung;  // Formations de la personne
		private System.String Interets;    // Centres d'intérêts de la personne
		//----------------------------------------------------------------
		public System.String _Datei;      // Adresse du fichier temporaire

		// Fonction Constructrice
		public CV(System.String lastname,
			System.String firstname,
			System.String year,
			System.String address,
			System.String postal_code,
			System.String city,
			System.String fix_num,
			System.String port_num,
			System.String fax,
			System.String mail,
			System.String obj,
			System.String comp_pro,
			System.String formation,
			System.String centres,
			System.Int32 sex,
			System.String foto)
		{
			_Geschlecht[0] = "Frau.";
			_Geschlecht[1] = "Herr.";
			//------------------------------------------------
			_Name         = lastname;    // Nom
			_Vorname      = firstname;   // Prénom
			_Alter         = year;        // Âge
			_Adresse     = address;     // Adresse
			_Plz = postal_code; // Code Postal
			_Stadt       = city;        // Ville
			_Num_fix     = fix_num;     // Téléphone Fixe
			_Num_port    = port_num;    // Téléphone Mobile
			_Num_fax     = fax;         // Fax
			_Email       = mail;        // Adresse E-Mail
			_Ssexe       = _Geschlecht[sex];   // Sexe
			_Photo       = foto;        // Photo
			//-------------------------------------------------
			_Ziel    = obj;         // Objectif
			_Kompetenz = comp_pro.Replace("\n","<BR>");;    // Compétences Professionnelles
			_Ausbildung  = formation.Replace("\n","<BR>");;   // Formations
			Interets    = centres.Replace("\n","<BR>");;     // Centres d'Intérets
			//-------------------------------------------------
			_Datei = @"c:\Temp"+ _Zufal.Next(100000,999999).ToString()+".html";
		}

		// Permet d'organiser le code HTML à écrire
		public void ComposeCV()
		{
			System.String Text = "<HTML><HEAD><TITLE>Curiculum Vitae de " + _Ssexe +" " + _Name + "</TITLE></HEAD><BODY STYLE=\"font-family:verdana; font-size: x-small\"><CENTER><TABLE STYLE=\"font-family:verdana; font-size: small\" BORDER=0 WIDTH=70%><TR><TD WIDTH=50% VALIGN=TOP><B>"+_Ssexe+" "+_Name.ToUpper()+" "+_Vorname.ToUpper()+"</B><BR>"+_Adresse+"<BR>"+_Plz+" "+_Stadt+"<BR>";
			if(_Num_fix != null && _Num_fix != "") Text += "Téléphone Fixe : "+_Num_fix+"<BR>";
			if(_Num_port != null && _Num_port != "") Text += "Téléphone Mobile : "+_Num_port+"<BR>";
			if(_Num_fax != null && _Num_fax != "") Text += "Fax : "+_Num_fax+"<BR>";
			Text += _Alter+" Ans<BR>";
			if(_Email != null && _Email != "") Text += "E-Mail : "+_Email;
			Text += "</TD>";
			if(_Photo != null && _Photo != "") Text += "<TD ALIGN=RIGHT WIDTH=50% VALIGN=TOP><IMG SRC=\""+_Photo+"\" ALT=\"Photo de "+_Ssexe+" "+_Name+"\"></TD>";
			Text += "</TR></TABLE><H2>Objectif : "+_Ziel+"</H2><BR><TABLE STYLE=\"font-family:verdana; font-size: x-small\" BORDER=0 WIDTH=50%><TR><TD ALGIN=LEFT><H3>Compétence Professionelles</H3>"+_Kompetenz+"<BR><BR></TD></TR><TR><TD><H3>Formations</H3>"+_Ausbildung+"<BR><BR></TD></TR><TR><TD><H3>Centres d'Intérêts</H3>"+Interets+"<BR><BR></TD></TR></TABLE></CENTER></BODY></HTML>";
			WriteCV(_Datei,Text);
		}

		// Permet d'écrire le code HTML du CV dans un fichier temporaire
		private void WriteCV(string file, string val)
		{
			string s = "";
			FileInfo fi = new FileInfo(file);

			if (fi.Exists)
			{
				StreamReader sr = new StreamReader(file, ASCIIEncoding.Default);
				s = sr.ReadToEnd(); 
				sr.Close();
			}

			if (s == null || s == "") 
			{
				StreamWriter sw = new StreamWriter(file, false, ASCIIEncoding.Default);
				sw.Write(val);
				sw.Close(); 
			}
			else
			{
				StreamWriter sw = new StreamWriter(file, true, ASCIIEncoding.Default);
				sw.Write("\r\n" + val);
				sw.Close();
			}
			OpenCV();
		}

		// Permet d'ouvrir la page créée afin que l'utilisateur l'imprime
		private void OpenCV()
		{
			System.Diagnostics.Process.Start(@"c:\windows\explorer.exe ", _Datei);
		}

    }
}