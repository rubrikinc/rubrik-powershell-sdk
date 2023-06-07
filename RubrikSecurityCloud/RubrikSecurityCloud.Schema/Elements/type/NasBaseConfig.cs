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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? ApiCertificate
        // GraphQL -> apiCertificate: String (scalar)
        if (this.ApiCertificate != null) {
            s += ind + "apiCertificate\n" ;
        }
        //      C# -> System.String? ApiEndpoint
        // GraphQL -> apiEndpoint: String (scalar)
        if (this.ApiEndpoint != null) {
            s += ind + "apiEndpoint\n" ;
        }
        //      C# -> System.String? ApiHostname
        // GraphQL -> apiHostname: String (scalar)
        if (this.ApiHostname != null) {
            s += ind + "apiHostname\n" ;
        }
        //      C# -> System.String? ApiUsername
        // GraphQL -> apiUsername: String (scalar)
        if (this.ApiUsername != null) {
            s += ind + "apiUsername\n" ;
        }
        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        if (this.IsIsilonChangelistEnabled != null) {
            s += ind + "isIsilonChangelistEnabled\n" ;
        }
        //      C# -> System.Boolean? IsNetAppSnapDiffEnabled
        // GraphQL -> isNetAppSnapDiffEnabled: Boolean (scalar)
        if (this.IsNetAppSnapDiffEnabled != null) {
            s += ind + "isNetAppSnapDiffEnabled\n" ;
        }
        //      C# -> System.Boolean? IsNutanixCftEnabled
        // GraphQL -> isNutanixCftEnabled: Boolean (scalar)
        if (this.IsNutanixCftEnabled != null) {
            s += ind + "isNutanixCftEnabled\n" ;
        }
        //      C# -> System.Boolean? IsShareAutoDiscoveryEnabled
        // GraphQL -> isShareAutoDiscoveryEnabled: Boolean (scalar)
        if (this.IsShareAutoDiscoveryEnabled != null) {
            s += ind + "isShareAutoDiscoveryEnabled\n" ;
        }
        //      C# -> System.Boolean? IsSnapdiffEnabled
        // GraphQL -> isSnapdiffEnabled: Boolean (scalar)
        if (this.IsSnapdiffEnabled != null) {
            s += ind + "isSnapdiffEnabled\n" ;
        }
        //      C# -> System.String? VendorType
        // GraphQL -> vendorType: String! (scalar)
        if (this.VendorType != null) {
            s += ind + "vendorType\n" ;
        }
        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        if (this.ZoneName != null) {
            s += ind + "zoneName\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ApiCertificate
        // GraphQL -> apiCertificate: String (scalar)
        if (this.ApiCertificate == null && Exploration.Includes(parent + ".apiCertificate", true))
        {
            this.ApiCertificate = "FETCH";
        }
        //      C# -> System.String? ApiEndpoint
        // GraphQL -> apiEndpoint: String (scalar)
        if (this.ApiEndpoint == null && Exploration.Includes(parent + ".apiEndpoint", true))
        {
            this.ApiEndpoint = "FETCH";
        }
        //      C# -> System.String? ApiHostname
        // GraphQL -> apiHostname: String (scalar)
        if (this.ApiHostname == null && Exploration.Includes(parent + ".apiHostname", true))
        {
            this.ApiHostname = "FETCH";
        }
        //      C# -> System.String? ApiUsername
        // GraphQL -> apiUsername: String (scalar)
        if (this.ApiUsername == null && Exploration.Includes(parent + ".apiUsername", true))
        {
            this.ApiUsername = "FETCH";
        }
        //      C# -> System.Boolean? IsIsilonChangelistEnabled
        // GraphQL -> isIsilonChangelistEnabled: Boolean (scalar)
        if (this.IsIsilonChangelistEnabled == null && Exploration.Includes(parent + ".isIsilonChangelistEnabled", true))
        {
            this.IsIsilonChangelistEnabled = true;
        }
        //      C# -> System.Boolean? IsNetAppSnapDiffEnabled
        // GraphQL -> isNetAppSnapDiffEnabled: Boolean (scalar)
        if (this.IsNetAppSnapDiffEnabled == null && Exploration.Includes(parent + ".isNetAppSnapDiffEnabled", true))
        {
            this.IsNetAppSnapDiffEnabled = true;
        }
        //      C# -> System.Boolean? IsNutanixCftEnabled
        // GraphQL -> isNutanixCftEnabled: Boolean (scalar)
        if (this.IsNutanixCftEnabled == null && Exploration.Includes(parent + ".isNutanixCftEnabled", true))
        {
            this.IsNutanixCftEnabled = true;
        }
        //      C# -> System.Boolean? IsShareAutoDiscoveryEnabled
        // GraphQL -> isShareAutoDiscoveryEnabled: Boolean (scalar)
        if (this.IsShareAutoDiscoveryEnabled == null && Exploration.Includes(parent + ".isShareAutoDiscoveryEnabled", true))
        {
            this.IsShareAutoDiscoveryEnabled = true;
        }
        //      C# -> System.Boolean? IsSnapdiffEnabled
        // GraphQL -> isSnapdiffEnabled: Boolean (scalar)
        if (this.IsSnapdiffEnabled == null && Exploration.Includes(parent + ".isSnapdiffEnabled", true))
        {
            this.IsSnapdiffEnabled = true;
        }
        //      C# -> System.String? VendorType
        // GraphQL -> vendorType: String! (scalar)
        if (this.VendorType == null && Exploration.Includes(parent + ".vendorType", true))
        {
            this.VendorType = "FETCH";
        }
        //      C# -> System.String? ZoneName
        // GraphQL -> zoneName: String (scalar)
        if (this.ZoneName == null && Exploration.Includes(parent + ".zoneName", true))
        {
            this.ZoneName = "FETCH";
        }
    }


    #endregion

    } // class NasBaseConfig
    
    #endregion

    public static class ListNasBaseConfigExtensions
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
            this List<NasBaseConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NasBaseConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NasBaseConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types