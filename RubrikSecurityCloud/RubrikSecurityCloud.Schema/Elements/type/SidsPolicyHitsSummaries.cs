// SidsPolicyHitsSummaries.cs
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
    #region SidsPolicyHitsSummaries
    public class SidsPolicyHitsSummaries: BaseType
    {
        #region members

        //      C# -> List<SidPolicyHitsSummary>? SidSummaries
        // GraphQL -> sidSummaries: [SidPolicyHitsSummary!]! (type)
        [JsonProperty("sidSummaries")]
        public List<SidPolicyHitsSummary>? SidSummaries { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SidsPolicyHitsSummaries";
    }

    public SidsPolicyHitsSummaries Set(
        List<SidPolicyHitsSummary>? SidSummaries = null
    ) 
    {
        if ( SidSummaries != null ) {
            this.SidSummaries = SidSummaries;
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
        //      C# -> List<SidPolicyHitsSummary>? SidSummaries
        // GraphQL -> sidSummaries: [SidPolicyHitsSummary!]! (type)
        if (this.SidSummaries != null) {
            var fspec = this.SidSummaries.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sidSummaries {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SidPolicyHitsSummary>? SidSummaries
        // GraphQL -> sidSummaries: [SidPolicyHitsSummary!]! (type)
        if (this.SidSummaries == null && ec.Includes("sidSummaries",false))
        {
            this.SidSummaries = new List<SidPolicyHitsSummary>();
            this.SidSummaries.ApplyExploratoryFieldSpec(ec.NewChild("sidSummaries"));
        }
    }


    #endregion

    } // class SidsPolicyHitsSummaries
    
    #endregion

    public static class ListSidsPolicyHitsSummariesExtensions
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
            this List<SidsPolicyHitsSummaries> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<SidsPolicyHitsSummaries> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SidsPolicyHitsSummaries());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<SidsPolicyHitsSummaries> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types