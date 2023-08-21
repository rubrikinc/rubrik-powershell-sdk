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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> DatabaseType? DatabaseType
        // GraphQL -> databaseType: DatabaseType! (enum)
        if (this.DatabaseType != null) {
            s += ind + "databaseType\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (this.EffectiveSlaDomainId != null) {
            s += ind + "effectiveSlaDomainId\n" ;
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (this.EffectiveSlaDomainName != null) {
            s += ind + "effectiveSlaDomainName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime != null) {
            s += ind + "lastSnapshotTime\n" ;
        }
        //      C# -> DateTime? LatestRecoveryTime
        // GraphQL -> latestRecoveryTime: DateTime (scalar)
        if (this.LatestRecoveryTime != null) {
            s += ind + "latestRecoveryTime\n" ;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            s += ind + "location\n" ;
        }
        //      C# -> System.Int64? LogBackupDelay
        // GraphQL -> logBackupDelay: Long (scalar)
        if (this.LogBackupDelay != null) {
            s += ind + "logBackupDelay\n" ;
        }
        //      C# -> System.Int32? LogBackupFrequency
        // GraphQL -> logBackupFrequency: Int (scalar)
        if (this.LogBackupFrequency != null) {
            s += ind + "logBackupFrequency\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId != null) {
            s += ind + "primaryClusterId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DatabaseType? DatabaseType
        // GraphQL -> databaseType: DatabaseType! (enum)
        if (this.DatabaseType == null && Exploration.Includes(parent + ".databaseType", true))
        {
            this.DatabaseType = new DatabaseType();
        }
        //      C# -> System.String? EffectiveSlaDomainId
        // GraphQL -> effectiveSlaDomainId: String! (scalar)
        if (this.EffectiveSlaDomainId == null && Exploration.Includes(parent + ".effectiveSlaDomainId", true))
        {
            this.EffectiveSlaDomainId = "FETCH";
        }
        //      C# -> System.String? EffectiveSlaDomainName
        // GraphQL -> effectiveSlaDomainName: String! (scalar)
        if (this.EffectiveSlaDomainName == null && Exploration.Includes(parent + ".effectiveSlaDomainName", true))
        {
            this.EffectiveSlaDomainName = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> DateTime? LastSnapshotTime
        // GraphQL -> lastSnapshotTime: DateTime (scalar)
        if (this.LastSnapshotTime == null && Exploration.Includes(parent + ".lastSnapshotTime", true))
        {
            this.LastSnapshotTime = new DateTime();
        }
        //      C# -> DateTime? LatestRecoveryTime
        // GraphQL -> latestRecoveryTime: DateTime (scalar)
        if (this.LatestRecoveryTime == null && Exploration.Includes(parent + ".latestRecoveryTime", true))
        {
            this.LatestRecoveryTime = new DateTime();
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location == null && Exploration.Includes(parent + ".location", true))
        {
            this.Location = "FETCH";
        }
        //      C# -> System.Int64? LogBackupDelay
        // GraphQL -> logBackupDelay: Long (scalar)
        if (this.LogBackupDelay == null && Exploration.Includes(parent + ".logBackupDelay", true))
        {
            this.LogBackupDelay = new System.Int64();
        }
        //      C# -> System.Int32? LogBackupFrequency
        // GraphQL -> logBackupFrequency: Int (scalar)
        if (this.LogBackupFrequency == null && Exploration.Includes(parent + ".logBackupFrequency", true))
        {
            this.LogBackupFrequency = Int32.MinValue;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = "FETCH";
        }
        //      C# -> System.String? PrimaryClusterId
        // GraphQL -> primaryClusterId: String! (scalar)
        if (this.PrimaryClusterId == null && Exploration.Includes(parent + ".primaryClusterId", true))
        {
            this.PrimaryClusterId = "FETCH";
        }
    }


    #endregion

    } // class DbLogReportSummary
    
    #endregion

    public static class ListDbLogReportSummaryExtensions
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
            this List<DbLogReportSummary> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DbLogReportSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DbLogReportSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types