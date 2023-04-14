// VmwareNetworkConfig.cs
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
    #region VmwareNetworkConfig
    public class VmwareNetworkConfig: IFragment
    {
        #region members
        //      C# -> List<VmwareNetworkDeviceInfo>? Nics
        // GraphQL -> nics: [VmwareNetworkDeviceInfo!]! (type)
        [JsonProperty("nics")]
        public List<VmwareNetworkDeviceInfo>? Nics { get; set; }

        #endregion

    #region methods

    public VmwareNetworkConfig Set(
        List<VmwareNetworkDeviceInfo>? Nics = null
    ) 
    {
        if ( Nics != null ) {
            this.Nics = Nics;
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
            //      C# -> List<VmwareNetworkDeviceInfo>? Nics
            // GraphQL -> nics: [VmwareNetworkDeviceInfo!]! (type)
            if (this.Nics != null)
            {
                 s += ind + "nics\n";

                 s += ind + "{\n" + 
                 this.Nics.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<VmwareNetworkDeviceInfo>? Nics
            // GraphQL -> nics: [VmwareNetworkDeviceInfo!]! (type)
            if (this.Nics == null && Exploration.Includes(parent + ".nics"))
            {
                this.Nics = new List<VmwareNetworkDeviceInfo>();
                this.Nics.ApplyExploratoryFragment(parent + ".nics");
            }
        }


    #endregion

    } // class VmwareNetworkConfig
    #endregion

    public static class ListVmwareNetworkConfigExtensions
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
            this List<VmwareNetworkConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareNetworkConfig> list, 
            String parent = "")
        {
            var item = new VmwareNetworkConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types