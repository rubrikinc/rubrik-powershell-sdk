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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "bugFixes {\n" + this.BugFixes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ReleaseNote>? NewFeatures
        // GraphQL -> newFeatures: [ReleaseNote!]! (type)
        if (this.NewFeatures != null) {
            s += ind + "newFeatures {\n" + this.NewFeatures.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ReleaseNote>? ProductChanges
        // GraphQL -> productChanges: [ReleaseNote!]! (type)
        if (this.ProductChanges != null) {
            s += ind + "productChanges {\n" + this.ProductChanges.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> DateTime? ReleaseDate
        // GraphQL -> releaseDate: DateTime (scalar)
        if (this.ReleaseDate == null && Exploration.Includes(parent + ".releaseDate", true))
        {
            this.ReleaseDate = new DateTime();
        }
        //      C# -> List<ReleaseNote>? BugFixes
        // GraphQL -> bugFixes: [ReleaseNote!]! (type)
        if (this.BugFixes == null && Exploration.Includes(parent + ".bugFixes"))
        {
            this.BugFixes = new List<ReleaseNote>();
            this.BugFixes.ApplyExploratoryFieldSpec(parent + ".bugFixes");
        }
        //      C# -> List<ReleaseNote>? NewFeatures
        // GraphQL -> newFeatures: [ReleaseNote!]! (type)
        if (this.NewFeatures == null && Exploration.Includes(parent + ".newFeatures"))
        {
            this.NewFeatures = new List<ReleaseNote>();
            this.NewFeatures.ApplyExploratoryFieldSpec(parent + ".newFeatures");
        }
        //      C# -> List<ReleaseNote>? ProductChanges
        // GraphQL -> productChanges: [ReleaseNote!]! (type)
        if (this.ProductChanges == null && Exploration.Includes(parent + ".productChanges"))
        {
            this.ProductChanges = new List<ReleaseNote>();
            this.ProductChanges.ApplyExploratoryFieldSpec(parent + ".productChanges");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GroupedReleaseNote> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GroupedReleaseNote());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types