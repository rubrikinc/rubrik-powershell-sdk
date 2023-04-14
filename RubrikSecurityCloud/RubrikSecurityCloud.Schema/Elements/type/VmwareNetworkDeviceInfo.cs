// VmwareNetworkDeviceInfo.cs
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
    #region VmwareNetworkDeviceInfo
    public class VmwareNetworkDeviceInfo: IFragment
    {
        #region members
        //      C# -> System.Int32? Key
        // GraphQL -> key: Int! (scalar)
        [JsonProperty("key")]
        public System.Int32? Key { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        #endregion

    #region methods

    public VmwareNetworkDeviceInfo Set(
        System.Int32? Key = null,
        System.String? Name = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( Name != null ) {
            this.Name = Name;
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
            //      C# -> System.Int32? Key
            // GraphQL -> key: Int! (scalar)
            if (this.Key != null)
            {
                 s += ind + "key\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Key
            // GraphQL -> key: Int! (scalar)
            if (this.Key == null && Exploration.Includes(parent + ".key$"))
            {
                this.Key = new System.Int32();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
        }


    #endregion

    } // class VmwareNetworkDeviceInfo
    #endregion

    public static class ListVmwareNetworkDeviceInfoExtensions
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
            this List<VmwareNetworkDeviceInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VmwareNetworkDeviceInfo> list, 
            String parent = "")
        {
            var item = new VmwareNetworkDeviceInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types