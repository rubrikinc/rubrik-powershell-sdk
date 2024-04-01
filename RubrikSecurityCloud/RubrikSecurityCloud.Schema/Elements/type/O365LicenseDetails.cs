// O365LicenseDetails.cs
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
    #region O365LicenseDetails
    public class O365LicenseDetails: BaseType
    {
        #region members

        //      C# -> AzureHostType? AllowedHost
        // GraphQL -> allowedHost: AzureHostType! (enum)
        [JsonProperty("allowedHost")]
        public AzureHostType? AllowedHost { get; set; }

        //      C# -> M365Cloud? M365Cloud
        // GraphQL -> m365Cloud: M365Cloud! (enum)
        [JsonProperty("m365Cloud")]
        public M365Cloud? M365Cloud { get; set; }

        //      C# -> O365AzureCloudType? RubrikSaasCloud
        // GraphQL -> rubrikSaasCloud: O365AzureCloudType! (enum)
        [JsonProperty("rubrikSaasCloud")]
        public O365AzureCloudType? RubrikSaasCloud { get; set; }

        //      C# -> System.Int32? AllowedO365UserCount
        // GraphQL -> allowedO365UserCount: Int! (scalar)
        [JsonProperty("allowedO365UserCount")]
        public System.Int32? AllowedO365UserCount { get; set; }

        //      C# -> System.Boolean? DisableLicense
        // GraphQL -> disableLicense: Boolean! (scalar)
        [JsonProperty("disableLicense")]
        public System.Boolean? DisableLicense { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "O365LicenseDetails";
    }

    public O365LicenseDetails Set(
        AzureHostType? AllowedHost = null,
        M365Cloud? M365Cloud = null,
        O365AzureCloudType? RubrikSaasCloud = null,
        System.Int32? AllowedO365UserCount = null,
        System.Boolean? DisableLicense = null
    ) 
    {
        if ( AllowedHost != null ) {
            this.AllowedHost = AllowedHost;
        }
        if ( M365Cloud != null ) {
            this.M365Cloud = M365Cloud;
        }
        if ( RubrikSaasCloud != null ) {
            this.RubrikSaasCloud = RubrikSaasCloud;
        }
        if ( AllowedO365UserCount != null ) {
            this.AllowedO365UserCount = AllowedO365UserCount;
        }
        if ( DisableLicense != null ) {
            this.DisableLicense = DisableLicense;
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
        //      C# -> AzureHostType? AllowedHost
        // GraphQL -> allowedHost: AzureHostType! (enum)
        if (this.AllowedHost != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedHost\n" ;
            } else {
                s += ind + "allowedHost\n" ;
            }
        }
        //      C# -> M365Cloud? M365Cloud
        // GraphQL -> m365Cloud: M365Cloud! (enum)
        if (this.M365Cloud != null) {
            if (conf.Flat) {
                s += conf.Prefix + "m365Cloud\n" ;
            } else {
                s += ind + "m365Cloud\n" ;
            }
        }
        //      C# -> O365AzureCloudType? RubrikSaasCloud
        // GraphQL -> rubrikSaasCloud: O365AzureCloudType! (enum)
        if (this.RubrikSaasCloud != null) {
            if (conf.Flat) {
                s += conf.Prefix + "rubrikSaasCloud\n" ;
            } else {
                s += ind + "rubrikSaasCloud\n" ;
            }
        }
        //      C# -> System.Int32? AllowedO365UserCount
        // GraphQL -> allowedO365UserCount: Int! (scalar)
        if (this.AllowedO365UserCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "allowedO365UserCount\n" ;
            } else {
                s += ind + "allowedO365UserCount\n" ;
            }
        }
        //      C# -> System.Boolean? DisableLicense
        // GraphQL -> disableLicense: Boolean! (scalar)
        if (this.DisableLicense != null) {
            if (conf.Flat) {
                s += conf.Prefix + "disableLicense\n" ;
            } else {
                s += ind + "disableLicense\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AzureHostType? AllowedHost
        // GraphQL -> allowedHost: AzureHostType! (enum)
        if (ec.Includes("allowedHost",true))
        {
            if(this.AllowedHost == null) {

                this.AllowedHost = new AzureHostType();

            } else {


            }
        }
        else if (this.AllowedHost != null && ec.Excludes("allowedHost",true))
        {
            this.AllowedHost = null;
        }
        //      C# -> M365Cloud? M365Cloud
        // GraphQL -> m365Cloud: M365Cloud! (enum)
        if (ec.Includes("m365Cloud",true))
        {
            if(this.M365Cloud == null) {

                this.M365Cloud = new M365Cloud();

            } else {


            }
        }
        else if (this.M365Cloud != null && ec.Excludes("m365Cloud",true))
        {
            this.M365Cloud = null;
        }
        //      C# -> O365AzureCloudType? RubrikSaasCloud
        // GraphQL -> rubrikSaasCloud: O365AzureCloudType! (enum)
        if (ec.Includes("rubrikSaasCloud",true))
        {
            if(this.RubrikSaasCloud == null) {

                this.RubrikSaasCloud = new O365AzureCloudType();

            } else {


            }
        }
        else if (this.RubrikSaasCloud != null && ec.Excludes("rubrikSaasCloud",true))
        {
            this.RubrikSaasCloud = null;
        }
        //      C# -> System.Int32? AllowedO365UserCount
        // GraphQL -> allowedO365UserCount: Int! (scalar)
        if (ec.Includes("allowedO365UserCount",true))
        {
            if(this.AllowedO365UserCount == null) {

                this.AllowedO365UserCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.AllowedO365UserCount != null && ec.Excludes("allowedO365UserCount",true))
        {
            this.AllowedO365UserCount = null;
        }
        //      C# -> System.Boolean? DisableLicense
        // GraphQL -> disableLicense: Boolean! (scalar)
        if (ec.Includes("disableLicense",true))
        {
            if(this.DisableLicense == null) {

                this.DisableLicense = true;

            } else {


            }
        }
        else if (this.DisableLicense != null && ec.Excludes("disableLicense",true))
        {
            this.DisableLicense = null;
        }
    }


    #endregion

    } // class O365LicenseDetails
    
    #endregion

    public static class ListO365LicenseDetailsExtensions
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
            this List<O365LicenseDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<O365LicenseDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<O365LicenseDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new O365LicenseDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<O365LicenseDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types