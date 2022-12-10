// MosaicStorageLocation.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:24.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Rubrik.SecurityCloud.Types
{
    #region MosaicStorageLocation
    public class MosaicStorageLocation: IFragment
    {
        #region members
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

        //      C# -> MosaicStoreConnectionStatus? StoreConnectionStatus
        // GraphQL -> storeConnectionStatus: MosaicStoreConnectionStatus! (enum)
        [JsonProperty("storeConnectionStatus")]
        public MosaicStoreConnectionStatus? StoreConnectionStatus { get; set; }

        //      C# -> MosaicStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreType! (enum)
        [JsonProperty("storeType")]
        public MosaicStoreType? StoreType { get; set; }

        #endregion

    #region methods

    public MosaicStorageLocation Set(
        System.Int32? BackupCount = null,
        System.String? ClusterUuid = null,
        System.String? Fid = null,
        System.String? GeographicLocation = null,
        System.String? Id = null,
        System.Int64? SpaceConsumedBytes = null,
        System.String? StorageLocationName = null,
        MosaicStoreConnectionParameters? ConnectionParameters = null,
        MosaicStoreConnectionStatus? StoreConnectionStatus = null,
        MosaicStoreType? StoreType = null
    ) 
    {
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
        if ( StoreConnectionStatus != null ) {
            this.StoreConnectionStatus = StoreConnectionStatus;
        }
        if ( StoreType != null ) {
            this.StoreType = StoreType;
        }
        return this;
    }

            //[JsonIgnore]
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.Int32? BackupCount
            // GraphQL -> backupCount: Int! (scalar)
            if (this.BackupCount != null)
            {
                 s += ind + "backupCount\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: String! (scalar)
            if (this.Fid != null)
            {
                 s += ind + "fid\n";

            }
            //      C# -> System.String? GeographicLocation
            // GraphQL -> geographicLocation: String! (scalar)
            if (this.GeographicLocation != null)
            {
                 s += ind + "geographicLocation\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.Int64? SpaceConsumedBytes
            // GraphQL -> spaceConsumedBytes: Long! (scalar)
            if (this.SpaceConsumedBytes != null)
            {
                 s += ind + "spaceConsumedBytes\n";

            }
            //      C# -> System.String? StorageLocationName
            // GraphQL -> storageLocationName: String! (scalar)
            if (this.StorageLocationName != null)
            {
                 s += ind + "storageLocationName\n";

            }
            //      C# -> MosaicStoreConnectionParameters? ConnectionParameters
            // GraphQL -> connectionParameters: MosaicStoreConnectionParameters (type)
            if (this.ConnectionParameters != null)
            {
                 s += ind + "connectionParameters\n";

                 s += ind + "{\n" + 
                 this.ConnectionParameters.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> MosaicStoreConnectionStatus? StoreConnectionStatus
            // GraphQL -> storeConnectionStatus: MosaicStoreConnectionStatus! (enum)
            if (this.StoreConnectionStatus != null)
            {
                 s += ind + "storeConnectionStatus\n";

            }
            //      C# -> MosaicStoreType? StoreType
            // GraphQL -> storeType: MosaicStoreType! (enum)
            if (this.StoreType != null)
            {
                 s += ind + "storeType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? BackupCount
            // GraphQL -> backupCount: Int! (scalar)
            if (this.BackupCount == null && Exploration.Includes(parent + ".backupCount$"))
            {
                this.BackupCount = new System.Int32();
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? Fid
            // GraphQL -> fid: String! (scalar)
            if (this.Fid == null && Exploration.Includes(parent + ".fid$"))
            {
                this.Fid = new System.String("FETCH");
            }
            //      C# -> System.String? GeographicLocation
            // GraphQL -> geographicLocation: String! (scalar)
            if (this.GeographicLocation == null && Exploration.Includes(parent + ".geographicLocation$"))
            {
                this.GeographicLocation = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.Int64? SpaceConsumedBytes
            // GraphQL -> spaceConsumedBytes: Long! (scalar)
            if (this.SpaceConsumedBytes == null && Exploration.Includes(parent + ".spaceConsumedBytes$"))
            {
                this.SpaceConsumedBytes = new System.Int64();
            }
            //      C# -> System.String? StorageLocationName
            // GraphQL -> storageLocationName: String! (scalar)
            if (this.StorageLocationName == null && Exploration.Includes(parent + ".storageLocationName$"))
            {
                this.StorageLocationName = new System.String("FETCH");
            }
            //      C# -> MosaicStoreConnectionParameters? ConnectionParameters
            // GraphQL -> connectionParameters: MosaicStoreConnectionParameters (type)
            if (this.ConnectionParameters == null && Exploration.Includes(parent + ".connectionParameters"))
            {
                this.ConnectionParameters = new MosaicStoreConnectionParameters();
                this.ConnectionParameters.ApplyExploratoryFragment(parent + ".connectionParameters");
            }
            //      C# -> MosaicStoreConnectionStatus? StoreConnectionStatus
            // GraphQL -> storeConnectionStatus: MosaicStoreConnectionStatus! (enum)
            if (this.StoreConnectionStatus == null && Exploration.Includes(parent + ".storeConnectionStatus$"))
            {
                this.StoreConnectionStatus = new MosaicStoreConnectionStatus();
            }
            //      C# -> MosaicStoreType? StoreType
            // GraphQL -> storeType: MosaicStoreType! (enum)
            if (this.StoreType == null && Exploration.Includes(parent + ".storeType$"))
            {
                this.StoreType = new MosaicStoreType();
            }
        }


    #endregion

    } // class MosaicStorageLocation
    #endregion

    public static class ListMosaicStorageLocationExtensions
    {
        // This SDK uses the convention of defining fragments by
        // _un-null-ing_ fields in an object of the type of the fragment
        // we want to create. When creating a fragment from an object,
        // all fields (including nested objects) that are not null are
        // included in the fragment. When creating a fragment from a list,
        // there is possibly a different fragment with each item in the list,
        // but the GraphQL syntax for list fragment is identical to
        // object fragment, so we have to decide how to generate the fragment.
        // We choose to generate a fragment that includes all fields that are
        // not null in the *first* item in the list. This is not a perfect
        // solution, but it is a reasonable one.
        public static string AsFragment(
            this List<MosaicStorageLocation> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MosaicStorageLocation> list, 
            String parent = "")
        {
            var item = new MosaicStorageLocation();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types