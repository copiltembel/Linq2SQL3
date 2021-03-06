﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.2.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace WriteTests.EntityClasses
{
	/// <summary>Class which represents the entity 'DerivedType2', mapped on table 'LLBLGenProUnitTest.dbo.GuidTPEHTester'.</summary>
	public partial class DerivedType2 : GuidTpehTester
	{
		#region Class Member Declarations
		private Nullable<System.Int32>	_element1;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnElement1Changing(Nullable<System.Int32> value);
		partial void OnElement1Changed();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="DerivedType2"/> class.</summary>
		public DerivedType2()
		{
			
			OnCreated();
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the Element1 field. Mapped on target field 'Element1'. </summary>
		public Nullable<System.Int32> Element1
		{
			get	{ return _element1; }
			set
			{
				if((_element1 != value))
				{
					OnElement1Changing(value);
					SendPropertyChanging("Element1");
					_element1 = value;
					SendPropertyChanged("Element1");
					OnElement1Changed();
				}
			}
		}

		#endregion
	}
}
#pragma warning restore 0649