// NetworkRuleSet.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:54.
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
    #region NetworkRuleSet
    public class NetworkRuleSet: IFragment
    {
        #region members
        //      C# -> List<IpRule>? IpRules
        // GraphQL -> ipRules: [IpRule!]! (type)
        [JsonProperty("ipRules")]
        public List<IpRule>? IpRules { get; set; }

        //      C# -> DefaultActionType? DefaultAction
        // GraphQL -> defaultAction: DefaultActionType! (enum)
        [JsonProperty("defaultAction")]
        public DefaultActionType? DefaultAction { get; set; }

        #endregion

    #region methods

    public NetworkRuleSet Set(
        List<IpRule>? IpRules = null,
        DefaultActionType? DefaultAction = null
    ) 
    {
        if ( IpRules != null ) {
            this.IpRules = IpRules;
        }
        if ( DefaultAction != null ) {
            this.DefaultAction = DefaultAction;
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
            //      C# -> List<IpRule>? IpRules
            // GraphQL -> ipRules: [IpRule!]! (type)
            if (this.IpRules != null)
            {
                 s += ind + "ipRules\n";

                 s += ind + "{\n" + 
                 this.IpRules.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> DefaultActionType? DefaultAction
            // GraphQL -> defaultAction: DefaultActionType! (enum)
            if (this.DefaultAction != null)
            {
                 s += ind + "defaultAction\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<IpRule>? IpRules
            // GraphQL -> ipRules: [IpRule!]! (type)
            if (this.IpRules == null && Exploration.Includes(parent + ".ipRules"))
            {
                this.IpRules = new List<IpRule>();
                this.IpRules.ApplyExploratoryFragment(parent + ".ipRules");
            }
            //      C# -> DefaultActionType? DefaultAction
            // GraphQL -> defaultAction: DefaultActionType! (enum)
            if (this.DefaultAction == null && Exploration.Includes(parent + ".defaultAction$"))
            {
                this.DefaultAction = new DefaultActionType();
            }
        }


    #endregion

    } // class NetworkRuleSet
    #endregion

    public static class ListNetworkRuleSetExtensions
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
            this List<NetworkRuleSet> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NetworkRuleSet> list, 
            String parent = "")
        {
            var item = new NetworkRuleSet();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types