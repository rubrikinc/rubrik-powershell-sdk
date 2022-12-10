// VappVmRestoreSpec.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
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
    #region VappVmRestoreSpec
    public class VappVmRestoreSpec: IFragment
    {
        #region members
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? StoragePolicyId
        // GraphQL -> storagePolicyId: String (scalar)
        [JsonProperty("storagePolicyId")]
        public System.String? StoragePolicyId { get; set; }

        //      C# -> System.String? VcdMoid
        // GraphQL -> vcdMoid: String! (scalar)
        [JsonProperty("vcdMoid")]
        public System.String? VcdMoid { get; set; }

        //      C# -> List<VappVmNetworkConnection>? NetworkConnections
        // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
        [JsonProperty("networkConnections")]
        public List<VappVmNetworkConnection>? NetworkConnections { get; set; }

        #endregion

    #region methods

    public VappVmRestoreSpec Set(
        System.String? Name = null,
        System.String? StoragePolicyId = null,
        System.String? VcdMoid = null,
        List<VappVmNetworkConnection>? NetworkConnections = null
    ) 
    {
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( StoragePolicyId != null ) {
            this.StoragePolicyId = StoragePolicyId;
        }
        if ( VcdMoid != null ) {
            this.VcdMoid = VcdMoid;
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? StoragePolicyId
            // GraphQL -> storagePolicyId: String (scalar)
            if (this.StoragePolicyId != null)
            {
                 s += ind + "storagePolicyId\n";

            }
            //      C# -> System.String? VcdMoid
            // GraphQL -> vcdMoid: String! (scalar)
            if (this.VcdMoid != null)
            {
                 s += ind + "vcdMoid\n";

            }
            //      C# -> List<VappVmNetworkConnection>? NetworkConnections
            // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
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
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? StoragePolicyId
            // GraphQL -> storagePolicyId: String (scalar)
            if (this.StoragePolicyId == null && Exploration.Includes(parent + ".storagePolicyId$"))
            {
                this.StoragePolicyId = new System.String("FETCH");
            }
            //      C# -> System.String? VcdMoid
            // GraphQL -> vcdMoid: String! (scalar)
            if (this.VcdMoid == null && Exploration.Includes(parent + ".vcdMoid$"))
            {
                this.VcdMoid = new System.String("FETCH");
            }
            //      C# -> List<VappVmNetworkConnection>? NetworkConnections
            // GraphQL -> networkConnections: [VappVmNetworkConnection!]! (type)
            if (this.NetworkConnections == null && Exploration.Includes(parent + ".networkConnections"))
            {
                this.NetworkConnections = new List<VappVmNetworkConnection>();
                this.NetworkConnections.ApplyExploratoryFragment(parent + ".networkConnections");
            }
        }


    #endregion

    } // class VappVmRestoreSpec
    #endregion

    public static class ListVappVmRestoreSpecExtensions
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
            this List<VappVmRestoreSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VappVmRestoreSpec> list, 
            String parent = "")
        {
            var item = new VappVmRestoreSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types