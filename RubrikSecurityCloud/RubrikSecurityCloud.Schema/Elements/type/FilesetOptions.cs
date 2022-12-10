// FilesetOptions.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:25.
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
    #region FilesetOptions
    public class FilesetOptions: IFragment
    {
        #region members
        //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
        // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
        [JsonProperty("allowBackupHiddenFoldersInNetworkMounts")]
        public System.Boolean? AllowBackupHiddenFoldersInNetworkMounts { get; set; }

        //      C# -> System.Boolean? AllowBackupNetworkMounts
        // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
        [JsonProperty("allowBackupNetworkMounts")]
        public System.Boolean? AllowBackupNetworkMounts { get; set; }

        //      C# -> System.Boolean? UseWindowsVss
        // GraphQL -> useWindowsVss: Boolean (scalar)
        [JsonProperty("useWindowsVss")]
        public System.Boolean? UseWindowsVss { get; set; }

        #endregion

    #region methods

    public FilesetOptions Set(
        System.Boolean? AllowBackupHiddenFoldersInNetworkMounts = null,
        System.Boolean? AllowBackupNetworkMounts = null,
        System.Boolean? UseWindowsVss = null
    ) 
    {
        if ( AllowBackupHiddenFoldersInNetworkMounts != null ) {
            this.AllowBackupHiddenFoldersInNetworkMounts = AllowBackupHiddenFoldersInNetworkMounts;
        }
        if ( AllowBackupNetworkMounts != null ) {
            this.AllowBackupNetworkMounts = AllowBackupNetworkMounts;
        }
        if ( UseWindowsVss != null ) {
            this.UseWindowsVss = UseWindowsVss;
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
            //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
            // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
            if (this.AllowBackupHiddenFoldersInNetworkMounts != null)
            {
                 s += ind + "allowBackupHiddenFoldersInNetworkMounts\n";

            }
            //      C# -> System.Boolean? AllowBackupNetworkMounts
            // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
            if (this.AllowBackupNetworkMounts != null)
            {
                 s += ind + "allowBackupNetworkMounts\n";

            }
            //      C# -> System.Boolean? UseWindowsVss
            // GraphQL -> useWindowsVss: Boolean (scalar)
            if (this.UseWindowsVss != null)
            {
                 s += ind + "useWindowsVss\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? AllowBackupHiddenFoldersInNetworkMounts
            // GraphQL -> allowBackupHiddenFoldersInNetworkMounts: Boolean (scalar)
            if (this.AllowBackupHiddenFoldersInNetworkMounts == null && Exploration.Includes(parent + ".allowBackupHiddenFoldersInNetworkMounts$"))
            {
                this.AllowBackupHiddenFoldersInNetworkMounts = new System.Boolean();
            }
            //      C# -> System.Boolean? AllowBackupNetworkMounts
            // GraphQL -> allowBackupNetworkMounts: Boolean (scalar)
            if (this.AllowBackupNetworkMounts == null && Exploration.Includes(parent + ".allowBackupNetworkMounts$"))
            {
                this.AllowBackupNetworkMounts = new System.Boolean();
            }
            //      C# -> System.Boolean? UseWindowsVss
            // GraphQL -> useWindowsVss: Boolean (scalar)
            if (this.UseWindowsVss == null && Exploration.Includes(parent + ".useWindowsVss$"))
            {
                this.UseWindowsVss = new System.Boolean();
            }
        }


    #endregion

    } // class FilesetOptions
    #endregion

    public static class ListFilesetOptionsExtensions
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
            this List<FilesetOptions> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetOptions> list, 
            String parent = "")
        {
            var item = new FilesetOptions();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types