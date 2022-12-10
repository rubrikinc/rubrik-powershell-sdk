// NutanixBackupScript.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:50.
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
    #region NutanixBackupScript
    public class NutanixBackupScript: IFragment
    {
        #region members
        //      C# -> System.String? ScriptPath
        // GraphQL -> scriptPath: String (scalar)
        [JsonProperty("scriptPath")]
        public System.String? ScriptPath { get; set; }

        //      C# -> System.Int64? TimeoutMs
        // GraphQL -> timeoutMs: Long! (scalar)
        [JsonProperty("timeoutMs")]
        public System.Int64? TimeoutMs { get; set; }

        //      C# -> NutanixBackupScriptFailureHandling? FailureHandling
        // GraphQL -> failureHandling: NutanixBackupScriptFailureHandling! (enum)
        [JsonProperty("failureHandling")]
        public NutanixBackupScriptFailureHandling? FailureHandling { get; set; }

        #endregion

    #region methods

    public NutanixBackupScript Set(
        System.String? ScriptPath = null,
        System.Int64? TimeoutMs = null,
        NutanixBackupScriptFailureHandling? FailureHandling = null
    ) 
    {
        if ( ScriptPath != null ) {
            this.ScriptPath = ScriptPath;
        }
        if ( TimeoutMs != null ) {
            this.TimeoutMs = TimeoutMs;
        }
        if ( FailureHandling != null ) {
            this.FailureHandling = FailureHandling;
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
            //      C# -> System.String? ScriptPath
            // GraphQL -> scriptPath: String (scalar)
            if (this.ScriptPath != null)
            {
                 s += ind + "scriptPath\n";

            }
            //      C# -> System.Int64? TimeoutMs
            // GraphQL -> timeoutMs: Long! (scalar)
            if (this.TimeoutMs != null)
            {
                 s += ind + "timeoutMs\n";

            }
            //      C# -> NutanixBackupScriptFailureHandling? FailureHandling
            // GraphQL -> failureHandling: NutanixBackupScriptFailureHandling! (enum)
            if (this.FailureHandling != null)
            {
                 s += ind + "failureHandling\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ScriptPath
            // GraphQL -> scriptPath: String (scalar)
            if (this.ScriptPath == null && Exploration.Includes(parent + ".scriptPath$"))
            {
                this.ScriptPath = new System.String("FETCH");
            }
            //      C# -> System.Int64? TimeoutMs
            // GraphQL -> timeoutMs: Long! (scalar)
            if (this.TimeoutMs == null && Exploration.Includes(parent + ".timeoutMs$"))
            {
                this.TimeoutMs = new System.Int64();
            }
            //      C# -> NutanixBackupScriptFailureHandling? FailureHandling
            // GraphQL -> failureHandling: NutanixBackupScriptFailureHandling! (enum)
            if (this.FailureHandling == null && Exploration.Includes(parent + ".failureHandling$"))
            {
                this.FailureHandling = new NutanixBackupScriptFailureHandling();
            }
        }


    #endregion

    } // class NutanixBackupScript
    #endregion

    public static class ListNutanixBackupScriptExtensions
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
            this List<NutanixBackupScript> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<NutanixBackupScript> list, 
            String parent = "")
        {
            var item = new NutanixBackupScript();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types