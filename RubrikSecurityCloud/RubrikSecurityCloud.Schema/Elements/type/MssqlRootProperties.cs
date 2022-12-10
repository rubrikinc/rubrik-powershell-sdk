// MssqlRootProperties.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:46.
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
    #region MssqlRootProperties
    public class MssqlRootProperties: IFragment
    {
        #region members
        //      C# -> System.String? RootId
        // GraphQL -> rootId: String (scalar)
        [JsonProperty("rootId")]
        public System.String? RootId { get; set; }

        //      C# -> System.String? RootName
        // GraphQL -> rootName: String! (scalar)
        [JsonProperty("rootName")]
        public System.String? RootName { get; set; }

        //      C# -> System.String? RootRole
        // GraphQL -> rootRole: String (scalar)
        [JsonProperty("rootRole")]
        public System.String? RootRole { get; set; }

        //      C# -> MssqlRootPropertiesRootType? RootType
        // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
        [JsonProperty("rootType")]
        public MssqlRootPropertiesRootType? RootType { get; set; }

        #endregion

    #region methods

    public MssqlRootProperties Set(
        System.String? RootId = null,
        System.String? RootName = null,
        System.String? RootRole = null,
        MssqlRootPropertiesRootType? RootType = null
    ) 
    {
        if ( RootId != null ) {
            this.RootId = RootId;
        }
        if ( RootName != null ) {
            this.RootName = RootName;
        }
        if ( RootRole != null ) {
            this.RootRole = RootRole;
        }
        if ( RootType != null ) {
            this.RootType = RootType;
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
            //      C# -> System.String? RootId
            // GraphQL -> rootId: String (scalar)
            if (this.RootId != null)
            {
                 s += ind + "rootId\n";

            }
            //      C# -> System.String? RootName
            // GraphQL -> rootName: String! (scalar)
            if (this.RootName != null)
            {
                 s += ind + "rootName\n";

            }
            //      C# -> System.String? RootRole
            // GraphQL -> rootRole: String (scalar)
            if (this.RootRole != null)
            {
                 s += ind + "rootRole\n";

            }
            //      C# -> MssqlRootPropertiesRootType? RootType
            // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
            if (this.RootType != null)
            {
                 s += ind + "rootType\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? RootId
            // GraphQL -> rootId: String (scalar)
            if (this.RootId == null && Exploration.Includes(parent + ".rootId$"))
            {
                this.RootId = new System.String("FETCH");
            }
            //      C# -> System.String? RootName
            // GraphQL -> rootName: String! (scalar)
            if (this.RootName == null && Exploration.Includes(parent + ".rootName$"))
            {
                this.RootName = new System.String("FETCH");
            }
            //      C# -> System.String? RootRole
            // GraphQL -> rootRole: String (scalar)
            if (this.RootRole == null && Exploration.Includes(parent + ".rootRole$"))
            {
                this.RootRole = new System.String("FETCH");
            }
            //      C# -> MssqlRootPropertiesRootType? RootType
            // GraphQL -> rootType: MssqlRootPropertiesRootType! (enum)
            if (this.RootType == null && Exploration.Includes(parent + ".rootType$"))
            {
                this.RootType = new MssqlRootPropertiesRootType();
            }
        }


    #endregion

    } // class MssqlRootProperties
    #endregion

    public static class ListMssqlRootPropertiesExtensions
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
            this List<MssqlRootProperties> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<MssqlRootProperties> list, 
            String parent = "")
        {
            var item = new MssqlRootProperties();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types