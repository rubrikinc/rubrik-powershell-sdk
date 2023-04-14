// GcpNativeKmsCryptoKey.cs
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
    #region GcpNativeKmsCryptoKey
    public class GcpNativeKmsCryptoKey: IFragment
    {
        #region members
        //      C# -> System.String? Key
        // GraphQL -> key: String! (scalar)
        [JsonProperty("key")]
        public System.String? Key { get; set; }

        //      C# -> System.String? KeyRing
        // GraphQL -> keyRing: String! (scalar)
        [JsonProperty("keyRing")]
        public System.String? KeyRing { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.String? ProjectNativeId
        // GraphQL -> projectNativeId: String! (scalar)
        [JsonProperty("projectNativeId")]
        public System.String? ProjectNativeId { get; set; }

        #endregion

    #region methods

    public GcpNativeKmsCryptoKey Set(
        System.String? Key = null,
        System.String? KeyRing = null,
        System.String? Location = null,
        System.String? ProjectNativeId = null
    ) 
    {
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( KeyRing != null ) {
            this.KeyRing = KeyRing;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( ProjectNativeId != null ) {
            this.ProjectNativeId = ProjectNativeId;
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
            //      C# -> System.String? Key
            // GraphQL -> key: String! (scalar)
            if (this.Key != null)
            {
                 s += ind + "key\n";

            }
            //      C# -> System.String? KeyRing
            // GraphQL -> keyRing: String! (scalar)
            if (this.KeyRing != null)
            {
                 s += ind + "keyRing\n";

            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location != null)
            {
                 s += ind + "location\n";

            }
            //      C# -> System.String? ProjectNativeId
            // GraphQL -> projectNativeId: String! (scalar)
            if (this.ProjectNativeId != null)
            {
                 s += ind + "projectNativeId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? Key
            // GraphQL -> key: String! (scalar)
            if (this.Key == null && Exploration.Includes(parent + ".key$"))
            {
                this.Key = new System.String("FETCH");
            }
            //      C# -> System.String? KeyRing
            // GraphQL -> keyRing: String! (scalar)
            if (this.KeyRing == null && Exploration.Includes(parent + ".keyRing$"))
            {
                this.KeyRing = new System.String("FETCH");
            }
            //      C# -> System.String? Location
            // GraphQL -> location: String! (scalar)
            if (this.Location == null && Exploration.Includes(parent + ".location$"))
            {
                this.Location = new System.String("FETCH");
            }
            //      C# -> System.String? ProjectNativeId
            // GraphQL -> projectNativeId: String! (scalar)
            if (this.ProjectNativeId == null && Exploration.Includes(parent + ".projectNativeId$"))
            {
                this.ProjectNativeId = new System.String("FETCH");
            }
        }


    #endregion

    } // class GcpNativeKmsCryptoKey
    #endregion

    public static class ListGcpNativeKmsCryptoKeyExtensions
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
            this List<GcpNativeKmsCryptoKey> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GcpNativeKmsCryptoKey> list, 
            String parent = "")
        {
            var item = new GcpNativeKmsCryptoKey();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types