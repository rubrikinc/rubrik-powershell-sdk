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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (this.ReleaseDate != null) {
            s += ind + "releaseDate\n" ;
        }
        //      C# -> List<ReleaseNote>? BugFixes
        // GraphQL -> bugFixes: [ReleaseNote!]! (type)
        if (this.BugFixes != null) {
            var fspec = this.BugFixes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "bugFixes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ReleaseNote>? NewFeatures
        // GraphQL -> newFeatures: [ReleaseNote!]! (type)
        if (this.NewFeatures != null) {
            var fspec = this.NewFeatures.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newFeatures {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<ReleaseNote>? ProductChanges
        // GraphQL -> productChanges: [ReleaseNote!]! (type)
        if (this.ProductChanges != null) {
            var fspec = this.ProductChanges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "productChanges {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (this.ReleaseDate == null && ec.Includes("releaseDate",true))
        {
            this.ReleaseDate = new DateTime();
        }
        //      C# -> List<ReleaseNote>? BugFixes
        // GraphQL -> bugFixes: [ReleaseNote!]! (type)
        if (this.BugFixes == null && ec.Includes("bugFixes",false))
        {
            this.BugFixes = new List<ReleaseNote>();
            this.BugFixes.ApplyExploratoryFieldSpec(ec.NewChild("bugFixes"));
        }
        //      C# -> List<ReleaseNote>? NewFeatures
        // GraphQL -> newFeatures: [ReleaseNote!]! (type)
        if (this.NewFeatures == null && ec.Includes("newFeatures",false))
        {
            this.NewFeatures = new List<ReleaseNote>();
            this.NewFeatures.ApplyExploratoryFieldSpec(ec.NewChild("newFeatures"));
        }
        //      C# -> List<ReleaseNote>? ProductChanges
        // GraphQL -> productChanges: [ReleaseNote!]! (type)
        if (this.ProductChanges == null && ec.Includes("productChanges",false))
        {
            this.ProductChanges = new List<ReleaseNote>();
            this.ProductChanges.ApplyExploratoryFieldSpec(ec.NewChild("productChanges"));
        }
    }


    #endregion

    } // class GroupedReleaseNote
    
    #endregion

    public static class ListGroupedReleaseNoteExtensions
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
            this List<GroupedReleaseNote> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<GroupedReleaseNote> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types