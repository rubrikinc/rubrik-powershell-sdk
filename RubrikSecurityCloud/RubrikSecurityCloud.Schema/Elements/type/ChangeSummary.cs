// ChangeSummary.cs
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
    #region ChangeSummary
    public class ChangeSummary: BaseType
    {
        #region members

        //      C# -> List<DailyChangeSummary>? PerDayChangeSummary
        // GraphQL -> perDayChangeSummary: [DailyChangeSummary!]! (type)
        [JsonProperty("perDayChangeSummary")]
        public List<DailyChangeSummary>? PerDayChangeSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ChangeSummary";
    }

    public ChangeSummary Set(
        List<DailyChangeSummary>? PerDayChangeSummary = null
    ) 
    {
        if ( PerDayChangeSummary != null ) {
            this.PerDayChangeSummary = PerDayChangeSummary;
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
        //      C# -> List<DailyChangeSummary>? PerDayChangeSummary
        // GraphQL -> perDayChangeSummary: [DailyChangeSummary!]! (type)
        if (this.PerDayChangeSummary != null) {
            var fspec = this.PerDayChangeSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "perDayChangeSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<DailyChangeSummary>? PerDayChangeSummary
        // GraphQL -> perDayChangeSummary: [DailyChangeSummary!]! (type)
        if (this.PerDayChangeSummary == null && Exploration.Includes(parent + ".perDayChangeSummary"))
        {
            this.PerDayChangeSummary = new List<DailyChangeSummary>();
            this.PerDayChangeSummary.ApplyExploratoryFieldSpec(parent + ".perDayChangeSummary");
        }
    }


    #endregion

    } // class ChangeSummary
    
    #endregion

    public static class ListChangeSummaryExtensions
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
            this List<ChangeSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ChangeSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ChangeSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types