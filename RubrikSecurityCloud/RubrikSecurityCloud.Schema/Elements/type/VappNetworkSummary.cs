// VappNetworkSummary.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:04.
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
    #region VappNetworkSummary
    public class VappNetworkSummary: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsDeployed
        // GraphQL -> isDeployed: Boolean! (scalar)
        [JsonProperty("isDeployed")]
        public System.Boolean? IsDeployed { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentNetworkId
        // GraphQL -> parentNetworkId: String (scalar)
        [JsonProperty("parentNetworkId")]
        public System.String? ParentNetworkId { get; set; }

        #endregion

    #region methods

    public VappNetworkSummary Set(
        System.Boolean? IsDeployed = null,
        System.String? Name = null,
        System.String? ParentNetworkId = null
    ) 
    {
        if ( IsDeployed != null ) {
            this.IsDeployed = IsDeployed;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentNetworkId != null ) {
            this.ParentNetworkId = ParentNetworkId;
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
            //      C# -> System.Boolean? IsDeployed
            // GraphQL -> isDeployed: Boolean! (scalar)
            if (this.IsDeployed != null)
            {
                 s += ind + "isDeployed\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> System.String? ParentNetworkId
            // GraphQL -> parentNetworkId: String (scalar)
            if (this.ParentNetworkId != null)
            {
                 s += ind + "parentNetworkId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsDeployed
            // GraphQL -> isDeployed: Boolean! (scalar)
            if (this.IsDeployed == null && Exploration.Includes(parent + ".isDeployed$"))
            {
                this.IsDeployed = new System.Boolean();
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> System.String? ParentNetworkId
            // GraphQL -> parentNetworkId: String (scalar)
            if (this.ParentNetworkId == null && Exploration.Includes(parent + ".parentNetworkId$"))
            {
                this.ParentNetworkId = new System.String("FETCH");
            }
        }


    #endregion

    } // class VappNetworkSummary
    #endregion

    public static class ListVappNetworkSummaryExtensions
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
            this List<VappNetworkSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<VappNetworkSummary> list, 
            String parent = "")
        {
            var item = new VappNetworkSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types