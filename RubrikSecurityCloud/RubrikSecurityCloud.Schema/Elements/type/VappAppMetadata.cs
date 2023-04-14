// VappAppMetadata.cs
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
    #region VappAppMetadata
    public class VappAppMetadata: IFragment
    {
        #region members
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? VcdVmMoid
        // GraphQL -> vcdVmMoid: String! (scalar)
        [JsonProperty("vcdVmMoid")]
        public System.String? VcdVmMoid { get; set; }

        //      C# -> System.String? VmName
        // GraphQL -> vmName: String! (scalar)
        [JsonProperty("vmName")]
        public System.String? VmName { get; set; }

        //      C# -> List<VmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
        [JsonProperty("networkConnections")]
        public List<VmNetworkConnection>? NetworkConnections { get; set; }

        #endregion

    #region methods

    public VappAppMetadata Set(
        System.String? SnapshotId = null,
        System.String? VcdVmMoid = null,
        System.String? VmName = null,
        List<VmNetworkConnection>? NetworkConnections = null
    ) 
    {
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( VcdVmMoid != null ) {
            this.VcdVmMoid = VcdVmMoid;
        }
        if ( VmName != null ) {
            this.VmName = VmName;
        }
        if ( NetworkConnections != null ) {
            this.NetworkConnections = NetworkConnections;
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
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: UUID! (scalar)
            if (this.SnapshotId != null)
            {
                 s += ind + "snapshotId\n";

            }
            //      C# -> System.String? VcdVmMoid
            // GraphQL -> vcdVmMoid: String! (scalar)
            if (this.VcdVmMoid != null)
            {
                 s += ind + "vcdVmMoid\n";

            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName != null)
            {
                 s += ind + "vmName\n";

            }
            //      C# -> List<VmNetworkConnection>? NetworkConnections
            // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
            if (this.NetworkConnections != null)
            {
                 s += ind + "networkConnections\n";

                 s += ind + "{\n" + 
                 this.NetworkConnections.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? SnapshotId
            // GraphQL -> snapshotId: UUID! (scalar)
            if (this.SnapshotId == null && Exploration.Includes(parent + ".snapshotId$"))
            {
                this.SnapshotId = new System.String("FETCH");
            }
            //      C# -> System.String? VcdVmMoid
            // GraphQL -> vcdVmMoid: String! (scalar)
            if (this.VcdVmMoid == null && Exploration.Includes(parent + ".vcdVmMoid$"))
            {
                this.VcdVmMoid = new System.String("FETCH");
            }
            //      C# -> System.String? VmName
            // GraphQL -> vmName: String! (scalar)
            if (this.VmName == null && Exploration.Includes(parent + ".vmName$"))
            {
                this.VmName = new System.String("FETCH");
            }
            //      C# -> List<VmNetworkConnection>? NetworkConnections
            // GraphQL -> networkConnections: [VmNetworkConnection!]! (type)
            if (this.NetworkConnections == null && Exploration.Includes(parent + ".networkConnections"))
            {
                this.NetworkConnections = new List<VmNetworkConnection>();
                this.NetworkConnections.ApplyExploratoryFragment(parent + ".networkConnections");
            }
        }


    #endregion

    } // class VappAppMetadata
    #endregion

    public static class ListVappAppMetadataExtensions
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
            this List<VappAppMetadata> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VappAppMetadata> list, 
            String parent = "")
        {
            var item = new VappAppMetadata();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types