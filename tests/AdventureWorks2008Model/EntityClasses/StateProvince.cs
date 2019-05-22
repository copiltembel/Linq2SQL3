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
	/// <summary>Class which represents the entity 'StateProvince', mapped on table 'AdventureWorks.Person.StateProvince'.</summary>
	public partial class StateProvince : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.String	_countryRegionCode;
		private System.Boolean	_isOnlyStateProvinceFlag;
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private System.Guid	_rowguid;
		private System.String	_stateProvinceCode;
		private System.Int32	_stateProvinceId;
		private System.Int32	_territoryId;
		private EntitySet <Address> _addresses;
		private EntityRef <CountryRegion> _countryRegion;
		private EntitySet <SalesTaxRate> _salesTaxRates;
		private EntityRef <SalesTerritory> _salesTerritory;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnCountryRegionCodeChanging(System.String value);
		partial void OnCountryRegionCodeChanged();
		partial void OnIsOnlyStateProvinceFlagChanging(System.Boolean value);
		partial void OnIsOnlyStateProvinceFlagChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnStateProvinceCodeChanging(System.String value);
		partial void OnStateProvinceCodeChanged();
		partial void OnStateProvinceIdChanging(System.Int32 value);
		partial void OnStateProvinceIdChanged();
		partial void OnTerritoryIdChanging(System.Int32 value);
		partial void OnTerritoryIdChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="StateProvince"/> class.</summary>
		public StateProvince()
		{
			_addresses = new EntitySet<Address>(new Action<Address>(this.Attach_Addresses), new Action<Address>(this.Detach_Addresses) );
			_countryRegion = default(EntityRef<CountryRegion>);
			_salesTaxRates = new EntitySet<SalesTaxRate>(new Action<SalesTaxRate>(this.Attach_SalesTaxRates), new Action<SalesTaxRate>(this.Detach_SalesTaxRates) );
			_salesTerritory = default(EntityRef<SalesTerritory>);
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
		private void Attach_Addresses(Address entity)
		{
			this.SendPropertyChanging("Addresses");
			entity.StateProvince = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_Addresses(Address entity)
		{
			this.SendPropertyChanging("Addresses");
			entity.StateProvince = null;
		}

		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_SalesTaxRates(SalesTaxRate entity)
		{
			this.SendPropertyChanging("SalesTaxRates");
			entity.StateProvince = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_SalesTaxRates(SalesTaxRate entity)
		{
			this.SendPropertyChanging("SalesTaxRates");
			entity.StateProvince = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the CountryRegionCode field. Mapped on target field 'CountryRegionCode'. </summary>
		public System.String CountryRegionCode
		{
			get	{ return _countryRegionCode; }
			set
			{
				if((_countryRegionCode != value))
				{
					if(_countryRegion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnCountryRegionCodeChanging(value);
					SendPropertyChanging("CountryRegionCode");
					_countryRegionCode = value;
					SendPropertyChanged("CountryRegionCode");
					OnCountryRegionCodeChanged();
				}
			}
		}

		/// <summary>Gets or sets the IsOnlyStateProvinceFlag field. Mapped on target field 'IsOnlyStateProvinceFlag'. </summary>
		public System.Boolean IsOnlyStateProvinceFlag
		{
			get	{ return _isOnlyStateProvinceFlag; }
			set
			{
				if((_isOnlyStateProvinceFlag != value))
				{
					OnIsOnlyStateProvinceFlagChanging(value);
					SendPropertyChanging("IsOnlyStateProvinceFlag");
					_isOnlyStateProvinceFlag = value;
					SendPropertyChanged("IsOnlyStateProvinceFlag");
					OnIsOnlyStateProvinceFlagChanged();
				}
			}
		}

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

		/// <summary>Gets or sets the Rowguid field. Mapped on target field 'rowguid'. </summary>
		public System.Guid Rowguid
		{
			get	{ return _rowguid; }
			set
			{
				if((_rowguid != value))
				{
					OnRowguidChanging(value);
					SendPropertyChanging("Rowguid");
					_rowguid = value;
					SendPropertyChanged("Rowguid");
					OnRowguidChanged();
				}
			}
		}

		/// <summary>Gets or sets the StateProvinceCode field. Mapped on target field 'StateProvinceCode'. </summary>
		public System.String StateProvinceCode
		{
			get	{ return _stateProvinceCode; }
			set
			{
				if((_stateProvinceCode != value))
				{
					OnStateProvinceCodeChanging(value);
					SendPropertyChanging("StateProvinceCode");
					_stateProvinceCode = value;
					SendPropertyChanged("StateProvinceCode");
					OnStateProvinceCodeChanged();
				}
			}
		}

		/// <summary>Gets or sets the StateProvinceId field. Mapped on target field 'StateProvinceID'. </summary>
		public System.Int32 StateProvinceId
		{
			get	{ return _stateProvinceId; }
			set
			{
				if((_stateProvinceId != value))
				{
					OnStateProvinceIdChanging(value);
					SendPropertyChanging("StateProvinceId");
					_stateProvinceId = value;
					SendPropertyChanged("StateProvinceId");
					OnStateProvinceIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the TerritoryId field. Mapped on target field 'TerritoryID'. </summary>
		public System.Int32 TerritoryId
		{
			get	{ return _territoryId; }
			set
			{
				if((_territoryId != value))
				{
					if(_salesTerritory.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnTerritoryIdChanging(value);
					SendPropertyChanging("TerritoryId");
					_territoryId = value;
					SendPropertyChanged("TerritoryId");
					OnTerritoryIdChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'Address.StateProvince - StateProvince.Addresses (m:1)'</summary>
		public EntitySet<Address> Addresses
		{
			get { return this._addresses; }
			set { this._addresses.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'StateProvince.CountryRegion - CountryRegion.StateProvinces (m:1)'</summary>
		public CountryRegion CountryRegion
		{
			get { return _countryRegion.Entity; }
			set
			{
				CountryRegion previousValue = _countryRegion.Entity;
				if((previousValue != value) || (_countryRegion.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("CountryRegion");
					if(previousValue != null)
					{
						_countryRegion.Entity = null;
						previousValue.StateProvinces.Remove(this);
					}
					_countryRegion.Entity = value;
					if(value == null)
					{
						_countryRegionCode = default(System.String);
					}
					else
					{
						value.StateProvinces.Add(this);
						_countryRegionCode = value.CountryRegionCode;
					}
					this.SendPropertyChanged("CountryRegion");
				}
			}
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'SalesTaxRate.StateProvince - StateProvince.SalesTaxRates (m:1)'</summary>
		public EntitySet<SalesTaxRate> SalesTaxRates
		{
			get { return this._salesTaxRates; }
			set { this._salesTaxRates.Assign(value); }
		}
		
		/// <summary>Represents the navigator which is mapped onto the association 'StateProvince.SalesTerritory - SalesTerritory.StateProvinces (m:1)'</summary>
		public SalesTerritory SalesTerritory
		{
			get { return _salesTerritory.Entity; }
			set
			{
				SalesTerritory previousValue = _salesTerritory.Entity;
				if((previousValue != value) || (_salesTerritory.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("SalesTerritory");
					if(previousValue != null)
					{
						_salesTerritory.Entity = null;
						previousValue.StateProvinces.Remove(this);
					}
					_salesTerritory.Entity = value;
					if(value == null)
					{
						_territoryId = default(System.Int32);
					}
					else
					{
						value.StateProvinces.Add(this);
						_territoryId = value.TerritoryId;
					}
					this.SendPropertyChanged("SalesTerritory");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649