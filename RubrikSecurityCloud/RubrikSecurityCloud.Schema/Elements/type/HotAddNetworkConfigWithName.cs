// HotAddNetworkConfigWithName.cs
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
    #region HotAddNetworkConfigWithName
    public class HotAddNetworkConfigWithName: IFragment
    {
        #region members
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        [JsonProperty("networkName")]
        public System.String? NetworkName { get; set; }

        //      C# -> StaticIpInfo? StaticIpConfig
        // GraphQL -> staticIpConfig: StaticIpInfo (type)
        [JsonProperty("staticIpConfig")]
        public StaticIpInfo? StaticIpConfig { get; set; }

        #endregion

    #region methods

    public HotAddNetworkConfigWithName Set(
        System.String? NetworkName = null,
        StaticIpInfo? StaticIpConfig = null
    ) 
    {
        if ( NetworkName != null ) {
            this.NetworkName = NetworkName;
        }
        if ( StaticIpConfig != null ) {
            this.StaticIpConfig = StaticIpConfig;
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
            //      C# -> System.String? NetworkName
            // GraphQL -> networkName: String (scalar)
            if (this.NetworkName != null)
            {
                 s += ind + "networkName\n";

            }
            //      C# -> StaticIpInfo? StaticIpConfig
            // GraphQL -> staticIpConfig: StaticIpInfo (type)
            if (this.StaticIpConfig != null)
            {
                 s += ind + "staticIpConfig\n";

                 s += ind + "{\n" + 
                 this.StaticIpConfig.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? NetworkName
            // GraphQL -> networkName: String (scalar)
            if (this.NetworkName == null && Exploration.Includes(parent + ".networkName$"))
            {
                this.NetworkName = new System.String("FETCH");
            }
            //      C# -> StaticIpInfo? StaticIpConfig
            // GraphQL -> staticIpConfig: StaticIpInfo (type)
            if (this.StaticIpConfig == null && Exploration.Includes(parent + ".staticIpConfig"))
            {
                this.StaticIpConfig = new StaticIpInfo();
                this.StaticIpConfig.ApplyExploratoryFragment(parent + ".staticIpConfig");
            }
        }


    #endregion

    } // class HotAddNetworkConfigWithName
    #endregion

    public static class ListHotAddNetworkConfigWithNameExtensions
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
            this List<HotAddNetworkConfigWithName> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HotAddNetworkConfigWithName> list, 
            String parent = "")
        {
            var item = new HotAddNetworkConfigWithName();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types