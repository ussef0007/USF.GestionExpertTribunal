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
	public class TypeDemande
	{
		private int id;

		private string libelle;

		private DateTime dateCreation;

		private DateTime dateModification;

		private string code;

		private bool isActive;

		public virtual int Id
		{
			get { return this.id; }
			set { this.id = value; }
		}

		public virtual string Libelle
		{
			get { return this.libelle; }
			set { this.libelle = value; }
		}

		public virtual DateTime DateCreation
		{
			get { return this.dateCreation; }
			set { this.dateCreation = value; }
		}

		public virtual DateTime DateModification
		{
			get { return this.dateModification; }
			set { this.dateModification = value; }
		}

		public virtual string Code
		{
			get { return this.code; }
			set { this.code = value; }
		}

		public virtual bool isActive
		{
			get { return this.isActive; }
			set { this.isActive = value; }
		}

	}
}
