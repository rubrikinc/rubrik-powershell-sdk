// InstalledVersionGroupCount.cs
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

namespace Rubrik.SecurityCloud.Types
{
    #region InstalledVersionGroupCount
    public class InstalledVersionGroupCount: IFragment
    {
        #region members
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        [JsonProperty("group")]
        public System.String? Group { get; set; }

        //      C# -> System.Boolean? IsUpgradeRecommended
        // GraphQL -> isUpgradeRecommended: Boolean! (scalar)
        [JsonProperty("isUpgradeRecommended")]
        public System.Boolean? IsUpgradeRecommended { get; set; }

        #endregion

    #region methods

    public InstalledVersionGroupCount Set(
        System.Int32? Count = null,
        System.String? Group = null,
        System.Boolean? IsUpgradeRecommended = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Group != null ) {
            this.Group = Group;
        }
        if ( IsUpgradeRecommended != null ) {
            this.IsUpgradeRecommended = IsUpgradeRecommended;
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
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count != null)
            {
                 s += ind + "count\n";

            }
            //      C# -> System.String? Group
            // GraphQL -> group: String! (scalar)
            if (this.Group != null)
            {
                 s += ind + "group\n";

            }
            //      C# -> System.Boolean? IsUpgradeRecommended
            // GraphQL -> isUpgradeRecommended: Boolean! (scalar)
            if (this.IsUpgradeRecommended != null)
            {
                 s += ind + "isUpgradeRecommended\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Count
            // GraphQL -> count: Int! (scalar)
            if (this.Count == null && Exploration.Includes(parent + ".count$"))
            {
                this.Count = new System.Int32();
            }
            //      C# -> System.String? Group
            // GraphQL -> group: String! (scalar)
            if (this.Group == null && Exploration.Includes(parent + ".group$"))
            {
                this.Group = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsUpgradeRecommended
            // GraphQL -> isUpgradeRecommended: Boolean! (scalar)
            if (this.IsUpgradeRecommended == null && Exploration.Includes(parent + ".isUpgradeRecommended$"))
            {
                this.IsUpgradeRecommended = new System.Boolean();
            }
        }


    #endregion

    } // class InstalledVersionGroupCount
    #endregion

    public static class ListInstalledVersionGroupCountExtensions
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
            this List<InstalledVersionGroupCount> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<InstalledVersionGroupCount> list, 
            String parent = "")
        {
            var item = new InstalledVersionGroupCount();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types