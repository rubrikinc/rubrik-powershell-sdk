// CloudDirectGlobalSearchResult.cs
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
    #region CloudDirectGlobalSearchResult
    public class CloudDirectGlobalSearchResult: BaseType
    {
        #region members

        //      C# -> System.String? NextMarker
        // GraphQL -> nextMarker: String (scalar)
        [JsonProperty("nextMarker")]
        public System.String? NextMarker { get; set; }

        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        [JsonProperty("totalCount")]
        public System.Int32? TotalCount { get; set; }

        //      C# -> List<CloudDirectGlobalSearchEntry>? Entries
        // GraphQL -> entries: [CloudDirectGlobalSearchEntry!]! (type)
        [JsonProperty("entries")]
        public List<CloudDirectGlobalSearchEntry>? Entries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CloudDirectGlobalSearchResult";
    }

    public CloudDirectGlobalSearchResult Set(
        System.String? NextMarker = null,
        System.Int32? TotalCount = null,
        List<CloudDirectGlobalSearchEntry>? Entries = null
    ) 
    {
        if ( NextMarker != null ) {
            this.NextMarker = NextMarker;
        }
        if ( TotalCount != null ) {
            this.TotalCount = TotalCount;
        }
        if ( Entries != null ) {
            this.Entries = Entries;
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
        //      C# -> System.String? NextMarker
        // GraphQL -> nextMarker: String (scalar)
        if (this.NextMarker != null) {
            if (conf.Flat) {
                s += conf.Prefix + "nextMarker\n" ;
            } else {
                s += ind + "nextMarker\n" ;
            }
        }
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (this.TotalCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCount\n" ;
            } else {
                s += ind + "totalCount\n" ;
            }
        }
        //      C# -> List<CloudDirectGlobalSearchEntry>? Entries
        // GraphQL -> entries: [CloudDirectGlobalSearchEntry!]! (type)
        if (this.Entries != null) {
            var fspec = this.Entries.AsFieldSpec(conf.Child("entries"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "entries" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.String? NextMarker
        // GraphQL -> nextMarker: String (scalar)
        if (ec.Includes("nextMarker",true))
        {
            if(this.NextMarker == null) {

                this.NextMarker = "FETCH";

            } else {


            }
        }
        else if (this.NextMarker != null && ec.Excludes("nextMarker",true))
        {
            this.NextMarker = null;
        }
        //      C# -> System.Int32? TotalCount
        // GraphQL -> totalCount: Int! (scalar)
        if (ec.Includes("totalCount",true))
        {
            if(this.TotalCount == null) {

                this.TotalCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalCount != null && ec.Excludes("totalCount",true))
        {
            this.TotalCount = null;
        }
        //      C# -> List<CloudDirectGlobalSearchEntry>? Entries
        // GraphQL -> entries: [CloudDirectGlobalSearchEntry!]! (type)
        if (ec.Includes("entries",false))
        {
            if(this.Entries == null) {

                this.Entries = new List<CloudDirectGlobalSearchEntry>();
                this.Entries.ApplyExploratoryFieldSpec(ec.NewChild("entries"));

            } else {

                this.Entries.ApplyExploratoryFieldSpec(ec.NewChild("entries"));

            }
        }
        else if (this.Entries != null && ec.Excludes("entries",false))
        {
            this.Entries = null;
        }
    }


    #endregion

    } // class CloudDirectGlobalSearchResult
    
    #endregion

    public static class ListCloudDirectGlobalSearchResultExtensions
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
            this List<CloudDirectGlobalSearchResult> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CloudDirectGlobalSearchResult> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CloudDirectGlobalSearchResult> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CloudDirectGlobalSearchResult());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CloudDirectGlobalSearchResult> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types