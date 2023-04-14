// DataGuardGroupMember.cs
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
    #region DataGuardGroupMember
    public class DataGuardGroupMember: IFragment
    {
        #region members
        //      C# -> System.String? DbUniqueName
        // GraphQL -> dbUniqueName: String! (scalar)
        [JsonProperty("dbUniqueName")]
        public System.String? DbUniqueName { get; set; }

        //      C# -> System.String? RacId
        // GraphQL -> racId: String (scalar)
        [JsonProperty("racId")]
        public System.String? RacId { get; set; }

        //      C# -> System.String? RacName
        // GraphQL -> racName: String (scalar)
        [JsonProperty("racName")]
        public System.String? RacName { get; set; }

        //      C# -> System.String? Role
        // GraphQL -> role: String! (scalar)
        [JsonProperty("role")]
        public System.String? Role { get; set; }

        //      C# -> System.String? StandaloneHostId
        // GraphQL -> standaloneHostId: String (scalar)
        [JsonProperty("standaloneHostId")]
        public System.String? StandaloneHostId { get; set; }

        //      C# -> System.String? StandaloneHostName
        // GraphQL -> standaloneHostName: String (scalar)
        [JsonProperty("standaloneHostName")]
        public System.String? StandaloneHostName { get; set; }

        #endregion

    #region methods

    public DataGuardGroupMember Set(
        System.String? DbUniqueName = null,
        System.String? RacId = null,
        System.String? RacName = null,
        System.String? Role = null,
        System.String? StandaloneHostId = null,
        System.String? StandaloneHostName = null
    ) 
    {
        if ( DbUniqueName != null ) {
            this.DbUniqueName = DbUniqueName;
        }
        if ( RacId != null ) {
            this.RacId = RacId;
        }
        if ( RacName != null ) {
            this.RacName = RacName;
        }
        if ( Role != null ) {
            this.Role = Role;
        }
        if ( StandaloneHostId != null ) {
            this.StandaloneHostId = StandaloneHostId;
        }
        if ( StandaloneHostName != null ) {
            this.StandaloneHostName = StandaloneHostName;
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
            //      C# -> System.String? DbUniqueName
            // GraphQL -> dbUniqueName: String! (scalar)
            if (this.DbUniqueName != null)
            {
                 s += ind + "dbUniqueName\n";

            }
            //      C# -> System.String? RacId
            // GraphQL -> racId: String (scalar)
            if (this.RacId != null)
            {
                 s += ind + "racId\n";

            }
            //      C# -> System.String? RacName
            // GraphQL -> racName: String (scalar)
            if (this.RacName != null)
            {
                 s += ind + "racName\n";

            }
            //      C# -> System.String? Role
            // GraphQL -> role: String! (scalar)
            if (this.Role != null)
            {
                 s += ind + "role\n";

            }
            //      C# -> System.String? StandaloneHostId
            // GraphQL -> standaloneHostId: String (scalar)
            if (this.StandaloneHostId != null)
            {
                 s += ind + "standaloneHostId\n";

            }
            //      C# -> System.String? StandaloneHostName
            // GraphQL -> standaloneHostName: String (scalar)
            if (this.StandaloneHostName != null)
            {
                 s += ind + "standaloneHostName\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? DbUniqueName
            // GraphQL -> dbUniqueName: String! (scalar)
            if (this.DbUniqueName == null && Exploration.Includes(parent + ".dbUniqueName$"))
            {
                this.DbUniqueName = new System.String("FETCH");
            }
            //      C# -> System.String? RacId
            // GraphQL -> racId: String (scalar)
            if (this.RacId == null && Exploration.Includes(parent + ".racId$"))
            {
                this.RacId = new System.String("FETCH");
            }
            //      C# -> System.String? RacName
            // GraphQL -> racName: String (scalar)
            if (this.RacName == null && Exploration.Includes(parent + ".racName$"))
            {
                this.RacName = new System.String("FETCH");
            }
            //      C# -> System.String? Role
            // GraphQL -> role: String! (scalar)
            if (this.Role == null && Exploration.Includes(parent + ".role$"))
            {
                this.Role = new System.String("FETCH");
            }
            //      C# -> System.String? StandaloneHostId
            // GraphQL -> standaloneHostId: String (scalar)
            if (this.StandaloneHostId == null && Exploration.Includes(parent + ".standaloneHostId$"))
            {
                this.StandaloneHostId = new System.String("FETCH");
            }
            //      C# -> System.String? StandaloneHostName
            // GraphQL -> standaloneHostName: String (scalar)
            if (this.StandaloneHostName == null && Exploration.Includes(parent + ".standaloneHostName$"))
            {
                this.StandaloneHostName = new System.String("FETCH");
            }
        }


    #endregion

    } // class DataGuardGroupMember
    #endregion

    public static class ListDataGuardGroupMemberExtensions
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
            this List<DataGuardGroupMember> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<DataGuardGroupMember> list, 
            String parent = "")
        {
            var item = new DataGuardGroupMember();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types