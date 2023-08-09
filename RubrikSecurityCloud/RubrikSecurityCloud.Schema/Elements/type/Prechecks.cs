// Prechecks.cs
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
    #region Prechecks
    public class Prechecks: BaseType
    {
        #region members

        //      C# -> MigrationPrecheckType? MigrationPrecheckType
        // GraphQL -> migrationPrecheckType: MigrationPrecheckType! (enum)
        [JsonProperty("migrationPrecheckType")]
        public MigrationPrecheckType? MigrationPrecheckType { get; set; }

        //      C# -> MigrationStatus? MigrationStatus
        // GraphQL -> migrationStatus: MigrationStatus! (enum)
        [JsonProperty("migrationStatus")]
        public MigrationStatus? MigrationStatus { get; set; }

        //      C# -> PrecheckName? PrecheckName
        // GraphQL -> precheckName: PrecheckName! (enum)
        [JsonProperty("precheckName")]
        public PrecheckName? PrecheckName { get; set; }

        //      C# -> PrecheckStatus? PrecheckStatus
        // GraphQL -> precheckStatus: PrecheckStatus! (enum)
        [JsonProperty("precheckStatus")]
        public PrecheckStatus? PrecheckStatus { get; set; }

        //      C# -> PrecheckType? PrecheckType
        // GraphQL -> precheckType: PrecheckType! (enum)
        [JsonProperty("precheckType")]
        public PrecheckType? PrecheckType { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> DateTime? LastRunTimestamp
        // GraphQL -> lastRunTimestamp: DateTime (scalar)
        [JsonProperty("lastRunTimestamp")]
        public DateTime? LastRunTimestamp { get; set; }

        //      C# -> PrecheckMessage? Cause
        // GraphQL -> cause: PrecheckMessage (type)
        [JsonProperty("cause")]
        public PrecheckMessage? Cause { get; set; }

        //      C# -> PrecheckMessage? Consequence
        // GraphQL -> consequence: PrecheckMessage (type)
        [JsonProperty("consequence")]
        public PrecheckMessage? Consequence { get; set; }

        //      C# -> PrecheckMessage? Remedy
        // GraphQL -> remedy: PrecheckMessage (type)
        [JsonProperty("remedy")]
        public PrecheckMessage? Remedy { get; set; }

        //      C# -> PrecheckMessage? Summary
        // GraphQL -> summary: PrecheckMessage (type)
        [JsonProperty("summary")]
        public PrecheckMessage? Summary { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "Prechecks";
    }

    public Prechecks Set(
        MigrationPrecheckType? MigrationPrecheckType = null,
        MigrationStatus? MigrationStatus = null,
        PrecheckName? PrecheckName = null,
        PrecheckStatus? PrecheckStatus = null,
        PrecheckType? PrecheckType = null,
        System.String? ClusterUuid = null,
        DateTime? LastRunTimestamp = null,
        PrecheckMessage? Cause = null,
        PrecheckMessage? Consequence = null,
        PrecheckMessage? Remedy = null,
        PrecheckMessage? Summary = null
    ) 
    {
        if ( MigrationPrecheckType != null ) {
            this.MigrationPrecheckType = MigrationPrecheckType;
        }
        if ( MigrationStatus != null ) {
            this.MigrationStatus = MigrationStatus;
        }
        if ( PrecheckName != null ) {
            this.PrecheckName = PrecheckName;
        }
        if ( PrecheckStatus != null ) {
            this.PrecheckStatus = PrecheckStatus;
        }
        if ( PrecheckType != null ) {
            this.PrecheckType = PrecheckType;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( LastRunTimestamp != null ) {
            this.LastRunTimestamp = LastRunTimestamp;
        }
        if ( Cause != null ) {
            this.Cause = Cause;
        }
        if ( Consequence != null ) {
            this.Consequence = Consequence;
        }
        if ( Remedy != null ) {
            this.Remedy = Remedy;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
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
        //      C# -> MigrationPrecheckType? MigrationPrecheckType
        // GraphQL -> migrationPrecheckType: MigrationPrecheckType! (enum)
        if (this.MigrationPrecheckType != null) {
            s += ind + "migrationPrecheckType\n" ;
        }
        //      C# -> MigrationStatus? MigrationStatus
        // GraphQL -> migrationStatus: MigrationStatus! (enum)
        if (this.MigrationStatus != null) {
            s += ind + "migrationStatus\n" ;
        }
        //      C# -> PrecheckName? PrecheckName
        // GraphQL -> precheckName: PrecheckName! (enum)
        if (this.PrecheckName != null) {
            s += ind + "precheckName\n" ;
        }
        //      C# -> PrecheckStatus? PrecheckStatus
        // GraphQL -> precheckStatus: PrecheckStatus! (enum)
        if (this.PrecheckStatus != null) {
            s += ind + "precheckStatus\n" ;
        }
        //      C# -> PrecheckType? PrecheckType
        // GraphQL -> precheckType: PrecheckType! (enum)
        if (this.PrecheckType != null) {
            s += ind + "precheckType\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> DateTime? LastRunTimestamp
        // GraphQL -> lastRunTimestamp: DateTime (scalar)
        if (this.LastRunTimestamp != null) {
            s += ind + "lastRunTimestamp\n" ;
        }
        //      C# -> PrecheckMessage? Cause
        // GraphQL -> cause: PrecheckMessage (type)
        if (this.Cause != null) {
            var fspec = this.Cause.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cause {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrecheckMessage? Consequence
        // GraphQL -> consequence: PrecheckMessage (type)
        if (this.Consequence != null) {
            var fspec = this.Consequence.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "consequence {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrecheckMessage? Remedy
        // GraphQL -> remedy: PrecheckMessage (type)
        if (this.Remedy != null) {
            var fspec = this.Remedy.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "remedy {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PrecheckMessage? Summary
        // GraphQL -> summary: PrecheckMessage (type)
        if (this.Summary != null) {
            var fspec = this.Summary.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "summary {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MigrationPrecheckType? MigrationPrecheckType
        // GraphQL -> migrationPrecheckType: MigrationPrecheckType! (enum)
        if (this.MigrationPrecheckType == null && Exploration.Includes(parent + ".migrationPrecheckType", true))
        {
            this.MigrationPrecheckType = new MigrationPrecheckType();
        }
        //      C# -> MigrationStatus? MigrationStatus
        // GraphQL -> migrationStatus: MigrationStatus! (enum)
        if (this.MigrationStatus == null && Exploration.Includes(parent + ".migrationStatus", true))
        {
            this.MigrationStatus = new MigrationStatus();
        }
        //      C# -> PrecheckName? PrecheckName
        // GraphQL -> precheckName: PrecheckName! (enum)
        if (this.PrecheckName == null && Exploration.Includes(parent + ".precheckName", true))
        {
            this.PrecheckName = new PrecheckName();
        }
        //      C# -> PrecheckStatus? PrecheckStatus
        // GraphQL -> precheckStatus: PrecheckStatus! (enum)
        if (this.PrecheckStatus == null && Exploration.Includes(parent + ".precheckStatus", true))
        {
            this.PrecheckStatus = new PrecheckStatus();
        }
        //      C# -> PrecheckType? PrecheckType
        // GraphQL -> precheckType: PrecheckType! (enum)
        if (this.PrecheckType == null && Exploration.Includes(parent + ".precheckType", true))
        {
            this.PrecheckType = new PrecheckType();
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> DateTime? LastRunTimestamp
        // GraphQL -> lastRunTimestamp: DateTime (scalar)
        if (this.LastRunTimestamp == null && Exploration.Includes(parent + ".lastRunTimestamp", true))
        {
            this.LastRunTimestamp = new DateTime();
        }
        //      C# -> PrecheckMessage? Cause
        // GraphQL -> cause: PrecheckMessage (type)
        if (this.Cause == null && Exploration.Includes(parent + ".cause"))
        {
            this.Cause = new PrecheckMessage();
            this.Cause.ApplyExploratoryFieldSpec(parent + ".cause");
        }
        //      C# -> PrecheckMessage? Consequence
        // GraphQL -> consequence: PrecheckMessage (type)
        if (this.Consequence == null && Exploration.Includes(parent + ".consequence"))
        {
            this.Consequence = new PrecheckMessage();
            this.Consequence.ApplyExploratoryFieldSpec(parent + ".consequence");
        }
        //      C# -> PrecheckMessage? Remedy
        // GraphQL -> remedy: PrecheckMessage (type)
        if (this.Remedy == null && Exploration.Includes(parent + ".remedy"))
        {
            this.Remedy = new PrecheckMessage();
            this.Remedy.ApplyExploratoryFieldSpec(parent + ".remedy");
        }
        //      C# -> PrecheckMessage? Summary
        // GraphQL -> summary: PrecheckMessage (type)
        if (this.Summary == null && Exploration.Includes(parent + ".summary"))
        {
            this.Summary = new PrecheckMessage();
            this.Summary.ApplyExploratoryFieldSpec(parent + ".summary");
        }
    }


    #endregion

    } // class Prechecks
    
    #endregion

    public static class ListPrechecksExtensions
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
            this List<Prechecks> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Prechecks> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Prechecks());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types