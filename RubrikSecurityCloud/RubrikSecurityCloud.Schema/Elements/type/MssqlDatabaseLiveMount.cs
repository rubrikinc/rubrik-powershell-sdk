// MssqlDatabaseLiveMount.cs
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
    #region MssqlDatabaseLiveMount
    public class MssqlDatabaseLiveMount: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        [JsonProperty("creationDate")]
        public DateTime? CreationDate { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String! (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> System.String? MountedDatabaseId
        // GraphQL -> mountedDatabaseId: String! (scalar)
        [JsonProperty("mountedDatabaseId")]
        public System.String? MountedDatabaseId { get; set; }

        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        [JsonProperty("mountedDatabaseName")]
        public System.String? MountedDatabaseName { get; set; }

        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        [JsonProperty("ownerId")]
        public System.String? OwnerId { get; set; }

        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        [JsonProperty("recoveryPoint")]
        public DateTime? RecoveryPoint { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String! (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> MssqlDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: MssqlDatabase (type)
        [JsonProperty("sourceDatabase")]
        public MssqlDatabase? SourceDatabase { get; set; }

        //      C# -> MssqlInstance? TargetInstance
        // GraphQL -> targetInstance: MssqlInstance (type)
        [JsonProperty("targetInstance")]
        public MssqlInstance? TargetInstance { get; set; }


        #endregion

    #region methods

    public MssqlDatabaseLiveMount Set(
        System.String? CdmId = null,
        DateTime? CreationDate = null,
        System.String? Fid = null,
        System.Boolean? IsReady = null,
        System.String? MountRequestId = null,
        System.String? MountedDatabaseId = null,
        System.String? MountedDatabaseName = null,
        System.String? OwnerId = null,
        DateTime? RecoveryPoint = null,
        System.String? UnmountRequestId = null,
        Cluster? Cluster = null,
        MssqlDatabase? SourceDatabase = null,
        MssqlInstance? TargetInstance = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CreationDate != null ) {
            this.CreationDate = CreationDate;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountedDatabaseId != null ) {
            this.MountedDatabaseId = MountedDatabaseId;
        }
        if ( MountedDatabaseName != null ) {
            this.MountedDatabaseName = MountedDatabaseName;
        }
        if ( OwnerId != null ) {
            this.OwnerId = OwnerId;
        }
        if ( RecoveryPoint != null ) {
            this.RecoveryPoint = RecoveryPoint;
        }
        if ( UnmountRequestId != null ) {
            this.UnmountRequestId = UnmountRequestId;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( SourceDatabase != null ) {
            this.SourceDatabase = SourceDatabase;
        }
        if ( TargetInstance != null ) {
            this.TargetInstance = TargetInstance;
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            s += ind + "isReady\n" ;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String! (scalar)
        if (this.MountRequestId != null) {
            s += ind + "mountRequestId\n" ;
        }
        //      C# -> System.String? MountedDatabaseId
        // GraphQL -> mountedDatabaseId: String! (scalar)
        if (this.MountedDatabaseId != null) {
            s += ind + "mountedDatabaseId\n" ;
        }
        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        if (this.MountedDatabaseName != null) {
            s += ind + "mountedDatabaseName\n" ;
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (this.OwnerId != null) {
            s += ind + "ownerId\n" ;
        }
        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        if (this.RecoveryPoint != null) {
            s += ind + "recoveryPoint\n" ;
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String! (scalar)
        if (this.UnmountRequestId != null) {
            s += ind + "unmountRequestId\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "cluster {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MssqlDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: MssqlDatabase (type)
        if (this.SourceDatabase != null) {
            var fspec = this.SourceDatabase.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "sourceDatabase {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> MssqlInstance? TargetInstance
        // GraphQL -> targetInstance: MssqlInstance (type)
        if (this.TargetInstance != null) {
            var fspec = this.TargetInstance.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "targetInstance {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
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
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid == null && Exploration.Includes(parent + ".fid", true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady == null && Exploration.Includes(parent + ".isReady", true))
        {
            this.IsReady = true;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String! (scalar)
        if (this.MountRequestId == null && Exploration.Includes(parent + ".mountRequestId", true))
        {
            this.MountRequestId = "FETCH";
        }
        //      C# -> System.String? MountedDatabaseId
        // GraphQL -> mountedDatabaseId: String! (scalar)
        if (this.MountedDatabaseId == null && Exploration.Includes(parent + ".mountedDatabaseId", true))
        {
            this.MountedDatabaseId = "FETCH";
        }
        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        if (this.MountedDatabaseName == null && Exploration.Includes(parent + ".mountedDatabaseName", true))
        {
            this.MountedDatabaseName = "FETCH";
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (this.OwnerId == null && Exploration.Includes(parent + ".ownerId", true))
        {
            this.OwnerId = "FETCH";
        }
        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        if (this.RecoveryPoint == null && Exploration.Includes(parent + ".recoveryPoint", true))
        {
            this.RecoveryPoint = new DateTime();
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String! (scalar)
        if (this.UnmountRequestId == null && Exploration.Includes(parent + ".unmountRequestId", true))
        {
            this.UnmountRequestId = "FETCH";
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> MssqlDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: MssqlDatabase (type)
        if (this.SourceDatabase == null && Exploration.Includes(parent + ".sourceDatabase"))
        {
            this.SourceDatabase = new MssqlDatabase();
            this.SourceDatabase.ApplyExploratoryFieldSpec(parent + ".sourceDatabase");
        }
        //      C# -> MssqlInstance? TargetInstance
        // GraphQL -> targetInstance: MssqlInstance (type)
        if (this.TargetInstance == null && Exploration.Includes(parent + ".targetInstance"))
        {
            this.TargetInstance = new MssqlInstance();
            this.TargetInstance.ApplyExploratoryFieldSpec(parent + ".targetInstance");
        }
    }


    #endregion

    } // class MssqlDatabaseLiveMount
    
    #endregion

    public static class ListMssqlDatabaseLiveMountExtensions
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
            this List<MssqlDatabaseLiveMount> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDatabaseLiveMount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDatabaseLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types