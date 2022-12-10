// NatGatewayInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:20.
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
    #region NatGatewayInfo
    public class NatGatewayInfo: IFragment
    {
        #region members
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        [JsonProperty("address")]
        public System.String? Address { get; set; }

        //      C# -> List<System.Int32>? Ports
        // GraphQL -> ports: [Int!]! (scalar)
        [JsonProperty("ports")]
        public List<System.Int32>? Ports { get; set; }

        #endregion

    #region methods

    public NatGatewayInfo Set(
        System.String? Address = null,
        List<System.Int32>? Ports = null
    ) 
    {
        if ( Address != null ) {
            this.Address = Address;
        }
        if ( Ports != null ) {
            this.Ports = Ports;
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
            //      C# -> System.String? Address
            // GraphQL -> address: String! (scalar)
            if (this.Address != null)
            {
                 s += ind + "address\n";

            }
            //      C# -> List<System.Int32>? Ports
            // GraphQL -> ports: [Int!]! (scalar)
            if (this.Ports != null)
            {
                 s += ind + "ports\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Address
            // GraphQL -> address: String! (scalar)
            if (this.Address == null && Exploration.Includes(parent + ".address$"))
            {
                this.Address = new System.String("FETCH");
            }
            //      C# -> List<System.Int32>? Ports
            // GraphQL -> ports: [Int!]! (scalar)
            if (this.Ports == null && Exploration.Includes(parent + ".ports$"))
            {
                this.Ports = new List<System.Int32>();
            }
        }


    #endregion

    } // class NatGatewayInfo
    #endregion

    public static class ListNatGatewayInfoExtensions
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
            this List<NatGatewayInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NatGatewayInfo> list, 
            String parent = "")
        {
            var item = new NatGatewayInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types