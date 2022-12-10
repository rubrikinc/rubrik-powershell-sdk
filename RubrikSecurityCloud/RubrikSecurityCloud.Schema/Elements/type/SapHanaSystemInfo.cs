// SapHanaSystemInfo.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:39.
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
    #region SapHanaSystemInfo
    public class SapHanaSystemInfo: IFragment
    {
        #region members
        //      C# -> System.String? HanaVersion
        // GraphQL -> hanaVersion: String! (scalar)
        [JsonProperty("hanaVersion")]
        public System.String? HanaVersion { get; set; }

        //      C# -> System.Boolean? IsSystemReplicationEnabled
        // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
        [JsonProperty("isSystemReplicationEnabled")]
        public System.Boolean? IsSystemReplicationEnabled { get; set; }

        #endregion

    #region methods

    public SapHanaSystemInfo Set(
        System.String? HanaVersion = null,
        System.Boolean? IsSystemReplicationEnabled = null
    ) 
    {
        if ( HanaVersion != null ) {
            this.HanaVersion = HanaVersion;
        }
        if ( IsSystemReplicationEnabled != null ) {
            this.IsSystemReplicationEnabled = IsSystemReplicationEnabled;
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
            //      C# -> System.String? HanaVersion
            // GraphQL -> hanaVersion: String! (scalar)
            if (this.HanaVersion != null)
            {
                 s += ind + "hanaVersion\n";

            }
            //      C# -> System.Boolean? IsSystemReplicationEnabled
            // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
            if (this.IsSystemReplicationEnabled != null)
            {
                 s += ind + "isSystemReplicationEnabled\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HanaVersion
            // GraphQL -> hanaVersion: String! (scalar)
            if (this.HanaVersion == null && Exploration.Includes(parent + ".hanaVersion$"))
            {
                this.HanaVersion = new System.String("FETCH");
            }
            //      C# -> System.Boolean? IsSystemReplicationEnabled
            // GraphQL -> isSystemReplicationEnabled: Boolean! (scalar)
            if (this.IsSystemReplicationEnabled == null && Exploration.Includes(parent + ".isSystemReplicationEnabled$"))
            {
                this.IsSystemReplicationEnabled = new System.Boolean();
            }
        }


    #endregion

    } // class SapHanaSystemInfo
    #endregion

    public static class ListSapHanaSystemInfoExtensions
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
            this List<SapHanaSystemInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SapHanaSystemInfo> list, 
            String parent = "")
        {
            var item = new SapHanaSystemInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types