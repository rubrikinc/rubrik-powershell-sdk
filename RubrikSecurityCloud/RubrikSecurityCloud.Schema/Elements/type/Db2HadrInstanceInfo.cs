// Db2HadrInstanceInfo.cs
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
    #region Db2HadrInstanceInfo
    public class Db2HadrInstanceInfo: IFragment
    {
        #region members
        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }

        //      C# -> Db2Instance? Db2Instance
        // GraphQL -> db2Instance: Db2Instance! (type)
        [JsonProperty("db2Instance")]
        public Db2Instance? Db2Instance { get; set; }

        #endregion

    #region methods

    public Db2HadrInstanceInfo Set(
        System.String? Role = null,
        Db2Instance? Db2Instance = null
    ) 
    {
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( Db2Instance != null ) {
            this.Db2Instance = Db2Instance;
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
            //      C# -> System.String? Role
            // GraphQL -> role: String! (scalar)
            if (this.Role != null)
            {
                 s += ind + "role\n";

            }
            //      C# -> Db2Instance? Db2Instance
            // GraphQL -> db2Instance: Db2Instance! (type)
            if (this.Db2Instance != null)
            {
                 s += ind + "db2Instance\n";

                 s += ind + "{\n" + 
                 this.Db2Instance.AsFragment(indent+1) + 
                 ind + "}\n";
            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Role
            // GraphQL -> role: String! (scalar)
            if (this.Role == null && Exploration.Includes(parent + ".role$"))
            {
                this.Role = new System.String("FETCH");
            }
            //      C# -> Db2Instance? Db2Instance
            // GraphQL -> db2Instance: Db2Instance! (type)
            if (this.Db2Instance == null && Exploration.Includes(parent + ".db2Instance"))
            {
                this.Db2Instance = new Db2Instance();
                this.Db2Instance.ApplyExploratoryFragment(parent + ".db2Instance");
            }
        }


    #endregion

    } // class Db2HadrInstanceInfo
    #endregion

    public static class ListDb2HadrInstanceInfoExtensions
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
            this List<Db2HadrInstanceInfo> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<Db2HadrInstanceInfo> list, 
            String parent = "")
        {
            var item = new Db2HadrInstanceInfo();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types