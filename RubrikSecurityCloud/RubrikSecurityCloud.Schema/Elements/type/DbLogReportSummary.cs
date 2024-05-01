// DbLogReportSummary.cs
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
    #region DbLogReportSummary
    public class DbLogReportSummary: BaseType
    {
        #region members

        //      C# -> DatabaseType? DatabaseType
        // GraphQL -> databaseType: DatabaseType! (enum)
        [JsonProperty("databaseType")]
        public DatabaseType? DatabaseType { get; set; }

        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        [JsonProperty("effectiveSlaDomainId")]
        public System.String? EffectiveSlaDomainId { get; set; }

        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        [JsonProperty("effectiveSlaDomainName")]
        public System.String? EffectiveSlaDomainName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        [JsonProperty("lastSnapshotTime")]
        public DateTime? LastSnapshotTime { get; set; }

        //      C# -> DateTime? LatestRecoveryTime
        // GraphQL -> latestRecoveryTime: DateTime (scalar)
        [JsonProperty("latestRecoveryTime")]
        public DateTime? LatestRecoveryTime { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int64? LogBackupDelay
        // GraphQL -> logBackupDelay: Long (scalar)
        [JsonProperty("logBackupDelay")]
        public System.Int64? LogBackupDelay { get; set; }

        //      C# -> System.Int32? LogBackupFrequency
        // GraphQL -> logBackupFrequency: Int (scalar)
        [JsonProperty("logBackupFrequency")]
        public System.Int32? LogBackupFrequency { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        [JsonProperty("primaryClusterId")]
        public System.String? PrimaryClusterId { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DbLogReportSummary";
    }

    public DbLogReportSummary Set(
        DatabaseType? DatabaseType = null,
        System.String? EffectiveSlaDomainId = null,
        System.String? EffectiveSlaDomainName = null,
        System.String? Id = null,
        DateTime? LastSnapshotTime = null,
        DateTime? LatestRecoveryTime = null,
        System.String? Location = null,
        System.Int64? LogBackupDelay = null,
        System.Int32? LogBackupFrequency = null,
        System.String? Name = null,
        System.String? PrimaryClusterId = null
    ) 
    {
        if ( DatabaseType != null ) {
            this.DatabaseType = DatabaseType;
        }
        if ( EffectiveSlaDomainId != null ) {
            this.EffectiveSlaDomainId = EffectiveSlaDomainId;
        }
        if ( EffectiveSlaDomainName != null ) {
            this.EffectiveSlaDomainName = EffectiveSlaDomainName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( LastSnapshotTime != null ) {
            this.LastSnapshotTime = LastSnapshotTime;
        }
        if ( LatestRecoveryTime != null ) {
            this.LatestRecoveryTime = LatestRecoveryTime;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( LogBackupDelay != null ) {
            this.LogBackupDelay = LogBackupDelay;
        }
        if ( LogBackupFrequency != null ) {
            this.LogBackupFrequency = LogBackupFrequency;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( PrimaryClusterId != null ) {
            this.PrimaryClusterId = PrimaryClusterId;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> DatabaseType? DatabaseType
        // GraphQL -> databaseType: DatabaseType! (enum)
        if (this.DatabaseType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "databaseType\n" ;
            } else {
                s += ind + "databaseType\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (this.EffectiveSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainId\n" ;
            } else {
                s += ind + "effectiveSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (this.EffectiveSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "effectiveSlaDomainName\n" ;
            } else {
                s += ind + "effectiveSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastSnapshotTime\n" ;
            } else {
                s += ind + "lastSnapshotTime\n" ;
            }
        }
        //      C# -> DateTime? LatestRecoveryTime
        // GraphQL -> latestRecoveryTime: DateTime (scalar)
        if (this.LatestRecoveryTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestRecoveryTime\n" ;
            } else {
                s += ind + "latestRecoveryTime\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.Int64? LogBackupDelay
        // GraphQL -> logBackupDelay: Long (scalar)
        if (this.LogBackupDelay != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupDelay\n" ;
            } else {
                s += ind + "logBackupDelay\n" ;
            }
        }
        //      C# -> System.Int32? LogBackupFrequency
        // GraphQL -> logBackupFrequency: Int (scalar)
        if (this.LogBackupFrequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "logBackupFrequency\n" ;
            } else {
                s += ind + "logBackupFrequency\n" ;
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "primaryClusterId\n" ;
            } else {
                s += ind + "primaryClusterId\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DatabaseType? DatabaseType
        // GraphQL -> databaseType: DatabaseType! (enum)
        if (ec.Includes("databaseType",true))
        {
            if(this.DatabaseType == null) {

                this.DatabaseType = new DatabaseType();

            } else {


            }
        }
        else if (this.DatabaseType != null && ec.Excludes("databaseType",true))
        {
            this.DatabaseType = null;
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (ec.Includes("effectiveSlaDomainId",true))
        {
            if(this.EffectiveSlaDomainId == null) {

                this.EffectiveSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainId != null && ec.Excludes("effectiveSlaDomainId",true))
        {
            this.EffectiveSlaDomainId = null;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (ec.Includes("effectiveSlaDomainName",true))
        {
            if(this.EffectiveSlaDomainName == null) {

                this.EffectiveSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.EffectiveSlaDomainName != null && ec.Excludes("effectiveSlaDomainName",true))
        {
            this.EffectiveSlaDomainName = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
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
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (ec.Includes("lastSnapshotTime",true))
        {
            if(this.LastSnapshotTime == null) {

                this.LastSnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.LastSnapshotTime != null && ec.Excludes("lastSnapshotTime",true))
        {
            this.LastSnapshotTime = null;
        }
        //      C# -> DateTime? LatestRecoveryTime
        // GraphQL -> latestRecoveryTime: DateTime (scalar)
        if (ec.Includes("latestRecoveryTime",true))
        {
            if(this.LatestRecoveryTime == null) {

                this.LatestRecoveryTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestRecoveryTime != null && ec.Excludes("latestRecoveryTime",true))
        {
            this.LatestRecoveryTime = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.Int64? LogBackupDelay
        // GraphQL -> logBackupDelay: Long (scalar)
        if (ec.Includes("logBackupDelay",true))
        {
            if(this.LogBackupDelay == null) {

                this.LogBackupDelay = new System.Int64();

            } else {


            }
        }
        else if (this.LogBackupDelay != null && ec.Excludes("logBackupDelay",true))
        {
            this.LogBackupDelay = null;
        }
        //      C# -> System.Int32? LogBackupFrequency
        // GraphQL -> logBackupFrequency: Int (scalar)
        if (ec.Includes("logBackupFrequency",true))
        {
            if(this.LogBackupFrequency == null) {

                this.LogBackupFrequency = Int32.MinValue;

            } else {


            }
        }
        else if (this.LogBackupFrequency != null && ec.Excludes("logBackupFrequency",true))
        {
            this.LogBackupFrequency = null;
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
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (ec.Includes("primaryClusterId",true))
        {
            if(this.PrimaryClusterId == null) {

                this.PrimaryClusterId = "FETCH";

            } else {


            }
        }
        else if (this.PrimaryClusterId != null && ec.Excludes("primaryClusterId",true))
        {
            this.PrimaryClusterId = null;
        }
    }


    #endregion

    } // class DbLogReportSummary
    
    #endregion

    public static class ListDbLogReportSummaryExtensions
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
        // | S   | II    | RscInterface<> : the field spec of each item in the list is included as an inline fragment (... on)
        // | L   | II    | RscInterfaceList<> : the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<DbLogReportSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DbLogReportSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DbLogReportSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DbLogReportSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DbLogReportSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types