// AdComputerMetadata.cs
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
    #region AdComputerMetadata
 
    public class AdComputerMetadata: BaseType, OnPremAdPrincipalTypeSpecificMetadata
    {
        #region members

        //      C# -> System.String? DnsName
        // GraphQL -> dnsName: String! (scalar)
        [JsonProperty("dnsName")]
        public System.String? DnsName { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? Os
        // GraphQL -> os: String! (scalar)
        [JsonProperty("os")]
        public System.String? Os { get; set; }

        //      C# -> System.String? OsVersion
        // GraphQL -> osVersion: String! (scalar)
        [JsonProperty("osVersion")]
        public System.String? OsVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AdComputerMetadata";
    }

    public AdComputerMetadata Set(
        System.String? DnsName = null,
        System.String? Location = null,
        System.String? Os = null,
        System.String? OsVersion = null
    ) 
    {
        if ( DnsName != null ) {
            this.DnsName = DnsName;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( Os != null ) {
            this.Os = Os;
        }
        if ( OsVersion != null ) {
            this.OsVersion = OsVersion;
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
        //      C# -> System.String? DnsName
        // GraphQL -> dnsName: String! (scalar)
        if (this.DnsName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnsName\n" ;
            } else {
                s += ind + "dnsName\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.String? Os
        // GraphQL -> os: String! (scalar)
        if (this.Os != null) {
            if (conf.Flat) {
                s += conf.Prefix + "os\n" ;
            } else {
                s += ind + "os\n" ;
            }
        }
        //      C# -> System.String? OsVersion
        // GraphQL -> osVersion: String! (scalar)
        if (this.OsVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osVersion\n" ;
            } else {
                s += ind + "osVersion\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? DnsName
        // GraphQL -> dnsName: String! (scalar)
        if (ec.Includes("dnsName",true))
        {
            if(this.DnsName == null) {

                this.DnsName = "FETCH";

            } else {


            }
        }
        else if (this.DnsName != null && ec.Excludes("dnsName",true))
        {
            this.DnsName = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.String? Os
        // GraphQL -> os: String! (scalar)
        if (ec.Includes("os",true))
        {
            if(this.Os == null) {

                this.Os = "FETCH";

            } else {


            }
        }
        else if (this.Os != null && ec.Excludes("os",true))
        {
            this.Os = null;
        }
        //      C# -> System.String? OsVersion
        // GraphQL -> osVersion: String! (scalar)
        if (ec.Includes("osVersion",true))
        {
            if(this.OsVersion == null) {

                this.OsVersion = "FETCH";

            } else {


            }
        }
        else if (this.OsVersion != null && ec.Excludes("osVersion",true))
        {
            this.OsVersion = null;
        }
    }


    #endregion

    } // class AdComputerMetadata
    
    #endregion

    public static class ListAdComputerMetadataExtensions
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
            this List<AdComputerMetadata> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AdComputerMetadata> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AdComputerMetadata> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AdComputerMetadata());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AdComputerMetadata> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types