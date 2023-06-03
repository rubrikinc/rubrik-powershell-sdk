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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
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
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<CyberRecoveryLocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [CyberRecoveryLocationPathPoint!]! (type)
        if (this.PhysicalLocation != null) {
            s += ind + "physicalLocation {\n" + this.PhysicalLocation.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RecoveryInfo>? RecoveryInfos
        // GraphQL -> recoveryInfos: [RecoveryInfo!]! (type)
        if (this.RecoveryInfos != null) {
            s += ind + "recoveryInfos {\n" + this.RecoveryInfos.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<RecoveryPlanDetails>? RecoveryPlansInfo
        // GraphQL -> recoveryPlansInfo: [RecoveryPlanDetails!]! (type)
        if (this.RecoveryPlansInfo != null) {
            s += ind + "recoveryPlansInfo {\n" + this.RecoveryPlansInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            s += ind + "snapshotDistribution {\n" + this.SnapshotDistribution.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> WorkloadLastFailoverStatus? LastRecoveryStatus
        // GraphQL -> lastRecoveryStatus: WorkloadLastFailoverStatus! (enum)
        if (this.LastRecoveryStatus == null && Exploration.Includes(parent + ".lastRecoveryStatus", true))
        {
            this.LastRecoveryStatus = new WorkloadLastFailoverStatus();
        }
        //      C# -> RecoveryPlanType? LastRecoveryType
        // GraphQL -> lastRecoveryType: RecoveryPlanType! (enum)
        if (this.LastRecoveryType == null && Exploration.Includes(parent + ".lastRecoveryType", true))
        {
            this.LastRecoveryType = new RecoveryPlanType();
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = new System.String("FETCH");
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? LastRecoveryFailoverId
        // GraphQL -> lastRecoveryFailoverId: UUID (scalar)
        if (this.LastRecoveryFailoverId == null && Exploration.Includes(parent + ".lastRecoveryFailoverId", true))
        {
            this.LastRecoveryFailoverId = new System.String("FETCH");
        }
        //      C# -> System.Int64? LastRecoveryMilliSec
        // GraphQL -> lastRecoveryMilliSec: Long! (scalar)
        if (this.LastRecoveryMilliSec == null && Exploration.Includes(parent + ".lastRecoveryMilliSec", true))
        {
            this.LastRecoveryMilliSec = new System.Int64();
        }
        //      C# -> System.String? LastRecoveryRecoveryPlanId
        // GraphQL -> lastRecoveryRecoveryPlanId: UUID (scalar)
        if (this.LastRecoveryRecoveryPlanId == null && Exploration.Includes(parent + ".lastRecoveryRecoveryPlanId", true))
        {
            this.LastRecoveryRecoveryPlanId = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> List<System.String>? RecoveryPlanIds
        // GraphQL -> recoveryPlanIds: [UUID!]! (scalar)
        if (this.RecoveryPlanIds == null && Exploration.Includes(parent + ".recoveryPlanIds", true))
        {
            this.RecoveryPlanIds = new List<System.String>();
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (this.RetentionSlaDomainId == null && Exploration.Includes(parent + ".retentionSlaDomainId", true))
        {
            this.RetentionSlaDomainId = new System.String("FETCH");
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (this.RetentionSlaDomainName == null && Exploration.Includes(parent + ".retentionSlaDomainName", true))
        {
            this.RetentionSlaDomainName = new System.String("FETCH");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> List<CyberRecoveryLocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [CyberRecoveryLocationPathPoint!]! (type)
        if (this.PhysicalLocation == null && Exploration.Includes(parent + ".physicalLocation"))
        {
            this.PhysicalLocation = new List<CyberRecoveryLocationPathPoint>();
            this.PhysicalLocation.ApplyExploratoryFieldSpec(parent + ".physicalLocation");
        }
        //      C# -> List<RecoveryInfo>? RecoveryInfos
        // GraphQL -> recoveryInfos: [RecoveryInfo!]! (type)
        if (this.RecoveryInfos == null && Exploration.Includes(parent + ".recoveryInfos"))
        {
            this.RecoveryInfos = new List<RecoveryInfo>();
            this.RecoveryInfos.ApplyExploratoryFieldSpec(parent + ".recoveryInfos");
        }
        //      C# -> List<RecoveryPlanDetails>? RecoveryPlansInfo
        // GraphQL -> recoveryPlansInfo: [RecoveryPlanDetails!]! (type)
        if (this.RecoveryPlansInfo == null && Exploration.Includes(parent + ".recoveryPlansInfo"))
        {
            this.RecoveryPlansInfo = new List<RecoveryPlanDetails>();
            this.RecoveryPlansInfo.ApplyExploratoryFieldSpec(parent + ".recoveryPlansInfo");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
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
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CyberRecoveryObject> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CyberRecoveryObject());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types