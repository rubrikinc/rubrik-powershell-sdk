// CdmMssqlDbReplica.cs
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
    #region CdmMssqlDbReplica
    public class CdmMssqlDbReplica: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        [JsonProperty("hasPermissions")]
        public System.Boolean? HasPermissions { get; set; }

        //      C# -> System.String? InstanceRootId
        // GraphQL -> instanceRootId: String! (scalar)
        [JsonProperty("instanceRootId")]
        public System.String? InstanceRootId { get; set; }

        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        [JsonProperty("isArchived")]
        public System.Boolean? IsArchived { get; set; }

        //      C# -> System.Boolean? IsStandBy
        // GraphQL -> isStandBy: Boolean! (scalar)
        [JsonProperty("isStandBy")]
        public System.Boolean? IsStandBy { get; set; }

        //      C# -> System.String? RecoveryModel
        // GraphQL -> recoveryModel: String! (scalar)
        [JsonProperty("recoveryModel")]
        public System.String? RecoveryModel { get; set; }

        //      C# -> System.Boolean? SnapshotNeeded
        // GraphQL -> snapshotNeeded: Boolean! (scalar)
        [JsonProperty("snapshotNeeded")]
        public System.Boolean? SnapshotNeeded { get; set; }

        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        [JsonProperty("state")]
        public System.String? State { get; set; }

        //      C# -> CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: CdmMssqlDbReplicaAvailabilityInfo (type)
        [JsonProperty("availabilityInfo")]
        public CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo { get; set; }

        //      C# -> MssqlInstance? Instance
        // GraphQL -> instance: MssqlInstance (type)
        [JsonProperty("instance")]
        public MssqlInstance? Instance { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CdmMssqlDbReplica";
    }

    public CdmMssqlDbReplica Set(
        System.String? ClusterUuid = null,
        System.Boolean? HasPermissions = null,
        System.String? InstanceRootId = null,
        System.Boolean? IsArchived = null,
        System.Boolean? IsStandBy = null,
        System.String? RecoveryModel = null,
        System.Boolean? SnapshotNeeded = null,
        System.String? State = null,
        CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo = null,
        MssqlInstance? Instance = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( HasPermissions != null ) {
            this.HasPermissions = HasPermissions;
        }
        if ( InstanceRootId != null ) {
            this.InstanceRootId = InstanceRootId;
        }
        if ( IsArchived != null ) {
            this.IsArchived = IsArchived;
        }
        if ( IsStandBy != null ) {
            this.IsStandBy = IsStandBy;
        }
        if ( RecoveryModel != null ) {
            this.RecoveryModel = RecoveryModel;
        }
        if ( SnapshotNeeded != null ) {
            this.SnapshotNeeded = SnapshotNeeded;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( AvailabilityInfo != null ) {
            this.AvailabilityInfo = AvailabilityInfo;
        }
        if ( Instance != null ) {
            this.Instance = Instance;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (this.HasPermissions != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasPermissions\n" ;
            } else {
                s += ind + "hasPermissions\n" ;
            }
        }
        //      C# -> System.String? InstanceRootId
        // GraphQL -> instanceRootId: String! (scalar)
        if (this.InstanceRootId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "instanceRootId\n" ;
            } else {
                s += ind + "instanceRootId\n" ;
            }
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (this.IsArchived != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isArchived\n" ;
            } else {
                s += ind + "isArchived\n" ;
            }
        }
        //      C# -> System.Boolean? IsStandBy
        // GraphQL -> isStandBy: Boolean! (scalar)
        if (this.IsStandBy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isStandBy\n" ;
            } else {
                s += ind + "isStandBy\n" ;
            }
        }
        //      C# -> System.String? RecoveryModel
        // GraphQL -> recoveryModel: String! (scalar)
        if (this.RecoveryModel != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryModel\n" ;
            } else {
                s += ind + "recoveryModel\n" ;
            }
        }
        //      C# -> System.Boolean? SnapshotNeeded
        // GraphQL -> snapshotNeeded: Boolean! (scalar)
        if (this.SnapshotNeeded != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotNeeded\n" ;
            } else {
                s += ind + "snapshotNeeded\n" ;
            }
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (this.State != null) {
            if (conf.Flat) {
                s += conf.Prefix + "state\n" ;
            } else {
                s += ind + "state\n" ;
            }
        }
        //      C# -> CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: CdmMssqlDbReplicaAvailabilityInfo (type)
        if (this.AvailabilityInfo != null) {
            var fspec = this.AvailabilityInfo.AsFieldSpec(conf.Child("availabilityInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "availabilityInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlInstance? Instance
        // GraphQL -> instance: MssqlInstance (type)
        if (this.Instance != null) {
            var fspec = this.Instance.AsFieldSpec(conf.Child("instance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "instance" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Boolean? HasPermissions
        // GraphQL -> hasPermissions: Boolean! (scalar)
        if (ec.Includes("hasPermissions",true))
        {
            if(this.HasPermissions == null) {

                this.HasPermissions = true;

            } else {


            }
        }
        else if (this.HasPermissions != null && ec.Excludes("hasPermissions",true))
        {
            this.HasPermissions = null;
        }
        //      C# -> System.String? InstanceRootId
        // GraphQL -> instanceRootId: String! (scalar)
        if (ec.Includes("instanceRootId",true))
        {
            if(this.InstanceRootId == null) {

                this.InstanceRootId = "FETCH";

            } else {


            }
        }
        else if (this.InstanceRootId != null && ec.Excludes("instanceRootId",true))
        {
            this.InstanceRootId = null;
        }
        //      C# -> System.Boolean? IsArchived
        // GraphQL -> isArchived: Boolean! (scalar)
        if (ec.Includes("isArchived",true))
        {
            if(this.IsArchived == null) {

                this.IsArchived = true;

            } else {


            }
        }
        else if (this.IsArchived != null && ec.Excludes("isArchived",true))
        {
            this.IsArchived = null;
        }
        //      C# -> System.Boolean? IsStandBy
        // GraphQL -> isStandBy: Boolean! (scalar)
        if (ec.Includes("isStandBy",true))
        {
            if(this.IsStandBy == null) {

                this.IsStandBy = true;

            } else {


            }
        }
        else if (this.IsStandBy != null && ec.Excludes("isStandBy",true))
        {
            this.IsStandBy = null;
        }
        //      C# -> System.String? RecoveryModel
        // GraphQL -> recoveryModel: String! (scalar)
        if (ec.Includes("recoveryModel",true))
        {
            if(this.RecoveryModel == null) {

                this.RecoveryModel = "FETCH";

            } else {


            }
        }
        else if (this.RecoveryModel != null && ec.Excludes("recoveryModel",true))
        {
            this.RecoveryModel = null;
        }
        //      C# -> System.Boolean? SnapshotNeeded
        // GraphQL -> snapshotNeeded: Boolean! (scalar)
        if (ec.Includes("snapshotNeeded",true))
        {
            if(this.SnapshotNeeded == null) {

                this.SnapshotNeeded = true;

            } else {


            }
        }
        else if (this.SnapshotNeeded != null && ec.Excludes("snapshotNeeded",true))
        {
            this.SnapshotNeeded = null;
        }
        //      C# -> System.String? State
        // GraphQL -> state: String! (scalar)
        if (ec.Includes("state",true))
        {
            if(this.State == null) {

                this.State = "FETCH";

            } else {


            }
        }
        else if (this.State != null && ec.Excludes("state",true))
        {
            this.State = null;
        }
        //      C# -> CdmMssqlDbReplicaAvailabilityInfo? AvailabilityInfo
        // GraphQL -> availabilityInfo: CdmMssqlDbReplicaAvailabilityInfo (type)
        if (ec.Includes("availabilityInfo",false))
        {
            if(this.AvailabilityInfo == null) {

                this.AvailabilityInfo = new CdmMssqlDbReplicaAvailabilityInfo();
                this.AvailabilityInfo.ApplyExploratoryFieldSpec(ec.NewChild("availabilityInfo"));

            } else {

                this.AvailabilityInfo.ApplyExploratoryFieldSpec(ec.NewChild("availabilityInfo"));

            }
        }
        else if (this.AvailabilityInfo != null && ec.Excludes("availabilityInfo",false))
        {
            this.AvailabilityInfo = null;
        }
        //      C# -> MssqlInstance? Instance
        // GraphQL -> instance: MssqlInstance (type)
        if (ec.Includes("instance",false))
        {
            if(this.Instance == null) {

                this.Instance = new MssqlInstance();
                this.Instance.ApplyExploratoryFieldSpec(ec.NewChild("instance"));

            } else {

                this.Instance.ApplyExploratoryFieldSpec(ec.NewChild("instance"));

            }
        }
        else if (this.Instance != null && ec.Excludes("instance",false))
        {
            this.Instance = null;
        }
    }


    #endregion

    } // class CdmMssqlDbReplica
    
    #endregion

    public static class ListCdmMssqlDbReplicaExtensions
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
            this List<CdmMssqlDbReplica> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CdmMssqlDbReplica> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CdmMssqlDbReplica> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmMssqlDbReplica());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CdmMssqlDbReplica> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types