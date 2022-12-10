// ManagedVolumeSlaScriptConfig.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:41.
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
    #region ManagedVolumeSlaScriptConfig
    public class ManagedVolumeSlaScriptConfig: IFragment
    {
        #region members
        //      C# -> System.String? ScriptCommand
        // GraphQL -> scriptCommand: String! (scalar)
        [JsonProperty("scriptCommand")]
        public System.String? ScriptCommand { get; set; }

        //      C# -> System.Int64? Timeout
        // GraphQL -> timeout: Long! (scalar)
        [JsonProperty("timeout")]
        public System.Int64? Timeout { get; set; }

        #endregion

    #region methods

    public ManagedVolumeSlaScriptConfig Set(
        System.String? ScriptCommand = null,
        System.Int64? Timeout = null
    ) 
    {
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
            //      C# -> System.String? ScriptCommand
            // GraphQL -> scriptCommand: String! (scalar)
            if (this.ScriptCommand != null)
            {
                 s += ind + "scriptCommand\n";

            }
            //      C# -> System.Int64? Timeout
            // GraphQL -> timeout: Long! (scalar)
            if (this.Timeout != null)
            {
                 s += ind + "timeout\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ScriptCommand
            // GraphQL -> scriptCommand: String! (scalar)
            if (this.ScriptCommand == null && Exploration.Includes(parent + ".scriptCommand$"))
            {
                this.ScriptCommand = new System.String("FETCH");
            }
            //      C# -> System.Int64? Timeout
            // GraphQL -> timeout: Long! (scalar)
            if (this.Timeout == null && Exploration.Includes(parent + ".timeout$"))
            {
                this.Timeout = new System.Int64();
            }
        }


    #endregion

    } // class ManagedVolumeSlaScriptConfig
    #endregion

    public static class ListManagedVolumeSlaScriptConfigExtensions
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
            this List<ManagedVolumeSlaScriptConfig> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ManagedVolumeSlaScriptConfig> list, 
            String parent = "")
        {
            var item = new ManagedVolumeSlaScriptConfig();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types