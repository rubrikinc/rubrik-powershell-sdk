// HpeVmeEnvironmentDetails.cs
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
    #region HpeVmeEnvironmentDetails
    public class HpeVmeEnvironmentDetails: BaseType
    {
        #region members

        //      C# -> System.String? HpeVmeHostId
        // GraphQL -> hpeVmeHostId: String (scalar)
        [JsonProperty("hpeVmeHostId")]
        public System.String? HpeVmeHostId { get; set; }

        //      C# -> System.String? HpeVmeManagerId
        // GraphQL -> hpeVmeManagerId: String! (scalar)
        [JsonProperty("hpeVmeManagerId")]
        public System.String? HpeVmeManagerId { get; set; }

        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        [JsonProperty("ipAddresses")]
        public List<System.String>? IpAddresses { get; set; }

        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        [JsonProperty("versions")]
        public List<System.String>? Versions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HpeVmeEnvironmentDetails";
    }

    public HpeVmeEnvironmentDetails Set(
        System.String? HpeVmeHostId = null,
        System.String? HpeVmeManagerId = null,
        List<System.String>? IpAddresses = null,
        List<System.String>? Versions = null
    ) 
    {
        if ( HpeVmeHostId != null ) {
            this.HpeVmeHostId = HpeVmeHostId;
        }
        if ( HpeVmeManagerId != null ) {
            this.HpeVmeManagerId = HpeVmeManagerId;
        }
        if ( IpAddresses != null ) {
            this.IpAddresses = IpAddresses;
        }
        if ( Versions != null ) {
            this.Versions = Versions;
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
        //      C# -> System.String? HpeVmeHostId
        // GraphQL -> hpeVmeHostId: String (scalar)
        if (this.HpeVmeHostId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hpeVmeHostId\n" ;
            } else {
                s += ind + "hpeVmeHostId\n" ;
            }
        }
        //      C# -> System.String? HpeVmeManagerId
        // GraphQL -> hpeVmeManagerId: String! (scalar)
        if (this.HpeVmeManagerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hpeVmeManagerId\n" ;
            } else {
                s += ind + "hpeVmeManagerId\n" ;
            }
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (this.IpAddresses != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ipAddresses\n" ;
            } else {
                s += ind + "ipAddresses\n" ;
            }
        }
        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        if (this.Versions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "versions\n" ;
            } else {
                s += ind + "versions\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? HpeVmeHostId
        // GraphQL -> hpeVmeHostId: String (scalar)
        if (ec.Includes("hpeVmeHostId",true))
        {
            if(this.HpeVmeHostId == null) {

                this.HpeVmeHostId = "FETCH";

            } else {


            }
        }
        else if (this.HpeVmeHostId != null && ec.Excludes("hpeVmeHostId",true))
        {
            this.HpeVmeHostId = null;
        }
        //      C# -> System.String? HpeVmeManagerId
        // GraphQL -> hpeVmeManagerId: String! (scalar)
        if (ec.Includes("hpeVmeManagerId",true))
        {
            if(this.HpeVmeManagerId == null) {

                this.HpeVmeManagerId = "FETCH";

            } else {


            }
        }
        else if (this.HpeVmeManagerId != null && ec.Excludes("hpeVmeManagerId",true))
        {
            this.HpeVmeManagerId = null;
        }
        //      C# -> List<System.String>? IpAddresses
        // GraphQL -> ipAddresses: [String!]! (scalar)
        if (ec.Includes("ipAddresses",true))
        {
            if(this.IpAddresses == null) {

                this.IpAddresses = new List<System.String>();

            } else {


            }
        }
        else if (this.IpAddresses != null && ec.Excludes("ipAddresses",true))
        {
            this.IpAddresses = null;
        }
        //      C# -> List<System.String>? Versions
        // GraphQL -> versions: [String!]! (scalar)
        if (ec.Includes("versions",true))
        {
            if(this.Versions == null) {

                this.Versions = new List<System.String>();

            } else {


            }
        }
        else if (this.Versions != null && ec.Excludes("versions",true))
        {
            this.Versions = null;
        }
    }


    #endregion

    } // class HpeVmeEnvironmentDetails
    
    #endregion

    public static class ListHpeVmeEnvironmentDetailsExtensions
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
            this List<HpeVmeEnvironmentDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<HpeVmeEnvironmentDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<HpeVmeEnvironmentDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HpeVmeEnvironmentDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<HpeVmeEnvironmentDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types