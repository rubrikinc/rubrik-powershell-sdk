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

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

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
        System.Boolean? IsRelic = null,
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
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> WorkloadLastFailoverStatus? LastRecoveryStatus
        // GraphQL -> lastRecoveryStatus: WorkloadLastFailoverStatus! (enum)
        if (this.LastRecoveryStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRecoveryStatus\n" ;
            } else {
                s += ind + "lastRecoveryStatus\n" ;
            }
        }
        //      C# -> RecoveryPlanType? LastRecoveryType
        // GraphQL -> lastRecoveryType: RecoveryPlanType! (enum)
        if (this.LastRecoveryType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRecoveryType\n" ;
            } else {
                s += ind + "lastRecoveryType\n" ;
            }
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterId\n" ;
            } else {
                s += ind + "clusterId\n" ;
            }
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterName\n" ;
            } else {
                s += ind + "clusterName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRelic\n" ;
            } else {
                s += ind + "isRelic\n" ;
            }
        }
        //      C# -> System.String? LastRecoveryFailoverId
        // GraphQL -> lastRecoveryFailoverId: UUID (scalar)
        if (this.LastRecoveryFailoverId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRecoveryFailoverId\n" ;
            } else {
                s += ind + "lastRecoveryFailoverId\n" ;
            }
        }
        //      C# -> System.Int64? LastRecoveryMilliSec
        // GraphQL -> lastRecoveryMilliSec: Long! (scalar)
        if (this.LastRecoveryMilliSec != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRecoveryMilliSec\n" ;
            } else {
                s += ind + "lastRecoveryMilliSec\n" ;
            }
        }
        //      C# -> System.String? LastRecoveryRecoveryPlanId
        // GraphQL -> lastRecoveryRecoveryPlanId: UUID (scalar)
        if (this.LastRecoveryRecoveryPlanId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRecoveryRecoveryPlanId\n" ;
            } else {
                s += ind + "lastRecoveryRecoveryPlanId\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> List<System.String>? RecoveryPlanIds
        // GraphQL -> recoveryPlanIds: [UUID!]! (scalar)
        if (this.RecoveryPlanIds != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanIds\n" ;
            } else {
                s += ind + "recoveryPlanIds\n" ;
            }
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (this.RetentionSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionSlaDomainId\n" ;
            } else {
                s += ind + "retentionSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (this.RetentionSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionSlaDomainName\n" ;
            } else {
                s += ind + "retentionSlaDomainName\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<CyberRecoveryLocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [CyberRecoveryLocationPathPoint!]! (type)
        if (this.PhysicalLocation != null) {
            var fspec = this.PhysicalLocation.AsFieldSpec(conf.Child("physicalLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RecoveryInfo>? RecoveryInfos
        // GraphQL -> recoveryInfos: [RecoveryInfo!]! (type)
        if (this.RecoveryInfos != null) {
            var fspec = this.RecoveryInfos.AsFieldSpec(conf.Child("recoveryInfos"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryInfos" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<RecoveryPlanDetails>? RecoveryPlansInfo
        // GraphQL -> recoveryPlansInfo: [RecoveryPlanDetails!]! (type)
        if (this.RecoveryPlansInfo != null) {
            var fspec = this.RecoveryPlansInfo.AsFieldSpec(conf.Child("recoveryPlansInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryPlansInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            var fspec = this.SnapshotDistribution.AsFieldSpec(conf.Child("snapshotDistribution"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotDistribution" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> WorkloadLastFailoverStatus? LastRecoveryStatus
        // GraphQL -> lastRecoveryStatus: WorkloadLastFailoverStatus! (enum)
        if (ec.Includes("lastRecoveryStatus",true))
        {
            if(this.LastRecoveryStatus == null) {

                this.LastRecoveryStatus = new WorkloadLastFailoverStatus();

            } else {


            }
        }
        else if (this.LastRecoveryStatus != null && ec.Excludes("lastRecoveryStatus",true))
        {
            this.LastRecoveryStatus = null;
        }
        //      C# -> RecoveryPlanType? LastRecoveryType
        // GraphQL -> lastRecoveryType: RecoveryPlanType! (enum)
        if (ec.Includes("lastRecoveryType",true))
        {
            if(this.LastRecoveryType == null) {

                this.LastRecoveryType = new RecoveryPlanType();

            } else {


            }
        }
        else if (this.LastRecoveryType != null && ec.Excludes("lastRecoveryType",true))
        {
            this.LastRecoveryType = null;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (ec.Includes("clusterId",true))
        {
            if(this.ClusterId == null) {

                this.ClusterId = "FETCH";

            } else {


            }
        }
        else if (this.ClusterId != null && ec.Excludes("clusterId",true))
        {
            this.ClusterId = null;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (ec.Includes("clusterName",true))
        {
            if(this.ClusterName == null) {

                this.ClusterName = "FETCH";

            } else {


            }
        }
        else if (this.ClusterName != null && ec.Excludes("clusterName",true))
        {
            this.ClusterName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (ec.Includes("isRelic",true))
        {
            if(this.IsRelic == null) {

                this.IsRelic = true;

            } else {


            }
        }
        else if (this.IsRelic != null && ec.Excludes("isRelic",true))
        {
            this.IsRelic = null;
        }
        //      C# -> System.String? LastRecoveryFailoverId
        // GraphQL -> lastRecoveryFailoverId: UUID (scalar)
        if (ec.Includes("lastRecoveryFailoverId",true))
        {
            if(this.LastRecoveryFailoverId == null) {

                this.LastRecoveryFailoverId = "FETCH";

            } else {


            }
        }
        else if (this.LastRecoveryFailoverId != null && ec.Excludes("lastRecoveryFailoverId",true))
        {
            this.LastRecoveryFailoverId = null;
        }
        //      C# -> System.Int64? LastRecoveryMilliSec
        // GraphQL -> lastRecoveryMilliSec: Long! (scalar)
        if (ec.Includes("lastRecoveryMilliSec",true))
        {
            if(this.LastRecoveryMilliSec == null) {

                this.LastRecoveryMilliSec = new System.Int64();

            } else {


            }
        }
        else if (this.LastRecoveryMilliSec != null && ec.Excludes("lastRecoveryMilliSec",true))
        {
            this.LastRecoveryMilliSec = null;
        }
        //      C# -> System.String? LastRecoveryRecoveryPlanId
        // GraphQL -> lastRecoveryRecoveryPlanId: UUID (scalar)
        if (ec.Includes("lastRecoveryRecoveryPlanId",true))
        {
            if(this.LastRecoveryRecoveryPlanId == null) {

                this.LastRecoveryRecoveryPlanId = "FETCH";

            } else {


            }
        }
        else if (this.LastRecoveryRecoveryPlanId != null && ec.Excludes("lastRecoveryRecoveryPlanId",true))
        {
            this.LastRecoveryRecoveryPlanId = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> List<System.String>? RecoveryPlanIds
        // GraphQL -> recoveryPlanIds: [UUID!]! (scalar)
        if (ec.Includes("recoveryPlanIds",true))
        {
            if(this.RecoveryPlanIds == null) {

                this.RecoveryPlanIds = new List<System.String>();

            } else {


            }
        }
        else if (this.RecoveryPlanIds != null && ec.Excludes("recoveryPlanIds",true))
        {
            this.RecoveryPlanIds = null;
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (ec.Includes("retentionSlaDomainId",true))
        {
            if(this.RetentionSlaDomainId == null) {

                this.RetentionSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.RetentionSlaDomainId != null && ec.Excludes("retentionSlaDomainId",true))
        {
            this.RetentionSlaDomainId = null;
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (ec.Includes("retentionSlaDomainName",true))
        {
            if(this.RetentionSlaDomainName == null) {

                this.RetentionSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.RetentionSlaDomainName != null && ec.Excludes("retentionSlaDomainName",true))
        {
            this.RetentionSlaDomainName = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> List<CyberRecoveryLocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [CyberRecoveryLocationPathPoint!]! (type)
        if (ec.Includes("physicalLocation",false))
        {
            if(this.PhysicalLocation == null) {

                this.PhysicalLocation = new List<CyberRecoveryLocationPathPoint>();
                this.PhysicalLocation.ApplyExploratoryFieldSpec(ec.NewChild("physicalLocation"));

            } else {

                this.PhysicalLocation.ApplyExploratoryFieldSpec(ec.NewChild("physicalLocation"));

            }
        }
        else if (this.PhysicalLocation != null && ec.Excludes("physicalLocation",false))
        {
            this.PhysicalLocation = null;
        }
        //      C# -> List<RecoveryInfo>? RecoveryInfos
        // GraphQL -> recoveryInfos: [RecoveryInfo!]! (type)
        if (ec.Includes("recoveryInfos",false))
        {
            if(this.RecoveryInfos == null) {

                this.RecoveryInfos = new List<RecoveryInfo>();
                this.RecoveryInfos.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfos"));

            } else {

                this.RecoveryInfos.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfos"));

            }
        }
        else if (this.RecoveryInfos != null && ec.Excludes("recoveryInfos",false))
        {
            this.RecoveryInfos = null;
        }
        //      C# -> List<RecoveryPlanDetails>? RecoveryPlansInfo
        // GraphQL -> recoveryPlansInfo: [RecoveryPlanDetails!]! (type)
        if (ec.Includes("recoveryPlansInfo",false))
        {
            if(this.RecoveryPlansInfo == null) {

                this.RecoveryPlansInfo = new List<RecoveryPlanDetails>();
                this.RecoveryPlansInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlansInfo"));

            } else {

                this.RecoveryPlansInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlansInfo"));

            }
        }
        else if (this.RecoveryPlansInfo != null && ec.Excludes("recoveryPlansInfo",false))
        {
            this.RecoveryPlansInfo = null;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (ec.Includes("snapshotDistribution",false))
        {
            if(this.SnapshotDistribution == null) {

                this.SnapshotDistribution = new SnapshotDistribution();
                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            } else {

                this.SnapshotDistribution.ApplyExploratoryFieldSpec(ec.NewChild("snapshotDistribution"));

            }
        }
        else if (this.SnapshotDistribution != null && ec.Excludes("snapshotDistribution",false))
        {
            this.SnapshotDistribution = null;
        }
    }


    #endregion

    } // class CyberRecoveryObject
    
    #endregion

    public static class ListCyberRecoveryObjectExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CyberRecoveryObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CyberRecoveryObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
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

        public static void SelectForRetrieval(this List<CyberRecoveryObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types