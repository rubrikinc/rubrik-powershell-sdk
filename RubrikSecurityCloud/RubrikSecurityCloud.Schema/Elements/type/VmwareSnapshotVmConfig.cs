// VmwareSnapshotVmConfig.cs
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
    #region VmwareSnapshotVmConfig
    public class VmwareSnapshotVmConfig: IFragment
    {
        #region members
        //      C# -> VmwareNetworkConfig? NetworkConfig
        // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
        [JsonProperty("networkConfig")]
        public VmwareNetworkConfig? NetworkConfig { get; set; }

        #endregion

    #region methods

    public VmwareSnapshotVmConfig Set(
        VmwareNetworkConfig? NetworkConfig = null
    ) 
    {
        if ( NetworkConfig != null ) {
            this.NetworkConfig = NetworkConfig;
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
            //      C# -> VmwareNetworkConfig? NetworkConfig
            // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
            if (this.NetworkConfig != null)
            {
                 s += ind + "networkConfig\n";

                 s += ind + "{\n" + 
                 this.NetworkConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> VmwareNetworkConfig? NetworkConfig
            // GraphQL -> networkConfig: VmwareNetworkConfig! (type)
            if (this.NetworkConfig == null && Exploration.Includes(parent + ".networkConfig"))
            {
                this.NetworkConfig = new VmwareNetworkConfig();
                this.NetworkConfig.ApplyExploratoryFragment(parent + ".networkConfig");
            }
        }


    #endregion

    } // class VmwareSnapshotVmConfig
    #endregion

    public static class ListVmwareSnapshotVmConfigExtensions
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
            this List<VmwareSnapshotVmConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareSnapshotVmConfig> list, 
            String parent = "")
        {
            var item = new VmwareSnapshotVmConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types