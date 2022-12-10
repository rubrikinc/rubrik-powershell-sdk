// PhoenixRolloutProgress.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:55.
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
    #region PhoenixRolloutProgress
    public class PhoenixRolloutProgress: IFragment
    {
        #region members
        //      C# -> System.Int32? NumEnabled
        // GraphQL -> numEnabled: Int! (scalar)
        [JsonProperty("numEnabled")]
        public System.Int32? NumEnabled { get; set; }

        //      C# -> System.Int32? NumInProcess
        // GraphQL -> numInProcess: Int! (scalar)
        [JsonProperty("numInProcess")]
        public System.Int32? NumInProcess { get; set; }

        //      C# -> System.Int32? NumIncompleteFirstFull
        // GraphQL -> numIncompleteFirstFull: Int! (scalar)
        [JsonProperty("numIncompleteFirstFull")]
        public System.Int32? NumIncompleteFirstFull { get; set; }

        //      C# -> System.Int32? NumNotEnabled
        // GraphQL -> numNotEnabled: Int! (scalar)
        [JsonProperty("numNotEnabled")]
        public System.Int32? NumNotEnabled { get; set; }

        #endregion

    #region methods

    public PhoenixRolloutProgress Set(
        System.Int32? NumEnabled = null,
        System.Int32? NumInProcess = null,
        System.Int32? NumIncompleteFirstFull = null,
        System.Int32? NumNotEnabled = null
    ) 
    {
        if ( NumEnabled != null ) {
            this.NumEnabled = NumEnabled;
        }
        if ( NumInProcess != null ) {
            this.NumInProcess = NumInProcess;
        }
        if ( NumIncompleteFirstFull != null ) {
            this.NumIncompleteFirstFull = NumIncompleteFirstFull;
        }
        if ( NumNotEnabled != null ) {
            this.NumNotEnabled = NumNotEnabled;
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
            //      C# -> System.Int32? NumEnabled
            // GraphQL -> numEnabled: Int! (scalar)
            if (this.NumEnabled != null)
            {
                 s += ind + "numEnabled\n";

            }
            //      C# -> System.Int32? NumInProcess
            // GraphQL -> numInProcess: Int! (scalar)
            if (this.NumInProcess != null)
            {
                 s += ind + "numInProcess\n";

            }
            //      C# -> System.Int32? NumIncompleteFirstFull
            // GraphQL -> numIncompleteFirstFull: Int! (scalar)
            if (this.NumIncompleteFirstFull != null)
            {
                 s += ind + "numIncompleteFirstFull\n";

            }
            //      C# -> System.Int32? NumNotEnabled
            // GraphQL -> numNotEnabled: Int! (scalar)
            if (this.NumNotEnabled != null)
            {
                 s += ind + "numNotEnabled\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? NumEnabled
            // GraphQL -> numEnabled: Int! (scalar)
            if (this.NumEnabled == null && Exploration.Includes(parent + ".numEnabled$"))
            {
                this.NumEnabled = new System.Int32();
            }
            //      C# -> System.Int32? NumInProcess
            // GraphQL -> numInProcess: Int! (scalar)
            if (this.NumInProcess == null && Exploration.Includes(parent + ".numInProcess$"))
            {
                this.NumInProcess = new System.Int32();
            }
            //      C# -> System.Int32? NumIncompleteFirstFull
            // GraphQL -> numIncompleteFirstFull: Int! (scalar)
            if (this.NumIncompleteFirstFull == null && Exploration.Includes(parent + ".numIncompleteFirstFull$"))
            {
                this.NumIncompleteFirstFull = new System.Int32();
            }
            //      C# -> System.Int32? NumNotEnabled
            // GraphQL -> numNotEnabled: Int! (scalar)
            if (this.NumNotEnabled == null && Exploration.Includes(parent + ".numNotEnabled$"))
            {
                this.NumNotEnabled = new System.Int32();
            }
        }


    #endregion

    } // class PhoenixRolloutProgress
    #endregion

    public static class ListPhoenixRolloutProgressExtensions
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
            this List<PhoenixRolloutProgress> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PhoenixRolloutProgress> list, 
            String parent = "")
        {
            var item = new PhoenixRolloutProgress();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types