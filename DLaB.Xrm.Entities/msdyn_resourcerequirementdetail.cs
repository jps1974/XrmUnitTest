//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DLaB.Xrm.Entities
{
	
	[System.Runtime.Serialization.DataContractAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public enum msdyn_resourcerequirementdetailState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Entity used to track the detailed information about resource requirements.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_resourcerequirementdetail")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class msdyn_resourcerequirementdetail : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msdyn_duration = "msdyn_duration";
			public const string msdyn_from = "msdyn_from";
			public const string msdyn_hours = "msdyn_hours";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_resourcerequirementdetailId = "msdyn_resourcerequirementdetailid";
			public const string Id = "msdyn_resourcerequirementdetailid";
			public const string msdyn_resourcerequirementid = "msdyn_resourcerequirementid";
			public const string msdyn_to = "msdyn_to";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_msdyn_resourcerequirementdetail = "business_unit_msdyn_resourcerequirementdetail";
			public const string lk_msdyn_resourcerequirementdetail_createdby = "lk_msdyn_resourcerequirementdetail_createdby";
			public const string lk_msdyn_resourcerequirementdetail_createdonbehalfby = "lk_msdyn_resourcerequirementdetail_createdonbehalfby";
			public const string lk_msdyn_resourcerequirementdetail_modifiedby = "lk_msdyn_resourcerequirementdetail_modifiedby";
			public const string lk_msdyn_resourcerequirementdetail_modifiedonbehalfby = "lk_msdyn_resourcerequirementdetail_modifiedonbehalfby";
			public const string msdyn_resourcerequirement_details = "msdyn_resourcerequirement_details";
			public const string team_msdyn_resourcerequirementdetail = "team_msdyn_resourcerequirementdetail";
			public const string user_msdyn_resourcerequirementdetail = "user_msdyn_resourcerequirementdetail";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_resourcerequirementdetail() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_resourcerequirementdetail";
		
		public const string PrimaryIdAttribute = "msdyn_resourcerequirementdetailid";
		
		public const string PrimaryNameAttribute = "msdyn_name";
		
		public const int EntityTypeCode = 10019;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedBy");
				this.SetAttributeValue("createdby", value);
				this.OnPropertyChanged("CreatedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOn");
				this.SetAttributeValue("createdon", value);
				this.OnPropertyChanged("CreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedBy");
				this.SetAttributeValue("modifiedby", value);
				this.OnPropertyChanged("ModifiedBy");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOn");
				this.SetAttributeValue("modifiedon", value);
				this.OnPropertyChanged("ModifiedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Shows the time duration for which the resource is required to persist in minutes.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_duration")]
		public System.Nullable<int> msdyn_duration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msdyn_duration");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_duration");
				this.SetAttributeValue("msdyn_duration", value);
				this.OnPropertyChanged("msdyn_duration");
			}
		}
		
		/// <summary>
		/// Enter the date and time from which a contiguous piece of time duration is required
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_from")]
		public System.Nullable<System.DateTime> msdyn_from
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_from");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_from");
				this.SetAttributeValue("msdyn_from", value);
				this.OnPropertyChanged("msdyn_from");
			}
		}
		
		/// <summary>
		/// Enter the number of hours for which a resource is required.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_hours")]
		public System.Nullable<decimal> msdyn_hours
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("msdyn_hours");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_hours");
				this.SetAttributeValue("msdyn_hours", value);
				this.OnPropertyChanged("msdyn_hours");
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_name")]
		public string msdyn_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_name");
				this.SetAttributeValue("msdyn_name", value);
				this.OnPropertyChanged("msdyn_name");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourcerequirementdetailid")]
		public System.Nullable<System.Guid> msdyn_resourcerequirementdetailId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_resourcerequirementdetailid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetailId");
				this.SetAttributeValue("msdyn_resourcerequirementdetailid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_resourcerequirementdetailId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourcerequirementdetailid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.msdyn_resourcerequirementdetailId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the resource requirement for the resource requirement detail.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourcerequirementid")]
		public Microsoft.Xrm.Sdk.EntityReference msdyn_resourcerequirementid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_resourcerequirementid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementid");
				this.SetAttributeValue("msdyn_resourcerequirementid", value);
				this.OnPropertyChanged("msdyn_resourcerequirementid");
			}
		}
		
		/// <summary>
		/// The end of requirement detail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_to")]
		public System.Nullable<System.DateTime> msdyn_to
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msdyn_to");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_to");
				this.SetAttributeValue("msdyn_to", value);
				this.OnPropertyChanged("msdyn_to");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningBusinessUnit");
				this.SetAttributeValue("owningbusinessunit", value);
				this.OnPropertyChanged("OwningBusinessUnit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningTeam");
				this.SetAttributeValue("owningteam", value);
				this.OnPropertyChanged("OwningTeam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser");
				this.SetAttributeValue("owninguser", value);
				this.OnPropertyChanged("OwningUser");
			}
		}
		
		/// <summary>
		/// Status of the Resource Requirement Detail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<DLaB.Xrm.Entities.msdyn_resourcerequirementdetailState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((DLaB.Xrm.Entities.msdyn_resourcerequirementdetailState)(System.Enum.ToObject(typeof(DLaB.Xrm.Entities.msdyn_resourcerequirementdetailState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Resource Requirement Detail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_Annotations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_Annotations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.Annotation> msdyn_resourcerequirementdetail_Annotations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.Annotation>("msdyn_resourcerequirementdetail_Annotations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_Annotations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.Annotation>("msdyn_resourcerequirementdetail_Annotations", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_Annotations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> msdyn_resourcerequirementdetail_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("msdyn_resourcerequirementdetail_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("msdyn_resourcerequirementdetail_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> msdyn_resourcerequirementdetail_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("msdyn_resourcerequirementdetail_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_BulkDeleteFailures");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("msdyn_resourcerequirementdetail_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.DuplicateRecord> msdyn_resourcerequirementdetail_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.DuplicateRecord>("msdyn_resourcerequirementdetail_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_DuplicateBaseRecord");
				this.SetRelatedEntities<DLaB.Xrm.Entities.DuplicateRecord>("msdyn_resourcerequirementdetail_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.DuplicateRecord> msdyn_resourcerequirementdetail_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.DuplicateRecord>("msdyn_resourcerequirementdetail_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_DuplicateMatchingRecord");
				this.SetRelatedEntities<DLaB.Xrm.Entities.DuplicateRecord>("msdyn_resourcerequirementdetail_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.MailboxTrackingFolder> msdyn_resourcerequirementdetail_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.MailboxTrackingFolder>("msdyn_resourcerequirementdetail_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_MailboxTrackingFolders");
				this.SetRelatedEntities<DLaB.Xrm.Entities.MailboxTrackingFolder>("msdyn_resourcerequirementdetail_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess> msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess>("msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess>("msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_ProcessSession")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ProcessSession> msdyn_resourcerequirementdetail_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("msdyn_resourcerequirementdetail_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_ProcessSession");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("msdyn_resourcerequirementdetail_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_SyncErrors")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.SyncError> msdyn_resourcerequirementdetail_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.SyncError>("msdyn_resourcerequirementdetail_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_SyncErrors");
				this.SetRelatedEntities<DLaB.Xrm.Entities.SyncError>("msdyn_resourcerequirementdetail_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_resourcerequirementdetail_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirementdetail_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> msdyn_resourcerequirementdetail_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("msdyn_resourcerequirementdetail_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirementdetail_UserEntityInstanceDatas");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("msdyn_resourcerequirementdetail_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirementdetail_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_msdyn_resourcerequirementdetail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_resourcerequirementdetail")]
		public DLaB.Xrm.Entities.BusinessUnit business_unit_msdyn_resourcerequirementdetail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_msdyn_resourcerequirementdetail", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("business_unit_msdyn_resourcerequirementdetail");
				this.SetRelatedEntity<DLaB.Xrm.Entities.BusinessUnit>("business_unit_msdyn_resourcerequirementdetail", null, value);
				this.OnPropertyChanged("business_unit_msdyn_resourcerequirementdetail");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_resourcerequirementdetail_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_resourcerequirementdetail_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_msdyn_resourcerequirementdetail_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_resourcerequirementdetail_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_resourcerequirementdetail_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_resourcerequirementdetail_createdby", null, value);
				this.OnPropertyChanged("lk_msdyn_resourcerequirementdetail_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_resourcerequirementdetail_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_resourcerequirementdetail_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_msdyn_resourcerequirementdetail_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_resourcerequirementdetail_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_resourcerequirementdetail_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_resourcerequirementdetail_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_resourcerequirementdetail_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_resourcerequirementdetail_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_resourcerequirementdetail_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_msdyn_resourcerequirementdetail_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_resourcerequirementdetail_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_resourcerequirementdetail_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_resourcerequirementdetail_modifiedby", null, value);
				this.OnPropertyChanged("lk_msdyn_resourcerequirementdetail_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_resourcerequirementdetail_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_resourcerequirementdetail_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_msdyn_resourcerequirementdetail_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_resourcerequirementdetail_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_resourcerequirementdetail_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_msdyn_resourcerequirementdetail_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_resourcerequirementdetail_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 msdyn_resourcerequirement_details
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_resourcerequirementid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_resourcerequirement_details")]
		public DLaB.Xrm.Entities.msdyn_resourcerequirement msdyn_resourcerequirement_details
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.msdyn_resourcerequirement>("msdyn_resourcerequirement_details", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_resourcerequirement_details");
				this.SetRelatedEntity<DLaB.Xrm.Entities.msdyn_resourcerequirement>("msdyn_resourcerequirement_details", null, value);
				this.OnPropertyChanged("msdyn_resourcerequirement_details");
			}
		}
		
		/// <summary>
		/// N:1 team_msdyn_resourcerequirementdetail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_resourcerequirementdetail")]
		public DLaB.Xrm.Entities.Team team_msdyn_resourcerequirementdetail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Team>("team_msdyn_resourcerequirementdetail", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_msdyn_resourcerequirementdetail");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Team>("team_msdyn_resourcerequirementdetail", null, value);
				this.OnPropertyChanged("team_msdyn_resourcerequirementdetail");
			}
		}
		
		/// <summary>
		/// N:1 user_msdyn_resourcerequirementdetail
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_resourcerequirementdetail")]
		public DLaB.Xrm.Entities.SystemUser user_msdyn_resourcerequirementdetail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("user_msdyn_resourcerequirementdetail", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("user_msdyn_resourcerequirementdetail");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("user_msdyn_resourcerequirementdetail", null, value);
				this.OnPropertyChanged("user_msdyn_resourcerequirementdetail");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_resourcerequirementdetail(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["msdyn_resourcerequirementdetailid"] = base.Id;
                        break;
                    case "msdyn_resourcerequirementdetailid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual msdyn_resourcerequirementdetail_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((msdyn_resourcerequirementdetail_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}