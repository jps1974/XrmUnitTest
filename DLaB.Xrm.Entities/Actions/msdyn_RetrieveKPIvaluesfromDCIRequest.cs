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
	
	[System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.microsoft.com/xrm/2011/msdyn/")]
	[Microsoft.Xrm.Sdk.Client.RequestProxyAttribute("msdyn_RetrieveKPIvaluesfromDCI")]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "9.0.0.9154")]
	public partial class msdyn_RetrieveKPIvaluesfromDCIRequest : Microsoft.Xrm.Sdk.OrganizationRequest
	{
		
		public static class Fields
		{
			public const string CrmRecord = "CrmRecord";
			public const string KPINameFilterMap = "KPINameFilterMap";
		}
		
		public const string ActionLogicalName = "msdyn_RetrieveKPIvaluesfromDCI";
		
		public Microsoft.Xrm.Sdk.EntityReference CrmRecord
		{
			get
			{
				if (this.Parameters.Contains("CrmRecord"))
				{
					return ((Microsoft.Xrm.Sdk.EntityReference)(this.Parameters["CrmRecord"]));
				}
				else
				{
					return default(Microsoft.Xrm.Sdk.EntityReference);
				}
			}
			set
			{
				this.Parameters["CrmRecord"] = value;
			}
		}
		
		public string KPINameFilterMap
		{
			get
			{
				if (this.Parameters.Contains("KPINameFilterMap"))
				{
					return ((string)(this.Parameters["KPINameFilterMap"]));
				}
				else
				{
					return default(string);
				}
			}
			set
			{
				this.Parameters["KPINameFilterMap"] = value;
			}
		}
		
		public msdyn_RetrieveKPIvaluesfromDCIRequest()
		{
			this.RequestName = "msdyn_RetrieveKPIvaluesfromDCI";
		}
	}
}