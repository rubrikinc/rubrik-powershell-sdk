// DhrcScore.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region DhrcScore
    public class DhrcScore: IFragment
    {
        #region members
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

        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        [JsonProperty("category")]
        public DhrcCategory? Category { get; set; }

        #endregion

    #region methods

    public DhrcScore Set(
        DateTime? CalculatedAt = null,
        DateTime? Date = null,
        DateTime? EarliestMetric = null,
        System.Single? Value = null,
        DhrcScoreContext? Context = null,
        DhrcCategory? Category = null
    ) 
    {
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
        if ( Category != null ) {
            this.Category = Category;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> DateTime? CalculatedAt
            // GraphQL -> calculatedAt: DateTime (scalar)
            if (this.CalculatedAt != null)
            {
                 s += ind + "calculatedAt\n";

            }
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date != null)
            {
                 s += ind + "date\n";

            }
            //      C# -> DateTime? EarliestMetric
            // GraphQL -> earliestMetric: DateTime (scalar)
            if (this.EarliestMetric != null)
            {
                 s += ind + "earliestMetric\n";

            }
            //      C# -> System.Single? Value
            // GraphQL -> value: Float! (scalar)
            if (this.Value != null)
            {
                 s += ind + "value\n";

            }
            //      C# -> DhrcScoreContext? Context
            // GraphQL -> context: DhrcScoreContext (type)
            if (this.Context != null)
            {
                 s += ind + "context\n";

                 s += ind + "{\n" + 
                 this.Context.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> DhrcCategory? Category
            // GraphQL -> category: DhrcCategory! (enum)
            if (this.Category != null)
            {
                 s += ind + "category\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? CalculatedAt
            // GraphQL -> calculatedAt: DateTime (scalar)
            if (this.CalculatedAt == null && Exploration.Includes(parent + ".calculatedAt$"))
            {
                this.CalculatedAt = new DateTime();
            }
            //      C# -> DateTime? Date
            // GraphQL -> date: DateTime (scalar)
            if (this.Date == null && Exploration.Includes(parent + ".date$"))
            {
                this.Date = new DateTime();
            }
            //      C# -> DateTime? EarliestMetric
            // GraphQL -> earliestMetric: DateTime (scalar)
            if (this.EarliestMetric == null && Exploration.Includes(parent + ".earliestMetric$"))
            {
                this.EarliestMetric = new DateTime();
            }
            //      C# -> System.Single? Value
            // GraphQL -> value: Float! (scalar)
            if (this.Value == null && Exploration.Includes(parent + ".value$"))
            {
                this.Value = new System.Single();
            }
            //      C# -> DhrcScoreContext? Context
            // GraphQL -> context: DhrcScoreContext (type)
            if (this.Context == null && Exploration.Includes(parent + ".context"))
            {
                this.Context = new DhrcScoreContext();
                this.Context.ApplyExploratoryFragment(parent + ".context");
            }
            //      C# -> DhrcCategory? Category
            // GraphQL -> category: DhrcCategory! (enum)
            if (this.Category == null && Exploration.Includes(parent + ".category$"))
            {
                this.Category = new DhrcCategory();
            }
        }


    #endregion

    } // class DhrcScore
    #endregion

    public static class ListDhrcScoreExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<DhrcScore> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DhrcScore> list, 
            String parent = "")
        {
            var item = new DhrcScore();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types