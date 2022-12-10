// ClassificationPolicyWhitelistDetailedEntry.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:28.
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
    #region ClassificationPolicyWhitelistDetailedEntry
    public class ClassificationPolicyWhitelistDetailedEntry: IFragment
    {
        #region members
        //      C# -> System.String? NativePath
        // GraphQL -> nativePath: String! (scalar)
        [JsonProperty("nativePath")]
        public System.String? NativePath { get; set; }

        //      C# -> System.String? StdPath
        // GraphQL -> stdPath: String! (scalar)
        [JsonProperty("stdPath")]
        public System.String? StdPath { get; set; }

        //      C# -> System.Int64? UpdateTs
        // GraphQL -> updateTs: Long! (scalar)
        [JsonProperty("updateTs")]
        public System.Int64? UpdateTs { get; set; }

        //      C# -> System.String? UpdateUsername
        // GraphQL -> updateUsername: String! (scalar)
        [JsonProperty("updateUsername")]
        public System.String? UpdateUsername { get; set; }

        //      C# -> HierarchyObject? Snappable
        // GraphQL -> snappable: HierarchyObject! (interface)
        [JsonProperty("snappable")]
        public HierarchyObject? Snappable { get; set; }

        #endregion

    #region methods

    public ClassificationPolicyWhitelistDetailedEntry Set(
        System.String? NativePath = null,
        System.String? StdPath = null,
        System.Int64? UpdateTs = null,
        System.String? UpdateUsername = null,
        HierarchyObject? Snappable = null
    ) 
    {
        if ( NativePath != null ) {
            this.NativePath = NativePath;
        }
        if ( StdPath != null ) {
            this.StdPath = StdPath;
        }
        if ( UpdateTs != null ) {
            this.UpdateTs = UpdateTs;
        }
        if ( UpdateUsername != null ) {
            this.UpdateUsername = UpdateUsername;
        }
        if ( Snappable != null ) {
            this.Snappable = Snappable;
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
            //      C# -> System.String? NativePath
            // GraphQL -> nativePath: String! (scalar)
            if (this.NativePath != null)
            {
                 s += ind + "nativePath\n";

            }
            //      C# -> System.String? StdPath
            // GraphQL -> stdPath: String! (scalar)
            if (this.StdPath != null)
            {
                 s += ind + "stdPath\n";

            }
            //      C# -> System.Int64? UpdateTs
            // GraphQL -> updateTs: Long! (scalar)
            if (this.UpdateTs != null)
            {
                 s += ind + "updateTs\n";

            }
            //      C# -> System.String? UpdateUsername
            // GraphQL -> updateUsername: String! (scalar)
            if (this.UpdateUsername != null)
            {
                 s += ind + "updateUsername\n";

            }
                        //      C# -> HierarchyObject? Snappable
            // GraphQL -> snappable: HierarchyObject! (interface)
            if (this.Snappable != null)
            {
                s += ind + "snappable\n";
                s += ind + "{\n";

                string typename = this.Snappable.GetType().ToString();
                int typenameIdx = typename.LastIndexOf('.');
                typename = typename.Substring(typenameIdx + 1);
                s += ind + String.Format("... on {0}\n", typename);
                s += ind + "{\n" +

                this.Snappable.AsFragment(indent+1) +

                ind + "}\n" +

                ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? NativePath
            // GraphQL -> nativePath: String! (scalar)
            if (this.NativePath == null && Exploration.Includes(parent + ".nativePath$"))
            {
                this.NativePath = new System.String("FETCH");
            }
            //      C# -> System.String? StdPath
            // GraphQL -> stdPath: String! (scalar)
            if (this.StdPath == null && Exploration.Includes(parent + ".stdPath$"))
            {
                this.StdPath = new System.String("FETCH");
            }
            //      C# -> System.Int64? UpdateTs
            // GraphQL -> updateTs: Long! (scalar)
            if (this.UpdateTs == null && Exploration.Includes(parent + ".updateTs$"))
            {
                this.UpdateTs = new System.Int64();
            }
            //      C# -> System.String? UpdateUsername
            // GraphQL -> updateUsername: String! (scalar)
            if (this.UpdateUsername == null && Exploration.Includes(parent + ".updateUsername$"))
            {
                this.UpdateUsername = new System.String("FETCH");
            }
            //      C# -> HierarchyObject? Snappable
            // GraphQL -> snappable: HierarchyObject! (interface)
            if (this.Snappable == null && Exploration.Includes(parent + ".snappable"))
            {
                this.Snappable = (HierarchyObject)InterfaceHelper.CreateInstanceOfFirstType(typeof(HierarchyObject));
                this.Snappable.ApplyExploratoryFragment(parent + ".snappable");
            }
        }


    #endregion

    } // class ClassificationPolicyWhitelistDetailedEntry
    #endregion

    public static class ListClassificationPolicyWhitelistDetailedEntryExtensions
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
            this List<ClassificationPolicyWhitelistDetailedEntry> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<ClassificationPolicyWhitelistDetailedEntry> list, 
            String parent = "")
        {
            var item = new ClassificationPolicyWhitelistDetailedEntry();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types