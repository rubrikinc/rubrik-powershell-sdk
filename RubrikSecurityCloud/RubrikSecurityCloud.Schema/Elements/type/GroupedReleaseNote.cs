// GroupedReleaseNote.cs
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
    #region GroupedReleaseNote
    public class GroupedReleaseNote: BaseType
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        [JsonProperty("releaseDate")]
        public DateTime? ReleaseDate { get; set; }

        //      C# -> List<ReleaseNote>? BugFixes
        // GraphQL -> bugFixes: [ReleaseNote!]! (type)
        [JsonProperty("bugFixes")]
        public List<ReleaseNote>? BugFixes { get; set; }

        //      C# -> List<ReleaseNote>? NewFeatures
        // GraphQL -> newFeatures: [ReleaseNote!]! (type)
        [JsonProperty("newFeatures")]
        public List<ReleaseNote>? NewFeatures { get; set; }

        //      C# -> List<ReleaseNote>? ProductChanges
        // GraphQL -> productChanges: [ReleaseNote!]! (type)
        [JsonProperty("productChanges")]
        public List<ReleaseNote>? ProductChanges { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GroupedReleaseNote";
    }

    public GroupedReleaseNote Set(
        System.String? Id = null,
        DateTime? ReleaseDate = null,
        List<ReleaseNote>? BugFixes = null,
        List<ReleaseNote>? NewFeatures = null,
        List<ReleaseNote>? ProductChanges = null
    ) 
    {
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( ReleaseDate != null ) {
            this.ReleaseDate = ReleaseDate;
        }
        if ( BugFixes != null ) {
            this.BugFixes = BugFixes;
        }
        if ( NewFeatures != null ) {
            this.NewFeatures = NewFeatures;
        }
        if ( ProductChanges != null ) {
            this.ProductChanges = ProductChanges;
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
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (this.ReleaseDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "releaseDate\n" ;
            } else {
                s += ind + "releaseDate\n" ;
            }
        }
        //      C# -> List<ReleaseNote>? BugFixes
        // GraphQL -> bugFixes: [ReleaseNote!]! (type)
        if (this.BugFixes != null) {
            var fspec = this.BugFixes.AsFieldSpec(conf.Child("bugFixes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "bugFixes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReleaseNote>? NewFeatures
        // GraphQL -> newFeatures: [ReleaseNote!]! (type)
        if (this.NewFeatures != null) {
            var fspec = this.NewFeatures.AsFieldSpec(conf.Child("newFeatures"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "newFeatures" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReleaseNote>? ProductChanges
        // GraphQL -> productChanges: [ReleaseNote!]! (type)
        if (this.ProductChanges != null) {
            var fspec = this.ProductChanges.AsFieldSpec(conf.Child("productChanges"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "productChanges" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
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
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (ec.Includes("releaseDate",true))
        {
            if(this.ReleaseDate == null) {

                this.ReleaseDate = new DateTime();

            } else {


            }
        }
        else if (this.ReleaseDate != null && ec.Excludes("releaseDate",true))
        {
            this.ReleaseDate = null;
        }
        //      C# -> List<ReleaseNote>? BugFixes
        // GraphQL -> bugFixes: [ReleaseNote!]! (type)
        if (ec.Includes("bugFixes",false))
        {
            if(this.BugFixes == null) {

                this.BugFixes = new List<ReleaseNote>();
                this.BugFixes.ApplyExploratoryFieldSpec(ec.NewChild("bugFixes"));

            } else {

                this.BugFixes.ApplyExploratoryFieldSpec(ec.NewChild("bugFixes"));

            }
        }
        else if (this.BugFixes != null && ec.Excludes("bugFixes",false))
        {
            this.BugFixes = null;
        }
        //      C# -> List<ReleaseNote>? NewFeatures
        // GraphQL -> newFeatures: [ReleaseNote!]! (type)
        if (ec.Includes("newFeatures",false))
        {
            if(this.NewFeatures == null) {

                this.NewFeatures = new List<ReleaseNote>();
                this.NewFeatures.ApplyExploratoryFieldSpec(ec.NewChild("newFeatures"));

            } else {

                this.NewFeatures.ApplyExploratoryFieldSpec(ec.NewChild("newFeatures"));

            }
        }
        else if (this.NewFeatures != null && ec.Excludes("newFeatures",false))
        {
            this.NewFeatures = null;
        }
        //      C# -> List<ReleaseNote>? ProductChanges
        // GraphQL -> productChanges: [ReleaseNote!]! (type)
        if (ec.Includes("productChanges",false))
        {
            if(this.ProductChanges == null) {

                this.ProductChanges = new List<ReleaseNote>();
                this.ProductChanges.ApplyExploratoryFieldSpec(ec.NewChild("productChanges"));

            } else {

                this.ProductChanges.ApplyExploratoryFieldSpec(ec.NewChild("productChanges"));

            }
        }
        else if (this.ProductChanges != null && ec.Excludes("productChanges",false))
        {
            this.ProductChanges = null;
        }
    }


    #endregion

    } // class GroupedReleaseNote
    
    #endregion

    public static class ListGroupedReleaseNoteExtensions
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
            this List<GroupedReleaseNote> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<GroupedReleaseNote> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GroupedReleaseNote> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GroupedReleaseNote());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GroupedReleaseNote> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types