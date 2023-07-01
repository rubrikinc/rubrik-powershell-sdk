// ClusterDisk.cs
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
    #region ClusterDisk
    public class ClusterDisk: BaseType
    {
        #region members

        //      C# -> ClusterDiskType? DiskType
        // GraphQL -> diskType: ClusterDiskType! (enum)
        [JsonProperty("diskType")]
        public ClusterDiskType? DiskType { get; set; }

        //      C# -> ClusterDiskStatus? Status
        // GraphQL -> status: ClusterDiskStatus! (enum)
        [JsonProperty("status")]
        public ClusterDiskStatus? Status { get; set; }

        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        [JsonProperty("capacityBytes")]
        public System.Int64? CapacityBytes { get; set; }

        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        [JsonProperty("clusterId")]
        public System.String? ClusterId { get; set; }

        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        [JsonProperty("diskId")]
        public System.String? DiskId { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsEncrypted
        // GraphQL -> isEncrypted: Boolean! (scalar)
        [JsonProperty("isEncrypted")]
        public System.Boolean? IsEncrypted { get; set; }

        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean! (scalar)
        [JsonProperty("isResizable")]
        public System.Boolean? IsResizable { get; set; }

        //      C# -> System.Boolean? LedStatus
        // GraphQL -> ledStatus: Boolean (scalar)
        [JsonProperty("ledStatus")]
        public System.Boolean? LedStatus { get; set; }

        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        [JsonProperty("nodeId")]
        public System.String? NodeId { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> System.String? Serial
        // GraphQL -> serial: String (scalar)
        [JsonProperty("serial")]
        public System.String? Serial { get; set; }

        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        [JsonProperty("unallocatedBytes")]
        public System.Int64? UnallocatedBytes { get; set; }

        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        [JsonProperty("usableBytes")]
        public System.Int64? UsableBytes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterDisk";
    }

    public ClusterDisk Set(
        ClusterDiskType? DiskType = null,
        ClusterDiskStatus? Status = null,
        System.Int64? CapacityBytes = null,
        System.String? ClusterId = null,
        System.String? DiskId = null,
        System.String? Id = null,
        System.Boolean? IsEncrypted = null,
        System.Boolean? IsResizable = null,
        System.Boolean? LedStatus = null,
        System.String? NodeId = null,
        System.String? Path = null,
        System.String? Serial = null,
        System.Int64? UnallocatedBytes = null,
        System.Int64? UsableBytes = null
    ) 
    {
        if ( DiskType != null ) {
            this.DiskType = DiskType;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( CapacityBytes != null ) {
            this.CapacityBytes = CapacityBytes;
        }
        if ( ClusterId != null ) {
            this.ClusterId = ClusterId;
        }
        if ( DiskId != null ) {
            this.DiskId = DiskId;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsEncrypted != null ) {
            this.IsEncrypted = IsEncrypted;
        }
        if ( IsResizable != null ) {
            this.IsResizable = IsResizable;
        }
        if ( LedStatus != null ) {
            this.LedStatus = LedStatus;
        }
        if ( NodeId != null ) {
            this.NodeId = NodeId;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Serial != null ) {
            this.Serial = Serial;
        }
        if ( UnallocatedBytes != null ) {
            this.UnallocatedBytes = UnallocatedBytes;
        }
        if ( UsableBytes != null ) {
            this.UsableBytes = UsableBytes;
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
        //      C# -> ClusterDiskType? DiskType
        // GraphQL -> diskType: ClusterDiskType! (enum)
        if (this.DiskType != null) {
            s += ind + "diskType\n" ;
        }
        //      C# -> ClusterDiskStatus? Status
        // GraphQL -> status: ClusterDiskStatus! (enum)
        if (this.Status != null) {
            s += ind + "status\n" ;
        }
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        if (this.CapacityBytes != null) {
            s += ind + "capacityBytes\n" ;
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId != null) {
            s += ind + "clusterId\n" ;
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId != null) {
            s += ind + "diskId\n" ;
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
        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean! (scalar)
        if (this.IsResizable != null) {
            s += ind + "isResizable\n" ;
        }
        //      C# -> System.Boolean? LedStatus
        // GraphQL -> ledStatus: Boolean (scalar)
        if (this.LedStatus != null) {
            s += ind + "ledStatus\n" ;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        if (this.NodeId != null) {
            s += ind + "nodeId\n" ;
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            s += ind + "path\n" ;
        }
        //      C# -> System.String? Serial
        // GraphQL -> serial: String (scalar)
        if (this.Serial != null) {
            s += ind + "serial\n" ;
        }
        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        if (this.UnallocatedBytes != null) {
            s += ind + "unallocatedBytes\n" ;
        }
        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        if (this.UsableBytes != null) {
            s += ind + "usableBytes\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ClusterDiskType? DiskType
        // GraphQL -> diskType: ClusterDiskType! (enum)
        if (this.DiskType == null && Exploration.Includes(parent + ".diskType", true))
        {
            this.DiskType = new ClusterDiskType();
        }
        //      C# -> ClusterDiskStatus? Status
        // GraphQL -> status: ClusterDiskStatus! (enum)
        if (this.Status == null && Exploration.Includes(parent + ".status", true))
        {
            this.Status = new ClusterDiskStatus();
        }
        //      C# -> System.Int64? CapacityBytes
        // GraphQL -> capacityBytes: Long! (scalar)
        if (this.CapacityBytes == null && Exploration.Includes(parent + ".capacityBytes", true))
        {
            this.CapacityBytes = new System.Int64();
        }
        //      C# -> System.String? ClusterId
        // GraphQL -> clusterId: UUID! (scalar)
        if (this.ClusterId == null && Exploration.Includes(parent + ".clusterId", true))
        {
            this.ClusterId = "FETCH";
        }
        //      C# -> System.String? DiskId
        // GraphQL -> diskId: String! (scalar)
        if (this.DiskId == null && Exploration.Includes(parent + ".diskId", true))
        {
            this.DiskId = "FETCH";
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
        //      C# -> System.Boolean? IsResizable
        // GraphQL -> isResizable: Boolean! (scalar)
        if (this.IsResizable == null && Exploration.Includes(parent + ".isResizable", true))
        {
            this.IsResizable = true;
        }
        //      C# -> System.Boolean? LedStatus
        // GraphQL -> ledStatus: Boolean (scalar)
        if (this.LedStatus == null && Exploration.Includes(parent + ".ledStatus", true))
        {
            this.LedStatus = true;
        }
        //      C# -> System.String? NodeId
        // GraphQL -> nodeId: String (scalar)
        if (this.NodeId == null && Exploration.Includes(parent + ".nodeId", true))
        {
            this.NodeId = "FETCH";
        }
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path == null && Exploration.Includes(parent + ".path", true))
        {
            this.Path = "FETCH";
        }
        //      C# -> System.String? Serial
        // GraphQL -> serial: String (scalar)
        if (this.Serial == null && Exploration.Includes(parent + ".serial", true))
        {
            this.Serial = "FETCH";
        }
        //      C# -> System.Int64? UnallocatedBytes
        // GraphQL -> unallocatedBytes: Long (scalar)
        if (this.UnallocatedBytes == null && Exploration.Includes(parent + ".unallocatedBytes", true))
        {
            this.UnallocatedBytes = new System.Int64();
        }
        //      C# -> System.Int64? UsableBytes
        // GraphQL -> usableBytes: Long (scalar)
        if (this.UsableBytes == null && Exploration.Includes(parent + ".usableBytes", true))
        {
            this.UsableBytes = new System.Int64();
        }
    }


    #endregion

    } // class ClusterDisk
    
    #endregion

    public static class ListClusterDiskExtensions
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
            this List<ClusterDisk> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterDisk> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterDisk());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types