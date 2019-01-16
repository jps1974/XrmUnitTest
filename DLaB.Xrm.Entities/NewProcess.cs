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
	public enum NewProcessState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// New Process Business Process Flow
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("newprocess")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class NewProcess : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ActiveStageId = "activestageid";
			public const string ActiveStageStartedOn = "activestagestartedon";
			public const string BusinessProcessFlowInstanceId = "businessprocessflowinstanceid";
			public const string Id = "businessprocessflowinstanceid";
			public const string CompletedOn = "completedon";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Duration = "duration";
			public const string ExchangeRate = "exchangerate";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string KnowledgeArticleId = "knowledgearticleid";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ProcessId = "processid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string TraversedPath = "traversedpath";
			public const string VersionNumber = "versionnumber";
			public const string lk_newprocess_activestageid = "lk_newprocess_activestageid";
			public const string lk_newprocess_createdby = "lk_newprocess_createdby";
			public const string lk_newprocess_createdonbehalfby = "lk_newprocess_createdonbehalfby";
			public const string lk_newprocess_knowledgearticleid = "lk_newprocess_knowledgearticleid";
			public const string lk_newprocess_modifiedby = "lk_newprocess_modifiedby";
			public const string lk_newprocess_modifiedonbehalfby = "lk_newprocess_modifiedonbehalfby";
			public const string lk_newprocess_processid = "lk_newprocess_processid";
			public const string organization_newprocess = "organization_newprocess";
			public const string transactioncurrency_newprocess = "transactioncurrency_newprocess";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public NewProcess() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "newprocess";
		
		public const string PrimaryIdAttribute = "businessprocessflowinstanceid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const int EntityTypeCode = 950;
		
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
		/// Unique identifier of the active stage for the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestageid")]
		public Microsoft.Xrm.Sdk.EntityReference ActiveStageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activestageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActiveStageId");
				this.SetAttributeValue("activestageid", value);
				this.OnPropertyChanged("ActiveStageId");
			}
		}
		
		/// <summary>
		/// Date and time when current active stage is started.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestagestartedon")]
		public System.Nullable<System.DateTime> ActiveStageStartedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("activestagestartedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActiveStageStartedOn");
				this.SetAttributeValue("activestagestartedon", value);
				this.OnPropertyChanged("ActiveStageStartedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier for New Process bpf entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocessflowinstanceid")]
		public System.Nullable<System.Guid> BusinessProcessFlowInstanceId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("businessprocessflowinstanceid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessProcessFlowInstanceId");
				this.SetAttributeValue("businessprocessflowinstanceid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("BusinessProcessFlowInstanceId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessprocessflowinstanceid")]
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
				this.BusinessProcessFlowInstanceId = value;
			}
		}
		
		/// <summary>
		/// Date and time when current active stage is started.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
		public System.Nullable<System.DateTime> CompletedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CompletedOn");
				this.SetAttributeValue("completedon", value);
				this.OnPropertyChanged("CompletedOn");
			}
		}
		
		/// <summary>
		/// Shows who created the record.
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
		/// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
		/// Shows who created the record on behalf of another user.
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
		/// Duration the business process flow was active.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duration")]
		public System.Nullable<int> Duration
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("duration");
			}
		}
		
		/// <summary>
		/// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Unique identifier of the Knowledge Article associated to the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleid")]
		public Microsoft.Xrm.Sdk.EntityReference KnowledgeArticleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("knowledgearticleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KnowledgeArticleId");
				this.SetAttributeValue("knowledgearticleid", value);
				this.OnPropertyChanged("KnowledgeArticleId");
			}
		}
		
		/// <summary>
		/// Shows who last updated the record.
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
		/// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
		/// Shows who last updated the record on behalf of another user.
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
		/// Process Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Unique identifier of the organization with which the SDK message request is associated.
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
		/// Unique identifier of the workflow associated to the Business Process Flow instance.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public Microsoft.Xrm.Sdk.EntityReference ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Shows whether the Delve action record is pending, completed, or tracking.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<DLaB.Xrm.Entities.NewProcessState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((DLaB.Xrm.Entities.NewProcessState)(System.Enum.ToObject(typeof(DLaB.Xrm.Entities.NewProcessState), optionSet.Value)));
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
		/// Select the delve action record status.
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
		/// Choose the local currency for the record to make sure budgets are reported in the correct currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Traversed Path
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
		public string TraversedPath
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("traversedpath");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraversedPath");
				this.SetAttributeValue("traversedpath", value);
				this.OnPropertyChanged("TraversedPath");
			}
		}
		
		/// <summary>
		/// Version number of the business process instance.
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
		/// 1:N lk_newprocess_workflowlogs
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_workflowlogs")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.WorkflowLog> lk_newprocess_workflowlogs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.WorkflowLog>("lk_newprocess_workflowlogs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_workflowlogs");
				this.SetRelatedEntities<DLaB.Xrm.Entities.WorkflowLog>("lk_newprocess_workflowlogs", null, value);
				this.OnPropertyChanged("lk_newprocess_workflowlogs");
			}
		}
		
		/// <summary>
		/// 1:N NewProcess_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("NewProcess_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ProcessSession> NewProcess_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("NewProcess_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NewProcess_ProcessSessions");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("NewProcess_ProcessSessions", null, value);
				this.OnPropertyChanged("NewProcess_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N NewProcess_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("NewProcess_SyncErrors")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.SyncError> NewProcess_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.SyncError>("NewProcess_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("NewProcess_SyncErrors");
				this.SetRelatedEntities<DLaB.Xrm.Entities.SyncError>("NewProcess_SyncErrors", null, value);
				this.OnPropertyChanged("NewProcess_SyncErrors");
			}
		}
		
		/// <summary>
		/// N:1 lk_newprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activestageid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_activestageid")]
		public DLaB.Xrm.Entities.ProcessStage lk_newprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.ProcessStage>("lk_newprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_activestageid");
				this.SetRelatedEntity<DLaB.Xrm.Entities.ProcessStage>("lk_newprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_newprocess_activestageid");
			}
		}
		
		/// <summary>
		/// N:1 lk_newprocess_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_newprocess_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_newprocess_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_newprocess_createdby", null, value);
				this.OnPropertyChanged("lk_newprocess_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_newprocess_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_newprocess_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_newprocess_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_newprocess_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_newprocess_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_newprocess_knowledgearticleid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("knowledgearticleid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_knowledgearticleid")]
		public DLaB.Xrm.Entities.KnowledgeArticle lk_newprocess_knowledgearticleid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.KnowledgeArticle>("lk_newprocess_knowledgearticleid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_knowledgearticleid");
				this.SetRelatedEntity<DLaB.Xrm.Entities.KnowledgeArticle>("lk_newprocess_knowledgearticleid", null, value);
				this.OnPropertyChanged("lk_newprocess_knowledgearticleid");
			}
		}
		
		/// <summary>
		/// N:1 lk_newprocess_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_newprocess_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_newprocess_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_newprocess_modifiedby", null, value);
				this.OnPropertyChanged("lk_newprocess_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 lk_newprocess_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_newprocess_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_newprocess_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_newprocess_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_newprocess_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_newprocess_processid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_processid")]
		public DLaB.Xrm.Entities.Workflow lk_newprocess_processid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Workflow>("lk_newprocess_processid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_processid");
				this.SetRelatedEntity<DLaB.Xrm.Entities.Workflow>("lk_newprocess_processid", null, value);
				this.OnPropertyChanged("lk_newprocess_processid");
			}
		}
		
		/// <summary>
		/// N:1 organization_newprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_newprocess")]
		public DLaB.Xrm.Entities.Organization organization_newprocess
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.Organization>("organization_newprocess", null);
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_newprocess
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_newprocess")]
		public DLaB.Xrm.Entities.TransactionCurrency transactioncurrency_newprocess
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.TransactionCurrency>("transactioncurrency_newprocess", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("transactioncurrency_newprocess");
				this.SetRelatedEntity<DLaB.Xrm.Entities.TransactionCurrency>("transactioncurrency_newprocess", null, value);
				this.OnPropertyChanged("transactioncurrency_newprocess");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public NewProcess(object anonymousType) : 
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
                        Attributes["businessprocessflowinstanceid"] = base.Id;
                        break;
                    case "businessprocessflowinstanceid":
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
		public virtual NewProcess_StatusCode? StatusCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((NewProcess_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				StatusCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}