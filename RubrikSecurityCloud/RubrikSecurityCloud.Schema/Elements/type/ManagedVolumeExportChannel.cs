// ManagedVolumeExportChannel.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:42.
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
    #region ManagedVolumeExportChannel
    public class ManagedVolumeExportChannel: IFragment
    {
        #region members
        //      C# -> DateTime? ExportDate
        // GraphQL -> exportDate: DateTime! (scalar)
        [JsonProperty("exportDate")]
        public DateTime? ExportDate { get; set; }

        //      C# -> System.String? FloatingIpAddress
        // GraphQL -> floatingIpAddress: String! (scalar)
        [JsonProperty("floatingIpAddress")]
        public System.String? FloatingIpAddress { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? MountPath
        // GraphQL -> mountPath: String! (scalar)
        [JsonProperty("mountPath")]
        public System.String? MountPath { get; set; }

        //      C# -> ManagedVolumeExportChannelStats? ChannelStats
        // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
        [JsonProperty("channelStats")]
        public ManagedVolumeExportChannelStats? ChannelStats { get; set; }

        //      C# -> ManagedVolumeMountSpec? MountSpec
        // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
        [JsonProperty("mountSpec")]
        public ManagedVolumeMountSpec? MountSpec { get; set; }

        #endregion

    #region methods

    public ManagedVolumeExportChannel Set(
        DateTime? ExportDate = null,
        System.String? FloatingIpAddress = null,
        System.String? Id = null,
        System.String? MountPath = null,
        ManagedVolumeExportChannelStats? ChannelStats = null,
        ManagedVolumeMountSpec? MountSpec = null
    ) 
    {
        if ( ExportDate != null ) {
            this.ExportDate = ExportDate;
        }
        if ( FloatingIpAddress != null ) {
            this.FloatingIpAddress = FloatingIpAddress;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( MountPath != null ) {
            this.MountPath = MountPath;
        }
        if ( ChannelStats != null ) {
            this.ChannelStats = ChannelStats;
        }
        if ( MountSpec != null ) {
            this.MountSpec = MountSpec;
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
            //      C# -> DateTime? ExportDate
            // GraphQL -> exportDate: DateTime! (scalar)
            if (this.ExportDate != null)
            {
                 s += ind + "exportDate\n";

            }
            //      C# -> System.String? FloatingIpAddress
            // GraphQL -> floatingIpAddress: String! (scalar)
            if (this.FloatingIpAddress != null)
            {
                 s += ind + "floatingIpAddress\n";

            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id != null)
            {
                 s += ind + "id\n";

            }
            //      C# -> System.String? MountPath
            // GraphQL -> mountPath: String! (scalar)
            if (this.MountPath != null)
            {
                 s += ind + "mountPath\n";

            }
            //      C# -> ManagedVolumeExportChannelStats? ChannelStats
            // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
            if (this.ChannelStats != null)
            {
                 s += ind + "channelStats\n";

                 s += ind + "{\n" + 
                 this.ChannelStats.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> ManagedVolumeMountSpec? MountSpec
            // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
            if (this.MountSpec != null)
            {
                 s += ind + "mountSpec\n";

                 s += ind + "{\n" + 
                 this.MountSpec.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> DateTime? ExportDate
            // GraphQL -> exportDate: DateTime! (scalar)
            if (this.ExportDate == null && Exploration.Includes(parent + ".exportDate$"))
            {
                this.ExportDate = new DateTime();
            }
            //      C# -> System.String? FloatingIpAddress
            // GraphQL -> floatingIpAddress: String! (scalar)
            if (this.FloatingIpAddress == null && Exploration.Includes(parent + ".floatingIpAddress$"))
            {
                this.FloatingIpAddress = new System.String("FETCH");
            }
            //      C# -> System.String? Id
            // GraphQL -> id: String! (scalar)
            if (this.Id == null && Exploration.Includes(parent + ".id$"))
            {
                this.Id = new System.String("FETCH");
            }
            //      C# -> System.String? MountPath
            // GraphQL -> mountPath: String! (scalar)
            if (this.MountPath == null && Exploration.Includes(parent + ".mountPath$"))
            {
                this.MountPath = new System.String("FETCH");
            }
            //      C# -> ManagedVolumeExportChannelStats? ChannelStats
            // GraphQL -> channelStats: ManagedVolumeExportChannelStats! (type)
            if (this.ChannelStats == null && Exploration.Includes(parent + ".channelStats"))
            {
                this.ChannelStats = new ManagedVolumeExportChannelStats();
                this.ChannelStats.ApplyExploratoryFragment(parent + ".channelStats");
            }
            //      C# -> ManagedVolumeMountSpec? MountSpec
            // GraphQL -> mountSpec: ManagedVolumeMountSpec! (type)
            if (this.MountSpec == null && Exploration.Includes(parent + ".mountSpec"))
            {
                this.MountSpec = new ManagedVolumeMountSpec();
                this.MountSpec.ApplyExploratoryFragment(parent + ".mountSpec");
            }
        }


    #endregion

    } // class ManagedVolumeExportChannel
    #endregion

    public static class ListManagedVolumeExportChannelExtensions
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
            this List<ManagedVolumeExportChannel> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeExportChannel> list, 
            String parent = "")
        {
            var item = new ManagedVolumeExportChannel();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types