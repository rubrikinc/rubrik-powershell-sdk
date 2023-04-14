// MountedVolume.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region MountedVolume
    public class MountedVolume: IFragment
    {
        #region members
        //      C# -> System.String? FileSystemType
        // GraphQL -> fileSystemType: String! (scalar)
        [JsonProperty("fileSystemType")]
        public System.String? FileSystemType { get; set; }

        //      C# -> System.String? HostMountPath
        // GraphQL -> hostMountPath: String (scalar)
        [JsonProperty("hostMountPath")]
        public System.String? HostMountPath { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> List<System.String>? OriginalMountPoints
        // GraphQL -> originalMountPoints: [String!]! (scalar)
        [JsonProperty("originalMountPoints")]
        public List<System.String>? OriginalMountPoints { get; set; }

        //      C# -> System.Int64? Size
        // GraphQL -> size: Long! (scalar)
        [JsonProperty("size")]
        public System.Int64? Size { get; set; }

        //      C# -> System.String? SmbPath
        // GraphQL -> smbPath: String (scalar)
        [JsonProperty("smbPath")]
        public System.String? SmbPath { get; set; }

        #endregion

    #region methods

    public MountedVolume Set(
        System.String? FileSystemType = null,
        System.String? HostMountPath = null,
        System.String? Id = null,
        List<System.String>? OriginalMountPoints = null,
        System.Int64? Size = null,
        System.String? SmbPath = null
    ) 
    {
        if ( FileSystemType != null ) {
            this.FileSystemType = FileSystemType;
        }
        if ( HostMountPath != null ) {
            this.HostMountPath = HostMountPath;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( OriginalMountPoints != null ) {
            this.OriginalMountPoints = OriginalMountPoints;
        }
        if ( Size != null ) {
            this.Size = Size;
        }
        if ( SmbPath != null ) {
            this.SmbPath = SmbPath;
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
            //      C# -> System.String? FileSystemType
            // GraphQL -> fileSystemType: String! (scalar)
            if (this.FileSystemType != null)
            {
                 s += ind + "fileSystemType\n";

            }
            //      C# -> System.String? HostMountPath
            // GraphQL -> hostMountPath: String (scalar)
            if (this.HostMountPath != null)
            {
                 s += ind + "hostMountPath\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> List<System.String>? OriginalMountPoints
            // GraphQL -> originalMountPoints: [String!]! (scalar)
            if (this.OriginalMountPoints != null)
            {
                 s += ind + "originalMountPoints\n";

            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size != null)
            {
                 s += ind + "size\n";

            }
            //      C# -> System.String? SmbPath
            // GraphQL -> smbPath: String (scalar)
            if (this.SmbPath != null)
            {
                 s += ind + "smbPath\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? FileSystemType
            // GraphQL -> fileSystemType: String! (scalar)
            if (this.FileSystemType == null && Exploration.Includes(parent + ".fileSystemType$"))
            {
                this.FileSystemType = new System.String("FETCH");
            }
            //      C# -> System.String? HostMountPath
            // GraphQL -> hostMountPath: String (scalar)
            if (this.HostMountPath == null && Exploration.Includes(parent + ".hostMountPath$"))
            {
                this.HostMountPath = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> List<System.String>? OriginalMountPoints
            // GraphQL -> originalMountPoints: [String!]! (scalar)
            if (this.OriginalMountPoints == null && Exploration.Includes(parent + ".originalMountPoints$"))
            {
                this.OriginalMountPoints = new List<System.String>();
            }
            //      C# -> System.Int64? Size
            // GraphQL -> size: Long! (scalar)
            if (this.Size == null && Exploration.Includes(parent + ".size$"))
            {
                this.Size = new System.Int64();
            }
            //      C# -> System.String? SmbPath
            // GraphQL -> smbPath: String (scalar)
            if (this.SmbPath == null && Exploration.Includes(parent + ".smbPath$"))
            {
                this.SmbPath = new System.String("FETCH");
            }
        }


    #endregion

    } // class MountedVolume
    #endregion

    public static class ListMountedVolumeExtensions
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
            this List<MountedVolume> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MountedVolume> list, 
            String parent = "")
        {
            var item = new MountedVolume();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types