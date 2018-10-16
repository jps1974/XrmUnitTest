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
	
	/// <summary>
	/// Configuration for the social insights.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("socialinsightsconfiguration")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SocialInsightsConfiguration : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ControlId = "controlid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string FormId = "formid";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string RegardingObjectId = "regardingobjectid";
			public const string SocialDataItemId = "socialdataitemid";
			public const string SocialDataItemType = "socialdataitemtype";
			public const string SocialDataParameters = "socialdataparameters";
			public const string SocialInsightsConfigurationId = "socialinsightsconfigurationid";
			public const string Id = "socialinsightsconfigurationid";
			public const string lk_socialinsightsconfiguration_createdby = "lk_socialinsightsconfiguration_createdby";
			public const string lk_socialinsightsconfiguration_createdonbehalfby = "lk_socialinsightsconfiguration_createdonbehalfby";
			public const string lk_socialinsightsconfiguration_modifiedby = "lk_socialinsightsconfiguration_modifiedby";
			public const string lk_socialinsightsconfiguration_modifiedonbehalfby = "lk_socialinsightsconfiguration_modifiedonbehalfby";
			public const string organization_socialinsightsconfiguration = "organization_socialinsightsconfiguration";
			public const string socialinsightsconfiguration_systemform = "socialinsightsconfiguration_systemform";
			public const string socialinsightsconfiguration_userform = "socialinsightsconfiguration_userform";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SocialInsightsConfiguration() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "socialinsightsconfiguration";
		
		public const string PrimaryIdAttribute = "socialinsightsconfigurationid";
		
		public const int EntityTypeCode = 1300;
		
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
		/// Id of the control.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("controlid")]
		public string ControlId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("controlid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ControlId");
				this.SetAttributeValue("controlid", value);
				this.OnPropertyChanged("ControlId");
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
		/// Unique identifier of the form with which the like is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		public Microsoft.Xrm.Sdk.EntityReference FormId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("formid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FormId");
				this.SetAttributeValue("formid", value);
				this.OnPropertyChanged("FormId");
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
		/// Unique identifier of the organization associated with the solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// Data Item Id for social data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialdataitemid")]
		public string SocialDataItemId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("socialdataitemid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SocialDataItemId");
				this.SetAttributeValue("socialdataitemid", value);
				this.OnPropertyChanged("SocialDataItemId");
			}
		}
		
		/// <summary>
		/// Type of social data item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialdataitemtype")]
		public Microsoft.Xrm.Sdk.OptionSetValue SocialDataItemType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("socialdataitemtype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SocialDataItemType");
				this.SetAttributeValue("socialdataitemtype", value);
				this.OnPropertyChanged("SocialDataItemType");
			}
		}
		
		/// <summary>
		/// Parameters used to render social data.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialdataparameters")]
		public string SocialDataParameters
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("socialdataparameters");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SocialDataParameters");
				this.SetAttributeValue("socialdataparameters", value);
				this.OnPropertyChanged("SocialDataParameters");
			}
		}
		
		/// <summary>
		/// Shows the ID of the social insights configuration.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialinsightsconfigurationid")]
		public System.Nullable<System.Guid> SocialInsightsConfigurationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("socialinsightsconfigurationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SocialInsightsConfigurationId");
				this.SetAttributeValue("socialinsightsconfigurationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SocialInsightsConfigurationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialinsightsconfigurationid")]
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
				this.SocialInsightsConfigurationId = value;
			}
		}
		
		/// <summary>
		/// N:1 lk_socialinsightsconfiguration_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_socialinsightsconfiguration_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_socialinsightsconfiguration_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_socialinsightsconfiguration_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_socialinsightsconfiguration_createdby", null, value);
				this.OnPropertyChanged("lk_socialinsightsconfiguration_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_socialinsightsconfiguration_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_socialinsightsconfiguration_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_socialinsightsconfiguration_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_socialinsightsconfiguration_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_socialinsightsconfiguration_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_socialinsightsconfiguration_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_socialinsightsconfiguration_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_socialinsightsconfiguration_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_socialinsightsconfiguration_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_socialinsightsconfiguration_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_socialinsightsconfiguration_modifiedby", null, value);
				this.OnPropertyChanged("lk_socialinsightsconfiguration_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_socialinsightsconfiguration_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_socialinsightsconfiguration_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_socialinsightsconfiguration_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_socialinsightsconfiguration_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_socialinsightsconfiguration_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_socialinsightsconfiguration_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_socialinsightsconfiguration
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_socialinsightsconfiguration")]
		public DLaB.Xrm.Entities.Organization organization_socialinsightsconfiguration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_socialinsightsconfiguration", null);
			}
		}
		
		/// <summary>
		/// N:1 socialinsightsconfiguration_systemform
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialinsightsconfiguration_systemform")]
		public DLaB.Xrm.Entities.SystemForm socialinsightsconfiguration_systemform
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemForm>("socialinsightsconfiguration_systemform", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("socialinsightsconfiguration_systemform");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemForm>("socialinsightsconfiguration_systemform", null, value);
				this.OnPropertyChanged("socialinsightsconfiguration_systemform");
			}
		}
		
		/// <summary>
		/// N:1 socialinsightsconfiguration_userform
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialinsightsconfiguration_userform")]
		public DLaB.Xrm.Entities.UserForm socialinsightsconfiguration_userform
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.UserForm>("socialinsightsconfiguration_userform", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("socialinsightsconfiguration_userform");
				this.SetRelatedEntity<DLaB.Xrm.Entities.UserForm>("socialinsightsconfiguration_userform", null, value);
				this.OnPropertyChanged("socialinsightsconfiguration_userform");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SocialInsightsConfiguration(object anonymousType) : 
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
                        Attributes["socialinsightsconfigurationid"] = base.Id;
                        break;
                    case "socialinsightsconfigurationid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialdataitemtype")]
		public virtual SocialInsightsConfiguration_SocialDataItemType? SocialDataItemTypeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SocialInsightsConfiguration_SocialDataItemType?)(EntityOptionSetEnum.GetEnum(this, "socialdataitemtype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				SocialDataItemType = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}