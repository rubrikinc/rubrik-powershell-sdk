// AzureCloudAccountSubscription.cs
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
    #region AzureCloudAccountSubscription
    public class AzureCloudAccountSubscription: BaseType
    {
        #region members

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        //      C# -> System.String? CustomerSubscriptionId
        // GraphQL -> customerSubscriptionId: String! (scalar)
        [JsonProperty("customerSubscriptionId")]
        public System.String? CustomerSubscriptionId { get; set; }

        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        [JsonProperty("customerTenantId")]
        public System.String? CustomerTenantId { get; set; }

        //      C# -> System.Boolean? IsAuthorized
        // GraphQL -> isAuthorized: Boolean! (scalar)
        [JsonProperty("isAuthorized")]
        public System.Boolean? IsAuthorized { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }


        #endregion

    #region methods

    public AzureCloudAccountSubscription Set(
        AzureCloudType? CloudType = null,
        System.String? CustomerSubscriptionId = null,
        System.String? CustomerTenantId = null,
        System.Boolean? IsAuthorized = null,
        System.String? Name = null,
        System.String? NativeId = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( CustomerSubscriptionId != null ) {
            this.CustomerSubscriptionId = CustomerSubscriptionId;
        }
        if ( CustomerTenantId != null ) {
            this.CustomerTenantId = CustomerTenantId;
        }
        if ( IsAuthorized != null ) {
            this.IsAuthorized = IsAuthorized;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
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
        //      C# -> System.String? CustomerSubscriptionId
        // GraphQL -> customerSubscriptionId: String! (scalar)
        if (this.CustomerSubscriptionId != null) {
            s += ind + "customerSubscriptionId\n" ;
        }
        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        if (this.CustomerTenantId != null) {
            s += ind + "customerTenantId\n" ;
        }
        //      C# -> System.Boolean? IsAuthorized
        // GraphQL -> isAuthorized: Boolean! (scalar)
        if (this.IsAuthorized != null) {
            s += ind + "isAuthorized\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            s += ind + "nativeId\n" ;
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
        //      C# -> System.String? CustomerSubscriptionId
        // GraphQL -> customerSubscriptionId: String! (scalar)
        if (this.CustomerSubscriptionId == null && Exploration.Includes(parent + ".customerSubscriptionId", true))
        {
            this.CustomerSubscriptionId = "FETCH";
        }
        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        if (this.CustomerTenantId == null && Exploration.Includes(parent + ".customerTenantId", true))
        {
            this.CustomerTenantId = "FETCH";
        }
        //      C# -> System.Boolean? IsAuthorized
        // GraphQL -> isAuthorized: Boolean! (scalar)
        if (this.IsAuthorized == null && Exploration.Includes(parent + ".isAuthorized", true))
        {
            this.IsAuthorized = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId == null && Exploration.Includes(parent + ".nativeId", true))
        {
            this.NativeId = "FETCH";
        }
    }


    #endregion

    } // class AzureCloudAccountSubscription
    
    #endregion

    public static class ListAzureCloudAccountSubscriptionExtensions
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
            this List<AzureCloudAccountSubscription> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountSubscription> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountSubscription());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types