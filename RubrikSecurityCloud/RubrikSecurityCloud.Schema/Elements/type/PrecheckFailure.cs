// PrecheckFailure.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:10.
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
    #region PrecheckFailure
    public class PrecheckFailure: IFragment
    {
        #region members
        //      C# -> System.String? Cause
        // GraphQL -> cause: String! (scalar)
        [JsonProperty("cause")]
        public System.String? Cause { get; set; }

        //      C# -> System.String? PrecheckName
        // GraphQL -> precheckName: String! (scalar)
        [JsonProperty("precheckName")]
        public System.String? PrecheckName { get; set; }

        //      C# -> System.String? Remedy
        // GraphQL -> remedy: String! (scalar)
        [JsonProperty("remedy")]
        public System.String? Remedy { get; set; }

        //      C# -> System.Boolean? UpgradeBlocker
        // GraphQL -> upgradeBlocker: Boolean! (scalar)
        [JsonProperty("upgradeBlocker")]
        public System.Boolean? UpgradeBlocker { get; set; }

        #endregion

    #region methods

    public PrecheckFailure Set(
        System.String? Cause = null,
        System.String? PrecheckName = null,
        System.String? Remedy = null,
        System.Boolean? UpgradeBlocker = null
    ) 
    {
        if ( Cause != null ) {
            this.Cause = Cause;
        }
        if ( PrecheckName != null ) {
            this.PrecheckName = PrecheckName;
        }
        if ( Remedy != null ) {
            this.Remedy = Remedy;
        }
        if ( UpgradeBlocker != null ) {
            this.UpgradeBlocker = UpgradeBlocker;
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
            //      C# -> System.String? Cause
            // GraphQL -> cause: String! (scalar)
            if (this.Cause != null)
            {
                 s += ind + "cause\n";

            }
            //      C# -> System.String? PrecheckName
            // GraphQL -> precheckName: String! (scalar)
            if (this.PrecheckName != null)
            {
                 s += ind + "precheckName\n";

            }
            //      C# -> System.String? Remedy
            // GraphQL -> remedy: String! (scalar)
            if (this.Remedy != null)
            {
                 s += ind + "remedy\n";

            }
            //      C# -> System.Boolean? UpgradeBlocker
            // GraphQL -> upgradeBlocker: Boolean! (scalar)
            if (this.UpgradeBlocker != null)
            {
                 s += ind + "upgradeBlocker\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Cause
            // GraphQL -> cause: String! (scalar)
            if (this.Cause == null && Exploration.Includes(parent + ".cause$"))
            {
                this.Cause = new System.String("FETCH");
            }
            //      C# -> System.String? PrecheckName
            // GraphQL -> precheckName: String! (scalar)
            if (this.PrecheckName == null && Exploration.Includes(parent + ".precheckName$"))
            {
                this.PrecheckName = new System.String("FETCH");
            }
            //      C# -> System.String? Remedy
            // GraphQL -> remedy: String! (scalar)
            if (this.Remedy == null && Exploration.Includes(parent + ".remedy$"))
            {
                this.Remedy = new System.String("FETCH");
            }
            //      C# -> System.Boolean? UpgradeBlocker
            // GraphQL -> upgradeBlocker: Boolean! (scalar)
            if (this.UpgradeBlocker == null && Exploration.Includes(parent + ".upgradeBlocker$"))
            {
                this.UpgradeBlocker = new System.Boolean();
            }
        }


    #endregion

    } // class PrecheckFailure
    #endregion

    public static class ListPrecheckFailureExtensions
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
            this List<PrecheckFailure> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PrecheckFailure> list, 
            String parent = "")
        {
            var item = new PrecheckFailure();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types