// OsDetails.cs
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
    #region OsDetails
    public class OsDetails: BaseType
    {
        #region members

        //      C# -> System.String? BuildNumber
        // GraphQL -> buildNumber: String! (scalar)
        [JsonProperty("buildNumber")]
        public System.String? BuildNumber { get; set; }

        //      C# -> System.String? OsName
        // GraphQL -> osName: String! (scalar)
        [JsonProperty("osName")]
        public System.String? OsName { get; set; }

        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        [JsonProperty("version")]
        public System.String? Version { get; set; }

        //      C# -> List<HotFixDetail>? HotFixDetails
        // GraphQL -> hotFixDetails: [HotFixDetail!]! (type)
        [JsonProperty("hotFixDetails")]
        public List<HotFixDetail>? HotFixDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "OsDetails";
    }

    public OsDetails Set(
        System.String? BuildNumber = null,
        System.String? OsName = null,
        System.String? Version = null,
        List<HotFixDetail>? HotFixDetails = null
    ) 
    {
        if ( BuildNumber != null ) {
            this.BuildNumber = BuildNumber;
        }
        if ( OsName != null ) {
            this.OsName = OsName;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( HotFixDetails != null ) {
            this.HotFixDetails = HotFixDetails;
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
        //      C# -> System.String? BuildNumber
        // GraphQL -> buildNumber: String! (scalar)
        if (this.BuildNumber != null) {
            if (conf.Flat) {
                s += conf.Prefix + "buildNumber\n" ;
            } else {
                s += ind + "buildNumber\n" ;
            }
        }
        //      C# -> System.String? OsName
        // GraphQL -> osName: String! (scalar)
        if (this.OsName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "osName\n" ;
            } else {
                s += ind + "osName\n" ;
            }
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> List<HotFixDetail>? HotFixDetails
        // GraphQL -> hotFixDetails: [HotFixDetail!]! (type)
        if (this.HotFixDetails != null) {
            var fspec = this.HotFixDetails.AsFieldSpec(conf.Child("hotFixDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "hotFixDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? BuildNumber
        // GraphQL -> buildNumber: String! (scalar)
        if (ec.Includes("buildNumber",true))
        {
            if(this.BuildNumber == null) {

                this.BuildNumber = "FETCH";

            } else {


            }
        }
        else if (this.BuildNumber != null && ec.Excludes("buildNumber",true))
        {
            this.BuildNumber = null;
        }
        //      C# -> System.String? OsName
        // GraphQL -> osName: String! (scalar)
        if (ec.Includes("osName",true))
        {
            if(this.OsName == null) {

                this.OsName = "FETCH";

            } else {


            }
        }
        else if (this.OsName != null && ec.Excludes("osName",true))
        {
            this.OsName = null;
        }
        //      C# -> System.String? Version
        // GraphQL -> version: String! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = "FETCH";

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> List<HotFixDetail>? HotFixDetails
        // GraphQL -> hotFixDetails: [HotFixDetail!]! (type)
        if (ec.Includes("hotFixDetails",false))
        {
            if(this.HotFixDetails == null) {

                this.HotFixDetails = new List<HotFixDetail>();
                this.HotFixDetails.ApplyExploratoryFieldSpec(ec.NewChild("hotFixDetails"));

            } else {

                this.HotFixDetails.ApplyExploratoryFieldSpec(ec.NewChild("hotFixDetails"));

            }
        }
        else if (this.HotFixDetails != null && ec.Excludes("hotFixDetails",false))
        {
            this.HotFixDetails = null;
        }
    }


    #endregion

    } // class OsDetails
    
    #endregion

    public static class ListOsDetailsExtensions
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
            this List<OsDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<OsDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<OsDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OsDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<OsDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types