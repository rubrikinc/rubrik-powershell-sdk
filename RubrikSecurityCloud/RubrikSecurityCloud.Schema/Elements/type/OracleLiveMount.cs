// OracleLiveMount.cs
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
    #region OracleLiveMount
    public class OracleLiveMount: BaseType
    {
        #region members

        //      C# -> OracleLiveMountStatus? Status
        // GraphQL -> status: OracleLiveMountStatus! (enum)
        [JsonProperty("status")]
        public OracleLiveMountStatus? Status { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        [JsonProperty("creationDate")]
        public DateTime? CreationDate { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsFilesOnlyMount
        // GraphQL -> isFilesOnlyMount: Boolean! (scalar)
        [JsonProperty("isFilesOnlyMount")]
        public System.Boolean? IsFilesOnlyMount { get; set; }

        //      C# -> System.Boolean? IsInstantRecovered
        // GraphQL -> isInstantRecovered: Boolean! (scalar)
        [JsonProperty("isInstantRecovered")]
        public System.Boolean? IsInstantRecovered { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        [JsonProperty("mountedDatabaseName")]
        public System.String? MountedDatabaseName { get; set; }

        //      C# -> System.String? TargetHostMount
        // GraphQL -> targetHostMount: String! (scalar)
        [JsonProperty("targetHostMount")]
        public System.String? TargetHostMount { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> OracleDatabase? MountedDatabase
        // GraphQL -> mountedDatabase: OracleDatabase (type)
        [JsonProperty("mountedDatabase")]
        public OracleDatabase? MountedDatabase { get; set; }

        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        [JsonProperty("owner")]
        public User? Owner { get; set; }

        //      C# -> OracleDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: OracleDatabase (type)
        [JsonProperty("sourceDatabase")]
        public OracleDatabase? SourceDatabase { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }

        //      C# -> OracleHost? TargetOracleHost
        // GraphQL -> targetOracleHost: OracleHost (type)
        [JsonProperty("targetOracleHost")]
        public OracleHost? TargetOracleHost { get; set; }

        //      C# -> OracleRac? TargetOracleRac
        // GraphQL -> targetOracleRac: OracleRac (type)
        [JsonProperty("targetOracleRac")]
        public OracleRac? TargetOracleRac { get; set; }


        #endregion

    #region methods

    public OracleLiveMount Set(
        OracleLiveMountStatus? Status = null,
        System.String? CdmId = null,
        DateTime? CreationDate = null,
        System.String? Id = null,
        System.Boolean? IsFilesOnlyMount = null,
        System.Boolean? IsInstantRecovered = null,
        System.Boolean? IsReady = null,
        System.String? MountedDatabaseName = null,
        System.String? TargetHostMount = null,
        Cluster? Cluster = null,
        OracleDatabase? MountedDatabase = null,
        User? Owner = null,
        OracleDatabase? SourceDatabase = null,
        CdmSnapshot? SourceSnapshot = null,
        OracleHost? TargetOracleHost = null,
        OracleRac? TargetOracleRac = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CreationDate != null ) {
            this.CreationDate = CreationDate;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsFilesOnlyMount != null ) {
            this.IsFilesOnlyMount = IsFilesOnlyMount;
        }
        if ( IsInstantRecovered != null ) {
            this.IsInstantRecovered = IsInstantRecovered;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountedDatabaseName != null ) {
            this.MountedDatabaseName = MountedDatabaseName;
        }
        if ( TargetHostMount != null ) {
            this.TargetHostMount = TargetHostMount;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( MountedDatabase != null ) {
            this.MountedDatabase = MountedDatabase;
        }
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( SourceDatabase != null ) {
            this.SourceDatabase = SourceDatabase;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
        }
        if ( TargetOracleHost != null ) {
            this.TargetOracleHost = TargetOracleHost;
        }
        if ( TargetOracleRac != null ) {
            this.TargetOracleRac = TargetOracleRac;
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
        //      C# -> OracleLiveMountStatus? Status
        // GraphQL -> status: OracleLiveMountStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        if (this.CreationDate != null) {
            s += ind + "creationDate\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsFilesOnlyMount
        // GraphQL -> isFilesOnlyMount: Boolean! (scalar)
        if (this.IsFilesOnlyMount != null) {
            s += ind + "isFilesOnlyMount\n" ;
        }
        //      C# -> System.Boolean? IsInstantRecovered
        // GraphQL -> isInstantRecovered: Boolean! (scalar)
        if (this.IsInstantRecovered != null) {
            s += ind + "isInstantRecovered\n" ;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            s += ind + "isReady\n" ;
        }
        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        if (this.MountedDatabaseName != null) {
            s += ind + "mountedDatabaseName\n" ;
        }
        //      C# -> System.String? TargetHostMount
        // GraphQL -> targetHostMount: String! (scalar)
        if (this.TargetHostMount != null) {
            s += ind + "targetHostMount\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleDatabase? MountedDatabase
        // GraphQL -> mountedDatabase: OracleDatabase (type)
        if (this.MountedDatabase != null) {
            var fspec = this.MountedDatabase.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "mountedDatabase {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        if (this.Owner != null) {
            var fspec = this.Owner.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "owner {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: OracleDatabase (type)
        if (this.SourceDatabase != null) {
            var fspec = this.SourceDatabase.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceDatabase {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot != null) {
            var fspec = this.SourceSnapshot.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceSnapshot {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleHost? TargetOracleHost
        // GraphQL -> targetOracleHost: OracleHost (type)
        if (this.TargetOracleHost != null) {
            var fspec = this.TargetOracleHost.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetOracleHost {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> OracleRac? TargetOracleRac
        // GraphQL -> targetOracleRac: OracleRac (type)
        if (this.TargetOracleRac != null) {
            var fspec = this.TargetOracleRac.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetOracleRac {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> OracleLiveMountStatus? Status
        // GraphQL -> status: OracleLiveMountStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new OracleLiveMountStatus();
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = "FETCH";
        }
        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        if (this.CreationDate == null && Exploration.Includes(parent + ".creationDate", true))
        {
            this.CreationDate = new DateTime();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsFilesOnlyMount
        // GraphQL -> isFilesOnlyMount: Boolean! (scalar)
        if (this.IsFilesOnlyMount == null && Exploration.Includes(parent + ".isFilesOnlyMount", true))
        {
            this.IsFilesOnlyMount = true;
        }
        //      C# -> System.Boolean? IsInstantRecovered
        // GraphQL -> isInstantRecovered: Boolean! (scalar)
        if (this.IsInstantRecovered == null && Exploration.Includes(parent + ".isInstantRecovered", true))
        {
            this.IsInstantRecovered = true;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady == null && Exploration.Includes(parent + ".isReady", true))
        {
            this.IsReady = true;
        }
        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        if (this.MountedDatabaseName == null && Exploration.Includes(parent + ".mountedDatabaseName", true))
        {
            this.MountedDatabaseName = "FETCH";
        }
        //      C# -> System.String? TargetHostMount
        // GraphQL -> targetHostMount: String! (scalar)
        if (this.TargetHostMount == null && Exploration.Includes(parent + ".targetHostMount", true))
        {
            this.TargetHostMount = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> OracleDatabase? MountedDatabase
        // GraphQL -> mountedDatabase: OracleDatabase (type)
        if (this.MountedDatabase == null && Exploration.Includes(parent + ".mountedDatabase"))
        {
            this.MountedDatabase = new OracleDatabase();
            this.MountedDatabase.ApplyExploratoryFieldSpec(parent + ".mountedDatabase");
        }
        //      C# -> User? Owner
        // GraphQL -> owner: User! (type)
        if (this.Owner == null && Exploration.Includes(parent + ".owner"))
        {
            this.Owner = new User();
            this.Owner.ApplyExploratoryFieldSpec(parent + ".owner");
        }
        //      C# -> OracleDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: OracleDatabase (type)
        if (this.SourceDatabase == null && Exploration.Includes(parent + ".sourceDatabase"))
        {
            this.SourceDatabase = new OracleDatabase();
            this.SourceDatabase.ApplyExploratoryFieldSpec(parent + ".sourceDatabase");
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot! (type)
        if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
        {
            this.SourceSnapshot = new CdmSnapshot();
            this.SourceSnapshot.ApplyExploratoryFieldSpec(parent + ".sourceSnapshot");
        }
        //      C# -> OracleHost? TargetOracleHost
        // GraphQL -> targetOracleHost: OracleHost (type)
        if (this.TargetOracleHost == null && Exploration.Includes(parent + ".targetOracleHost"))
        {
            this.TargetOracleHost = new OracleHost();
            this.TargetOracleHost.ApplyExploratoryFieldSpec(parent + ".targetOracleHost");
        }
        //      C# -> OracleRac? TargetOracleRac
        // GraphQL -> targetOracleRac: OracleRac (type)
        if (this.TargetOracleRac == null && Exploration.Includes(parent + ".targetOracleRac"))
        {
            this.TargetOracleRac = new OracleRac();
            this.TargetOracleRac.ApplyExploratoryFieldSpec(parent + ".targetOracleRac");
        }
    }


    #endregion

    } // class OracleLiveMount
    
    #endregion

    public static class ListOracleLiveMountExtensions
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
            this List<OracleLiveMount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleLiveMount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types