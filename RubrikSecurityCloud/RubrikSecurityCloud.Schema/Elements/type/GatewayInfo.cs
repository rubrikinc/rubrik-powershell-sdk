// GatewayInfo.cs
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
    #region GatewayInfo
    public class GatewayInfo: BaseType
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

    public GatewayInfo Set(
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address != null) {
            s += ind + "address\n" ;
        }
        //      C# -> List<System.Int32>? Ports
        // GraphQL -> ports: [Int!]! (scalar)
        if (this.Ports != null) {
            s += ind + "ports\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Address
        // GraphQL -> address: String! (scalar)
        if (this.Address == null && Exploration.Includes(parent + ".address", true))
        {
            this.Address = "FETCH";
        }
        //      C# -> List<System.Int32>? Ports
        // GraphQL -> ports: [Int!]! (scalar)
        if (this.Ports == null && Exploration.Includes(parent + ".ports", true))
        {
            this.Ports = new List<System.Int32>();
        }
    }


    #endregion

    } // class GatewayInfo
    
    #endregion

    public static class ListGatewayInfoExtensions
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
            this List<GatewayInfo> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<GatewayInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new GatewayInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types