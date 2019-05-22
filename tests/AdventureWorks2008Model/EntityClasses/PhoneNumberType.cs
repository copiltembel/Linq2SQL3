﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace ReadTestsAdventureWorks2008.EntityClasses
{
	/// <summary>Class which represents the entity 'PhoneNumberType', mapped on table 'AdventureWorks.Person.PhoneNumberType'.</summary>
	public partial class PhoneNumberType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private System.Int32	_phoneNumberTypeId;
		private EntitySet <PersonPhone> _personPhones;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		partial void OnPhoneNumberTypeIdChanging(System.Int32 value);
		partial void OnPhoneNumberTypeIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="PhoneNumberType"/> class.</summary>
		public PhoneNumberType()
		{
			_personPhones = new EntitySet<PersonPhone>(new Action<PersonPhone>(this.Attach_PersonPhones), new Action<PersonPhone>(this.Detach_PersonPhones) );
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_PersonPhones(PersonPhone entity)
		{
			this.SendPropertyChanging("PersonPhones");
			entity.PhoneNumberType = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_PersonPhones(PersonPhone entity)
		{
			this.SendPropertyChanging("PersonPhones");
			entity.PhoneNumberType = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the Name field. Mapped on target field 'Name'. </summary>
		public System.String Name
		{
			get	{ return _name; }
			set
			{
				if((_name != value))
				{
					OnNameChanging(value);
					SendPropertyChanging("Name");
					_name = value;
					SendPropertyChanged("Name");
					OnNameChanged();
				}
			}
		}

		/// <summary>Gets or sets the PhoneNumberTypeId field. Mapped on target field 'PhoneNumberTypeID'. </summary>
		public System.Int32 PhoneNumberTypeId
		{
			get	{ return _phoneNumberTypeId; }
			set
			{
				if((_phoneNumberTypeId != value))
				{
					OnPhoneNumberTypeIdChanging(value);
					SendPropertyChanging("PhoneNumberTypeId");
					_phoneNumberTypeId = value;
					SendPropertyChanged("PhoneNumberTypeId");
					OnPhoneNumberTypeIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'PersonPhone.PhoneNumberType - PhoneNumberType.PersonPhones (m:1)'</summary>
		public EntitySet<PersonPhone> PersonPhones
		{
			get { return this._personPhones; }
			set { this._personPhones.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649