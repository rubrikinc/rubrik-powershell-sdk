// AzureCloudAccountDetailsForFeatureReply.cs
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
    #region AzureCloudAccountDetailsForFeatureReply
    public class AzureCloudAccountDetailsForFeatureReply: BaseType
    {
        #region members

        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType! (enum)
        [JsonProperty("azureCloudType")]
        public AzureCloudType? AzureCloudType { get; set; }

        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!]! (enum)
        [JsonProperty("permissionsGroups")]
        public List<PermissionsGroup>? PermissionsGroups { get; set; }

        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        [JsonProperty("subscriptionId")]
        public System.String? SubscriptionId { get; set; }

        //      C# -> System.String? TenantDomain
        // GraphQL -> tenantDomain: String! (scalar)
        [JsonProperty("tenantDomain")]
        public System.String? TenantDomain { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureCloudAccountDetailsForFeatureReply";
    }

    public AzureCloudAccountDetailsForFeatureReply Set(
        AzureCloudType? AzureCloudType = null,
        List<PermissionsGroup>? PermissionsGroups = null,
        System.String? SubscriptionId = null,
        System.String? TenantDomain = null,
        System.String? TenantId = null
    ) 
    {
        if ( AzureCloudType != null ) {
            this.AzureCloudType = AzureCloudType;
        }
        if ( PermissionsGroups != null ) {
            this.PermissionsGroups = PermissionsGroups;
        }
        if ( SubscriptionId != null ) {
            this.SubscriptionId = SubscriptionId;
        }
        if ( TenantDomain != null ) {
            this.TenantDomain = TenantDomain;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
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
        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType! (enum)
        if (this.AzureCloudType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "azureCloudType\n" ;
            } else {
                s += ind + "azureCloudType\n" ;
            }
        }
        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!]! (enum)
        if (this.PermissionsGroups != null) {
            if (conf.Flat) {
                s += conf.Prefix + "permissionsGroups\n" ;
            } else {
                s += ind + "permissionsGroups\n" ;
            }
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (this.SubscriptionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "subscriptionId\n" ;
            } else {
                s += ind + "subscriptionId\n" ;
            }
        }
        //      C# -> System.String? TenantDomain
        // GraphQL -> tenantDomain: String! (scalar)
        if (this.TenantDomain != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantDomain\n" ;
            } else {
                s += ind + "tenantDomain\n" ;
            }
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AzureCloudType? AzureCloudType
        // GraphQL -> azureCloudType: AzureCloudType! (enum)
        if (ec.Includes("azureCloudType",true))
        {
            if(this.AzureCloudType == null) {

                this.AzureCloudType = new AzureCloudType();

            } else {


            }
        }
        else if (this.AzureCloudType != null && ec.Excludes("azureCloudType",true))
        {
            this.AzureCloudType = null;
        }
        //      C# -> List<PermissionsGroup>? PermissionsGroups
        // GraphQL -> permissionsGroups: [PermissionsGroup!]! (enum)
        if (ec.Includes("permissionsGroups",true))
        {
            if(this.PermissionsGroups == null) {

                this.PermissionsGroups = new List<PermissionsGroup>();

            } else {


            }
        }
        else if (this.PermissionsGroups != null && ec.Excludes("permissionsGroups",true))
        {
            this.PermissionsGroups = null;
        }
        //      C# -> System.String? SubscriptionId
        // GraphQL -> subscriptionId: String! (scalar)
        if (ec.Includes("subscriptionId",true))
        {
            if(this.SubscriptionId == null) {

                this.SubscriptionId = "FETCH";

            } else {


            }
        }
        else if (this.SubscriptionId != null && ec.Excludes("subscriptionId",true))
        {
            this.SubscriptionId = null;
        }
        //      C# -> System.String? TenantDomain
        // GraphQL -> tenantDomain: String! (scalar)
        if (ec.Includes("tenantDomain",true))
        {
            if(this.TenantDomain == null) {

                this.TenantDomain = "FETCH";

            } else {


            }
        }
        else if (this.TenantDomain != null && ec.Excludes("tenantDomain",true))
        {
            this.TenantDomain = null;
        }
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (ec.Includes("tenantId",true))
        {
            if(this.TenantId == null) {

                this.TenantId = "FETCH";

            } else {


            }
        }
        else if (this.TenantId != null && ec.Excludes("tenantId",true))
        {
            this.TenantId = null;
        }
    }


    #endregion

    } // class AzureCloudAccountDetailsForFeatureReply
    
    #endregion

    public static class ListAzureCloudAccountDetailsForFeatureReplyExtensions
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
            this List<AzureCloudAccountDetailsForFeatureReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureCloudAccountDetailsForFeatureReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureCloudAccountDetailsForFeatureReply> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureCloudAccountDetailsForFeatureReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureCloudAccountDetailsForFeatureReply> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types