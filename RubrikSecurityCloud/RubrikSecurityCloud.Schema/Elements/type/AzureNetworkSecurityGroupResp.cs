// AzureNetworkSecurityGroupResp.cs
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
    #region AzureNetworkSecurityGroupResp
    public class AzureNetworkSecurityGroupResp: BaseType
    {
        #region members

        //      C# -> AzureNetworkSecurityRulesStatus? RulesStatus
        // GraphQL -> rulesStatus: AzureNetworkSecurityRulesStatus! (enum)
        [JsonProperty("rulesStatus")]
        public AzureNetworkSecurityRulesStatus? RulesStatus { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }


        #endregion

    #region methods

    public AzureNetworkSecurityGroupResp Set(
        AzureNetworkSecurityRulesStatus? RulesStatus = null,
        System.String? Reason = null
    ) 
    {
        if ( RulesStatus != null ) {
            this.RulesStatus = RulesStatus;
        }
        if ( Reason != null ) {
            this.Reason = Reason;
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
        //      C# -> AzureNetworkSecurityRulesStatus? RulesStatus
        // GraphQL -> rulesStatus: AzureNetworkSecurityRulesStatus! (enum)
        if (this.RulesStatus != null) {
            s += ind + "rulesStatus\n" ;
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (this.Reason != null) {
            s += ind + "reason\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> AzureNetworkSecurityRulesStatus? RulesStatus
        // GraphQL -> rulesStatus: AzureNetworkSecurityRulesStatus! (enum)
        if (this.RulesStatus == null && Exploration.Includes(parent + ".rulesStatus", true))
        {
            this.RulesStatus = new AzureNetworkSecurityRulesStatus();
        }
        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        if (this.Reason == null && Exploration.Includes(parent + ".reason", true))
        {
            this.Reason = "FETCH";
        }
    }


    #endregion

    } // class AzureNetworkSecurityGroupResp
    
    #endregion

    public static class ListAzureNetworkSecurityGroupRespExtensions
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
            this List<AzureNetworkSecurityGroupResp> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AzureNetworkSecurityGroupResp> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AzureNetworkSecurityGroupResp());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types