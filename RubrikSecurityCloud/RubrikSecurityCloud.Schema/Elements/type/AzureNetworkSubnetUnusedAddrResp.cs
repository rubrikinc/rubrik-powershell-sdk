// AzureNetworkSubnetUnusedAddrResp.cs
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
    #region AzureNetworkSubnetUnusedAddrResp
    public class AzureNetworkSubnetUnusedAddrResp: BaseType
    {
        #region members

        //      C# -> System.Int64? UnusedAddr
        // GraphQL -> unusedAddr: Long! (scalar)
        [JsonProperty("unusedAddr")]
        public System.Int64? UnusedAddr { get; set; }


        #endregion

    #region methods

    public AzureNetworkSubnetUnusedAddrResp Set(
        System.Int64? UnusedAddr = null
    ) 
    {
        if ( UnusedAddr != null ) {
            this.UnusedAddr = UnusedAddr;
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
        //      C# -> System.Int64? UnusedAddr
        // GraphQL -> unusedAddr: Long! (scalar)
        if (this.UnusedAddr != null) {
            s += ind + "unusedAddr\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? UnusedAddr
        // GraphQL -> unusedAddr: Long! (scalar)
        if (this.UnusedAddr == null && Exploration.Includes(parent + ".unusedAddr", true))
        {
            this.UnusedAddr = new System.Int64();
        }
    }


    #endregion

    } // class AzureNetworkSubnetUnusedAddrResp
    
    #endregion

    public static class ListAzureNetworkSubnetUnusedAddrRespExtensions
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
            this List<AzureNetworkSubnetUnusedAddrResp> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNetworkSubnetUnusedAddrResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNetworkSubnetUnusedAddrResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types