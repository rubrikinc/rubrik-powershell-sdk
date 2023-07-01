// MosaicStorageLocation.cs
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
    #region MosaicStorageLocation
    public class MosaicStorageLocation: BaseType
    {
        #region members

        //      C# -> MosaicStoreConnectionStatus? StoreConnectionStatus
        // GraphQL -> storeConnectionStatus: MosaicStoreConnectionStatus! (enum)
        [JsonProperty("storeConnectionStatus")]
        public MosaicStoreConnectionStatus? StoreConnectionStatus { get; set; }

        //      C# -> MosaicStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreType! (enum)
        [JsonProperty("storeType")]
        public MosaicStoreType? StoreType { get; set; }

        //      C# -> System.Int32? BackupCount
        // GraphQL -> backupCount: Int! (scalar)
        [JsonProperty("backupCount")]
        public System.Int32? BackupCount { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> System.String? GeographicLocation
        // GraphQL -> geographicLocation: String! (scalar)
        [JsonProperty("geographicLocation")]
        public System.String? GeographicLocation { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Int64? SpaceConsumedBytes
        // GraphQL -> spaceConsumedBytes: Long! (scalar)
        [JsonProperty("spaceConsumedBytes")]
        public System.Int64? SpaceConsumedBytes { get; set; }

        //      C# -> System.String? StorageLocationName
        // GraphQL -> storageLocationName: String! (scalar)
        [JsonProperty("storageLocationName")]
        public System.String? StorageLocationName { get; set; }

        //      C# -> MosaicStoreConnectionParameters? ConnectionParameters
        // GraphQL -> connectionParameters: MosaicStoreConnectionParameters (type)
        [JsonProperty("connectionParameters")]
        public MosaicStoreConnectionParameters? ConnectionParameters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MosaicStorageLocation";
    }

    public MosaicStorageLocation Set(
        MosaicStoreConnectionStatus? StoreConnectionStatus = null,
        MosaicStoreType? StoreType = null,
        System.Int32? BackupCount = null,
        System.String? ClusterUuid = null,
        System.String? Fid = null,
        System.String? GeographicLocation = null,
        System.String? Id = null,
        System.Int64? SpaceConsumedBytes = null,
        System.String? StorageLocationName = null,
        MosaicStoreConnectionParameters? ConnectionParameters = null
    ) 
    {
        if ( StoreConnectionStatus != null ) {
            this.StoreConnectionStatus = StoreConnectionStatus;
        }
        if ( StoreType != null ) {
            this.StoreType = StoreType;
        }
        if ( BackupCount != null ) {
            this.BackupCount = BackupCount;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Fid != null ) {
            this.Fid = Fid;
        }
        if ( GeographicLocation != null ) {
            this.GeographicLocation = GeographicLocation;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( SpaceConsumedBytes != null ) {
            this.SpaceConsumedBytes = SpaceConsumedBytes;
        }
        if ( StorageLocationName != null ) {
            this.StorageLocationName = StorageLocationName;
        }
        if ( ConnectionParameters != null ) {
            this.ConnectionParameters = ConnectionParameters;
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
        //      C# -> MosaicStoreConnectionStatus? StoreConnectionStatus
        // GraphQL -> storeConnectionStatus: MosaicStoreConnectionStatus! (enum)
        if (this.StoreConnectionStatus != null) {
            s += ind + "storeConnectionStatus\n" ;
        }
        //      C# -> MosaicStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreType! (enum)
        if (this.StoreType != null) {
            s += ind + "storeType\n" ;
        }
        //      C# -> System.Int32? BackupCount
        // GraphQL -> backupCount: Int! (scalar)
        if (this.BackupCount != null) {
            s += ind + "backupCount\n" ;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid != null) {
            s += ind + "fid\n" ;
        }
        //      C# -> System.String? GeographicLocation
        // GraphQL -> geographicLocation: String! (scalar)
        if (this.GeographicLocation != null) {
            s += ind + "geographicLocation\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Int64? SpaceConsumedBytes
        // GraphQL -> spaceConsumedBytes: Long! (scalar)
        if (this.SpaceConsumedBytes != null) {
            s += ind + "spaceConsumedBytes\n" ;
        }
        //      C# -> System.String? StorageLocationName
        // GraphQL -> storageLocationName: String! (scalar)
        if (this.StorageLocationName != null) {
            s += ind + "storageLocationName\n" ;
        }
        //      C# -> MosaicStoreConnectionParameters? ConnectionParameters
        // GraphQL -> connectionParameters: MosaicStoreConnectionParameters (type)
        if (this.ConnectionParameters != null) {
            var fspec = this.ConnectionParameters.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "connectionParameters {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> MosaicStoreConnectionStatus? StoreConnectionStatus
        // GraphQL -> storeConnectionStatus: MosaicStoreConnectionStatus! (enum)
        if (this.StoreConnectionStatus == null && Exploration.Includes(parent + ".storeConnectionStatus", true))
        {
            this.StoreConnectionStatus = new MosaicStoreConnectionStatus();
        }
        //      C# -> MosaicStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreType! (enum)
        if (this.StoreType == null && Exploration.Includes(parent + ".storeType", true))
        {
            this.StoreType = new MosaicStoreType();
        }
        //      C# -> System.Int32? BackupCount
        // GraphQL -> backupCount: Int! (scalar)
        if (this.BackupCount == null && Exploration.Includes(parent + ".backupCount", true))
        {
            this.BackupCount = Int32.MinValue;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? Fid
        // GraphQL -> fid: String! (scalar)
        if (this.Fid == null && Exploration.Includes(parent + ".fid", true))
        {
            this.Fid = "FETCH";
        }
        //      C# -> System.String? GeographicLocation
        // GraphQL -> geographicLocation: String! (scalar)
        if (this.GeographicLocation == null && Exploration.Includes(parent + ".geographicLocation", true))
        {
            this.GeographicLocation = "FETCH";
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = "FETCH";
        }
        //      C# -> System.Int64? SpaceConsumedBytes
        // GraphQL -> spaceConsumedBytes: Long! (scalar)
        if (this.SpaceConsumedBytes == null && Exploration.Includes(parent + ".spaceConsumedBytes", true))
        {
            this.SpaceConsumedBytes = new System.Int64();
        }
        //      C# -> System.String? StorageLocationName
        // GraphQL -> storageLocationName: String! (scalar)
        if (this.StorageLocationName == null && Exploration.Includes(parent + ".storageLocationName", true))
        {
            this.StorageLocationName = "FETCH";
        }
        //      C# -> MosaicStoreConnectionParameters? ConnectionParameters
        // GraphQL -> connectionParameters: MosaicStoreConnectionParameters (type)
        if (this.ConnectionParameters == null && Exploration.Includes(parent + ".connectionParameters"))
        {
            this.ConnectionParameters = new MosaicStoreConnectionParameters();
            this.ConnectionParameters.ApplyExploratoryFieldSpec(parent + ".connectionParameters");
        }
    }


    #endregion

    } // class MosaicStorageLocation
    
    #endregion

    public static class ListMosaicStorageLocationExtensions
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
            this List<MosaicStorageLocation> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicStorageLocation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicStorageLocation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types