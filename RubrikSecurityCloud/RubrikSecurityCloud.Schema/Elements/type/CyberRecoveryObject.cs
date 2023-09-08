// CyberRecoveryObject.cs
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
    #region CyberRecoveryObject
    public class CyberRecoveryObject: BaseType
    {
        #region members

        //      C# -> WorkloadLastFailoverStatus? LastRecoveryStatus
        // GraphQL -> lastRecoveryStatus: WorkloadLastFailoverStatus! (enum)
        [JsonProperty("lastRecoveryStatus")]
        public WorkloadLastFailoverStatus? LastRecoveryStatus { get; set; }

        //      C# -> RecoveryPlanType? LastRecoveryType
        // GraphQL -> lastRecoveryType: RecoveryPlanType! (enum)
        [JsonProperty("lastRecoveryType")]
        public RecoveryPlanType? LastRecoveryType { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? LastRecoveryFailoverId
        // GraphQL -> lastRecoveryFailoverId: UUID (scalar)
        [JsonProperty("lastRecoveryFailoverId")]
        public System.String? LastRecoveryFailoverId { get; set; }

        //      C# -> System.Int64? LastRecoveryMilliSec
        // GraphQL -> lastRecoveryMilliSec: Long! (scalar)
        [JsonProperty("lastRecoveryMilliSec")]
        public System.Int64? LastRecoveryMilliSec { get; set; }

        //      C# -> System.String? LastRecoveryRecoveryPlanId
        // GraphQL -> lastRecoveryRecoveryPlanId: UUID (scalar)
        [JsonProperty("lastRecoveryRecoveryPlanId")]
        public System.String? LastRecoveryRecoveryPlanId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<System.String>? RecoveryPlanIds
        // GraphQL -> recoveryPlanIds: [UUID!]! (scalar)
        [JsonProperty("recoveryPlanIds")]
        public List<System.String>? RecoveryPlanIds { get; set; }

        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        [JsonProperty("retentionSlaDomainId")]
        public System.String? RetentionSlaDomainId { get; set; }

        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        [JsonProperty("retentionSlaDomainName")]
        public System.String? RetentionSlaDomainName { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<CyberRecoveryLocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [CyberRecoveryLocationPathPoint!]! (type)
        [JsonProperty("physicalLocation")]
        public List<CyberRecoveryLocationPathPoint>? PhysicalLocation { get; set; }

        //      C# -> List<RecoveryInfo>? RecoveryInfos
        // GraphQL -> recoveryInfos: [RecoveryInfo!]! (type)
        [JsonProperty("recoveryInfos")]
        public List<RecoveryInfo>? RecoveryInfos { get; set; }

        //      C# -> List<RecoveryPlanDetails>? RecoveryPlansInfo
        // GraphQL -> recoveryPlansInfo: [RecoveryPlanDetails!]! (type)
        [JsonProperty("recoveryPlansInfo")]
        public List<RecoveryPlanDetails>? RecoveryPlansInfo { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CyberRecoveryObject";
    }

    public CyberRecoveryObject Set(
        WorkloadLastFailoverStatus? LastRecoveryStatus = null,
        RecoveryPlanType? LastRecoveryType = null,
        System.String? ClusterId = null,
        System.String? ClusterName = null,
        System.String? Id = null,
        System.String? LastRecoveryFailoverId = null,
        System.Int64? LastRecoveryMilliSec = null,
        System.String? LastRecoveryRecoveryPlanId = null,
        System.String? Name = null,
        List<System.String>? RecoveryPlanIds = null,
        System.String? RetentionSlaDomainId = null,
        System.String? RetentionSlaDomainName = null,
        Cluster? Cluster = null,
        List<CyberRecoveryLocationPathPoint>? PhysicalLocation = null,
        List<RecoveryInfo>? RecoveryInfos = null,
        List<RecoveryPlanDetails>? RecoveryPlansInfo = null,
        SnapshotDistribution? SnapshotDistribution = null
    ) 
    {
        if ( LastRecoveryStatus != null ) {
            this.LastRecoveryStatus = LastRecoveryStatus;
        }
        if ( LastRecoveryType != null ) {
            this.LastRecoveryType = LastRecoveryType;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastRecoveryFailoverId != null ) {
            this.LastRecoveryFailoverId = LastRecoveryFailoverId;
        }
        if ( LastRecoveryMilliSec != null ) {
            this.LastRecoveryMilliSec = LastRecoveryMilliSec;
        }
        if ( LastRecoveryRecoveryPlanId != null ) {
            this.LastRecoveryRecoveryPlanId = LastRecoveryRecoveryPlanId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RecoveryPlanIds != null ) {
            this.RecoveryPlanIds = RecoveryPlanIds;
        }
        if ( RetentionSlaDomainId != null ) {
            this.RetentionSlaDomainId = RetentionSlaDomainId;
        }
        if ( RetentionSlaDomainName != null ) {
            this.RetentionSlaDomainName = RetentionSlaDomainName;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( PhysicalLocation != null ) {
            this.PhysicalLocation = PhysicalLocation;
        }
        if ( RecoveryInfos != null ) {
            this.RecoveryInfos = RecoveryInfos;
        }
        if ( RecoveryPlansInfo != null ) {
            this.RecoveryPlansInfo = RecoveryPlansInfo;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
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
        //      C# -> WorkloadLastFailoverStatus? LastRecoveryStatus
        // GraphQL -> lastRecoveryStatus: WorkloadLastFailoverStatus! (enum)
        if (this.LastRecoveryStatus != null) {
            s += ind + "lastRecoveryStatus\n" ;
        }
        //      C# -> RecoveryPlanType? LastRecoveryType
        // GraphQL -> lastRecoveryType: RecoveryPlanType! (enum)
        if (this.LastRecoveryType != null) {
            s += ind + "lastRecoveryType\n" ;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? LastRecoveryFailoverId
        // GraphQL -> lastRecoveryFailoverId: UUID (scalar)
        if (this.LastRecoveryFailoverId != null) {
            s += ind + "lastRecoveryFailoverId\n" ;
        }
        //      C# -> System.Int64? LastRecoveryMilliSec
        // GraphQL -> lastRecoveryMilliSec: Long! (scalar)
        if (this.LastRecoveryMilliSec != null) {
            s += ind + "lastRecoveryMilliSec\n" ;
        }
        //      C# -> System.String? LastRecoveryRecoveryPlanId
        // GraphQL -> lastRecoveryRecoveryPlanId: UUID (scalar)
        if (this.LastRecoveryRecoveryPlanId != null) {
            s += ind + "lastRecoveryRecoveryPlanId\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<System.String>? RecoveryPlanIds
        // GraphQL -> recoveryPlanIds: [UUID!]! (scalar)
        if (this.RecoveryPlanIds != null) {
            s += ind + "recoveryPlanIds\n" ;
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (this.RetentionSlaDomainId != null) {
            s += ind + "retentionSlaDomainId\n" ;
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (this.RetentionSlaDomainName != null) {
            s += ind + "retentionSlaDomainName\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<CyberRecoveryLocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [CyberRecoveryLocationPathPoint!]! (type)
        if (this.PhysicalLocation != null) {
            var fspec = this.PhysicalLocation.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "physicalLocation {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<RecoveryInfo>? RecoveryInfos
        // GraphQL -> recoveryInfos: [RecoveryInfo!]! (type)
        if (this.RecoveryInfos != null) {
            var fspec = this.RecoveryInfos.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoveryInfos {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<RecoveryPlanDetails>? RecoveryPlansInfo
        // GraphQL -> recoveryPlansInfo: [RecoveryPlanDetails!]! (type)
        if (this.RecoveryPlansInfo != null) {
            var fspec = this.RecoveryPlansInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "recoveryPlansInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "snapshotDistribution {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadLastFailoverStatus? LastRecoveryStatus
        // GraphQL -> lastRecoveryStatus: WorkloadLastFailoverStatus! (enum)
        if (this.LastRecoveryStatus == null && ec.Includes("lastRecoveryStatus",true))
        {
            this.LastRecoveryStatus = new WorkloadLastFailoverStatus();
        }
        //      C# -> RecoveryPlanType? LastRecoveryType
        // GraphQL -> lastRecoveryType: RecoveryPlanType! (enum)
        if (this.LastRecoveryType == null && ec.Includes("lastRecoveryType",true))
        {
            this.LastRecoveryType = new RecoveryPlanType();
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && ec.Includes("clusterId",true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && ec.Includes("clusterName",true))
        {
            this.ClusterName = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && ec.Includes("id",true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.String? LastRecoveryFailoverId
        // GraphQL -> lastRecoveryFailoverId: UUID (scalar)
        if (this.LastRecoveryFailoverId == null && ec.Includes("lastRecoveryFailoverId",true))
        {
            this.LastRecoveryFailoverId = "FETCH";
        }
        //      C# -> System.Int64? LastRecoveryMilliSec
        // GraphQL -> lastRecoveryMilliSec: Long! (scalar)
        if (this.LastRecoveryMilliSec == null && ec.Includes("lastRecoveryMilliSec",true))
        {
            this.LastRecoveryMilliSec = new System.Int64();
        }
        //      C# -> System.String? LastRecoveryRecoveryPlanId
        // GraphQL -> lastRecoveryRecoveryPlanId: UUID (scalar)
        if (this.LastRecoveryRecoveryPlanId == null && ec.Includes("lastRecoveryRecoveryPlanId",true))
        {
            this.LastRecoveryRecoveryPlanId = "FETCH";
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && ec.Includes("name",true))
        {
            this.Name = "FETCH";
        }
        //      C# -> List<System.String>? RecoveryPlanIds
        // GraphQL -> recoveryPlanIds: [UUID!]! (scalar)
        if (this.RecoveryPlanIds == null && ec.Includes("recoveryPlanIds",true))
        {
            this.RecoveryPlanIds = new List<System.String>();
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (this.RetentionSlaDomainId == null && ec.Includes("retentionSlaDomainId",true))
        {
            this.RetentionSlaDomainId = "FETCH";
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (this.RetentionSlaDomainName == null && ec.Includes("retentionSlaDomainName",true))
        {
            this.RetentionSlaDomainName = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && ec.Includes("cluster",false))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));
        }
        //      C# -> List<CyberRecoveryLocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [CyberRecoveryLocationPathPoint!]! (type)
        if (this.PhysicalLocation == null && ec.Includes("physicalLocation",false))
        {
            this.PhysicalLocation = new List<CyberRecoveryLocationPathPoint>();
            this.PhysicalLocation.ApplyExploratoryFieldSpec(ec.NewChild("physicalLocation"));
        }
        //      C# -> List<RecoveryInfo>? RecoveryInfos
        // GraphQL -> recoveryInfos: [RecoveryInfo!]! (type)
        if (this.RecoveryInfos == null && ec.Includes("recoveryInfos",false))
        {
            this.RecoveryInfos = new List<RecoveryInfo>();
            this.RecoveryInfos.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfos"));
        }
        //      C# -> List<RecoveryPlanDetails>? RecoveryPlansInfo
        // GraphQL -> recoveryPlansInfo: [RecoveryPlanDetails!]! (type)
        if (this.RecoveryPlansInfo == null && ec.Includes("recoveryPlansInfo",false))
        {
            this.RecoveryPlansInfo = new List<RecoveryPlanDetails>();
            this.RecoveryPlansInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlansInfo"));
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && ec.Includes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));
        }
    }


    #endregion

    } // class CyberRecoveryObject
    
    #endregion

    public static class ListCyberRecoveryObjectExtensions
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
            this List<CyberRecoveryObject> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CyberRecoveryObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CyberRecoveryObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<CyberRecoveryObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types