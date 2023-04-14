// RouteConfig.cs
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
    #region RouteConfig
    public class RouteConfig: IFragment
    {
        #region members
        //      C# -> System.String? Device
        // GraphQL -> device: String! (scalar)
        [JsonProperty("device")]
        public System.String? Device { get; set; }

        //      C# -> System.String? Gateway
        // GraphQL -> gateway: String! (scalar)
        [JsonProperty("gateway")]
        public System.String? Gateway { get; set; }

        //      C# -> System.String? Netmask
        // GraphQL -> netmask: String! (scalar)
        [JsonProperty("netmask")]
        public System.String? Netmask { get; set; }

        //      C# -> System.String? Network
        // GraphQL -> network: String! (scalar)
        [JsonProperty("network")]
        public System.String? Network { get; set; }

        #endregion

    #region methods

    public RouteConfig Set(
        System.String? Device = null,
        System.String? Gateway = null,
        System.String? Netmask = null,
        System.String? Network = null
    ) 
    {
        if ( Device != null ) {
            this.Device = Device;
        }
        if ( Gateway != null ) {
            this.Gateway = Gateway;
        }
        if ( Netmask != null ) {
            this.Netmask = Netmask;
        }
        if ( Network != null ) {
            this.Network = Network;
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
            //      C# -> System.String? Device
            // GraphQL -> device: String! (scalar)
            if (this.Device != null)
            {
                 s += ind + "device\n";

            }
            //      C# -> System.String? Gateway
            // GraphQL -> gateway: String! (scalar)
            if (this.Gateway != null)
            {
                 s += ind + "gateway\n";

            }
            //      C# -> System.String? Netmask
            // GraphQL -> netmask: String! (scalar)
            if (this.Netmask != null)
            {
                 s += ind + "netmask\n";

            }
            //      C# -> System.String? Network
            // GraphQL -> network: String! (scalar)
            if (this.Network != null)
            {
                 s += ind + "network\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Device
            // GraphQL -> device: String! (scalar)
            if (this.Device == null && Exploration.Includes(parent + ".device$"))
            {
                this.Device = new System.String("FETCH");
            }
            //      C# -> System.String? Gateway
            // GraphQL -> gateway: String! (scalar)
            if (this.Gateway == null && Exploration.Includes(parent + ".gateway$"))
            {
                this.Gateway = new System.String("FETCH");
            }
            //      C# -> System.String? Netmask
            // GraphQL -> netmask: String! (scalar)
            if (this.Netmask == null && Exploration.Includes(parent + ".netmask$"))
            {
                this.Netmask = new System.String("FETCH");
            }
            //      C# -> System.String? Network
            // GraphQL -> network: String! (scalar)
            if (this.Network == null && Exploration.Includes(parent + ".network$"))
            {
                this.Network = new System.String("FETCH");
            }
        }


    #endregion

    } // class RouteConfig
    #endregion

    public static class ListRouteConfigExtensions
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
            this List<RouteConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<RouteConfig> list, 
            String parent = "")
        {
            var item = new RouteConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types