// SlaWithExternalReplicationTargetSummary.cs
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
    #region SlaWithExternalReplicationTargetSummary
    public class SlaWithExternalReplicationTargetSummary: BaseType
    {
        #region members

        //      C# -> List<SlaObjectType>? ObjectTypeList
        // GraphQL -> objectTypeList: [SlaObjectType!]! (enum)
        [JsonProperty("objectTypeList")]
        public List<SlaObjectType>? ObjectTypeList { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? SourceAccountId
        // GraphQL -> sourceAccountId: String! (scalar)
        [JsonProperty("sourceAccountId")]
        public System.String? SourceAccountId { get; set; }

        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        [JsonProperty("stateVersion")]
        public System.Int64? StateVersion { get; set; }

        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        [JsonProperty("backupWindows")]
        public List<BackupWindow>? BackupWindows { get; set; }

        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        [JsonProperty("firstFullBackupWindows")]
        public List<BackupWindow>? FirstFullBackupWindows { get; set; }

        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        [JsonProperty("logConfig")]
        public LogConfigResult? LogConfig { get; set; }

        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        [JsonProperty("objectSpecificConfigs")]
        public ObjectSpecificConfigs? ObjectSpecificConfigs { get; set; }

        //      C# -> List<ReplicationSpecV2>? ReplicationSpecs
        // GraphQL -> replicationSpecs: [ReplicationSpecV2!]! (type)
        [JsonProperty("replicationSpecs")]
        public List<ReplicationSpecV2>? ReplicationSpecs { get; set; }

        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        [JsonProperty("snapshotSchedule")]
        public SnapshotSchedule? SnapshotSchedule { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SLAWithExternalReplicationTargetSummary";
    }

    public SlaWithExternalReplicationTargetSummary Set(
        List<SlaObjectType>? ObjectTypeList = null,
        System.String? Id = null,
        System.String? Name = null,
        System.String? SourceAccountId = null,
        System.Int64? StateVersion = null,
        List<BackupWindow>? BackupWindows = null,
        List<BackupWindow>? FirstFullBackupWindows = null,
        LogConfigResult? LogConfig = null,
        ObjectSpecificConfigs? ObjectSpecificConfigs = null,
        List<ReplicationSpecV2>? ReplicationSpecs = null,
        SnapshotSchedule? SnapshotSchedule = null
    ) 
    {
        if ( ObjectTypeList != null ) {
            this.ObjectTypeList = ObjectTypeList;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( SourceAccountId != null ) {
            this.SourceAccountId = SourceAccountId;
        }
        if ( StateVersion != null ) {
            this.StateVersion = StateVersion;
        }
        if ( BackupWindows != null ) {
            this.BackupWindows = BackupWindows;
        }
        if ( FirstFullBackupWindows != null ) {
            this.FirstFullBackupWindows = FirstFullBackupWindows;
        }
        if ( LogConfig != null ) {
            this.LogConfig = LogConfig;
        }
        if ( ObjectSpecificConfigs != null ) {
            this.ObjectSpecificConfigs = ObjectSpecificConfigs;
        }
        if ( ReplicationSpecs != null ) {
            this.ReplicationSpecs = ReplicationSpecs;
        }
        if ( SnapshotSchedule != null ) {
            this.SnapshotSchedule = SnapshotSchedule;
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
        //      C# -> List<SlaObjectType>? ObjectTypeList
        // GraphQL -> objectTypeList: [SlaObjectType!]! (enum)
        if (this.ObjectTypeList != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectTypeList\n" ;
            } else {
                s += ind + "objectTypeList\n" ;
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
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? SourceAccountId
        // GraphQL -> sourceAccountId: String! (scalar)
        if (this.SourceAccountId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sourceAccountId\n" ;
            } else {
                s += ind + "sourceAccountId\n" ;
            }
        }
        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        if (this.StateVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "stateVersion\n" ;
            } else {
                s += ind + "stateVersion\n" ;
            }
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (this.BackupWindows != null) {
            var fspec = this.BackupWindows.AsFieldSpec(conf.Child("backupWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "backupWindows" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        if (this.FirstFullBackupWindows != null) {
            var fspec = this.FirstFullBackupWindows.AsFieldSpec(conf.Child("firstFullBackupWindows"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "firstFullBackupWindows" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        if (this.LogConfig != null) {
            var fspec = this.LogConfig.AsFieldSpec(conf.Child("logConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "logConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        if (this.ObjectSpecificConfigs != null) {
            var fspec = this.ObjectSpecificConfigs.AsFieldSpec(conf.Child("objectSpecificConfigs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectSpecificConfigs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ReplicationSpecV2>? ReplicationSpecs
        // GraphQL -> replicationSpecs: [ReplicationSpecV2!]! (type)
        if (this.ReplicationSpecs != null) {
            var fspec = this.ReplicationSpecs.AsFieldSpec(conf.Child("replicationSpecs"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "replicationSpecs" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        if (this.SnapshotSchedule != null) {
            var fspec = this.SnapshotSchedule.AsFieldSpec(conf.Child("snapshotSchedule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotSchedule" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SlaObjectType>? ObjectTypeList
        // GraphQL -> objectTypeList: [SlaObjectType!]! (enum)
        if (ec.Includes("objectTypeList",true))
        {
            if(this.ObjectTypeList == null) {

                this.ObjectTypeList = new List<SlaObjectType>();

            } else {


            }
        }
        else if (this.ObjectTypeList != null && ec.Excludes("objectTypeList",true))
        {
            this.ObjectTypeList = null;
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
        //      C# -> System.String? SourceAccountId
        // GraphQL -> sourceAccountId: String! (scalar)
        if (ec.Includes("sourceAccountId",true))
        {
            if(this.SourceAccountId == null) {

                this.SourceAccountId = "FETCH";

            } else {


            }
        }
        else if (this.SourceAccountId != null && ec.Excludes("sourceAccountId",true))
        {
            this.SourceAccountId = null;
        }
        //      C# -> System.Int64? StateVersion
        // GraphQL -> stateVersion: Long! (scalar)
        if (ec.Includes("stateVersion",true))
        {
            if(this.StateVersion == null) {

                this.StateVersion = new System.Int64();

            } else {


            }
        }
        else if (this.StateVersion != null && ec.Excludes("stateVersion",true))
        {
            this.StateVersion = null;
        }
        //      C# -> List<BackupWindow>? BackupWindows
        // GraphQL -> backupWindows: [BackupWindow!]! (type)
        if (ec.Includes("backupWindows",false))
        {
            if(this.BackupWindows == null) {

                this.BackupWindows = new List<BackupWindow>();
                this.BackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("backupWindows"));

            } else {

                this.BackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("backupWindows"));

            }
        }
        else if (this.BackupWindows != null && ec.Excludes("backupWindows",false))
        {
            this.BackupWindows = null;
        }
        //      C# -> List<BackupWindow>? FirstFullBackupWindows
        // GraphQL -> firstFullBackupWindows: [BackupWindow!]! (type)
        if (ec.Includes("firstFullBackupWindows",false))
        {
            if(this.FirstFullBackupWindows == null) {

                this.FirstFullBackupWindows = new List<BackupWindow>();
                this.FirstFullBackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("firstFullBackupWindows"));

            } else {

                this.FirstFullBackupWindows.ApplyExploratoryFieldSpec(ec.NewChild("firstFullBackupWindows"));

            }
        }
        else if (this.FirstFullBackupWindows != null && ec.Excludes("firstFullBackupWindows",false))
        {
            this.FirstFullBackupWindows = null;
        }
        //      C# -> LogConfigResult? LogConfig
        // GraphQL -> logConfig: LogConfigResult (type)
        if (ec.Includes("logConfig",false))
        {
            if(this.LogConfig == null) {

                this.LogConfig = new LogConfigResult();
                this.LogConfig.ApplyExploratoryFieldSpec(ec.NewChild("logConfig"));

            } else {

                this.LogConfig.ApplyExploratoryFieldSpec(ec.NewChild("logConfig"));

            }
        }
        else if (this.LogConfig != null && ec.Excludes("logConfig",false))
        {
            this.LogConfig = null;
        }
        //      C# -> ObjectSpecificConfigs? ObjectSpecificConfigs
        // GraphQL -> objectSpecificConfigs: ObjectSpecificConfigs (type)
        if (ec.Includes("objectSpecificConfigs",false))
        {
            if(this.ObjectSpecificConfigs == null) {

                this.ObjectSpecificConfigs = new ObjectSpecificConfigs();
                this.ObjectSpecificConfigs.ApplyExploratoryFieldSpec(ec.NewChild("objectSpecificConfigs"));

            } else {

                this.ObjectSpecificConfigs.ApplyExploratoryFieldSpec(ec.NewChild("objectSpecificConfigs"));

            }
        }
        else if (this.ObjectSpecificConfigs != null && ec.Excludes("objectSpecificConfigs",false))
        {
            this.ObjectSpecificConfigs = null;
        }
        //      C# -> List<ReplicationSpecV2>? ReplicationSpecs
        // GraphQL -> replicationSpecs: [ReplicationSpecV2!]! (type)
        if (ec.Includes("replicationSpecs",false))
        {
            if(this.ReplicationSpecs == null) {

                this.ReplicationSpecs = new List<ReplicationSpecV2>();
                this.ReplicationSpecs.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpecs"));

            } else {

                this.ReplicationSpecs.ApplyExploratoryFieldSpec(ec.NewChild("replicationSpecs"));

            }
        }
        else if (this.ReplicationSpecs != null && ec.Excludes("replicationSpecs",false))
        {
            this.ReplicationSpecs = null;
        }
        //      C# -> SnapshotSchedule? SnapshotSchedule
        // GraphQL -> snapshotSchedule: SnapshotSchedule (type)
        if (ec.Includes("snapshotSchedule",false))
        {
            if(this.SnapshotSchedule == null) {

                this.SnapshotSchedule = new SnapshotSchedule();
                this.SnapshotSchedule.ApplyExploratoryFieldSpec(ec.NewChild("snapshotSchedule"));

            } else {

                this.SnapshotSchedule.ApplyExploratoryFieldSpec(ec.NewChild("snapshotSchedule"));

            }
        }
        else if (this.SnapshotSchedule != null && ec.Excludes("snapshotSchedule",false))
        {
            this.SnapshotSchedule = null;
        }
    }


    #endregion

    } // class SlaWithExternalReplicationTargetSummary
    
    #endregion

    public static class ListSlaWithExternalReplicationTargetSummaryExtensions
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
            this List<SlaWithExternalReplicationTargetSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SlaWithExternalReplicationTargetSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SlaWithExternalReplicationTargetSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SlaWithExternalReplicationTargetSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SlaWithExternalReplicationTargetSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types