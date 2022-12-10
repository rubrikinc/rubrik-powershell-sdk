// FailoverClusterAppConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:24.
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
    #region FailoverClusterAppConfig
    public class FailoverClusterAppConfig: IFragment
    {
        #region members
        //      C# -> System.String? ConfiguredSlaDomainId
        // GraphQL -> configuredSlaDomainId: String (scalar)
        [JsonProperty("configuredSlaDomainId")]
        public System.String? ConfiguredSlaDomainId { get; set; }

        //      C# -> System.String? FailoverClusterId
        // GraphQL -> failoverClusterId: String! (scalar)
        [JsonProperty("failoverClusterId")]
        public System.String? FailoverClusterId { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
        // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
        [JsonProperty("failoverClusterAppSource")]
        public FailoverClusterAppSource? FailoverClusterAppSource { get; set; }

        //      C# -> FailoverClusterType? FailoverClusterType
        // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
        [JsonProperty("failoverClusterType")]
        public FailoverClusterType? FailoverClusterType { get; set; }

        #endregion

    #region methods

    public FailoverClusterAppConfig Set(
        System.String? ConfiguredSlaDomainId = null,
        System.String? FailoverClusterId = null,
        System.String? Name = null,
        FailoverClusterAppSource? FailoverClusterAppSource = null,
        FailoverClusterType? FailoverClusterType = null
    ) 
    {
        if ( ConfiguredSlaDomainId != null ) {
            this.ConfiguredSlaDomainId = ConfiguredSlaDomainId;
        }
        if ( FailoverClusterId != null ) {
            this.FailoverClusterId = FailoverClusterId;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( FailoverClusterAppSource != null ) {
            this.FailoverClusterAppSource = FailoverClusterAppSource;
        }
        if ( FailoverClusterType != null ) {
            this.FailoverClusterType = FailoverClusterType;
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
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId != null)
            {
                 s += ind + "configuredSlaDomainId\n";

            }
            //      C# -> System.String? FailoverClusterId
            // GraphQL -> failoverClusterId: String! (scalar)
            if (this.FailoverClusterId != null)
            {
                 s += ind + "failoverClusterId\n";

            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name != null)
            {
                 s += ind + "name\n";

            }
            //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
            // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
            if (this.FailoverClusterAppSource != null)
            {
                 s += ind + "failoverClusterAppSource\n";

                 s += ind + "{\n" + 
                 this.FailoverClusterAppSource.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            //      C# -> FailoverClusterType? FailoverClusterType
            // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
            if (this.FailoverClusterType != null)
            {
                 s += ind + "failoverClusterType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ConfiguredSlaDomainId
            // GraphQL -> configuredSlaDomainId: String (scalar)
            if (this.ConfiguredSlaDomainId == null && Exploration.Includes(parent + ".configuredSlaDomainId$"))
            {
                this.ConfiguredSlaDomainId = new System.String("FETCH");
            }
            //      C# -> System.String? FailoverClusterId
            // GraphQL -> failoverClusterId: String! (scalar)
            if (this.FailoverClusterId == null && Exploration.Includes(parent + ".failoverClusterId$"))
            {
                this.FailoverClusterId = new System.String("FETCH");
            }
            //      C# -> System.String? Name
            // GraphQL -> name: String! (scalar)
            if (this.Name == null && Exploration.Includes(parent + ".name$"))
            {
                this.Name = new System.String("FETCH");
            }
            //      C# -> FailoverClusterAppSource? FailoverClusterAppSource
            // GraphQL -> failoverClusterAppSource: FailoverClusterAppSource (type)
            if (this.FailoverClusterAppSource == null && Exploration.Includes(parent + ".failoverClusterAppSource"))
            {
                this.FailoverClusterAppSource = new FailoverClusterAppSource();
                this.FailoverClusterAppSource.ApplyExploratoryFragment(parent + ".failoverClusterAppSource");
            }
            //      C# -> FailoverClusterType? FailoverClusterType
            // GraphQL -> failoverClusterType: FailoverClusterType! (enum)
            if (this.FailoverClusterType == null && Exploration.Includes(parent + ".failoverClusterType$"))
            {
                this.FailoverClusterType = new FailoverClusterType();
            }
        }


    #endregion

    } // class FailoverClusterAppConfig
    #endregion

    public static class ListFailoverClusterAppConfigExtensions
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
            this List<FailoverClusterAppConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FailoverClusterAppConfig> list, 
            String parent = "")
        {
            var item = new FailoverClusterAppConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types