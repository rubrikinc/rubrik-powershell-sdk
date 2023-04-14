// EulaState.cs
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
    #region EulaState
    public class EulaState: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsAccepted
        // GraphQL -> isAccepted: Boolean! (scalar)
        [JsonProperty("isAccepted")]
        public System.Boolean? IsAccepted { get; set; }

        //      C# -> System.Boolean? IsPactsafeEnabled
        // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
        [JsonProperty("isPactsafeEnabled")]
        public System.Boolean? IsPactsafeEnabled { get; set; }

        //      C# -> System.Boolean? IsPactsafeV2Enabled
        // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
        [JsonProperty("isPactsafeV2Enabled")]
        public System.Boolean? IsPactsafeV2Enabled { get; set; }

        #endregion

    #region methods

    public EulaState Set(
        System.Boolean? IsAccepted = null,
        System.Boolean? IsPactsafeEnabled = null,
        System.Boolean? IsPactsafeV2Enabled = null
    ) 
    {
        if ( IsAccepted != null ) {
            this.IsAccepted = IsAccepted;
        }
        if ( IsPactsafeEnabled != null ) {
            this.IsPactsafeEnabled = IsPactsafeEnabled;
        }
        if ( IsPactsafeV2Enabled != null ) {
            this.IsPactsafeV2Enabled = IsPactsafeV2Enabled;
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
            //      C# -> System.Boolean? IsAccepted
            // GraphQL -> isAccepted: Boolean! (scalar)
            if (this.IsAccepted != null)
            {
                 s += ind + "isAccepted\n";

            }
            //      C# -> System.Boolean? IsPactsafeEnabled
            // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
            if (this.IsPactsafeEnabled != null)
            {
                 s += ind + "isPactsafeEnabled\n";

            }
            //      C# -> System.Boolean? IsPactsafeV2Enabled
            // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
            if (this.IsPactsafeV2Enabled != null)
            {
                 s += ind + "isPactsafeV2Enabled\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsAccepted
            // GraphQL -> isAccepted: Boolean! (scalar)
            if (this.IsAccepted == null && Exploration.Includes(parent + ".isAccepted$"))
            {
                this.IsAccepted = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPactsafeEnabled
            // GraphQL -> isPactsafeEnabled: Boolean! (scalar)
            if (this.IsPactsafeEnabled == null && Exploration.Includes(parent + ".isPactsafeEnabled$"))
            {
                this.IsPactsafeEnabled = new System.Boolean();
            }
            //      C# -> System.Boolean? IsPactsafeV2Enabled
            // GraphQL -> isPactsafeV2Enabled: Boolean! (scalar)
            if (this.IsPactsafeV2Enabled == null && Exploration.Includes(parent + ".isPactsafeV2Enabled$"))
            {
                this.IsPactsafeV2Enabled = new System.Boolean();
            }
        }


    #endregion

    } // class EulaState
    #endregion

    public static class ListEulaStateExtensions
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
            this List<EulaState> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<EulaState> list, 
            String parent = "")
        {
            var item = new EulaState();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types