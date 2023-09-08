// GlobalFileSearchReplyType.cs
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
    #region GlobalFileSearchReplyType
    public class GlobalFileSearchReplyType: BaseType
    {
        #region members

        //      C# -> System.Int32? Total
        // GraphQL -> total: Int! (scalar)
        [JsonProperty("total")]
        public System.Int32? Total { get; set; }

        //      C# -> List<GlobalFileEntry>? Results
        // GraphQL -> results: [GlobalFileEntry!]! (type)
        [JsonProperty("results")]
        public List<GlobalFileEntry>? Results { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GlobalFileSearchReplyType";
    }

    public GlobalFileSearchReplyType Set(
        System.Int32? Total = null,
        List<GlobalFileEntry>? Results = null
    ) 
    {
        if ( Total != null ) {
            this.Total = Total;
        }
        if ( Results != null ) {
            this.Results = Results;
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
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int! (scalar)
        if (this.Total != null) {
            s += ind + "total\n" ;
        }
        //      C# -> List<GlobalFileEntry>? Results
        // GraphQL -> results: [GlobalFileEntry!]! (type)
        if (this.Results != null) {
            var fspec = this.Results.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "results {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Total
        // GraphQL -> total: Int! (scalar)
        if (this.Total == null && ec.Includes("total",true))
        {
            this.Total = Int32.MinValue;
        }
        //      C# -> List<GlobalFileEntry>? Results
        // GraphQL -> results: [GlobalFileEntry!]! (type)
        if (this.Results == null && ec.Includes("results",false))
        {
            this.Results = new List<GlobalFileEntry>();
            this.Results.ApplyExploratoryFieldSpec(ec.NewChild("results"));
        }
    }


    #endregion

    } // class GlobalFileSearchReplyType
    
    #endregion

    public static class ListGlobalFileSearchReplyTypeExtensions
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
            this List<GlobalFileSearchReplyType> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GlobalFileSearchReplyType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GlobalFileSearchReplyType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<GlobalFileSearchReplyType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types