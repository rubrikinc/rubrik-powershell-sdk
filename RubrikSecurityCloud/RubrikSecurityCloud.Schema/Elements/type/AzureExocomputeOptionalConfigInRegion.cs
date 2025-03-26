// AzureExocomputeOptionalConfigInRegion.cs
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
    #region AzureExocomputeOptionalConfigInRegion
    public class AzureExocomputeOptionalConfigInRegion: BaseType
    {
        #region members

        //      C# -> AksProvisionTier? AksClusterTier
        // GraphQL -> aksClusterTier: AKSProvisionTier! (enum)
        [JsonProperty("aksClusterTier")]
        public AksProvisionTier? AksClusterTier { get; set; }

        //      C# -> AksNodeCountBucket? AksNodeCountBucket
        // GraphQL -> aksNodeCountBucket: AKSNodeCountBucket! (enum)
        [JsonProperty("aksNodeCountBucket")]
        public AksNodeCountBucket? AksNodeCountBucket { get; set; }

        //      C# -> List<System.String>? AdditionalWhitelistIps
        // GraphQL -> additionalWhitelistIps: [String!]! (scalar)
        [JsonProperty("additionalWhitelistIps")]
        public List<System.String>? AdditionalWhitelistIps { get; set; }

        //      C# -> System.String? AksNodeRgPrefix
        // GraphQL -> aksNodeRgPrefix: String! (scalar)
        [JsonProperty("aksNodeRgPrefix")]
        public System.String? AksNodeRgPrefix { get; set; }

        //      C# -> System.Boolean? DiskEncryptionAtHost
        // GraphQL -> diskEncryptionAtHost: Boolean! (scalar)
        [JsonProperty("diskEncryptionAtHost")]
        public System.Boolean? DiskEncryptionAtHost { get; set; }

        //      C# -> System.Boolean? EnableUserDefinedRouting
        // GraphQL -> enableUserDefinedRouting: Boolean! (scalar)
        [JsonProperty("enableUserDefinedRouting")]
        public System.Boolean? EnableUserDefinedRouting { get; set; }

        //      C# -> System.Boolean? ShouldWhitelistRubrikIps
        // GraphQL -> shouldWhitelistRubrikIps: Boolean! (scalar)
        [JsonProperty("shouldWhitelistRubrikIps")]
        public System.Boolean? ShouldWhitelistRubrikIps { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AzureExocomputeOptionalConfigInRegion";
    }

    public AzureExocomputeOptionalConfigInRegion Set(
        AksProvisionTier? AksClusterTier = null,
        AksNodeCountBucket? AksNodeCountBucket = null,
        List<System.String>? AdditionalWhitelistIps = null,
        System.String? AksNodeRgPrefix = null,
        System.Boolean? DiskEncryptionAtHost = null,
        System.Boolean? EnableUserDefinedRouting = null,
        System.Boolean? ShouldWhitelistRubrikIps = null
    ) 
    {
        if ( AksClusterTier != null ) {
            this.AksClusterTier = AksClusterTier;
        }
        if ( AksNodeCountBucket != null ) {
            this.AksNodeCountBucket = AksNodeCountBucket;
        }
        if ( AdditionalWhitelistIps != null ) {
            this.AdditionalWhitelistIps = AdditionalWhitelistIps;
        }
        if ( AksNodeRgPrefix != null ) {
            this.AksNodeRgPrefix = AksNodeRgPrefix;
        }
        if ( DiskEncryptionAtHost != null ) {
            this.DiskEncryptionAtHost = DiskEncryptionAtHost;
        }
        if ( EnableUserDefinedRouting != null ) {
            this.EnableUserDefinedRouting = EnableUserDefinedRouting;
        }
        if ( ShouldWhitelistRubrikIps != null ) {
            this.ShouldWhitelistRubrikIps = ShouldWhitelistRubrikIps;
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
        //      C# -> AksProvisionTier? AksClusterTier
        // GraphQL -> aksClusterTier: AKSProvisionTier! (enum)
        if (this.AksClusterTier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aksClusterTier\n" ;
            } else {
                s += ind + "aksClusterTier\n" ;
            }
        }
        //      C# -> AksNodeCountBucket? AksNodeCountBucket
        // GraphQL -> aksNodeCountBucket: AKSNodeCountBucket! (enum)
        if (this.AksNodeCountBucket != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aksNodeCountBucket\n" ;
            } else {
                s += ind + "aksNodeCountBucket\n" ;
            }
        }
        //      C# -> List<System.String>? AdditionalWhitelistIps
        // GraphQL -> additionalWhitelistIps: [String!]! (scalar)
        if (this.AdditionalWhitelistIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "additionalWhitelistIps\n" ;
            } else {
                s += ind + "additionalWhitelistIps\n" ;
            }
        }
        //      C# -> System.String? AksNodeRgPrefix
        // GraphQL -> aksNodeRgPrefix: String! (scalar)
        if (this.AksNodeRgPrefix != null) {
            if (conf.Flat) {
                s += conf.Prefix + "aksNodeRgPrefix\n" ;
            } else {
                s += ind + "aksNodeRgPrefix\n" ;
            }
        }
        //      C# -> System.Boolean? DiskEncryptionAtHost
        // GraphQL -> diskEncryptionAtHost: Boolean! (scalar)
        if (this.DiskEncryptionAtHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "diskEncryptionAtHost\n" ;
            } else {
                s += ind + "diskEncryptionAtHost\n" ;
            }
        }
        //      C# -> System.Boolean? EnableUserDefinedRouting
        // GraphQL -> enableUserDefinedRouting: Boolean! (scalar)
        if (this.EnableUserDefinedRouting != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enableUserDefinedRouting\n" ;
            } else {
                s += ind + "enableUserDefinedRouting\n" ;
            }
        }
        //      C# -> System.Boolean? ShouldWhitelistRubrikIps
        // GraphQL -> shouldWhitelistRubrikIps: Boolean! (scalar)
        if (this.ShouldWhitelistRubrikIps != null) {
            if (conf.Flat) {
                s += conf.Prefix + "shouldWhitelistRubrikIps\n" ;
            } else {
                s += ind + "shouldWhitelistRubrikIps\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AksProvisionTier? AksClusterTier
        // GraphQL -> aksClusterTier: AKSProvisionTier! (enum)
        if (ec.Includes("aksClusterTier",true))
        {
            if(this.AksClusterTier == null) {

                this.AksClusterTier = new AksProvisionTier();

            } else {


            }
        }
        else if (this.AksClusterTier != null && ec.Excludes("aksClusterTier",true))
        {
            this.AksClusterTier = null;
        }
        //      C# -> AksNodeCountBucket? AksNodeCountBucket
        // GraphQL -> aksNodeCountBucket: AKSNodeCountBucket! (enum)
        if (ec.Includes("aksNodeCountBucket",true))
        {
            if(this.AksNodeCountBucket == null) {

                this.AksNodeCountBucket = new AksNodeCountBucket();

            } else {


            }
        }
        else if (this.AksNodeCountBucket != null && ec.Excludes("aksNodeCountBucket",true))
        {
            this.AksNodeCountBucket = null;
        }
        //      C# -> List<System.String>? AdditionalWhitelistIps
        // GraphQL -> additionalWhitelistIps: [String!]! (scalar)
        if (ec.Includes("additionalWhitelistIps",true))
        {
            if(this.AdditionalWhitelistIps == null) {

                this.AdditionalWhitelistIps = new List<System.String>();

            } else {


            }
        }
        else if (this.AdditionalWhitelistIps != null && ec.Excludes("additionalWhitelistIps",true))
        {
            this.AdditionalWhitelistIps = null;
        }
        //      C# -> System.String? AksNodeRgPrefix
        // GraphQL -> aksNodeRgPrefix: String! (scalar)
        if (ec.Includes("aksNodeRgPrefix",true))
        {
            if(this.AksNodeRgPrefix == null) {

                this.AksNodeRgPrefix = "FETCH";

            } else {


            }
        }
        else if (this.AksNodeRgPrefix != null && ec.Excludes("aksNodeRgPrefix",true))
        {
            this.AksNodeRgPrefix = null;
        }
        //      C# -> System.Boolean? DiskEncryptionAtHost
        // GraphQL -> diskEncryptionAtHost: Boolean! (scalar)
        if (ec.Includes("diskEncryptionAtHost",true))
        {
            if(this.DiskEncryptionAtHost == null) {

                this.DiskEncryptionAtHost = true;

            } else {


            }
        }
        else if (this.DiskEncryptionAtHost != null && ec.Excludes("diskEncryptionAtHost",true))
        {
            this.DiskEncryptionAtHost = null;
        }
        //      C# -> System.Boolean? EnableUserDefinedRouting
        // GraphQL -> enableUserDefinedRouting: Boolean! (scalar)
        if (ec.Includes("enableUserDefinedRouting",true))
        {
            if(this.EnableUserDefinedRouting == null) {

                this.EnableUserDefinedRouting = true;

            } else {


            }
        }
        else if (this.EnableUserDefinedRouting != null && ec.Excludes("enableUserDefinedRouting",true))
        {
            this.EnableUserDefinedRouting = null;
        }
        //      C# -> System.Boolean? ShouldWhitelistRubrikIps
        // GraphQL -> shouldWhitelistRubrikIps: Boolean! (scalar)
        if (ec.Includes("shouldWhitelistRubrikIps",true))
        {
            if(this.ShouldWhitelistRubrikIps == null) {

                this.ShouldWhitelistRubrikIps = true;

            } else {


            }
        }
        else if (this.ShouldWhitelistRubrikIps != null && ec.Excludes("shouldWhitelistRubrikIps",true))
        {
            this.ShouldWhitelistRubrikIps = null;
        }
    }


    #endregion

    } // class AzureExocomputeOptionalConfigInRegion
    
    #endregion

    public static class ListAzureExocomputeOptionalConfigInRegionExtensions
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
            this List<AzureExocomputeOptionalConfigInRegion> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AzureExocomputeOptionalConfigInRegion> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AzureExocomputeOptionalConfigInRegion> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureExocomputeOptionalConfigInRegion());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AzureExocomputeOptionalConfigInRegion> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types