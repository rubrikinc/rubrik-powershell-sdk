// DhrcScore.cs
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
    #region DhrcScore
    public class DhrcScore: BaseType
    {
        #region members

        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        [JsonProperty("category")]
        public DhrcCategory? Category { get; set; }

        //      C# -> DateTime? CalculatedAt
        // GraphQL -> calculatedAt: DateTime (scalar)
        [JsonProperty("calculatedAt")]
        public DateTime? CalculatedAt { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        [JsonProperty("earliestMetric")]
        public DateTime? EarliestMetric { get; set; }

        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        [JsonProperty("value")]
        public System.Single? Value { get; set; }

        //      C# -> DhrcScoreContext? Context
        // GraphQL -> context: DhrcScoreContext (type)
        [JsonProperty("context")]
        public DhrcScoreContext? Context { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DhrcScore";
    }

    public DhrcScore Set(
        DhrcCategory? Category = null,
        DateTime? CalculatedAt = null,
        DateTime? Date = null,
        DateTime? EarliestMetric = null,
        System.Single? Value = null,
        DhrcScoreContext? Context = null
    ) 
    {
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( CalculatedAt != null ) {
            this.CalculatedAt = CalculatedAt;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( EarliestMetric != null ) {
            this.EarliestMetric = EarliestMetric;
        }
        if ( Value != null ) {
            this.Value = Value;
        }
        if ( Context != null ) {
            this.Context = Context;
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
        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        if (this.Category != null) {
            s += ind + "category\n" ;
        }
        //      C# -> DateTime? CalculatedAt
        // GraphQL -> calculatedAt: DateTime (scalar)
        if (this.CalculatedAt != null) {
            s += ind + "calculatedAt\n" ;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            s += ind + "date\n" ;
        }
        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        if (this.EarliestMetric != null) {
            s += ind + "earliestMetric\n" ;
        }
        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        if (this.Value != null) {
            s += ind + "value\n" ;
        }
        //      C# -> DhrcScoreContext? Context
        // GraphQL -> context: DhrcScoreContext (type)
        if (this.Context != null) {
            var fspec = this.Context.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "context {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        if (this.Category == null && Exploration.Includes(parent + ".category", true))
        {
            this.Category = new DhrcCategory();
        }
        //      C# -> DateTime? CalculatedAt
        // GraphQL -> calculatedAt: DateTime (scalar)
        if (this.CalculatedAt == null && Exploration.Includes(parent + ".calculatedAt", true))
        {
            this.CalculatedAt = new DateTime();
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date == null && Exploration.Includes(parent + ".date", true))
        {
            this.Date = new DateTime();
        }
        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        if (this.EarliestMetric == null && Exploration.Includes(parent + ".earliestMetric", true))
        {
            this.EarliestMetric = new DateTime();
        }
        //      C# -> System.Single? Value
        // GraphQL -> value: Float! (scalar)
        if (this.Value == null && Exploration.Includes(parent + ".value", true))
        {
            this.Value = new System.Single();
        }
        //      C# -> DhrcScoreContext? Context
        // GraphQL -> context: DhrcScoreContext (type)
        if (this.Context == null && Exploration.Includes(parent + ".context"))
        {
            this.Context = new DhrcScoreContext();
            this.Context.ApplyExploratoryFieldSpec(parent + ".context");
        }
    }


    #endregion

    } // class DhrcScore
    
    #endregion

    public static class ListDhrcScoreExtensions
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
            this List<DhrcScore> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DhrcScore> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcScore());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types