// ManagedVolumeChannelConfig.cs
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
    #region ManagedVolumeChannelConfig
    public class ManagedVolumeChannelConfig: IFragment
    {
        #region members
        //      C# -> System.String? HostMountPoint
        // GraphQL -> hostMountPoint: String (scalar)
        [JsonProperty("hostMountPoint")]
        public System.String? HostMountPoint { get; set; }

        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        [JsonProperty("ipAddress")]
        public System.String? IpAddress { get; set; }

        //      C# -> System.String? MountPoint
        // GraphQL -> mountPoint: String! (scalar)
        [JsonProperty("mountPoint")]
        public System.String? MountPoint { get; set; }

        #endregion

    #region methods

    public ManagedVolumeChannelConfig Set(
        System.String? HostMountPoint = null,
        System.String? IpAddress = null,
        System.String? MountPoint = null
    ) 
    {
        if ( HostMountPoint != null ) {
            this.HostMountPoint = HostMountPoint;
        }
        if ( IpAddress != null ) {
            this.IpAddress = IpAddress;
        }
        if ( MountPoint != null ) {
            this.MountPoint = MountPoint;
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
            //      C# -> System.String? HostMountPoint
            // GraphQL -> hostMountPoint: String (scalar)
            if (this.HostMountPoint != null)
            {
                 s += ind + "hostMountPoint\n";

            }
            //      C# -> System.String? IpAddress
            // GraphQL -> ipAddress: String! (scalar)
            if (this.IpAddress != null)
            {
                 s += ind + "ipAddress\n";

            }
            //      C# -> System.String? MountPoint
            // GraphQL -> mountPoint: String! (scalar)
            if (this.MountPoint != null)
            {
                 s += ind + "mountPoint\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HostMountPoint
            // GraphQL -> hostMountPoint: String (scalar)
            if (this.HostMountPoint == null && Exploration.Includes(parent + ".hostMountPoint$"))
            {
                this.HostMountPoint = new System.String("FETCH");
            }
            //      C# -> System.String? IpAddress
            // GraphQL -> ipAddress: String! (scalar)
            if (this.IpAddress == null && Exploration.Includes(parent + ".ipAddress$"))
            {
                this.IpAddress = new System.String("FETCH");
            }
            //      C# -> System.String? MountPoint
            // GraphQL -> mountPoint: String! (scalar)
            if (this.MountPoint == null && Exploration.Includes(parent + ".mountPoint$"))
            {
                this.MountPoint = new System.String("FETCH");
            }
        }


    #endregion

    } // class ManagedVolumeChannelConfig
    #endregion

    public static class ListManagedVolumeChannelConfigExtensions
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
            this List<ManagedVolumeChannelConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeChannelConfig> list, 
            String parent = "")
        {
            var item = new ManagedVolumeChannelConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types