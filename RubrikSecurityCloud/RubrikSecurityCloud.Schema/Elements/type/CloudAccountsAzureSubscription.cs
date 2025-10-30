// CloudAccountsAzureSubscription.cs
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
    #region CloudAccountsAzureSubscription
    public class CloudAccountsAzureSubscription: BaseType
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
        return "CloudAccountsAzureSubscription";
    }

    public CloudAccountsAzureSubscription Set(
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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

    } // class CloudAccountsAzureSubscription
    
    #endregion

    public static class ListCloudAccountsAzureSubscriptionExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CloudAccountsAzureSubscription> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudAccountsAzureSubscription> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudAccountsAzureSubscription> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudAccountsAzureSubscription());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudAccountsAzureSubscription> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types