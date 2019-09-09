using System;
using System.IO;

namespace Curiculum_Vitae
{
	public class Save
	{
		//---------------------------------------------------------------
		private System.String _Name;         // Name der Person
		private System.String _Vorname;      // Vorname der person
		private System.String _Alter;         // Alter person
		private System.String _Adresse;     // Adresse der person
        private System.String _Plz; // PLZ der person
        private System.String _Stadt;       // Stadt de person
        private System.String _Num_fix;     // Tel der person
        private System.String _Num_port;    // Mobile Der person
        private System.String _Num_fax;     // Fax der person
		private System.String _Email;       // E-Mail der person
		private System.Int32 _Geschlecht;         // Geschlecht der person
		private System.String _Photo;       // Photo der person
                                           //----------------------------------------------------------------
        private System.String _Ziel;    // Objectif de la personne
		private System.String _Kompetenz; // Compétences Professionnelles de la personne
		private System.String _Ausbildung;  // Formations de la personne
		private System.String _Interets;    // Centres d'intérêts de la personne
		//----------------------------------------------------------------

		// Konstruktor
		public Save(System.String lastname,
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
			//------------------------------------------------
			_Name         = lastname;    // Name
			_Vorname      = firstname;   // Vorname
			_Alter         = year;        // Alter
			_Adresse     = address;     // Adresse
			_Plz = postal_code; // Plz
			_Stadt       = city;        // Stadt
			_Num_fix     = fix_num;     // Telefon Fixe
			_Num_port    = port_num;    // Mobile
			_Num_fax     = fax;         // Fax
			_Email       = mail;        // E-Mail
			_Geschlecht        = sex;         // Geschlaecht
			_Photo       = foto;        // Photo
			//-------------------------------------------------
			_Ziel    = obj;         // Objectif
			_Kompetenz = comp_pro.Replace("\n","<BR>");    // Persönlichen Kompetenzen
			_Ausbildung  = formation.Replace("\n","<BR>");   // Ausbildung
			_Interets    = centres.Replace("\n","<BR>");     // Centres d'Intérets
			//-------------------------------------------------
		}

		public void SaveFile(System.String fileway)
		{
			StreamWriter Fichier;              // Deklaration des Objektes
			Fichier = File.CreateText(fileway);     // Erstellen der Datei
			//-------------------------------------------------
			Fichier.WriteLine(_Name);             // Name
			Fichier.WriteLine(_Vorname);          // Vorname
			Fichier.WriteLine(_Alter);             // Alter
			Fichier.WriteLine(_Adresse);         // Adresse
			Fichier.WriteLine(_Plz);     // Plz
			Fichier.WriteLine(_Stadt);           // Stadt
			Fichier.WriteLine(_Num_fix);         // Téléphone Fixe
			Fichier.WriteLine(_Num_port);        // Téléphone Mobile
			Fichier.WriteLine(_Num_fax);         // Fax
			Fichier.WriteLine(_Email);           // E-Mail
			Fichier.WriteLine(_Geschlecht.ToString()); // Geschlecht
			Fichier.WriteLine(_Photo);           // Photo
			//-------------------------------------------------
			Fichier.WriteLine(_Ziel);        // Ziel
			Fichier.WriteLine(_Kompetenz);     // Persönlichen Kompetenzen
            Fichier.WriteLine(_Ausbildung);      // Ausbildung
			Fichier.WriteLine(_Interets);        // Centres d'Intérêts
			//--------------------------------------------------
			Fichier.Close();
		}
	}
}
