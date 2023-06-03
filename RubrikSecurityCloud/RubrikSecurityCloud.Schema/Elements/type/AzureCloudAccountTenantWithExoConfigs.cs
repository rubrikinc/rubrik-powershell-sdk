// AzureCloudAccountTenantWithExoConfigs.cs
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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureCloudAccountTenantWithExoConfigs
    public class AzureCloudAccountTenantWithExoConfigs: BaseType
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

        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        [JsonProperty("clientId")]
        public System.String? ClientId { get; set; }

        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        [JsonProperty("domainName")]
        public System.String? DomainName { get; set; }

        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        [JsonProperty("subscriptionCount")]
        public System.Int32? SubscriptionCount { get; set; }

        //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
        // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
        [JsonProperty("subscriptions")]
        public List<AzureSubscriptionWithExoConfigs>? Subscriptions { get; set; }


        #endregion

    #region methods

    public AzureCloudAccountTenantWithExoConfigs Set(
        AzureCloudType? CloudType = null,
        System.String? AppName = null,
        System.String? ClientId = null,
        System.String? DomainName = null,
        System.Int32? SubscriptionCount = null,
        List<AzureSubscriptionWithExoConfigs>? Subscriptions = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( AppName != null ) {
            this.AppName = AppName;
        }
        if ( ClientId != null ) {
            this.ClientId = ClientId;
        }
        if ( DomainName != null ) {
            this.DomainName = DomainName;
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
        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        if (this.SubscriptionCount != null) {
            s += ind + "subscriptionCount\n" ;
        }
        //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
        // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
        if (this.Subscriptions != null) {
            s += ind + "subscriptions {\n" + this.Subscriptions.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        if (this.CloudType == null && Exploration.Includes(parent + ".cloudType", true))
        {
            this.CloudType = new AzureCloudType();
        }
        //      C# -> System.String? AppName
        // GraphQL -> appName: String! (scalar)
        if (this.AppName == null && Exploration.Includes(parent + ".appName", true))
        {
            this.AppName = new System.String("FETCH");
        }
        //      C# -> System.String? ClientId
        // GraphQL -> clientId: String! (scalar)
        if (this.ClientId == null && Exploration.Includes(parent + ".clientId", true))
        {
            this.ClientId = new System.String("FETCH");
        }
        //      C# -> System.String? DomainName
        // GraphQL -> domainName: String! (scalar)
        if (this.DomainName == null && Exploration.Includes(parent + ".domainName", true))
        {
            this.DomainName = new System.String("FETCH");
        }
        //      C# -> System.Int32? SubscriptionCount
        // GraphQL -> subscriptionCount: Int! (scalar)
        if (this.SubscriptionCount == null && Exploration.Includes(parent + ".subscriptionCount", true))
        {
            this.SubscriptionCount = new System.Int32();
        }
        //      C# -> List<AzureSubscriptionWithExoConfigs>? Subscriptions
        // GraphQL -> subscriptions: [AzureSubscriptionWithExoConfigs!]! (type)
        if (this.Subscriptions == null && Exploration.Includes(parent + ".subscriptions"))
        {
            this.Subscriptions = new List<AzureSubscriptionWithExoConfigs>();
            this.Subscriptions.ApplyExploratoryFieldSpec(parent + ".subscriptions");
        }
    }


    #endregion

    } // class AzureCloudAccountTenantWithExoConfigs
    
    #endregion

    public static class ListAzureCloudAccountTenantWithExoConfigsExtensions
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
            this List<AzureCloudAccountTenantWithExoConfigs> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountTenantWithExoConfigs> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountTenantWithExoConfigs());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types