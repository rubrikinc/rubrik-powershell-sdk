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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region HotAddNetworkConfigWithName
    public class HotAddNetworkConfigWithName: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        if (this.NetworkName != null) {
            s += ind + "networkName\n" ;
        }
        //      C# -> StaticIpInfo? StaticIpConfig
        // GraphQL -> staticIpConfig: StaticIpInfo (type)
        if (this.StaticIpConfig != null) {
            var fspec = this.StaticIpConfig.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "staticIpConfig {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? NetworkName
        // GraphQL -> networkName: String (scalar)
        if (this.NetworkName == null && Exploration.Includes(parent + ".networkName", true))
        {
            this.NetworkName = "FETCH";
        }
        //      C# -> StaticIpInfo? StaticIpConfig
        // GraphQL -> staticIpConfig: StaticIpInfo (type)
        if (this.StaticIpConfig == null && Exploration.Includes(parent + ".staticIpConfig"))
        {
            this.StaticIpConfig = new StaticIpInfo();
            this.StaticIpConfig.ApplyExploratoryFieldSpec(parent + ".staticIpConfig");
        }
    }


    #endregion

    } // class HotAddNetworkConfigWithName
    
    #endregion

    public static class ListHotAddNetworkConfigWithNameExtensions
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
            this List<HotAddNetworkConfigWithName> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HotAddNetworkConfigWithName> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HotAddNetworkConfigWithName());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types