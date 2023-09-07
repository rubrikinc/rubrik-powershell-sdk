// VsphereVmChild.cs
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
    #region VsphereVmChild
 
    public class VsphereVmChild: BaseType, BlueprintChild
    {
        #region members

        //      C# -> ObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: ObjectTypeEnum! (enum)
        [JsonProperty("snappableType")]
        public ObjectTypeEnum? SnappableType { get; set; }

        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec (interface)
        [JsonProperty("recoverySpec")]
        public RecoverySpec? RecoverySpec { get; set; }

        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        [JsonProperty("bootPriority")]
        public System.Int32? BootPriority { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Int64? LastRecoveryPoint
        // GraphQL -> lastRecoveryPoint: Long (scalar)
        [JsonProperty("lastRecoveryPoint")]
        public System.Int64? LastRecoveryPoint { get; set; }

        //      C# -> VsphereBlueprintChildFailoverInstance? FailoverInstance
        // GraphQL -> failoverInstance: VsphereBlueprintChildFailoverInstance (type)
        [JsonProperty("failoverInstance")]
        public VsphereBlueprintChildFailoverInstance? FailoverInstance { get; set; }

        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("localRpoLagInfo")]
        public RpoLagInfo? LocalRpoLagInfo { get; set; }

        //      C# -> ChildVmRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: ChildVmRecoveryInfo (type)
        [JsonProperty("recoveryInfo")]
        public ChildVmRecoveryInfo? RecoveryInfo { get; set; }

        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        [JsonProperty("remoteRpoLagInfo")]
        public RpoLagInfo? RemoteRpoLagInfo { get; set; }

        //      C# -> VmwareResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: VmwareResourceSpec (type)
        [JsonProperty("resourceSpec")]
        public VmwareResourceSpec? ResourceSpec { get; set; }

        //      C# -> VsphereVm? Snappable
        // GraphQL -> snappable: VsphereVm (type)
        [JsonProperty("snappable")]
        public VsphereVm? Snappable { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "VSphereVmChild";
    }

    public VsphereVmChild Set(
        ObjectTypeEnum? SnappableType = null,
        RecoverySpec? RecoverySpec = null,
        System.Int32? BootPriority = null,
        System.String? Fid = null,
        System.Int64? LastRecoveryPoint = null,
        VsphereBlueprintChildFailoverInstance? FailoverInstance = null,
        RpoLagInfo? LocalRpoLagInfo = null,
        ChildVmRecoveryInfo? RecoveryInfo = null,
        RpoLagInfo? RemoteRpoLagInfo = null,
        VmwareResourceSpec? ResourceSpec = null,
        VsphereVm? Snappable = null
    ) 
    {
        if ( SnappableType != null ) {
            this.SnappableType = SnappableType;
        }
        if ( RecoverySpec != null ) {
            this.RecoverySpec = RecoverySpec;
        }
        if ( BootPriority != null ) {
            this.BootPriority = BootPriority;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( LastRecoveryPoint != null ) {
            this.LastRecoveryPoint = LastRecoveryPoint;
        }
        if ( FailoverInstance != null ) {
            this.FailoverInstance = FailoverInstance;
        }
        if ( LocalRpoLagInfo != null ) {
            this.LocalRpoLagInfo = LocalRpoLagInfo;
        }
        if ( RecoveryInfo != null ) {
            this.RecoveryInfo = RecoveryInfo;
        }
        if ( RemoteRpoLagInfo != null ) {
            this.RemoteRpoLagInfo = RemoteRpoLagInfo;
        }
        if ( ResourceSpec != null ) {
            this.ResourceSpec = ResourceSpec;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
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
        //      C# -> ObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: ObjectTypeEnum! (enum)
        if (this.SnappableType != null) {
            s += ind + "snappableType\n" ;
        }
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec (interface)
        if (this.RecoverySpec != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.RecoverySpec).AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoverySpec {\n" + fspec + ind + "}\n";
            }
        }
        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        if (this.BootPriority != null) {
            s += ind + "bootPriority\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.Int64? LastRecoveryPoint
        // GraphQL -> lastRecoveryPoint: Long (scalar)
        if (this.LastRecoveryPoint != null) {
            s += ind + "lastRecoveryPoint\n" ;
        }
        //      C# -> VsphereBlueprintChildFailoverInstance? FailoverInstance
        // GraphQL -> failoverInstance: VsphereBlueprintChildFailoverInstance (type)
        if (this.FailoverInstance != null) {
            var fspec = this.FailoverInstance.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "failoverInstance {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        if (this.LocalRpoLagInfo != null) {
            var fspec = this.LocalRpoLagInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "localRpoLagInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> ChildVmRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: ChildVmRecoveryInfo (type)
        if (this.RecoveryInfo != null) {
            var fspec = this.RecoveryInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoveryInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        if (this.RemoteRpoLagInfo != null) {
            var fspec = this.RemoteRpoLagInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "remoteRpoLagInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VmwareResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: VmwareResourceSpec (type)
        if (this.ResourceSpec != null) {
            var fspec = this.ResourceSpec.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "resourceSpec {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> VsphereVm? Snappable
        // GraphQL -> snappable: VsphereVm (type)
        if (this.Snappable != null) {
            var fspec = this.Snappable.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snappable {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: ObjectTypeEnum! (enum)
        if (this.SnappableType == null && ec.Includes("snappableType",true))
        {
            this.SnappableType = new ObjectTypeEnum();
        }
        //      C# -> RecoverySpec? RecoverySpec
        // GraphQL -> recoverySpec: RecoverySpec (interface)
        if (this.RecoverySpec == null && ec.Includes("recoverySpec",false))
        {
            var impls = new List<RecoverySpec>();
            impls.ApplyExploratoryFieldSpec(ec.NewChild("recoverySpec"));
            this.RecoverySpec = (RecoverySpec)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        if (this.BootPriority == null && ec.Includes("bootPriority",true))
        {
            this.BootPriority = Int32.MinValue;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        if (this.Fid == null && ec.Includes("fid",true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.Int64? LastRecoveryPoint
        // GraphQL -> lastRecoveryPoint: Long (scalar)
        if (this.LastRecoveryPoint == null && ec.Includes("lastRecoveryPoint",true))
        {
            this.LastRecoveryPoint = new System.Int64();
        }
        //      C# -> VsphereBlueprintChildFailoverInstance? FailoverInstance
        // GraphQL -> failoverInstance: VsphereBlueprintChildFailoverInstance (type)
        if (this.FailoverInstance == null && ec.Includes("failoverInstance",false))
        {
            this.FailoverInstance = new VsphereBlueprintChildFailoverInstance();
            this.FailoverInstance.ApplyExploratoryFieldSpec(ec.NewChild("failoverInstance"));
        }
        //      C# -> RpoLagInfo? LocalRpoLagInfo
        // GraphQL -> localRpoLagInfo: RpoLagInfo (type)
        if (this.LocalRpoLagInfo == null && ec.Includes("localRpoLagInfo",false))
        {
            this.LocalRpoLagInfo = new RpoLagInfo();
            this.LocalRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("localRpoLagInfo"));
        }
        //      C# -> ChildVmRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: ChildVmRecoveryInfo (type)
        if (this.RecoveryInfo == null && ec.Includes("recoveryInfo",false))
        {
            this.RecoveryInfo = new ChildVmRecoveryInfo();
            this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));
        }
        //      C# -> RpoLagInfo? RemoteRpoLagInfo
        // GraphQL -> remoteRpoLagInfo: RpoLagInfo (type)
        if (this.RemoteRpoLagInfo == null && ec.Includes("remoteRpoLagInfo",false))
        {
            this.RemoteRpoLagInfo = new RpoLagInfo();
            this.RemoteRpoLagInfo.ApplyExploratoryFieldSpec(ec.NewChild("remoteRpoLagInfo"));
        }
        //      C# -> VmwareResourceSpec? ResourceSpec
        // GraphQL -> resourceSpec: VmwareResourceSpec (type)
        if (this.ResourceSpec == null && ec.Includes("resourceSpec",false))
        {
            this.ResourceSpec = new VmwareResourceSpec();
            this.ResourceSpec.ApplyExploratoryFieldSpec(ec.NewChild("resourceSpec"));
        }
        //      C# -> VsphereVm? Snappable
        // GraphQL -> snappable: VsphereVm (type)
        if (this.Snappable == null && ec.Includes("snappable",false))
        {
            this.Snappable = new VsphereVm();
            this.Snappable.ApplyExploratoryFieldSpec(ec.NewChild("snappable"));
        }
    }


    #endregion

    } // class VsphereVmChild
    
    #endregion

    public static class ListVsphereVmChildExtensions
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
            this List<VsphereVmChild> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereVmChild> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereVmChild());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<VsphereVmChild> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types