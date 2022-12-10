// CdmHostVolume.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:09.
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
    #region CdmHostVolume
    public class CdmHostVolume: IFragment
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
        // AsFragment returns a string that denotes what
        // fields are not null, recursively for non-scalar fields.
        public string AsFragment(int indent=0)
        {
            string ind = new string(' ', indent*2);
            string s = "";
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId != null)
            {
                 s += ind + "cdmId\n";

            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid != null)
            {
                 s += ind + "clusterUuid\n";

            }
            //      C# -> System.String? FileSystemType
            // GraphQL -> fileSystemType: String (scalar)
            if (this.FileSystemType != null)
            {
                 s += ind + "fileSystemType\n";

            }
            //      C# -> List<System.String>? MountPoints
            // GraphQL -> mountPoints: [String!]! (scalar)
            if (this.MountPoints != null)
            {
                 s += ind + "mountPoints\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? VolumeGroupId
            // GraphQL -> volumeGroupId: String (scalar)
            if (this.VolumeGroupId != null)
            {
                 s += ind + "volumeGroupId\n";

            }
            //      C# -> System.String? VolumeId
            // GraphQL -> volumeId: String! (scalar)
            if (this.VolumeId != null)
            {
                 s += ind + "volumeId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? CdmId
            // GraphQL -> cdmId: String! (scalar)
            if (this.CdmId == null && Exploration.Includes(parent + ".cdmId$"))
            {
                this.CdmId = new System.String("FETCH");
            }
            //      C# -> System.String? ClusterUuid
            // GraphQL -> clusterUuid: String! (scalar)
            if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid$"))
            {
                this.ClusterUuid = new System.String("FETCH");
            }
            //      C# -> System.String? FileSystemType
            // GraphQL -> fileSystemType: String (scalar)
            if (this.FileSystemType == null && Exploration.Includes(parent + ".fileSystemType$"))
            {
                this.FileSystemType = new System.String("FETCH");
            }
            //      C# -> List<System.String>? MountPoints
            // GraphQL -> mountPoints: [String!]! (scalar)
            if (this.MountPoints == null && Exploration.Includes(parent + ".mountPoints$"))
            {
                this.MountPoints = new List<System.String>();
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? VolumeGroupId
            // GraphQL -> volumeGroupId: String (scalar)
            if (this.VolumeGroupId == null && Exploration.Includes(parent + ".volumeGroupId$"))
            {
                this.VolumeGroupId = new System.String("FETCH");
            }
            //      C# -> System.String? VolumeId
            // GraphQL -> volumeId: String! (scalar)
            if (this.VolumeId == null && Exploration.Includes(parent + ".volumeId$"))
            {
                this.VolumeId = new System.String("FETCH");
            }
        }


    #endregion

    } // class CdmHostVolume
    #endregion

    public static class ListCdmHostVolumeExtensions
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
            this List<CdmHostVolume> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<CdmHostVolume> list, 
            String parent = "")
        {
            var item = new CdmHostVolume();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types