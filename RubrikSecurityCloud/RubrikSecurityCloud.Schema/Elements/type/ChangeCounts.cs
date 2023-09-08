// ChangeCounts.cs
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
    #region ChangeCounts
    public class ChangeCounts: BaseType
    {
        #region members

        //      C# -> System.Int32? Added
        // GraphQL -> added: Int! (scalar)
        [JsonProperty("added")]
        public System.Int32? Added { get; set; }

        //      C# -> System.Int32? Deleted
        // GraphQL -> deleted: Int! (scalar)
        [JsonProperty("deleted")]
        public System.Int32? Deleted { get; set; }

        //      C# -> System.Int32? Modified
        // GraphQL -> modified: Int! (scalar)
        [JsonProperty("modified")]
        public System.Int32? Modified { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChangeCounts";
    }

    public ChangeCounts Set(
        System.Int32? Added = null,
        System.Int32? Deleted = null,
        System.Int32? Modified = null
    ) 
    {
        if ( Added != null ) {
            this.Added = Added;
        }
        if ( Deleted != null ) {
            this.Deleted = Deleted;
        }
        if ( Modified != null ) {
            this.Modified = Modified;
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
        //      C# -> System.Int32? Added
        // GraphQL -> added: Int! (scalar)
        if (this.Added != null) {
            s += ind + "added\n" ;
        }
        //      C# -> System.Int32? Deleted
        // GraphQL -> deleted: Int! (scalar)
        if (this.Deleted != null) {
            s += ind + "deleted\n" ;
        }
        //      C# -> System.Int32? Modified
        // GraphQL -> modified: Int! (scalar)
        if (this.Modified != null) {
            s += ind + "modified\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Added
        // GraphQL -> added: Int! (scalar)
        if (this.Added == null && ec.Includes("added",true))
        {
            this.Added = Int32.MinValue;
        }
        //      C# -> System.Int32? Deleted
        // GraphQL -> deleted: Int! (scalar)
        if (this.Deleted == null && ec.Includes("deleted",true))
        {
            this.Deleted = Int32.MinValue;
        }
        //      C# -> System.Int32? Modified
        // GraphQL -> modified: Int! (scalar)
        if (this.Modified == null && ec.Includes("modified",true))
        {
            this.Modified = Int32.MinValue;
        }
    }


    #endregion

    } // class ChangeCounts
    
    #endregion

    public static class ListChangeCountsExtensions
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
            this List<ChangeCounts> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ChangeCounts> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ChangeCounts());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<ChangeCounts> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types