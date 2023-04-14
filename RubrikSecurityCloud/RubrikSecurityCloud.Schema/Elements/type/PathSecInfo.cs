// PathSecInfo.cs
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
    #region PathSecInfo
    public class PathSecInfo: IFragment
    {
        #region members
        //      C# -> System.String? Owner
        // GraphQL -> owner: String! (scalar)
        [JsonProperty("owner")]
        public System.String? Owner { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }

        //      C# -> List<SddlPermission>? Permissions
        // GraphQL -> permissions: [SDDLPermission!]! (type)
        [JsonProperty("permissions")]
        public List<SddlPermission>? Permissions { get; set; }

        #endregion

    #region methods

    public PathSecInfo Set(
        System.String? Owner = null,
        System.String? Path = null,
        List<SddlPermission>? Permissions = null
    ) 
    {
        if ( Owner != null ) {
            this.Owner = Owner;
        }
        if ( Path != null ) {
            this.Path = Path;
        }
        if ( Permissions != null ) {
            this.Permissions = Permissions;
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
            //      C# -> System.String? Owner
            // GraphQL -> owner: String! (scalar)
            if (this.Owner != null)
            {
                 s += ind + "owner\n";

            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path != null)
            {
                 s += ind + "path\n";

            }
            //      C# -> List<SddlPermission>? Permissions
            // GraphQL -> permissions: [SDDLPermission!]! (type)
            if (this.Permissions != null)
            {
                 s += ind + "permissions\n";

                 s += ind + "{\n" + 
                 this.Permissions.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Owner
            // GraphQL -> owner: String! (scalar)
            if (this.Owner == null && Exploration.Includes(parent + ".owner$"))
            {
                this.Owner = new System.String("FETCH");
            }
            //      C# -> System.String? Path
            // GraphQL -> path: String! (scalar)
            if (this.Path == null && Exploration.Includes(parent + ".path$"))
            {
                this.Path = new System.String("FETCH");
            }
            //      C# -> List<SddlPermission>? Permissions
            // GraphQL -> permissions: [SDDLPermission!]! (type)
            if (this.Permissions == null && Exploration.Includes(parent + ".permissions"))
            {
                this.Permissions = new List<SddlPermission>();
                this.Permissions.ApplyExploratoryFragment(parent + ".permissions");
            }
        }


    #endregion

    } // class PathSecInfo
    #endregion

    public static class ListPathSecInfoExtensions
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
            this List<PathSecInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<PathSecInfo> list, 
            String parent = "")
        {
            var item = new PathSecInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types