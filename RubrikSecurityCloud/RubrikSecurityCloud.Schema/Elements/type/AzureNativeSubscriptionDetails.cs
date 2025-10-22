// AzureNativeSubscriptionDetails.cs
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
    #region AzureNativeSubscriptionDetails
    public class AzureNativeSubscriptionDetails: BaseType
    {
        #region members

        //      C# -> AzureCloudType? CloudType
        // GraphQL -> cloudType: AzureCloudType! (enum)
        [JsonProperty("cloudType")]
        public AzureCloudType? CloudType { get; set; }

        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        [JsonProperty("status")]
        public AzureSubscriptionStatus? Status { get; set; }

        //      C# -> System.String? AccountConnectionId
        // GraphQL -> accountConnectionId: String! (scalar)
        [JsonProperty("accountConnectionId")]
        public System.String? AccountConnectionId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? NativeId
        // GraphQL -> nativeId: String! (scalar)
        [JsonProperty("nativeId")]
        public System.String? NativeId { get; set; }

        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        [JsonProperty("tenantId")]
        public System.String? TenantId { get; set; }

        //      C# -> List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AzureNativeSubscriptionEnabledFeature!]! (type)
        [JsonProperty("enabledFeatures")]
        public List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures { get; set; }

        //      C# -> List<AzureNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AzureNativeRegionSpec!]! (type)
        [JsonProperty("regionSpecs")]
        public List<AzureNativeRegionSpec>? RegionSpecs { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureNativeSubscriptionDetails";
    }

    public AzureNativeSubscriptionDetails Set(
        AzureCloudType? CloudType = null,
        AzureSubscriptionStatus? Status = null,
        System.String? AccountConnectionId = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? NativeId = null,
        System.String? TenantId = null,
        List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures = null,
        List<AzureNativeRegionSpec>? RegionSpecs = null
    ) 
    {
        if ( CloudType != null ) {
            this.CloudType = CloudType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( AccountConnectionId != null ) {
            this.AccountConnectionId = AccountConnectionId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NativeId != null ) {
            this.NativeId = NativeId;
        }
        if ( TenantId != null ) {
            this.TenantId = TenantId;
        }
        if ( EnabledFeatures != null ) {
            this.EnabledFeatures = EnabledFeatures;
        }
        if ( RegionSpecs != null ) {
            this.RegionSpecs = RegionSpecs;
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
        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.String? AccountConnectionId
        // GraphQL -> accountConnectionId: String! (scalar)
        if (this.AccountConnectionId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "accountConnectionId\n" ;
            } else {
                s += ind + "accountConnectionId\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
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
        //      C# -> System.String? TenantId
        // GraphQL -> tenantId: String! (scalar)
        if (this.TenantId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tenantId\n" ;
            } else {
                s += ind + "tenantId\n" ;
            }
        }
        //      C# -> List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AzureNativeSubscriptionEnabledFeature!]! (type)
        if (this.EnabledFeatures != null) {
            var fspec = this.EnabledFeatures.AsFieldSpec(conf.Child("enabledFeatures"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "enabledFeatures" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<AzureNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AzureNativeRegionSpec!]! (type)
        if (this.RegionSpecs != null) {
            var fspec = this.RegionSpecs.AsFieldSpec(conf.Child("regionSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "regionSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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
        //      C# -> AzureSubscriptionStatus? Status
        // GraphQL -> status: AzureSubscriptionStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new AzureSubscriptionStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.String? AccountConnectionId
        // GraphQL -> accountConnectionId: String! (scalar)
        if (ec.Includes("accountConnectionId",true))
        {
            if(this.AccountConnectionId == null) {

                this.AccountConnectionId = "FETCH";

            } else {


            }
        }
        else if (this.AccountConnectionId != null && ec.Excludes("accountConnectionId",true))
        {
            this.AccountConnectionId = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
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
        //      C# -> List<AzureNativeSubscriptionEnabledFeature>? EnabledFeatures
        // GraphQL -> enabledFeatures: [AzureNativeSubscriptionEnabledFeature!]! (type)
        if (ec.Includes("enabledFeatures",false))
        {
            if(this.EnabledFeatures == null) {

                this.EnabledFeatures = new List<AzureNativeSubscriptionEnabledFeature>();
                this.EnabledFeatures.ApplyExploratoryFieldSpec(ec.NewChild("enabledFeatures"));

            } else {

                this.EnabledFeatures.ApplyExploratoryFieldSpec(ec.NewChild("enabledFeatures"));

            }
        }
        else if (this.EnabledFeatures != null && ec.Excludes("enabledFeatures",false))
        {
            this.EnabledFeatures = null;
        }
        //      C# -> List<AzureNativeRegionSpec>? RegionSpecs
        // GraphQL -> regionSpecs: [AzureNativeRegionSpec!]! (type)
        if (ec.Includes("regionSpecs",false))
        {
            if(this.RegionSpecs == null) {

                this.RegionSpecs = new List<AzureNativeRegionSpec>();
                this.RegionSpecs.ApplyExploratoryFieldSpec(ec.NewChild("regionSpecs"));

            } else {

                this.RegionSpecs.ApplyExploratoryFieldSpec(ec.NewChild("regionSpecs"));

            }
        }
        else if (this.RegionSpecs != null && ec.Excludes("regionSpecs",false))
        {
            this.RegionSpecs = null;
        }
    }


    #endregion

    } // class AzureNativeSubscriptionDetails
    
    #endregion

    public static class ListAzureNativeSubscriptionDetailsExtensions
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
            this List<AzureNativeSubscriptionDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureNativeSubscriptionDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureNativeSubscriptionDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNativeSubscriptionDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureNativeSubscriptionDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types