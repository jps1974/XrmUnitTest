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
	/// Item in the sales literature collection.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("salesliteratureitem")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9369")]
	public partial class SalesLiteratureItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string Abstract = "abstract";
			public const string AttachedDocumentUrl = "attacheddocumenturl";
			public const string AuthorName = "authorname";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DocumentBody = "documentbody";
			public const string FileName = "filename";
			public const string FileSize = "filesize";
			public const string FileTypeCode = "filetypecode";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsCustomerViewable = "iscustomerviewable";
			public const string KeyWords = "keywords";
			public const string MimeType = "mimetype";
			public const string Mode = "mode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string SalesLiteratureId = "salesliteratureid";
			public const string SalesLiteratureItemId = "salesliteratureitemid";
			public const string Id = "salesliteratureitemid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string Title = "title";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_salesliteratureitem_createdonbehalfby = "lk_salesliteratureitem_createdonbehalfby";
			public const string lk_salesliteratureitem_modifiedonbehalfby = "lk_salesliteratureitem_modifiedonbehalfby";
			public const string lk_salesliteratureitembase_createdby = "lk_salesliteratureitembase_createdby";
			public const string lk_salesliteratureitembase_modifiedby = "lk_salesliteratureitembase_modifiedby";
			public const string sales_literature_items = "sales_literature_items";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SalesLiteratureItem() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "salesliteratureitem";
		
		public const string PrimaryIdAttribute = "salesliteratureitemid";
		
		public const string PrimaryNameAttribute = "title";
		
		public const int EntityTypeCode = 1070;
		
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
		/// Abstract of the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abstract")]
		public string Abstract
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("abstract");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Abstract");
				this.SetAttributeValue("abstract", value);
				this.OnPropertyChanged("Abstract");
			}
		}
		
		/// <summary>
		/// URL of the Website on which the document is located.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attacheddocumenturl")]
		public string AttachedDocumentUrl
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("attacheddocumenturl");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AttachedDocumentUrl");
				this.SetAttributeValue("attacheddocumenturl", value);
				this.OnPropertyChanged("AttachedDocumentUrl");
			}
		}
		
		/// <summary>
		/// Author name for the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("authorname")]
		public string AuthorName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("authorname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AuthorName");
				this.SetAttributeValue("authorname", value);
				this.OnPropertyChanged("AuthorName");
			}
		}
		
		/// <summary>
		/// lk_salesliteratureitembase_createdby
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
		/// Date and time when the document was created.
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
		/// lk_salesliteratureitem_createdonbehalfby
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
		/// Shows the encoded contents of the sales literature document attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentbody")]
		public string DocumentBody
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("documentbody");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DocumentBody");
				this.SetAttributeValue("documentbody", value);
				this.OnPropertyChanged("DocumentBody");
			}
		}
		
		/// <summary>
		/// File name of the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filename")]
		public string FileName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("filename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FileName");
				this.SetAttributeValue("filename", value);
				this.OnPropertyChanged("FileName");
			}
		}
		
		/// <summary>
		/// File size of the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
		public System.Nullable<int> FileSize
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("filesize");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FileSize");
				this.SetAttributeValue("filesize", value);
				this.OnPropertyChanged("FileSize");
			}
		}
		
		/// <summary>
		/// Select the file type of the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filetypecode")]
		public Microsoft.Xrm.Sdk.OptionSetValue FileTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("filetypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FileTypeCode");
				this.SetAttributeValue("filetypecode", value);
				this.OnPropertyChanged("FileTypeCode");
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
		/// Tells whether the document can be shared with customers or is for internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomerviewable")]
		public System.Nullable<bool> IsCustomerViewable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iscustomerviewable");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsCustomerViewable");
				this.SetAttributeValue("iscustomerviewable", value);
				this.OnPropertyChanged("IsCustomerViewable");
			}
		}
		
		/// <summary>
		/// Keywords to use for searches in documents.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("keywords")]
		public string KeyWords
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("keywords");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("KeyWords");
				this.SetAttributeValue("keywords", value);
				this.OnPropertyChanged("KeyWords");
			}
		}
		
		/// <summary>
		/// Shows the file type of the sales literature document attachment, such as text or document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
		public string MimeType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mimetype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MimeType");
				this.SetAttributeValue("mimetype", value);
				this.OnPropertyChanged("MimeType");
			}
		}
		
		/// <summary>
		/// Defines the mode of the sales literature document attachment.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mode")]
		public string Mode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Mode");
				this.SetAttributeValue("mode", value);
				this.OnPropertyChanged("Mode");
			}
		}
		
		/// <summary>
		/// lk_salesliteratureitembase_modifiedby
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
		/// Date and time when the document was last modified.
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
		/// lk_salesliteratureitem_modifiedonbehalfby
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
		/// Unique identifier of the organization associated with the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public System.Nullable<System.Guid> OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid");
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
		/// sales_literature_items
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureid")]
		public Microsoft.Xrm.Sdk.EntityReference SalesLiteratureId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("salesliteratureid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesLiteratureId");
				this.SetAttributeValue("salesliteratureid", value);
				this.OnPropertyChanged("SalesLiteratureId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureitemid")]
		public System.Nullable<System.Guid> SalesLiteratureItemId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("salesliteratureitemid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesLiteratureItemId");
				this.SetAttributeValue("salesliteratureitemid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SalesLiteratureItemId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureitemid")]
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
				this.SalesLiteratureItemId = value;
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
		/// Type the title or name that describes the document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("title");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Title");
				this.SetAttributeValue("title", value);
				this.OnPropertyChanged("Title");
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
		/// Version number of the sales literature item.
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
		/// 1:N SalesLiteratureItem_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.AsyncOperation> SalesLiteratureItem_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("SalesLiteratureItem_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesLiteratureItem_AsyncOperations");
				this.SetRelatedEntities<DLaB.Xrm.Entities.AsyncOperation>("SalesLiteratureItem_AsyncOperations", null, value);
				this.OnPropertyChanged("SalesLiteratureItem_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N SalesLiteratureItem_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.BulkDeleteFailure> SalesLiteratureItem_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("SalesLiteratureItem_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesLiteratureItem_BulkDeleteFailures");
				this.SetRelatedEntities<DLaB.Xrm.Entities.BulkDeleteFailure>("SalesLiteratureItem_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("SalesLiteratureItem_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N salesliteratureitem_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesliteratureitem_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.MailboxTrackingFolder> salesliteratureitem_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.MailboxTrackingFolder>("salesliteratureitem_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("salesliteratureitem_MailboxTrackingFolders");
				this.SetRelatedEntities<DLaB.Xrm.Entities.MailboxTrackingFolder>("salesliteratureitem_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("salesliteratureitem_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N salesliteratureitem_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesliteratureitem_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess> salesliteratureitem_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess>("salesliteratureitem_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("salesliteratureitem_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<DLaB.Xrm.Entities.PrincipalObjectAttributeAccess>("salesliteratureitem_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("salesliteratureitem_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N SalesLiteratureItem_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.ProcessSession> SalesLiteratureItem_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("SalesLiteratureItem_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesLiteratureItem_ProcessSessions");
				this.SetRelatedEntities<DLaB.Xrm.Entities.ProcessSession>("SalesLiteratureItem_ProcessSessions", null, value);
				this.OnPropertyChanged("SalesLiteratureItem_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N salesliteratureitem_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesliteratureitem_SyncErrors")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.SyncError> salesliteratureitem_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.SyncError>("salesliteratureitem_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("salesliteratureitem_SyncErrors");
				this.SetRelatedEntities<DLaB.Xrm.Entities.SyncError>("salesliteratureitem_SyncErrors", null, value);
				this.OnPropertyChanged("salesliteratureitem_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_salesliteratureitem
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesliteratureitem")]
		public System.Collections.Generic.IEnumerable<DLaB.Xrm.Entities.UserEntityInstanceData> userentityinstancedata_salesliteratureitem
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_salesliteratureitem", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_salesliteratureitem");
				this.SetRelatedEntities<DLaB.Xrm.Entities.UserEntityInstanceData>("userentityinstancedata_salesliteratureitem", null, value);
				this.OnPropertyChanged("userentityinstancedata_salesliteratureitem");
			}
		}
		
		/// <summary>
		/// N:1 lk_salesliteratureitem_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitem_createdonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_salesliteratureitem_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_salesliteratureitem_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_salesliteratureitem_createdonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_salesliteratureitem_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_salesliteratureitem_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_salesliteratureitem_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitem_modifiedonbehalfby")]
		public DLaB.Xrm.Entities.SystemUser lk_salesliteratureitem_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_salesliteratureitem_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_salesliteratureitem_modifiedonbehalfby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_salesliteratureitem_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_salesliteratureitem_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_salesliteratureitembase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitembase_createdby")]
		public DLaB.Xrm.Entities.SystemUser lk_salesliteratureitembase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_salesliteratureitembase_createdby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_salesliteratureitembase_createdby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_salesliteratureitembase_createdby", null, value);
				this.OnPropertyChanged("lk_salesliteratureitembase_createdby");
			}
		}
		
		/// <summary>
		/// N:1 lk_salesliteratureitembase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitembase_modifiedby")]
		public DLaB.Xrm.Entities.SystemUser lk_salesliteratureitembase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_salesliteratureitembase_modifiedby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_salesliteratureitembase_modifiedby");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SystemUser>("lk_salesliteratureitembase_modifiedby", null, value);
				this.OnPropertyChanged("lk_salesliteratureitembase_modifiedby");
			}
		}
		
		/// <summary>
		/// N:1 sales_literature_items
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sales_literature_items")]
		public DLaB.Xrm.Entities.SalesLiterature sales_literature_items
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<DLaB.Xrm.Entities.SalesLiterature>("sales_literature_items", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("sales_literature_items");
				this.SetRelatedEntity<DLaB.Xrm.Entities.SalesLiterature>("sales_literature_items", null, value);
				this.OnPropertyChanged("sales_literature_items");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SalesLiteratureItem(object anonymousType) : 
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
                        Attributes["salesliteratureitemid"] = base.Id;
                        break;
                    case "salesliteratureitemid":
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
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filetypecode")]
		public virtual SalesLiteratureItem_FileTypeCode? FileTypeCodeEnum
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SalesLiteratureItem_FileTypeCode?)(EntityOptionSetEnum.GetEnum(this, "filetypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				FileTypeCode = value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null;
			}
		}
	}
}