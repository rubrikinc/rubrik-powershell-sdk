// AzureCloudAccountTenant.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region AzureCloudAccountTenant
    public class AzureCloudAccountTenant: BaseType
    {
        #region members

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        [JsonProperty("appName")]
        public System.String? AppName { get; set; }

        //      C# -> System.String? AzureCloudAccountTenantRubrikId
        // GraphQL -> azureCloudAccountTenantRubrikId: String! (scalar)
        [JsonProperty("azureCloudAccountTenantRubrikId")]
        public System.String? AzureCloudAccountTenantRubrikId { get; set; }

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.Boolean? IsAppRubrikManaged
        // GraphQL -> isAppRubrikManaged: Boolean! (scalar)
        [JsonProperty("isAppRubrikManaged")]
        public System.Boolean? IsAppRubrikManaged { get; set; }

        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        [JsonProperty("subscriptionCount")]
        public System.Int32? SubscriptionCount { get; set; }

        //      C# -> List<AzureCloudAccountSubscriptionDetail>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscriptionDetail!]! (type)
        [JsonProperty("subscriptions")]
        public List<AzureCloudAccountSubscriptionDetail>? Subscriptions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudAccountTenant";
    }

    public AzureCloudAccountTenant Set(
        AzureCloudType? CloudType = null,
        System.String? AppName = null,
        System.String? AzureCloudAccountTenantRubrikId = null,
        System.String? ClientId = null,
        System.String? DomainName = null,
        System.Boolean? IsAppRubrikManaged = null,
        System.Int32? SubscriptionCount = null,
        List<AzureCloudAccountSubscriptionDetail>? Subscriptions = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( AppName != null ) {
            this.AppName = AppName;
        }
        if ( AzureCloudAccountTenantRubrikId != null ) {
            this.AzureCloudAccountTenantRubrikId = AzureCloudAccountTenantRubrikId;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
        }
        if ( IsAppRubrikManaged != null ) {
            this.IsAppRubrikManaged = IsAppRubrikManaged;
        }
        if ( SubscriptionCount != null ) {
            this.SubscriptionCount = SubscriptionCount;
        }
        if ( Subscriptions != null ) {
            this.Subscriptions = Subscriptions;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        if (this.CloudType != null) {
            s += ind + "cloudType\n" ;
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (this.AppName != null) {
            s += ind + "appName\n" ;
        }
        //      C# -> System.String? AzureCloudAccountTenantRubrikId
        // GraphQL -> azureCloudAccountTenantRubrikId: String! (scalar)
        if (this.AzureCloudAccountTenantRubrikId != null) {
            s += ind + "azureCloudAccountTenantRubrikId\n" ;
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId != null) {
            s += ind + "clientId\n" ;
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName != null) {
            s += ind + "domainName\n" ;
        }
        //      C# -> System.Boolean? IsAppRubrikManaged
        // GraphQL -> isAppRubrikManaged: Boolean! (scalar)
        if (this.IsAppRubrikManaged != null) {
            s += ind + "isAppRubrikManaged\n" ;
        }
        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        if (this.SubscriptionCount != null) {
            s += ind + "subscriptionCount\n" ;
        }
        //      C# -> List<AzureCloudAccountSubscriptionDetail>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscriptionDetail!]! (type)
        if (this.Subscriptions != null) {
            var fspec = this.Subscriptions.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "subscriptions {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        if (this.CloudType == null && ec.Includes("cloudType",true))
        {
            this.CloudType = new AzureCloudType();
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (this.AppName == null && ec.Includes("appName",true))
        {
            this.AppName = "FETCH";
        }
        //      C# -> System.String? AzureCloudAccountTenantRubrikId
        // GraphQL -> azureCloudAccountTenantRubrikId: String! (scalar)
        if (this.AzureCloudAccountTenantRubrikId == null && ec.Includes("azureCloudAccountTenantRubrikId",true))
        {
            this.AzureCloudAccountTenantRubrikId = "FETCH";
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId == null && ec.Includes("clientId",true))
        {
            this.ClientId = "FETCH";
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName == null && ec.Includes("domainName",true))
        {
            this.DomainName = "FETCH";
        }
        //      C# -> System.Boolean? IsAppRubrikManaged
        // GraphQL -> isAppRubrikManaged: Boolean! (scalar)
        if (this.IsAppRubrikManaged == null && ec.Includes("isAppRubrikManaged",true))
        {
            this.IsAppRubrikManaged = true;
        }
        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        if (this.SubscriptionCount == null && ec.Includes("subscriptionCount",true))
        {
            this.SubscriptionCount = Int32.MinValue;
        }
        //      C# -> List<AzureCloudAccountSubscriptionDetail>? Subscriptions
        // GraphQL -> subscriptions: [AzureCloudAccountSubscriptionDetail!]! (type)
        if (this.Subscriptions == null && ec.Includes("subscriptions",false))
        {
            this.Subscriptions = new List<AzureCloudAccountSubscriptionDetail>();
            this.Subscriptions.ApplyExploratoryFieldSpec(ec.NewChild("subscriptions"));
        }
    }


    #endregion

    } // class AzureCloudAccountTenant
    
    #endregion

    public static class ListAzureCloudAccountTenantExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<AzureCloudAccountTenant> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountTenant> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountTenant());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureCloudAccountTenant> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types