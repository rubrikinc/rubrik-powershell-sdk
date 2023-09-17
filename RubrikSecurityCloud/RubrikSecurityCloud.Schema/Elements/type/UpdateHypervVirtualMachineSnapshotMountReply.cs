// UpdateHypervVirtualMachineSnapshotMountReply.cs
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
    #region UpdateHypervVirtualMachineSnapshotMountReply
    public class UpdateHypervVirtualMachineSnapshotMountReply: BaseType
    {
        #region members

        //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
        // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
        [JsonProperty("hypervVirtualMachineMountSummary")]
        public HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UpdateHypervVirtualMachineSnapshotMountReply";
    }

    public UpdateHypervVirtualMachineSnapshotMountReply Set(
        HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary = null
    ) 
    {
        if ( HypervVirtualMachineMountSummary != null ) {
            this.HypervVirtualMachineMountSummary = HypervVirtualMachineMountSummary;
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
        //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
        // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
        if (this.HypervVirtualMachineMountSummary != null) {
            var fspec = this.HypervVirtualMachineMountSummary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "hypervVirtualMachineMountSummary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> HypervVirtualMachineMountSummary? HypervVirtualMachineMountSummary
        // GraphQL -> hypervVirtualMachineMountSummary: HypervVirtualMachineMountSummary (type)
        if (this.HypervVirtualMachineMountSummary == null && ec.Includes("hypervVirtualMachineMountSummary",false))
        {
            this.HypervVirtualMachineMountSummary = new HypervVirtualMachineMountSummary();
            this.HypervVirtualMachineMountSummary.ApplyExploratoryFieldSpec(ec.NewChild("hypervVirtualMachineMountSummary"));
        }
    }


    #endregion

    } // class UpdateHypervVirtualMachineSnapshotMountReply
    
    #endregion

    public static class ListUpdateHypervVirtualMachineSnapshotMountReplyExtensions
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
            this List<UpdateHypervVirtualMachineSnapshotMountReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<UpdateHypervVirtualMachineSnapshotMountReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UpdateHypervVirtualMachineSnapshotMountReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UpdateHypervVirtualMachineSnapshotMountReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types