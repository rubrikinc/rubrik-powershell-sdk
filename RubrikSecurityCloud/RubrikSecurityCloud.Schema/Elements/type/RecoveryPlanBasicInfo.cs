// RecoveryPlanBasicInfo.cs
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
    #region RecoveryPlanBasicInfo
    public class RecoveryPlanBasicInfo: BaseType
    {
        #region members

        //      C# -> RecoveryPlanStatus? RecoveryPlanStatus
        // GraphQL -> recoveryPlanStatus: RecoveryPlanStatus! (enum)
        [JsonProperty("recoveryPlanStatus")]
        public RecoveryPlanStatus? RecoveryPlanStatus { get; set; }

        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        [JsonProperty("recoveryPlanType")]
        public RecoveryPlanType? RecoveryPlanType { get; set; }

        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        [JsonProperty("workloadType")]
        public ManagedObjectType? WorkloadType { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        [JsonProperty("version")]
        public System.Int64? Version { get; set; }

        //      C# -> Recovery? LatestRecovery
        // GraphQL -> latestRecovery: Recovery (type)
        [JsonProperty("latestRecovery")]
        public Recovery? LatestRecovery { get; set; }

        //      C# -> RecoveryPlanStats? RecoveryPlanStats
        // GraphQL -> recoveryPlanStats: RecoveryPlanStats (type)
        [JsonProperty("recoveryPlanStats")]
        public RecoveryPlanStats? RecoveryPlanStats { get; set; }

        //      C# -> RecoverySchedule? RecoverySchedule
        // GraphQL -> recoverySchedule: RecoverySchedule (type)
        [JsonProperty("recoverySchedule")]
        public RecoverySchedule? RecoverySchedule { get; set; }

        //      C# -> RecoveryPlanLocation? SourceLocation
        // GraphQL -> sourceLocation: RecoveryPlanLocation (type)
        [JsonProperty("sourceLocation")]
        public RecoveryPlanLocation? SourceLocation { get; set; }

        //      C# -> RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo
        // GraphQL -> targetConsistencyInfo: RecoveryPlanTargetConsistencyInfo (type)
        [JsonProperty("targetConsistencyInfo")]
        public RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo { get; set; }

        //      C# -> RecoveryPlanLocation? TargetLocation
        // GraphQL -> targetLocation: RecoveryPlanLocation (type)
        [JsonProperty("targetLocation")]
        public RecoveryPlanLocation? TargetLocation { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RecoveryPlanBasicInfo";
    }

    public RecoveryPlanBasicInfo Set(
        RecoveryPlanStatus? RecoveryPlanStatus = null,
        RecoveryPlanType? RecoveryPlanType = null,
        ManagedObjectType? WorkloadType = null,
        System.String? Id = null,
        System.String? Name = null,
        System.Int64? Version = null,
        Recovery? LatestRecovery = null,
        RecoveryPlanStats? RecoveryPlanStats = null,
        RecoverySchedule? RecoverySchedule = null,
        RecoveryPlanLocation? SourceLocation = null,
        RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo = null,
        RecoveryPlanLocation? TargetLocation = null
    ) 
    {
        if ( RecoveryPlanStatus != null ) {
            this.RecoveryPlanStatus = RecoveryPlanStatus;
        }
        if ( RecoveryPlanType != null ) {
            this.RecoveryPlanType = RecoveryPlanType;
        }
        if ( WorkloadType != null ) {
            this.WorkloadType = WorkloadType;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Version != null ) {
            this.Version = Version;
        }
        if ( LatestRecovery != null ) {
            this.LatestRecovery = LatestRecovery;
        }
        if ( RecoveryPlanStats != null ) {
            this.RecoveryPlanStats = RecoveryPlanStats;
        }
        if ( RecoverySchedule != null ) {
            this.RecoverySchedule = RecoverySchedule;
        }
        if ( SourceLocation != null ) {
            this.SourceLocation = SourceLocation;
        }
        if ( TargetConsistencyInfo != null ) {
            this.TargetConsistencyInfo = TargetConsistencyInfo;
        }
        if ( TargetLocation != null ) {
            this.TargetLocation = TargetLocation;
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
        //      C# -> RecoveryPlanStatus? RecoveryPlanStatus
        // GraphQL -> recoveryPlanStatus: RecoveryPlanStatus! (enum)
        if (this.RecoveryPlanStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanStatus\n" ;
            } else {
                s += ind + "recoveryPlanStatus\n" ;
            }
        }
        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        if (this.RecoveryPlanType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPlanType\n" ;
            } else {
                s += ind + "recoveryPlanType\n" ;
            }
        }
        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        if (this.WorkloadType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadType\n" ;
            } else {
                s += ind + "workloadType\n" ;
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
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (this.Version != null) {
            if (conf.Flat) {
                s += conf.Prefix + "version\n" ;
            } else {
                s += ind + "version\n" ;
            }
        }
        //      C# -> Recovery? LatestRecovery
        // GraphQL -> latestRecovery: Recovery (type)
        if (this.LatestRecovery != null) {
            var fspec = this.LatestRecovery.AsFieldSpec(conf.Child("latestRecovery"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "latestRecovery" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanStats? RecoveryPlanStats
        // GraphQL -> recoveryPlanStats: RecoveryPlanStats (type)
        if (this.RecoveryPlanStats != null) {
            var fspec = this.RecoveryPlanStats.AsFieldSpec(conf.Child("recoveryPlanStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryPlanStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoverySchedule? RecoverySchedule
        // GraphQL -> recoverySchedule: RecoverySchedule (type)
        if (this.RecoverySchedule != null) {
            var fspec = this.RecoverySchedule.AsFieldSpec(conf.Child("recoverySchedule"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoverySchedule" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanLocation? SourceLocation
        // GraphQL -> sourceLocation: RecoveryPlanLocation (type)
        if (this.SourceLocation != null) {
            var fspec = this.SourceLocation.AsFieldSpec(conf.Child("sourceLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo
        // GraphQL -> targetConsistencyInfo: RecoveryPlanTargetConsistencyInfo (type)
        if (this.TargetConsistencyInfo != null) {
            var fspec = this.TargetConsistencyInfo.AsFieldSpec(conf.Child("targetConsistencyInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetConsistencyInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> RecoveryPlanLocation? TargetLocation
        // GraphQL -> targetLocation: RecoveryPlanLocation (type)
        if (this.TargetLocation != null) {
            var fspec = this.TargetLocation.AsFieldSpec(conf.Child("targetLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetLocation" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RecoveryPlanStatus? RecoveryPlanStatus
        // GraphQL -> recoveryPlanStatus: RecoveryPlanStatus! (enum)
        if (ec.Includes("recoveryPlanStatus",true))
        {
            if(this.RecoveryPlanStatus == null) {

                this.RecoveryPlanStatus = new RecoveryPlanStatus();

            } else {


            }
        }
        else if (this.RecoveryPlanStatus != null && ec.Excludes("recoveryPlanStatus",true))
        {
            this.RecoveryPlanStatus = null;
        }
        //      C# -> RecoveryPlanType? RecoveryPlanType
        // GraphQL -> recoveryPlanType: RecoveryPlanType! (enum)
        if (ec.Includes("recoveryPlanType",true))
        {
            if(this.RecoveryPlanType == null) {

                this.RecoveryPlanType = new RecoveryPlanType();

            } else {


            }
        }
        else if (this.RecoveryPlanType != null && ec.Excludes("recoveryPlanType",true))
        {
            this.RecoveryPlanType = null;
        }
        //      C# -> ManagedObjectType? WorkloadType
        // GraphQL -> workloadType: ManagedObjectType! (enum)
        if (ec.Includes("workloadType",true))
        {
            if(this.WorkloadType == null) {

                this.WorkloadType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.WorkloadType != null && ec.Excludes("workloadType",true))
        {
            this.WorkloadType = null;
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
        //      C# -> System.Int64? Version
        // GraphQL -> version: Long! (scalar)
        if (ec.Includes("version",true))
        {
            if(this.Version == null) {

                this.Version = new System.Int64();

            } else {


            }
        }
        else if (this.Version != null && ec.Excludes("version",true))
        {
            this.Version = null;
        }
        //      C# -> Recovery? LatestRecovery
        // GraphQL -> latestRecovery: Recovery (type)
        if (ec.Includes("latestRecovery",false))
        {
            if(this.LatestRecovery == null) {

                this.LatestRecovery = new Recovery();
                this.LatestRecovery.ApplyExploratoryFieldSpec(ec.NewChild("latestRecovery"));

            } else {

                this.LatestRecovery.ApplyExploratoryFieldSpec(ec.NewChild("latestRecovery"));

            }
        }
        else if (this.LatestRecovery != null && ec.Excludes("latestRecovery",false))
        {
            this.LatestRecovery = null;
        }
        //      C# -> RecoveryPlanStats? RecoveryPlanStats
        // GraphQL -> recoveryPlanStats: RecoveryPlanStats (type)
        if (ec.Includes("recoveryPlanStats",false))
        {
            if(this.RecoveryPlanStats == null) {

                this.RecoveryPlanStats = new RecoveryPlanStats();
                this.RecoveryPlanStats.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanStats"));

            } else {

                this.RecoveryPlanStats.ApplyExploratoryFieldSpec(ec.NewChild("recoveryPlanStats"));

            }
        }
        else if (this.RecoveryPlanStats != null && ec.Excludes("recoveryPlanStats",false))
        {
            this.RecoveryPlanStats = null;
        }
        //      C# -> RecoverySchedule? RecoverySchedule
        // GraphQL -> recoverySchedule: RecoverySchedule (type)
        if (ec.Includes("recoverySchedule",false))
        {
            if(this.RecoverySchedule == null) {

                this.RecoverySchedule = new RecoverySchedule();
                this.RecoverySchedule.ApplyExploratoryFieldSpec(ec.NewChild("recoverySchedule"));

            } else {

                this.RecoverySchedule.ApplyExploratoryFieldSpec(ec.NewChild("recoverySchedule"));

            }
        }
        else if (this.RecoverySchedule != null && ec.Excludes("recoverySchedule",false))
        {
            this.RecoverySchedule = null;
        }
        //      C# -> RecoveryPlanLocation? SourceLocation
        // GraphQL -> sourceLocation: RecoveryPlanLocation (type)
        if (ec.Includes("sourceLocation",false))
        {
            if(this.SourceLocation == null) {

                this.SourceLocation = new RecoveryPlanLocation();
                this.SourceLocation.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocation"));

            } else {

                this.SourceLocation.ApplyExploratoryFieldSpec(ec.NewChild("sourceLocation"));

            }
        }
        else if (this.SourceLocation != null && ec.Excludes("sourceLocation",false))
        {
            this.SourceLocation = null;
        }
        //      C# -> RecoveryPlanTargetConsistencyInfo? TargetConsistencyInfo
        // GraphQL -> targetConsistencyInfo: RecoveryPlanTargetConsistencyInfo (type)
        if (ec.Includes("targetConsistencyInfo",false))
        {
            if(this.TargetConsistencyInfo == null) {

                this.TargetConsistencyInfo = new RecoveryPlanTargetConsistencyInfo();
                this.TargetConsistencyInfo.ApplyExploratoryFieldSpec(ec.NewChild("targetConsistencyInfo"));

            } else {

                this.TargetConsistencyInfo.ApplyExploratoryFieldSpec(ec.NewChild("targetConsistencyInfo"));

            }
        }
        else if (this.TargetConsistencyInfo != null && ec.Excludes("targetConsistencyInfo",false))
        {
            this.TargetConsistencyInfo = null;
        }
        //      C# -> RecoveryPlanLocation? TargetLocation
        // GraphQL -> targetLocation: RecoveryPlanLocation (type)
        if (ec.Includes("targetLocation",false))
        {
            if(this.TargetLocation == null) {

                this.TargetLocation = new RecoveryPlanLocation();
                this.TargetLocation.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));

            } else {

                this.TargetLocation.ApplyExploratoryFieldSpec(ec.NewChild("targetLocation"));

            }
        }
        else if (this.TargetLocation != null && ec.Excludes("targetLocation",false))
        {
            this.TargetLocation = null;
        }
    }


    #endregion

    } // class RecoveryPlanBasicInfo
    
    #endregion

    public static class ListRecoveryPlanBasicInfoExtensions
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
            this List<RecoveryPlanBasicInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RecoveryPlanBasicInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RecoveryPlanBasicInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RecoveryPlanBasicInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RecoveryPlanBasicInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types