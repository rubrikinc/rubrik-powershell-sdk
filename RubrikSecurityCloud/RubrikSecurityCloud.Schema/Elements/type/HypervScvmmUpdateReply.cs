// HypervScvmmUpdateReply.cs
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
    #region HypervScvmmUpdateReply
    public class HypervScvmmUpdateReply: BaseType
    {
        #region members

        //      C# -> HypervScvmmSummary? HypervScvmmSummary
        // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
        [JsonProperty("hypervScvmmSummary")]
        public HypervScvmmSummary? HypervScvmmSummary { get; set; }

        //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
        [JsonProperty("hypervScvmmUpdate")]
        public HypervScvmmUpdate? HypervScvmmUpdate { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "HypervScvmmUpdateReply";
    }

    public HypervScvmmUpdateReply Set(
        HypervScvmmSummary? HypervScvmmSummary = null,
        HypervScvmmUpdate? HypervScvmmUpdate = null
    ) 
    {
        if ( HypervScvmmSummary != null ) {
            this.HypervScvmmSummary = HypervScvmmSummary;
        }
        if ( HypervScvmmUpdate != null ) {
            this.HypervScvmmUpdate = HypervScvmmUpdate;
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
        //      C# -> HypervScvmmSummary? HypervScvmmSummary
        // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
        if (this.HypervScvmmSummary != null) {
            var fspec = this.HypervScvmmSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hypervScvmmSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
        if (this.HypervScvmmUpdate != null) {
            var fspec = this.HypervScvmmUpdate.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hypervScvmmUpdate {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HypervScvmmSummary? HypervScvmmSummary
        // GraphQL -> hypervScvmmSummary: HypervScvmmSummary (type)
        if (this.HypervScvmmSummary == null && ec.Includes("hypervScvmmSummary",false))
        {
            this.HypervScvmmSummary = new HypervScvmmSummary();
            this.HypervScvmmSummary.ApplyExploratoryFieldSpec(ec.NewChild("hypervScvmmSummary"));
        }
        //      C# -> HypervScvmmUpdate? HypervScvmmUpdate
        // GraphQL -> hypervScvmmUpdate: HypervScvmmUpdate (type)
        if (this.HypervScvmmUpdate == null && ec.Includes("hypervScvmmUpdate",false))
        {
            this.HypervScvmmUpdate = new HypervScvmmUpdate();
            this.HypervScvmmUpdate.ApplyExploratoryFieldSpec(ec.NewChild("hypervScvmmUpdate"));
        }
    }


    #endregion

    } // class HypervScvmmUpdateReply
    
    #endregion

    public static class ListHypervScvmmUpdateReplyExtensions
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
            this List<HypervScvmmUpdateReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HypervScvmmUpdateReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new HypervScvmmUpdateReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<HypervScvmmUpdateReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types