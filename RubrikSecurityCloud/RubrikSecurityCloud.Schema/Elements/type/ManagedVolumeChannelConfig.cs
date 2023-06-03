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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ManagedVolumeChannelConfig
    public class ManagedVolumeChannelConfig: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? HostMountPoint
        // GraphQL -> hostMountPoint: String (scalar)
        if (this.HostMountPoint != null) {
            s += ind + "hostMountPoint\n" ;
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress != null) {
            s += ind + "ipAddress\n" ;
        }
        //      C# -> System.String? MountPoint
        // GraphQL -> mountPoint: String! (scalar)
        if (this.MountPoint != null) {
            s += ind + "mountPoint\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? HostMountPoint
        // GraphQL -> hostMountPoint: String (scalar)
        if (this.HostMountPoint == null && Exploration.Includes(parent + ".hostMountPoint", true))
        {
            this.HostMountPoint = new System.String("FETCH");
        }
        //      C# -> System.String? IpAddress
        // GraphQL -> ipAddress: String! (scalar)
        if (this.IpAddress == null && Exploration.Includes(parent + ".ipAddress", true))
        {
            this.IpAddress = new System.String("FETCH");
        }
        //      C# -> System.String? MountPoint
        // GraphQL -> mountPoint: String! (scalar)
        if (this.MountPoint == null && Exploration.Includes(parent + ".mountPoint", true))
        {
            this.MountPoint = new System.String("FETCH");
        }
    }


    #endregion

    } // class ManagedVolumeChannelConfig
    
    #endregion

    public static class ListManagedVolumeChannelConfigExtensions
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
            this List<ManagedVolumeChannelConfig> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolumeChannelConfig> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolumeChannelConfig());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types