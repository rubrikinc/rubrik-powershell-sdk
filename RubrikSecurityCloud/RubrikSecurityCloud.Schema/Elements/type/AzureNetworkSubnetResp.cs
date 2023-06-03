// AzureNetworkSubnetResp.cs
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
    #region AzureNetworkSubnetResp
    public class AzureNetworkSubnetResp: BaseType
    {
        #region members

        //      C# -> System.Boolean? Valid
        // GraphQL -> valid: Boolean! (scalar)
        [JsonProperty("valid")]
        public System.Boolean? Valid { get; set; }


        #endregion

    #region methods

    public AzureNetworkSubnetResp Set(
        System.Boolean? Valid = null
    ) 
    {
        if ( Valid != null ) {
            this.Valid = Valid;
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
        //      C# -> System.Boolean? Valid
        // GraphQL -> valid: Boolean! (scalar)
        if (this.Valid != null) {
            s += ind + "valid\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? Valid
        // GraphQL -> valid: Boolean! (scalar)
        if (this.Valid == null && Exploration.Includes(parent + ".valid", true))
        {
            this.Valid = true;
        }
    }


    #endregion

    } // class AzureNetworkSubnetResp
    
    #endregion

    public static class ListAzureNetworkSubnetRespExtensions
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
            this List<AzureNetworkSubnetResp> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNetworkSubnetResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNetworkSubnetResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types