// TprRequestedChangeSlaDomainSummaryEntry.cs
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
    #region TprRequestedChangeSlaDomainSummaryEntry
    public class TprRequestedChangeSlaDomainSummaryEntry: BaseType
    {
        #region members

        //      C# -> List<SlaDomainSummary>? NewValue
        // GraphQL -> newValue: [SlaDomainSummary!]! (type)
        [JsonProperty("newValue")]
        public List<SlaDomainSummary>? NewValue { get; set; }

        //      C# -> List<SlaDomainSummary>? OldValue
        // GraphQL -> oldValue: [SlaDomainSummary!]! (type)
        [JsonProperty("oldValue")]
        public List<SlaDomainSummary>? OldValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "TprRequestedChangeSlaDomainSummaryEntry";
    }

    public TprRequestedChangeSlaDomainSummaryEntry Set(
        List<SlaDomainSummary>? NewValue = null,
        List<SlaDomainSummary>? OldValue = null
    ) 
    {
        if ( NewValue != null ) {
            this.NewValue = NewValue;
        }
        if ( OldValue != null ) {
            this.OldValue = OldValue;
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
        //      C# -> List<SlaDomainSummary>? NewValue
        // GraphQL -> newValue: [SlaDomainSummary!]! (type)
        if (this.NewValue != null) {
            var fspec = this.NewValue.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "newValue {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<SlaDomainSummary>? OldValue
        // GraphQL -> oldValue: [SlaDomainSummary!]! (type)
        if (this.OldValue != null) {
            var fspec = this.OldValue.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "oldValue {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SlaDomainSummary>? NewValue
        // GraphQL -> newValue: [SlaDomainSummary!]! (type)
        if (this.NewValue == null && ec.Includes("newValue",false))
        {
            this.NewValue = new List<SlaDomainSummary>();
            this.NewValue.ApplyExploratoryFieldSpec(ec.NewChild("newValue"));
        }
        //      C# -> List<SlaDomainSummary>? OldValue
        // GraphQL -> oldValue: [SlaDomainSummary!]! (type)
        if (this.OldValue == null && ec.Includes("oldValue",false))
        {
            this.OldValue = new List<SlaDomainSummary>();
            this.OldValue.ApplyExploratoryFieldSpec(ec.NewChild("oldValue"));
        }
    }


    #endregion

    } // class TprRequestedChangeSlaDomainSummaryEntry
    
    #endregion

    public static class ListTprRequestedChangeSlaDomainSummaryEntryExtensions
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
            this List<TprRequestedChangeSlaDomainSummaryEntry> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<TprRequestedChangeSlaDomainSummaryEntry> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new TprRequestedChangeSlaDomainSummaryEntry());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<TprRequestedChangeSlaDomainSummaryEntry> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types