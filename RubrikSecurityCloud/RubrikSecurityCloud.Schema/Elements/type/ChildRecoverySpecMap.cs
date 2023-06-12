// ChildRecoverySpecMap.cs
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
    #region ChildRecoverySpecMap
    public class ChildRecoverySpecMap: BaseType
    {
        #region members

        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        [JsonProperty("recoverySpec")]
        public RecoverySpec? RecoverySpec { get; set; }

        //      C# -> SlaDomain? Sla
        // GraphQL -> sla: SlaDomain (interface)
        [JsonProperty("sla")]
        public SlaDomain? Sla { get; set; }

        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long (scalar)
        [JsonProperty("recoveryPoint")]
        public System.Int64? RecoveryPoint { get; set; }

        //      C# -> System.String? RecoverySpecFid
        // GraphQL -> recoverySpecFid: String! (scalar)
        [JsonProperty("recoverySpecFid")]
        public System.String? RecoverySpecFid { get; set; }

        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        [JsonProperty("slaId")]
        public System.String? SlaId { get; set; }

        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        [JsonProperty("snappableFid")]
        public System.String? SnappableFid { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }


        #endregion

    #region methods

    public ChildRecoverySpecMap Set(
        RecoverySpec? RecoverySpec = null,
        SlaDomain? Sla = null,
        System.Int64? RecoveryPoint = null,
        System.String? RecoverySpecFid = null,
        System.String? SlaId = null,
        System.String? SnappableFid = null,
        System.String? SnapshotId = null
    ) 
    {
        if ( RecoverySpec != null ) {
            this.RecoverySpec = RecoverySpec;
        }
        if ( Sla != null ) {
            this.Sla = Sla;
        }
        if ( RecoveryPoint != null ) {
            this.RecoveryPoint = RecoveryPoint;
        }
        if ( RecoverySpecFid != null ) {
            this.RecoverySpecFid = RecoverySpecFid;
        }
        if ( SlaId != null ) {
            this.SlaId = SlaId;
        }
        if ( SnappableFid != null ) {
            this.SnappableFid = SnappableFid;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
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
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        if (this.RecoverySpec != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.RecoverySpec).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoverySpec {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> SlaDomain? Sla
        // GraphQL -> sla: SlaDomain (interface)
        if (this.Sla != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.Sla).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sla {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long (scalar)
        if (this.RecoveryPoint != null) {
            s += ind + "recoveryPoint\n" ;
        }
        //      C# -> System.String? RecoverySpecFid
        // GraphQL -> recoverySpecFid: String! (scalar)
        if (this.RecoverySpecFid != null) {
            s += ind + "recoverySpecFid\n" ;
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        if (this.SlaId != null) {
            s += ind + "slaId\n" ;
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (this.SnappableFid != null) {
            s += ind + "snappableFid\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec! (interface)
        if (this.RecoverySpec == null && Exploration.Includes(parent + ".recoverySpec"))
        {
            var impls = new List<RecoverySpec>();
            impls.ApplyExploratoryFieldSpec(parent + ".recoverySpec");
            this.RecoverySpec = (RecoverySpec)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? Sla
        // GraphQL -> sla: SlaDomain (interface)
        if (this.Sla == null && Exploration.Includes(parent + ".sla"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".sla");
            this.Sla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Int64? RecoveryPoint
        // GraphQL -> recoveryPoint: Long (scalar)
        if (this.RecoveryPoint == null && Exploration.Includes(parent + ".recoveryPoint", true))
        {
            this.RecoveryPoint = new System.Int64();
        }
        //      C# -> System.String? RecoverySpecFid
        // GraphQL -> recoverySpecFid: String! (scalar)
        if (this.RecoverySpecFid == null && Exploration.Includes(parent + ".recoverySpecFid", true))
        {
            this.RecoverySpecFid = "FETCH";
        }
        //      C# -> System.String? SlaId
        // GraphQL -> slaId: String (scalar)
        if (this.SlaId == null && Exploration.Includes(parent + ".slaId", true))
        {
            this.SlaId = "FETCH";
        }
        //      C# -> System.String? SnappableFid
        // GraphQL -> snappableFid: String! (scalar)
        if (this.SnappableFid == null && Exploration.Includes(parent + ".snappableFid", true))
        {
            this.SnappableFid = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
    }


    #endregion

    } // class ChildRecoverySpecMap
    
    #endregion

    public static class ListChildRecoverySpecMapExtensions
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
            this List<ChildRecoverySpecMap> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ChildRecoverySpecMap> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ChildRecoverySpecMap());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types