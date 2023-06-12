// NetworkRuleSet.cs
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
    #region NetworkRuleSet
    public class NetworkRuleSet: BaseType
    {
        #region members

        //      C# -> DefaultActionType? DefaultAction
        // GraphQL -> defaultAction: DefaultActionType! (enum)
        [JsonProperty("defaultAction")]
        public DefaultActionType? DefaultAction { get; set; }

        //      C# -> List<IpRule>? IpRules
        // GraphQL -> ipRules: [IpRule!]! (type)
        [JsonProperty("ipRules")]
        public List<IpRule>? IpRules { get; set; }


        #endregion

    #region methods

    public NetworkRuleSet Set(
        DefaultActionType? DefaultAction = null,
        List<IpRule>? IpRules = null
    ) 
    {
        if ( DefaultAction != null ) {
            this.DefaultAction = DefaultAction;
        }
        if ( IpRules != null ) {
            this.IpRules = IpRules;
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
        //      C# -> DefaultActionType? DefaultAction
        // GraphQL -> defaultAction: DefaultActionType! (enum)
        if (this.DefaultAction != null) {
            s += ind + "defaultAction\n" ;
        }
        //      C# -> List<IpRule>? IpRules
        // GraphQL -> ipRules: [IpRule!]! (type)
        if (this.IpRules != null) {
            var fspec = this.IpRules.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "ipRules {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DefaultActionType? DefaultAction
        // GraphQL -> defaultAction: DefaultActionType! (enum)
        if (this.DefaultAction == null && Exploration.Includes(parent + ".defaultAction", true))
        {
            this.DefaultAction = new DefaultActionType();
        }
        //      C# -> List<IpRule>? IpRules
        // GraphQL -> ipRules: [IpRule!]! (type)
        if (this.IpRules == null && Exploration.Includes(parent + ".ipRules"))
        {
            this.IpRules = new List<IpRule>();
            this.IpRules.ApplyExploratoryFieldSpec(parent + ".ipRules");
        }
    }


    #endregion

    } // class NetworkRuleSet
    
    #endregion

    public static class ListNetworkRuleSetExtensions
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
            this List<NetworkRuleSet> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NetworkRuleSet> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkRuleSet());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types