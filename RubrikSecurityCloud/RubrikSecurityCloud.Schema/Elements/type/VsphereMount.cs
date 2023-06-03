// VsphereMount.cs
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
    #region VsphereMount
    public class VsphereMount: BaseType
    {
        #region members

        //      C# -> VsphereMountStatus? Status
        // GraphQL -> status: VsphereMountStatus! (enum)
        [JsonProperty("status")]
        public VsphereMountStatus? Status { get; set; }

        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        [JsonProperty("attachingDiskCount")]
        public System.Int32? AttachingDiskCount { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        [JsonProperty("clusterName")]
        public System.String? ClusterName { get; set; }

        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        [JsonProperty("hasAttachingDisk")]
        public System.Boolean? HasAttachingDisk { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        [JsonProperty("isReady")]
        public System.Boolean? IsReady { get; set; }

        //      C# -> System.String? MigrateDatastoreRequestId
        // GraphQL -> migrateDatastoreRequestId: String (scalar)
        [JsonProperty("migrateDatastoreRequestId")]
        public System.String? MigrateDatastoreRequestId { get; set; }

        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        [JsonProperty("mountRequestId")]
        public System.String? MountRequestId { get; set; }

        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        [JsonProperty("mountTimestamp")]
        public DateTime? MountTimestamp { get; set; }

        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        [JsonProperty("newVmName")]
        public System.String? NewVmName { get; set; }

        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        [JsonProperty("unmountRequestId")]
        public System.String? UnmountRequestId { get; set; }

        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        [JsonProperty("authorizedOperations")]
        public AuthorizedOperations? AuthorizedOperations { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> VsphereHost? Host
        // GraphQL -> host: VsphereHost (type)
        [JsonProperty("host")]
        public VsphereHost? Host { get; set; }

        //      C# -> VsphereVm? NewVm
        // GraphQL -> newVm: VsphereVm (type)
        [JsonProperty("newVm")]
        public VsphereVm? NewVm { get; set; }

        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        [JsonProperty("sourceSnapshot")]
        public CdmSnapshot? SourceSnapshot { get; set; }

        //      C# -> VsphereVm? SourceVm
        // GraphQL -> sourceVm: VsphereVm (type)
        [JsonProperty("sourceVm")]
        public VsphereVm? SourceVm { get; set; }


        #endregion

    #region methods

    public VsphereMount Set(
        VsphereMountStatus? Status = null,
        System.Int32? AttachingDiskCount = null,
        System.String? CdmId = null,
        System.String? ClusterName = null,
        System.Boolean? HasAttachingDisk = null,
        System.String? Id = null,
        System.Boolean? IsReady = null,
        System.String? MigrateDatastoreRequestId = null,
        System.String? MountRequestId = null,
        DateTime? MountTimestamp = null,
        System.String? NewVmName = null,
        System.String? UnmountRequestId = null,
        AuthorizedOperations? AuthorizedOperations = null,
        Cluster? Cluster = null,
        VsphereHost? Host = null,
        VsphereVm? NewVm = null,
        CdmSnapshot? SourceSnapshot = null,
        VsphereVm? SourceVm = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( AttachingDiskCount != null ) {
            this.AttachingDiskCount = AttachingDiskCount;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterName != null ) {
            this.ClusterName = ClusterName;
        }
        if ( HasAttachingDisk != null ) {
            this.HasAttachingDisk = HasAttachingDisk;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsReady != null ) {
            this.IsReady = IsReady;
        }
        if ( MigrateDatastoreRequestId != null ) {
            this.MigrateDatastoreRequestId = MigrateDatastoreRequestId;
        }
        if ( MountRequestId != null ) {
            this.MountRequestId = MountRequestId;
        }
        if ( MountTimestamp != null ) {
            this.MountTimestamp = MountTimestamp;
        }
        if ( NewVmName != null ) {
            this.NewVmName = NewVmName;
        }
        if ( UnmountRequestId != null ) {
            this.UnmountRequestId = UnmountRequestId;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( NewVm != null ) {
            this.NewVm = NewVm;
        }
        if ( SourceSnapshot != null ) {
            this.SourceSnapshot = SourceSnapshot;
        }
        if ( SourceVm != null ) {
            this.SourceVm = SourceVm;
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
        //      C# -> VsphereMountStatus? Status
        // GraphQL -> status: VsphereMountStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        if (this.AttachingDiskCount != null) {
            s += ind + "attachingDiskCount\n" ;
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName != null) {
            s += ind + "clusterName\n" ;
        }
        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        if (this.HasAttachingDisk != null) {
            s += ind + "hasAttachingDisk\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady != null) {
            s += ind + "isReady\n" ;
        }
        //      C# -> System.String? MigrateDatastoreRequestId
        // GraphQL -> migrateDatastoreRequestId: String (scalar)
        if (this.MigrateDatastoreRequestId != null) {
            s += ind + "migrateDatastoreRequestId\n" ;
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId != null) {
            s += ind + "mountRequestId\n" ;
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp != null) {
            s += ind + "mountTimestamp\n" ;
        }
        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        if (this.NewVmName != null) {
            s += ind + "newVmName\n" ;
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId != null) {
            s += ind + "unmountRequestId\n" ;
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations {\n" + this.AuthorizedOperations.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> VsphereHost? Host
        // GraphQL -> host: VsphereHost (type)
        if (this.Host != null) {
            s += ind + "host {\n" + this.Host.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> VsphereVm? NewVm
        // GraphQL -> newVm: VsphereVm (type)
        if (this.NewVm != null) {
            s += ind + "newVm {\n" + this.NewVm.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        if (this.SourceSnapshot != null) {
            s += ind + "sourceSnapshot {\n" + this.SourceSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> VsphereVm? SourceVm
        // GraphQL -> sourceVm: VsphereVm (type)
        if (this.SourceVm != null) {
            s += ind + "sourceVm {\n" + this.SourceVm.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> VsphereMountStatus? Status
        // GraphQL -> status: VsphereMountStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new VsphereMountStatus();
        }
        //      C# -> System.Int32? AttachingDiskCount
        // GraphQL -> attachingDiskCount: Int (scalar)
        if (this.AttachingDiskCount == null && Exploration.Includes(parent + ".attachingDiskCount", true))
        {
            this.AttachingDiskCount = new System.Int32();
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = new System.String("FETCH");
        }
        //      C# -> System.String? ClusterName
        // GraphQL -> clusterName: String! (scalar)
        if (this.ClusterName == null && Exploration.Includes(parent + ".clusterName", true))
        {
            this.ClusterName = new System.String("FETCH");
        }
        //      C# -> System.Boolean? HasAttachingDisk
        // GraphQL -> hasAttachingDisk: Boolean (scalar)
        if (this.HasAttachingDisk == null && Exploration.Includes(parent + ".hasAttachingDisk", true))
        {
            this.HasAttachingDisk = true;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsReady
        // GraphQL -> isReady: Boolean! (scalar)
        if (this.IsReady == null && Exploration.Includes(parent + ".isReady", true))
        {
            this.IsReady = true;
        }
        //      C# -> System.String? MigrateDatastoreRequestId
        // GraphQL -> migrateDatastoreRequestId: String (scalar)
        if (this.MigrateDatastoreRequestId == null && Exploration.Includes(parent + ".migrateDatastoreRequestId", true))
        {
            this.MigrateDatastoreRequestId = new System.String("FETCH");
        }
        //      C# -> System.String? MountRequestId
        // GraphQL -> mountRequestId: String (scalar)
        if (this.MountRequestId == null && Exploration.Includes(parent + ".mountRequestId", true))
        {
            this.MountRequestId = new System.String("FETCH");
        }
        //      C# -> DateTime? MountTimestamp
        // GraphQL -> mountTimestamp: DateTime (scalar)
        if (this.MountTimestamp == null && Exploration.Includes(parent + ".mountTimestamp", true))
        {
            this.MountTimestamp = new DateTime();
        }
        //      C# -> System.String? NewVmName
        // GraphQL -> newVmName: String (scalar)
        if (this.NewVmName == null && Exploration.Includes(parent + ".newVmName", true))
        {
            this.NewVmName = new System.String("FETCH");
        }
        //      C# -> System.String? UnmountRequestId
        // GraphQL -> unmountRequestId: String (scalar)
        if (this.UnmountRequestId == null && Exploration.Includes(parent + ".unmountRequestId", true))
        {
            this.UnmountRequestId = new System.String("FETCH");
        }
        //      C# -> AuthorizedOperations? AuthorizedOperations
        // GraphQL -> authorizedOperations: AuthorizedOperations! (type)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations"))
        {
            this.AuthorizedOperations = new AuthorizedOperations();
            this.AuthorizedOperations.ApplyExploratoryFieldSpec(parent + ".authorizedOperations");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> VsphereHost? Host
        // GraphQL -> host: VsphereHost (type)
        if (this.Host == null && Exploration.Includes(parent + ".host"))
        {
            this.Host = new VsphereHost();
            this.Host.ApplyExploratoryFieldSpec(parent + ".host");
        }
        //      C# -> VsphereVm? NewVm
        // GraphQL -> newVm: VsphereVm (type)
        if (this.NewVm == null && Exploration.Includes(parent + ".newVm"))
        {
            this.NewVm = new VsphereVm();
            this.NewVm.ApplyExploratoryFieldSpec(parent + ".newVm");
        }
        //      C# -> CdmSnapshot? SourceSnapshot
        // GraphQL -> sourceSnapshot: CdmSnapshot (type)
        if (this.SourceSnapshot == null && Exploration.Includes(parent + ".sourceSnapshot"))
        {
            this.SourceSnapshot = new CdmSnapshot();
            this.SourceSnapshot.ApplyExploratoryFieldSpec(parent + ".sourceSnapshot");
        }
        //      C# -> VsphereVm? SourceVm
        // GraphQL -> sourceVm: VsphereVm (type)
        if (this.SourceVm == null && Exploration.Includes(parent + ".sourceVm"))
        {
            this.SourceVm = new VsphereVm();
            this.SourceVm.ApplyExploratoryFieldSpec(parent + ".sourceVm");
        }
    }


    #endregion

    } // class VsphereMount
    
    #endregion

    public static class ListVsphereMountExtensions
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
            this List<VsphereMount> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VsphereMount> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VsphereMount());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types