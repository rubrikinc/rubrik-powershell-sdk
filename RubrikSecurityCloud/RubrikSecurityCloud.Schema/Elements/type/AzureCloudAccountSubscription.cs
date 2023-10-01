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

    public override string GetGqlTypeName() {
        return "AzureCloudAccountSubscription";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        if (this.CloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cloudType\n" ;
            } else {
                s += ind + "cloudType\n" ;
            }
        }
        //      C# -> System.String? CustomerSubscriptionId
        // GraphQL -> customerSubscriptionId: String! (scalar)
        if (this.CustomerSubscriptionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customerSubscriptionId\n" ;
            } else {
                s += ind + "customerSubscriptionId\n" ;
            }
        }
        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        if (this.CustomerTenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "customerTenantId\n" ;
            } else {
                s += ind + "customerTenantId\n" ;
            }
        }
        //      C# -> System.Boolean? IsAuthorized
        // GraphQL -> isAuthorized: Boolean! (scalar)
        if (this.IsAuthorized != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAuthorized\n" ;
            } else {
                s += ind + "isAuthorized\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (this.NativeId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nativeId\n" ;
            } else {
                s += ind + "nativeId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        if (ec.Includes("cloudType",true))
        {
            if(this.CloudType == null) {

                this.CloudType = new AzureCloudType();

            } else {


            }
        }
        else if (this.CloudType != null && ec.Excludes("cloudType",true))
        {
            this.CloudType = null;
        }
        //      C# -> System.String? CustomerSubscriptionId
        // GraphQL -> customerSubscriptionId: String! (scalar)
        if (ec.Includes("customerSubscriptionId",true))
        {
            if(this.CustomerSubscriptionId == null) {

                this.CustomerSubscriptionId = "FETCH";

            } else {


            }
        }
        else if (this.CustomerSubscriptionId != null && ec.Excludes("customerSubscriptionId",true))
        {
            this.CustomerSubscriptionId = null;
        }
        //      C# -> System.String? CustomerTenantId
        // GraphQL -> customerTenantId: String! (scalar)
        if (ec.Includes("customerTenantId",true))
        {
            if(this.CustomerTenantId == null) {

                this.CustomerTenantId = "FETCH";

            } else {


            }
        }
        else if (this.CustomerTenantId != null && ec.Excludes("customerTenantId",true))
        {
            this.CustomerTenantId = null;
        }
        //      C# -> System.Boolean? IsAuthorized
        // GraphQL -> isAuthorized: Boolean! (scalar)
        if (ec.Includes("isAuthorized",true))
        {
            if(this.IsAuthorized == null) {

                this.IsAuthorized = true;

            } else {


            }
        }
        else if (this.IsAuthorized != null && ec.Excludes("isAuthorized",true))
        {
            this.IsAuthorized = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        if (ec.Includes("nativeId",true))
        {
            if(this.NativeId == null) {

                this.NativeId = "FETCH";

            } else {


            }
        }
        else if (this.NativeId != null && ec.Excludes("nativeId",true))
        {
            this.NativeId = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AzureCloudAccountSubscription> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountSubscription> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountSubscription());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudAccountSubscription> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types