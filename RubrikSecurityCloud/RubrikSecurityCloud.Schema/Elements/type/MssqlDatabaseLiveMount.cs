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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "MssqlDatabaseLiveMount";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdmId\n" ;
            } else {
                s += ind + "cdmId\n" ;
            }
        }
        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        if (this.CreationDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "creationDate\n" ;
            } else {
                s += ind + "creationDate\n" ;
            }
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "fid\n" ;
            } else {
                s += ind + "fid\n" ;
            }
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isReady\n" ;
            } else {
                s += ind + "isReady\n" ;
            }
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String! (scalar)
        if (this.MountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountRequestId\n" ;
            } else {
                s += ind + "mountRequestId\n" ;
            }
        }
        //      C# -> System.String? MountedDatabaseId
        // GraphQL -> mountedDatabaseId: String! (scalar)
        if (this.MountedDatabaseId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedDatabaseId\n" ;
            } else {
                s += ind + "mountedDatabaseId\n" ;
            }
        }
        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        if (this.MountedDatabaseName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mountedDatabaseName\n" ;
            } else {
                s += ind + "mountedDatabaseName\n" ;
            }
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (this.OwnerId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ownerId\n" ;
            } else {
                s += ind + "ownerId\n" ;
            }
        }
        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        if (this.RecoveryPoint != null) {
            if (conf.Flat) {
                s += conf.Prefix + "recoveryPoint\n" ;
            } else {
                s += ind + "recoveryPoint\n" ;
            }
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String! (scalar)
        if (this.UnmountRequestId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unmountRequestId\n" ;
            } else {
                s += ind + "unmountRequestId\n" ;
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
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: MssqlDatabase (type)
        if (this.SourceDatabase != null) {
            var fspec = this.SourceDatabase.AsFieldSpec(conf.Child("sourceDatabase"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "sourceDatabase {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> MssqlInstance? TargetInstance
        // GraphQL -> targetInstance: MssqlInstance (type)
        if (this.TargetInstance != null) {
            var fspec = this.TargetInstance.AsFieldSpec(conf.Child("targetInstance"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "targetInstance {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (ec.Includes("cdmId",true))
        {
            if(this.CdmId == null) {

                this.CdmId = "FETCH";

            } else {


            }
        }
        else if (this.CdmId != null && ec.Excludes("cdmId",true))
        {
            this.CdmId = null;
        }
        //      C# -> DateTime? CreationDate
        // GraphQL -> creationDate: DateTime (scalar)
        if (ec.Includes("creationDate",true))
        {
            if(this.CreationDate == null) {

                this.CreationDate = new DateTime();

            } else {


            }
        }
        else if (this.CreationDate != null && ec.Excludes("creationDate",true))
        {
            this.CreationDate = null;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (ec.Includes("fid",true))
        {
            if(this.Fid == null) {

                this.Fid = "FETCH";

            } else {


            }
        }
        else if (this.Fid != null && ec.Excludes("fid",true))
        {
            this.Fid = null;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (ec.Includes("isReady",true))
        {
            if(this.IsReady == null) {

                this.IsReady = true;

            } else {


            }
        }
        else if (this.IsReady != null && ec.Excludes("isReady",true))
        {
            this.IsReady = null;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String! (scalar)
        if (ec.Includes("mountRequestId",true))
        {
            if(this.MountRequestId == null) {

                this.MountRequestId = "FETCH";

            } else {


            }
        }
        else if (this.MountRequestId != null && ec.Excludes("mountRequestId",true))
        {
            this.MountRequestId = null;
        }
        //      C# -> System.String? MountedDatabaseId
        // GraphQL -> mountedDatabaseId: String! (scalar)
        if (ec.Includes("mountedDatabaseId",true))
        {
            if(this.MountedDatabaseId == null) {

                this.MountedDatabaseId = "FETCH";

            } else {


            }
        }
        else if (this.MountedDatabaseId != null && ec.Excludes("mountedDatabaseId",true))
        {
            this.MountedDatabaseId = null;
        }
        //      C# -> System.String? MountedDatabaseName
        // GraphQL -> mountedDatabaseName: String! (scalar)
        if (ec.Includes("mountedDatabaseName",true))
        {
            if(this.MountedDatabaseName == null) {

                this.MountedDatabaseName = "FETCH";

            } else {


            }
        }
        else if (this.MountedDatabaseName != null && ec.Excludes("mountedDatabaseName",true))
        {
            this.MountedDatabaseName = null;
        }
        //      C# -> System.String? OwnerId
        // GraphQL -> ownerId: String! (scalar)
        if (ec.Includes("ownerId",true))
        {
            if(this.OwnerId == null) {

                this.OwnerId = "FETCH";

            } else {


            }
        }
        else if (this.OwnerId != null && ec.Excludes("ownerId",true))
        {
            this.OwnerId = null;
        }
        //      C# -> DateTime? RecoveryPoint
        // GraphQL -> recoveryPoint: DateTime (scalar)
        if (ec.Includes("recoveryPoint",true))
        {
            if(this.RecoveryPoint == null) {

                this.RecoveryPoint = new DateTime();

            } else {


            }
        }
        else if (this.RecoveryPoint != null && ec.Excludes("recoveryPoint",true))
        {
            this.RecoveryPoint = null;
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String! (scalar)
        if (ec.Includes("unmountRequestId",true))
        {
            if(this.UnmountRequestId == null) {

                this.UnmountRequestId = "FETCH";

            } else {


            }
        }
        else if (this.UnmountRequestId != null && ec.Excludes("unmountRequestId",true))
        {
            this.UnmountRequestId = null;
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
        //      C# -> MssqlDatabase? SourceDatabase
        // GraphQL -> sourceDatabase: MssqlDatabase (type)
        if (ec.Includes("sourceDatabase",false))
        {
            if(this.SourceDatabase == null) {

                this.SourceDatabase = new MssqlDatabase();
                this.SourceDatabase.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatabase"));

            } else {

                this.SourceDatabase.ApplyExploratoryFieldSpec(ec.NewChild("sourceDatabase"));

            }
        }
        else if (this.SourceDatabase != null && ec.Excludes("sourceDatabase",false))
        {
            this.SourceDatabase = null;
        }
        //      C# -> MssqlInstance? TargetInstance
        // GraphQL -> targetInstance: MssqlInstance (type)
        if (ec.Includes("targetInstance",false))
        {
            if(this.TargetInstance == null) {

                this.TargetInstance = new MssqlInstance();
                this.TargetInstance.ApplyExploratoryFieldSpec(ec.NewChild("targetInstance"));

            } else {

                this.TargetInstance.ApplyExploratoryFieldSpec(ec.NewChild("targetInstance"));

            }
        }
        else if (this.TargetInstance != null && ec.Excludes("targetInstance",false))
        {
            this.TargetInstance = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MssqlDatabaseLiveMount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MssqlDatabaseLiveMount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MssqlDatabaseLiveMount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types