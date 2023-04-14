// SlaManagedVolumeScriptSummary.cs
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
    #region SlaManagedVolumeScriptSummary
    public class SlaManagedVolumeScriptSummary: IFragment
    {
        #region members
        //      C# -> System.String? RunAsUser
        // GraphQL -> runAsUser: String! (scalar)
        [JsonProperty("runAsUser")]
        public System.String? RunAsUser { get; set; }

        //      C# -> System.String? ScriptCommand
        // GraphQL -> scriptCommand: String! (scalar)
        [JsonProperty("scriptCommand")]
        public System.String? ScriptCommand { get; set; }

        //      C# -> System.Int64? Timeout
        // GraphQL -> timeout: Long (scalar)
        [JsonProperty("timeout")]
        public System.Int64? Timeout { get; set; }

        #endregion

    #region methods

    public SlaManagedVolumeScriptSummary Set(
        System.String? RunAsUser = null,
        System.String? ScriptCommand = null,
        System.Int64? Timeout = null
    ) 
    {
        if ( RunAsUser != null ) {
            this.RunAsUser = RunAsUser;
        }
        if ( ScriptCommand != null ) {
            this.ScriptCommand = ScriptCommand;
        }
        if ( Timeout != null ) {
            this.Timeout = Timeout;
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
            //      C# -> System.String? RunAsUser
            // GraphQL -> runAsUser: String! (scalar)
            if (this.RunAsUser != null)
            {
                 s += ind + "runAsUser\n";

            }
            //      C# -> System.String? ScriptCommand
            // GraphQL -> scriptCommand: String! (scalar)
            if (this.ScriptCommand != null)
            {
                 s += ind + "scriptCommand\n";

            }
            //      C# -> System.Int64? Timeout
            // GraphQL -> timeout: Long (scalar)
            if (this.Timeout != null)
            {
                 s += ind + "timeout\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? RunAsUser
            // GraphQL -> runAsUser: String! (scalar)
            if (this.RunAsUser == null && Exploration.Includes(parent + ".runAsUser$"))
            {
                this.RunAsUser = new System.String("FETCH");
            }
            //      C# -> System.String? ScriptCommand
            // GraphQL -> scriptCommand: String! (scalar)
            if (this.ScriptCommand == null && Exploration.Includes(parent + ".scriptCommand$"))
            {
                this.ScriptCommand = new System.String("FETCH");
            }
            //      C# -> System.Int64? Timeout
            // GraphQL -> timeout: Long (scalar)
            if (this.Timeout == null && Exploration.Includes(parent + ".timeout$"))
            {
                this.Timeout = new System.Int64();
            }
        }


    #endregion

    } // class SlaManagedVolumeScriptSummary
    #endregion

    public static class ListSlaManagedVolumeScriptSummaryExtensions
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
            this List<SlaManagedVolumeScriptSummary> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<SlaManagedVolumeScriptSummary> list, 
            String parent = "")
        {
            var item = new SlaManagedVolumeScriptSummary();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types