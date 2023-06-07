// RansomwareResult.cs
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
    #region RansomwareResult
    public class RansomwareResult: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Single? EncryptionProbability
        // GraphQL -> encryptionProbability: Float! (scalar)
        [JsonProperty("encryptionProbability")]
        public System.Single? EncryptionProbability { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        [JsonProperty("managedId")]
        public System.String? ManagedId { get; set; }

        //      C# -> DateTime? SnapshotData
        // GraphQL -> snapshotData: DateTime! (scalar)
        [JsonProperty("snapshotData")]
        public DateTime? SnapshotData { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }


        #endregion

    #region methods

    public RansomwareResult Set(
        System.String? ClusterUuid = null,
        System.Single? EncryptionProbability = null,
        System.String? Id = null,
        System.Boolean? IsEncrypted = null,
        System.String? ManagedId = null,
        DateTime? SnapshotData = null,
        System.String? SnapshotFid = null,
        System.String? SnapshotId = null,
        System.String? WorkloadId = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( EncryptionProbability != null ) {
            this.EncryptionProbability = EncryptionProbability;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( ManagedId != null ) {
            this.ManagedId = ManagedId;
        }
        if ( SnapshotData != null ) {
            this.SnapshotData = SnapshotData;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.Single? EncryptionProbability
        // GraphQL -> encryptionProbability: Float! (scalar)
        if (this.EncryptionProbability != null) {
            s += ind + "encryptionProbability\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted != null) {
            s += ind + "isEncrypted\n" ;
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId != null) {
            s += ind + "managedId\n" ;
        }
        //      C# -> DateTime? SnapshotData
        // GraphQL -> snapshotData: DateTime! (scalar)
        if (this.SnapshotData != null) {
            s += ind + "snapshotData\n" ;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            s += ind + "snapshotFid\n" ;
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId != null) {
            s += ind + "snapshotId\n" ;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            s += ind + "workloadId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.Single? EncryptionProbability
        // GraphQL -> encryptionProbability: Float! (scalar)
        if (this.EncryptionProbability == null && Exploration.Includes(parent + ".encryptionProbability", true))
        {
            this.EncryptionProbability = new System.Single();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        if (this.IsEncrypted == null && Exploration.Includes(parent + ".isEncrypted", true))
        {
            this.IsEncrypted = true;
        }
        //      C# -> System.String? ManagedId
        // GraphQL -> managedId: String! (scalar)
        if (this.ManagedId == null && Exploration.Includes(parent + ".managedId", true))
        {
            this.ManagedId = "FETCH";
        }
        //      C# -> DateTime? SnapshotData
        // GraphQL -> snapshotData: DateTime! (scalar)
        if (this.SnapshotData == null && Exploration.Includes(parent + ".snapshotData", true))
        {
            this.SnapshotData = new DateTime();
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid == null && Exploration.Includes(parent + ".snapshotFid", true))
        {
            this.SnapshotFid = "FETCH";
        }
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: String! (scalar)
        if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId", true))
        {
            this.SnapshotId = "FETCH";
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId == null && Exploration.Includes(parent + ".workloadId", true))
        {
            this.WorkloadId = "FETCH";
        }
    }


    #endregion

    } // class RansomwareResult
    
    #endregion

    public static class ListRansomwareResultExtensions
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
            this List<RansomwareResult> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<RansomwareResult> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new RansomwareResult());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types