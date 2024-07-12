// ActiveDirectorySnappableSearchResponse.cs
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
    #region ActiveDirectorySnappableSearchResponse
    public class ActiveDirectorySnappableSearchResponse: BaseType
    {
        #region members

        //      C# -> ActiveDirectoryObjectType? ObjectType
        // GraphQL -> objectType: ActiveDirectoryObjectType! (enum)
        [JsonProperty("objectType")]
        public ActiveDirectoryObjectType? ObjectType { get; set; }

        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        [JsonProperty("dnt")]
        public System.Int32? Dnt { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<ActiveDirectorySearchVersions>? Versions
        // GraphQL -> versions: [ActiveDirectorySearchVersions!]! (type)
        [JsonProperty("versions")]
        public List<ActiveDirectorySearchVersions>? Versions { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ActiveDirectorySnappableSearchResponse";
    }

    public ActiveDirectorySnappableSearchResponse Set(
        ActiveDirectoryObjectType? ObjectType = null,
        System.Int32? Dnt = null,
        System.String? Name = null,
        List<ActiveDirectorySearchVersions>? Versions = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Dnt != null ) {
            this.Dnt = Dnt;
        }
        if ( Name != null ) {
            this.Name = Name;
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
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ActiveDirectoryObjectType? ObjectType
        // GraphQL -> objectType: ActiveDirectoryObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        if (this.Dnt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dnt\n" ;
            } else {
                s += ind + "dnt\n" ;
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
        //      C# -> List<ActiveDirectorySearchVersions>? Versions
        // GraphQL -> versions: [ActiveDirectorySearchVersions!]! (type)
        if (this.Versions != null) {
            var fspec = this.Versions.AsFieldSpec(conf.Child("versions"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "versions" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ActiveDirectoryObjectType? ObjectType
        // GraphQL -> objectType: ActiveDirectoryObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ActiveDirectoryObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.Int32? Dnt
        // GraphQL -> dnt: Int! (scalar)
        if (ec.Includes("dnt",true))
        {
            if(this.Dnt == null) {

                this.Dnt = Int32.MinValue;

            } else {


            }
        }
        else if (this.Dnt != null && ec.Excludes("dnt",true))
        {
            this.Dnt = null;
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
        //      C# -> List<ActiveDirectorySearchVersions>? Versions
        // GraphQL -> versions: [ActiveDirectorySearchVersions!]! (type)
        if (ec.Includes("versions",false))
        {
            if(this.Versions == null) {

                this.Versions = new List<ActiveDirectorySearchVersions>();
                this.Versions.ApplyExploratoryFieldSpec(ec.NewChild("versions"));

            } else {

                this.Versions.ApplyExploratoryFieldSpec(ec.NewChild("versions"));

            }
        }
        else if (this.Versions != null && ec.Excludes("versions",false))
        {
            this.Versions = null;
        }
    }


    #endregion

    } // class ActiveDirectorySnappableSearchResponse
    
    #endregion

    public static class ListActiveDirectorySnappableSearchResponseExtensions
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
            this List<ActiveDirectorySnappableSearchResponse> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ActiveDirectorySnappableSearchResponse> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ActiveDirectorySnappableSearchResponse> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ActiveDirectorySnappableSearchResponse());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ActiveDirectorySnappableSearchResponse> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types