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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> MosaicStoreConnectionStatus? StoreConnectionStatus
        // GraphQL -> storeConnectionStatus: MosaicStoreConnectionStatus! (enum)
        if (this.StoreConnectionStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storeConnectionStatus\n" ;
            } else {
                s += ind + "storeConnectionStatus\n" ;
            }
        }
        //      C# -> MosaicStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreType! (enum)
        if (this.StoreType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storeType\n" ;
            } else {
                s += ind + "storeType\n" ;
            }
        }
        //      C# -> System.Int32? BackupCount
        // GraphQL -> backupCount: Int! (scalar)
        if (this.BackupCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "backupCount\n" ;
            } else {
                s += ind + "backupCount\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
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
        //      C# -> System.String? GeographicLocation
        // GraphQL -> geographicLocation: String! (scalar)
        if (this.GeographicLocation != null) {
            if (conf.Flat) {
                s += conf.Prefix + "geographicLocation\n" ;
            } else {
                s += ind + "geographicLocation\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Int64? SpaceConsumedBytes
        // GraphQL -> spaceConsumedBytes: Long! (scalar)
        if (this.SpaceConsumedBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "spaceConsumedBytes\n" ;
            } else {
                s += ind + "spaceConsumedBytes\n" ;
            }
        }
        //      C# -> System.String? StorageLocationName
        // GraphQL -> storageLocationName: String! (scalar)
        if (this.StorageLocationName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storageLocationName\n" ;
            } else {
                s += ind + "storageLocationName\n" ;
            }
        }
        //      C# -> MosaicStoreConnectionParameters? ConnectionParameters
        // GraphQL -> connectionParameters: MosaicStoreConnectionParameters (type)
        if (this.ConnectionParameters != null) {
            var fspec = this.ConnectionParameters.AsFieldSpec(conf.Child("connectionParameters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "connectionParameters {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> MosaicStoreConnectionStatus? StoreConnectionStatus
        // GraphQL -> storeConnectionStatus: MosaicStoreConnectionStatus! (enum)
        if (ec.Includes("storeConnectionStatus",true))
        {
            if(this.StoreConnectionStatus == null) {

                this.StoreConnectionStatus = new MosaicStoreConnectionStatus();

            } else {


            }
        }
        else if (this.StoreConnectionStatus != null && ec.Excludes("storeConnectionStatus",true))
        {
            this.StoreConnectionStatus = null;
        }
        //      C# -> MosaicStoreType? StoreType
        // GraphQL -> storeType: MosaicStoreType! (enum)
        if (ec.Includes("storeType",true))
        {
            if(this.StoreType == null) {

                this.StoreType = new MosaicStoreType();

            } else {


            }
        }
        else if (this.StoreType != null && ec.Excludes("storeType",true))
        {
            this.StoreType = null;
        }
        //      C# -> System.Int32? BackupCount
        // GraphQL -> backupCount: Int! (scalar)
        if (ec.Includes("backupCount",true))
        {
            if(this.BackupCount == null) {

                this.BackupCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.BackupCount != null && ec.Excludes("backupCount",true))
        {
            this.BackupCount = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
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
        //      C# -> System.String? GeographicLocation
        // GraphQL -> geographicLocation: String! (scalar)
        if (ec.Includes("geographicLocation",true))
        {
            if(this.GeographicLocation == null) {

                this.GeographicLocation = "FETCH";

            } else {


            }
        }
        else if (this.GeographicLocation != null && ec.Excludes("geographicLocation",true))
        {
            this.GeographicLocation = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Int64? SpaceConsumedBytes
        // GraphQL -> spaceConsumedBytes: Long! (scalar)
        if (ec.Includes("spaceConsumedBytes",true))
        {
            if(this.SpaceConsumedBytes == null) {

                this.SpaceConsumedBytes = new System.Int64();

            } else {


            }
        }
        else if (this.SpaceConsumedBytes != null && ec.Excludes("spaceConsumedBytes",true))
        {
            this.SpaceConsumedBytes = null;
        }
        //      C# -> System.String? StorageLocationName
        // GraphQL -> storageLocationName: String! (scalar)
        if (ec.Includes("storageLocationName",true))
        {
            if(this.StorageLocationName == null) {

                this.StorageLocationName = "FETCH";

            } else {


            }
        }
        else if (this.StorageLocationName != null && ec.Excludes("storageLocationName",true))
        {
            this.StorageLocationName = null;
        }
        //      C# -> MosaicStoreConnectionParameters? ConnectionParameters
        // GraphQL -> connectionParameters: MosaicStoreConnectionParameters (type)
        if (ec.Includes("connectionParameters",false))
        {
            if(this.ConnectionParameters == null) {

                this.ConnectionParameters = new MosaicStoreConnectionParameters();
                this.ConnectionParameters.ApplyExploratoryFieldSpec(ec.NewChild("connectionParameters"));

            } else {

                this.ConnectionParameters.ApplyExploratoryFieldSpec(ec.NewChild("connectionParameters"));

            }
        }
        else if (this.ConnectionParameters != null && ec.Excludes("connectionParameters",false))
        {
            this.ConnectionParameters = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MosaicStorageLocation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MosaicStorageLocation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MosaicStorageLocation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types