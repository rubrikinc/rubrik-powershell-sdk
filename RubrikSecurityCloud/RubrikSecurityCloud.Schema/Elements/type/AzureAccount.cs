// AzureAccount.cs
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
    #region AzureAccount
 
    public class AzureAccount: BaseType, CloudAccount
    {
        #region members

        //      C# -> CloudAccountType? CloudProvider
        // GraphQL -> cloudProvider: CloudAccountType! (enum)
        [JsonProperty("cloudProvider")]
        public CloudAccountType? CloudProvider { get; set; }

        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        [JsonProperty("connectionStatus")]
        public ConnectionStatusType? ConnectionStatus { get; set; }

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureAccount";
    }

    public AzureAccount Set(
        CloudAccountType? CloudProvider = null,
        ConnectionStatusType? ConnectionStatus = null,
        System.String? CloudAccountId = null,
        System.String? Description = null,
        System.String? Name = null,
        System.String? SubscriptionId = null,
        System.String? TenantId = null
    ) 
    {
        if ( CloudProvider != null ) {
            this.CloudProvider = CloudProvider;
        }
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( CloudAccountId != null ) {
            this.CloudAccountId = CloudAccountId;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
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
        //      C# -> CloudAccountType? CloudProvider
        // GraphQL -> cloudProvider: CloudAccountType! (enum)
        if (this.CloudProvider != null) {
            s += ind + "cloudProvider\n" ;
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId != null) {
            s += ind + "cloudAccountId\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            s += ind + "subscriptionId\n" ;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            s += ind + "tenantId\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CloudAccountType? CloudProvider
        // GraphQL -> cloudProvider: CloudAccountType! (enum)
        if (this.CloudProvider == null && ec.Includes("cloudProvider",true))
        {
            this.CloudProvider = new CloudAccountType();
        }
        //      C# -> ConnectionStatusType? ConnectionStatus
        // GraphQL -> connectionStatus: ConnectionStatusType! (enum)
        if (this.ConnectionStatus == null && ec.Includes("connectionStatus",true))
        {
            this.ConnectionStatus = new ConnectionStatusType();
        }
        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: String! (scalar)
        if (this.CloudAccountId == null && ec.Includes("cloudAccountId",true))
        {
            this.CloudAccountId = "FETCH";
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String (scalar)
        if (this.Description == null && ec.Includes("description",true))
        {
            this.Description = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId == null && ec.Includes("subscriptionId",true))
        {
            this.SubscriptionId = "FETCH";
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId == null && ec.Includes("tenantId",true))
        {
            this.TenantId = "FETCH";
        }
    }


    #endregion

    } // class AzureAccount
    
    #endregion

    public static class ListAzureAccountExtensions
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
            this List<AzureAccount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureAccount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureAccount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<AzureAccount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types