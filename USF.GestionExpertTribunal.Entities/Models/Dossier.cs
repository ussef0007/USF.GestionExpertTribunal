﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace USF.GestionExpertTribunal.Entities.Models
{
	public class Dossier
	{
		private int id;

		private string nom;

		private int code;

		private DateTime dateCreation;

		private bool isTaken;

		private DateTime delai;

		private double prix;

		private string objet;

		private string commantaire;

		private DateTime delaiModifier;

		private double prixModifier;

		private string state;

		private Greffier greffiers;

		public virtual int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}

		public virtual string Nom
		{
			get { return this.nom; }
			set { this.nom = value; }
		}

		public virtual int Code
		{
			get { return this.code; }
			set { this.code = value; }
		}

		public virtual DateTime DateCreation
		{
			get { return this.dateCreation; }
			set { this.dateCreation = value; }
		}

		public virtual bool IsTaken
		{
			get { return this.isTaken; }
			set { this.isTaken = value; }
		}

		public virtual DateTime Delai
		{
			get { return this.delai; }
			set { this.delai = value; }
		}

		public virtual double Prix
		{
			get { return this.prix; }
			set { this.prix = value; }
		}

		public virtual string Objet
		{
			get { return this.objet; }
			set { this.objet = value; }
		}

		public virtual string Commantaire
		{
			get { return this.commantaire; }
			set { this.commantaire = value; }
		}

		public virtual DateTime DelaiModifier
		{
			get { return this.delaiModifier; }
			set { this.delaiModifier = value; }
		}

		public virtual double PrixModifier
		{
			get { return this.prixModifier; }
			set { this.prixModifier = value; }
		}

		public virtual string State
		{
			get { return this.state; }
			set { this.state = value; }
		}

		public virtual Greffier Greffiers
		{
			get { return this.greffiers; }
			set { this.greffiers = value; }
		}

	}
}
