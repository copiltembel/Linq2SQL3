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
	/// <summary>Class which represents the entity 'SalesTaxRate', mapped on table 'AdventureWorks.Sales.SalesTaxRate'.</summary>
	public partial class SalesTaxRate : INotifyPropertyChanging, INotifyPropertyChanged
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
		private System.Guid	_rowguid;
		private System.Int32	_salesTaxRateId;
		private System.Int32	_stateProvinceId;
		private System.Decimal	_taxRate;
		private System.Byte	_taxType;
		private EntityRef <StateProvince> _stateProvince;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		partial void OnRowguidChanging(System.Guid value);
		partial void OnRowguidChanged();
		partial void OnSalesTaxRateIdChanging(System.Int32 value);
		partial void OnSalesTaxRateIdChanged();
		partial void OnStateProvinceIdChanging(System.Int32 value);
		partial void OnStateProvinceIdChanged();
		partial void OnTaxRateChanging(System.Decimal value);
		partial void OnTaxRateChanged();
		partial void OnTaxTypeChanging(System.Byte value);
		partial void OnTaxTypeChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="SalesTaxRate"/> class.</summary>
		public SalesTaxRate()
		{
			_stateProvince = default(EntityRef<StateProvince>);
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

		/// <summary>Gets or sets the SalesTaxRateId field. Mapped on target field 'SalesTaxRateID'. </summary>
		public System.Int32 SalesTaxRateId
		{
			get	{ return _salesTaxRateId; }
			set
			{
				if((_salesTaxRateId != value))
				{
					OnSalesTaxRateIdChanging(value);
					SendPropertyChanging("SalesTaxRateId");
					_salesTaxRateId = value;
					SendPropertyChanged("SalesTaxRateId");
					OnSalesTaxRateIdChanged();
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
					if(_stateProvince.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					OnStateProvinceIdChanging(value);
					SendPropertyChanging("StateProvinceId");
					_stateProvinceId = value;
					SendPropertyChanged("StateProvinceId");
					OnStateProvinceIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the TaxRate field. Mapped on target field 'TaxRate'. </summary>
		public System.Decimal TaxRate
		{
			get	{ return _taxRate; }
			set
			{
				if((_taxRate != value))
				{
					OnTaxRateChanging(value);
					SendPropertyChanging("TaxRate");
					_taxRate = value;
					SendPropertyChanged("TaxRate");
					OnTaxRateChanged();
				}
			}
		}

		/// <summary>Gets or sets the TaxType field. Mapped on target field 'TaxType'. </summary>
		public System.Byte TaxType
		{
			get	{ return _taxType; }
			set
			{
				if((_taxType != value))
				{
					OnTaxTypeChanging(value);
					SendPropertyChanging("TaxType");
					_taxType = value;
					SendPropertyChanged("TaxType");
					OnTaxTypeChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'SalesTaxRate.StateProvince - StateProvince.SalesTaxRates (m:1)'</summary>
		public StateProvince StateProvince
		{
			get { return _stateProvince.Entity; }
			set
			{
				StateProvince previousValue = _stateProvince.Entity;
				if((previousValue != value) || (_stateProvince.HasLoadedOrAssignedValue == false))
				{
					this.SendPropertyChanging("StateProvince");
					if(previousValue != null)
					{
						_stateProvince.Entity = null;
						previousValue.SalesTaxRates.Remove(this);
					}
					_stateProvince.Entity = value;
					if(value == null)
					{
						_stateProvinceId = default(System.Int32);
					}
					else
					{
						value.SalesTaxRates.Add(this);
						_stateProvinceId = value.StateProvinceId;
					}
					this.SendPropertyChanged("StateProvince");
				}
			}
		}
		
		#endregion
	}
}
#pragma warning restore 0649