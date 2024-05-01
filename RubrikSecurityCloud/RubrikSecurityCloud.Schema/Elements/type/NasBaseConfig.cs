// NasBaseConfig.cs
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
    #region NasBaseConfig
    public class NasBaseConfig: BaseType
    {
        #region members

        //      C# -> System.String? ApiCertificate
        // GraphQL -> apiCertificate: String (scalar)
        [JsonProperty("apiCertificate")]
        public System.String? ApiCertificate { get; set; }

        //      C# -> System.String? ApiEndpoint
        // GraphQL -> apiEndpoint: String (scalar)
        [JsonProperty("apiEndpoint")]
        public System.String? ApiEndpoint { get; set; }

        //      C# -> System.String? ApiHostname
        // GraphQL -> apiHostname: String (scalar)
        [JsonProperty("apiHostname")]
        public System.String? ApiHostname { get; set; }

        //      C# -> System.String? ApiUsername
        // GraphQL -> apiUsername: String (scalar)
        [JsonProperty("apiUsername")]
        public System.String? ApiUsername { get; set; }

        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        [JsonProperty("isIsilonChangelistEnabled")]
        public System.Boolean? IsIsilonChangelistEnabled { get; set; }

        //      C# -> System.Boolean? IsNetAppSnapDiffEnabled
        // GraphQL -> isNetAppSnapDiffEnabled: Boolean (scalar)
        [JsonProperty("isNetAppSnapDiffEnabled")]
        public System.Boolean? IsNetAppSnapDiffEnabled { get; set; }

        //      C# -> System.Boolean? IsNutanixCftEnabled
        // GraphQL -> isNutanixCftEnabled: Boolean (scalar)
        [JsonProperty("isNutanixCftEnabled")]
        public System.Boolean? IsNutanixCftEnabled { get; set; }

        //      C# -> System.Boolean? IsShareAutoDiscoveryEnabled
        // GraphQL -> isShareAutoDiscoveryEnabled: Boolean (scalar)
        [JsonProperty("isShareAutoDiscoveryEnabled")]
        public System.Boolean? IsShareAutoDiscoveryEnabled { get; set; }

        //      C# -> System.Boolean? IsSnapdiffEnabled
        // GraphQL -> isSnapdiffEnabled: Boolean (scalar)
        [JsonProperty("isSnapdiffEnabled")]
        public System.Boolean? IsSnapdiffEnabled { get; set; }

        //      C# -> System.String? VendorType
        // GraphQL -> vendorType: String! (scalar)
        [JsonProperty("vendorType")]
        public System.String? VendorType { get; set; }

        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        [JsonProperty("zoneName")]
        public System.String? ZoneName { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NasBaseConfig";
    }

    public NasBaseConfig Set(
        System.String? ApiCertificate = null,
        System.String? ApiEndpoint = null,
        System.String? ApiHostname = null,
        System.String? ApiUsername = null,
        System.Boolean? IsIsilonChangelistEnabled = null,
        System.Boolean? IsNetAppSnapDiffEnabled = null,
        System.Boolean? IsNutanixCftEnabled = null,
        System.Boolean? IsShareAutoDiscoveryEnabled = null,
        System.Boolean? IsSnapdiffEnabled = null,
        System.String? VendorType = null,
        System.String? ZoneName = null
    ) 
    {
        if ( ApiCertificate != null ) {
            this.ApiCertificate = ApiCertificate;
        }
        if ( ApiEndpoint != null ) {
            this.ApiEndpoint = ApiEndpoint;
        }
        if ( ApiHostname != null ) {
            this.ApiHostname = ApiHostname;
        }
        if ( ApiUsername != null ) {
            this.ApiUsername = ApiUsername;
        }
        if ( IsIsilonChangelistEnabled != null ) {
            this.IsIsilonChangelistEnabled = IsIsilonChangelistEnabled;
        }
        if ( IsNetAppSnapDiffEnabled != null ) {
            this.IsNetAppSnapDiffEnabled = IsNetAppSnapDiffEnabled;
        }
        if ( IsNutanixCftEnabled != null ) {
            this.IsNutanixCftEnabled = IsNutanixCftEnabled;
        }
        if ( IsShareAutoDiscoveryEnabled != null ) {
            this.IsShareAutoDiscoveryEnabled = IsShareAutoDiscoveryEnabled;
        }
        if ( IsSnapdiffEnabled != null ) {
            this.IsSnapdiffEnabled = IsSnapdiffEnabled;
        }
        if ( VendorType != null ) {
            this.VendorType = VendorType;
        }
        if ( ZoneName != null ) {
            this.ZoneName = ZoneName;
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
        //      C# -> System.String? ApiCertificate
        // GraphQL -> apiCertificate: String (scalar)
        if (this.ApiCertificate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiCertificate\n" ;
            } else {
                s += ind + "apiCertificate\n" ;
            }
        }
        //      C# -> System.String? ApiEndpoint
        // GraphQL -> apiEndpoint: String (scalar)
        if (this.ApiEndpoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiEndpoint\n" ;
            } else {
                s += ind + "apiEndpoint\n" ;
            }
        }
        //      C# -> System.String? ApiHostname
        // GraphQL -> apiHostname: String (scalar)
        if (this.ApiHostname != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiHostname\n" ;
            } else {
                s += ind + "apiHostname\n" ;
            }
        }
        //      C# -> System.String? ApiUsername
        // GraphQL -> apiUsername: String (scalar)
        if (this.ApiUsername != null) {
            if (conf.Flat) {
                s += conf.Prefix + "apiUsername\n" ;
            } else {
                s += ind + "apiUsername\n" ;
            }
        }
        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        if (this.IsIsilonChangelistEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isIsilonChangelistEnabled\n" ;
            } else {
                s += ind + "isIsilonChangelistEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsNetAppSnapDiffEnabled
        // GraphQL -> isNetAppSnapDiffEnabled: Boolean (scalar)
        if (this.IsNetAppSnapDiffEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isNetAppSnapDiffEnabled\n" ;
            } else {
                s += ind + "isNetAppSnapDiffEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsNutanixCftEnabled
        // GraphQL -> isNutanixCftEnabled: Boolean (scalar)
        if (this.IsNutanixCftEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isNutanixCftEnabled\n" ;
            } else {
                s += ind + "isNutanixCftEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsShareAutoDiscoveryEnabled
        // GraphQL -> isShareAutoDiscoveryEnabled: Boolean (scalar)
        if (this.IsShareAutoDiscoveryEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isShareAutoDiscoveryEnabled\n" ;
            } else {
                s += ind + "isShareAutoDiscoveryEnabled\n" ;
            }
        }
        //      C# -> System.Boolean? IsSnapdiffEnabled
        // GraphQL -> isSnapdiffEnabled: Boolean (scalar)
        if (this.IsSnapdiffEnabled != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isSnapdiffEnabled\n" ;
            } else {
                s += ind + "isSnapdiffEnabled\n" ;
            }
        }
        //      C# -> System.String? VendorType
        // GraphQL -> vendorType: String! (scalar)
        if (this.VendorType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "vendorType\n" ;
            } else {
                s += ind + "vendorType\n" ;
            }
        }
        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        if (this.ZoneName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "zoneName\n" ;
            } else {
                s += ind + "zoneName\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ApiCertificate
        // GraphQL -> apiCertificate: String (scalar)
        if (ec.Includes("apiCertificate",true))
        {
            if(this.ApiCertificate == null) {

                this.ApiCertificate = "FETCH";

            } else {


            }
        }
        else if (this.ApiCertificate != null && ec.Excludes("apiCertificate",true))
        {
            this.ApiCertificate = null;
        }
        //      C# -> System.String? ApiEndpoint
        // GraphQL -> apiEndpoint: String (scalar)
        if (ec.Includes("apiEndpoint",true))
        {
            if(this.ApiEndpoint == null) {

                this.ApiEndpoint = "FETCH";

            } else {


            }
        }
        else if (this.ApiEndpoint != null && ec.Excludes("apiEndpoint",true))
        {
            this.ApiEndpoint = null;
        }
        //      C# -> System.String? ApiHostname
        // GraphQL -> apiHostname: String (scalar)
        if (ec.Includes("apiHostname",true))
        {
            if(this.ApiHostname == null) {

                this.ApiHostname = "FETCH";

            } else {


            }
        }
        else if (this.ApiHostname != null && ec.Excludes("apiHostname",true))
        {
            this.ApiHostname = null;
        }
        //      C# -> System.String? ApiUsername
        // GraphQL -> apiUsername: String (scalar)
        if (ec.Includes("apiUsername",true))
        {
            if(this.ApiUsername == null) {

                this.ApiUsername = "FETCH";

            } else {


            }
        }
        else if (this.ApiUsername != null && ec.Excludes("apiUsername",true))
        {
            this.ApiUsername = null;
        }
        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        if (ec.Includes("isIsilonChangelistEnabled",true))
        {
            if(this.IsIsilonChangelistEnabled == null) {

                this.IsIsilonChangelistEnabled = true;

            } else {


            }
        }
        else if (this.IsIsilonChangelistEnabled != null && ec.Excludes("isIsilonChangelistEnabled",true))
        {
            this.IsIsilonChangelistEnabled = null;
        }
        //      C# -> System.Boolean? IsNetAppSnapDiffEnabled
        // GraphQL -> isNetAppSnapDiffEnabled: Boolean (scalar)
        if (ec.Includes("isNetAppSnapDiffEnabled",true))
        {
            if(this.IsNetAppSnapDiffEnabled == null) {

                this.IsNetAppSnapDiffEnabled = true;

            } else {


            }
        }
        else if (this.IsNetAppSnapDiffEnabled != null && ec.Excludes("isNetAppSnapDiffEnabled",true))
        {
            this.IsNetAppSnapDiffEnabled = null;
        }
        //      C# -> System.Boolean? IsNutanixCftEnabled
        // GraphQL -> isNutanixCftEnabled: Boolean (scalar)
        if (ec.Includes("isNutanixCftEnabled",true))
        {
            if(this.IsNutanixCftEnabled == null) {

                this.IsNutanixCftEnabled = true;

            } else {


            }
        }
        else if (this.IsNutanixCftEnabled != null && ec.Excludes("isNutanixCftEnabled",true))
        {
            this.IsNutanixCftEnabled = null;
        }
        //      C# -> System.Boolean? IsShareAutoDiscoveryEnabled
        // GraphQL -> isShareAutoDiscoveryEnabled: Boolean (scalar)
        if (ec.Includes("isShareAutoDiscoveryEnabled",true))
        {
            if(this.IsShareAutoDiscoveryEnabled == null) {

                this.IsShareAutoDiscoveryEnabled = true;

            } else {


            }
        }
        else if (this.IsShareAutoDiscoveryEnabled != null && ec.Excludes("isShareAutoDiscoveryEnabled",true))
        {
            this.IsShareAutoDiscoveryEnabled = null;
        }
        //      C# -> System.Boolean? IsSnapdiffEnabled
        // GraphQL -> isSnapdiffEnabled: Boolean (scalar)
        if (ec.Includes("isSnapdiffEnabled",true))
        {
            if(this.IsSnapdiffEnabled == null) {

                this.IsSnapdiffEnabled = true;

            } else {


            }
        }
        else if (this.IsSnapdiffEnabled != null && ec.Excludes("isSnapdiffEnabled",true))
        {
            this.IsSnapdiffEnabled = null;
        }
        //      C# -> System.String? VendorType
        // GraphQL -> vendorType: String! (scalar)
        if (ec.Includes("vendorType",true))
        {
            if(this.VendorType == null) {

                this.VendorType = "FETCH";

            } else {


            }
        }
        else if (this.VendorType != null && ec.Excludes("vendorType",true))
        {
            this.VendorType = null;
        }
        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        if (ec.Includes("zoneName",true))
        {
            if(this.ZoneName == null) {

                this.ZoneName = "FETCH";

            } else {


            }
        }
        else if (this.ZoneName != null && ec.Excludes("zoneName",true))
        {
            this.ZoneName = null;
        }
    }


    #endregion

    } // class NasBaseConfig
    
    #endregion

    public static class ListNasBaseConfigExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<NasBaseConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NasBaseConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NasBaseConfig> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NasBaseConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NasBaseConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types