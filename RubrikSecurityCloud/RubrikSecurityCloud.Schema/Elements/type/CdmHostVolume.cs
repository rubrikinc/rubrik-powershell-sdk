// CdmHostVolume.cs
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
    #region CdmHostVolume
    public class CdmHostVolume: BaseType
    {
        #region members

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String (scalar)
        [JsonProperty("fileSystemType")]
        public System.String? FileSystemType { get; set; }

        //      C# -> List<System.String>? MountPoints
        // GraphQL -> mountPoints: [String!]! (scalar)
        [JsonProperty("mountPoints")]
        public List<System.String>? MountPoints { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? VolumeGroupId
        // GraphQL -> volumeGroupId: String (scalar)
        [JsonProperty("volumeGroupId")]
        public System.String? VolumeGroupId { get; set; }

        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        [JsonProperty("volumeId")]
        public System.String? VolumeId { get; set; }


        #endregion

    #region methods

    public CdmHostVolume Set(
        System.String? CdmId = null,
        System.String? ClusterUuid = null,
        System.String? FileSystemType = null,
        List<System.String>? MountPoints = null,
        System.Int64? Size = null,
        System.String? VolumeGroupId = null,
        System.String? VolumeId = null
    ) 
    {
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( FileSystemType != null ) {
            this.FileSystemType = FileSystemType;
        }
        if ( MountPoints != null ) {
            this.MountPoints = MountPoints;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( VolumeGroupId != null ) {
            this.VolumeGroupId = VolumeGroupId;
        }
        if ( VolumeId != null ) {
            this.VolumeId = VolumeId;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String (scalar)
        if (this.FileSystemType != null) {
            s += ind + "fileSystemType\n" ;
        }
        //      C# -> List<System.String>? MountPoints
        // GraphQL -> mountPoints: [String!]! (scalar)
        if (this.MountPoints != null) {
            s += ind + "mountPoints\n" ;
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size != null) {
            s += ind + "size\n" ;
        }
        //      C# -> System.String? VolumeGroupId
        // GraphQL -> volumeGroupId: String (scalar)
        if (this.VolumeGroupId != null) {
            s += ind + "volumeGroupId\n" ;
        }
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        if (this.VolumeId != null) {
            s += ind + "volumeId\n" ;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = "FETCH";
        }
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String (scalar)
        if (this.FileSystemType == null && Exploration.Includes(parent + ".fileSystemType", true))
        {
            this.FileSystemType = "FETCH";
        }
        //      C# -> List<System.String>? MountPoints
        // GraphQL -> mountPoints: [String!]! (scalar)
        if (this.MountPoints == null && Exploration.Includes(parent + ".mountPoints", true))
        {
            this.MountPoints = new List<System.String>();
        }
        //      C# -> System.Int64? Size
        // GraphQL -> size: Long (scalar)
        if (this.Size == null && Exploration.Includes(parent + ".size", true))
        {
            this.Size = new System.Int64();
        }
        //      C# -> System.String? VolumeGroupId
        // GraphQL -> volumeGroupId: String (scalar)
        if (this.VolumeGroupId == null && Exploration.Includes(parent + ".volumeGroupId", true))
        {
            this.VolumeGroupId = "FETCH";
        }
        //      C# -> System.String? VolumeId
        // GraphQL -> volumeId: String! (scalar)
        if (this.VolumeId == null && Exploration.Includes(parent + ".volumeId", true))
        {
            this.VolumeId = "FETCH";
        }
    }


    #endregion

    } // class CdmHostVolume
    
    #endregion

    public static class ListCdmHostVolumeExtensions
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
            this List<CdmHostVolume> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CdmHostVolume> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CdmHostVolume());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types