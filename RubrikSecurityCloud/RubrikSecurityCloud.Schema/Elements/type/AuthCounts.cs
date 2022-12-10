// AuthCounts.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:56.
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
    #region AuthCounts
    public class AuthCounts: IFragment
    {
        #region members
        //      C# -> System.Int32? Authenticated
        // GraphQL -> authenticated: Int! (scalar)
        [JsonProperty("authenticated")]
        public System.Int32? Authenticated { get; set; }

        //      C# -> System.Int32? PartiallyAuthenticated
        // GraphQL -> partiallyAuthenticated: Int! (scalar)
        [JsonProperty("partiallyAuthenticated")]
        public System.Int32? PartiallyAuthenticated { get; set; }

        //      C# -> System.Int32? Unauthenticated
        // GraphQL -> unauthenticated: Int! (scalar)
        [JsonProperty("unauthenticated")]
        public System.Int32? Unauthenticated { get; set; }

        #endregion

    #region methods

    public AuthCounts Set(
        System.Int32? Authenticated = null,
        System.Int32? PartiallyAuthenticated = null,
        System.Int32? Unauthenticated = null
    ) 
    {
        if ( Authenticated != null ) {
            this.Authenticated = Authenticated;
        }
        if ( PartiallyAuthenticated != null ) {
            this.PartiallyAuthenticated = PartiallyAuthenticated;
        }
        if ( Unauthenticated != null ) {
            this.Unauthenticated = Unauthenticated;
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
            //      C# -> System.Int32? Authenticated
            // GraphQL -> authenticated: Int! (scalar)
            if (this.Authenticated != null)
            {
                 s += ind + "authenticated\n";

            }
            //      C# -> System.Int32? PartiallyAuthenticated
            // GraphQL -> partiallyAuthenticated: Int! (scalar)
            if (this.PartiallyAuthenticated != null)
            {
                 s += ind + "partiallyAuthenticated\n";

            }
            //      C# -> System.Int32? Unauthenticated
            // GraphQL -> unauthenticated: Int! (scalar)
            if (this.Unauthenticated != null)
            {
                 s += ind + "unauthenticated\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Int32? Authenticated
            // GraphQL -> authenticated: Int! (scalar)
            if (this.Authenticated == null && Exploration.Includes(parent + ".authenticated$"))
            {
                this.Authenticated = new System.Int32();
            }
            //      C# -> System.Int32? PartiallyAuthenticated
            // GraphQL -> partiallyAuthenticated: Int! (scalar)
            if (this.PartiallyAuthenticated == null && Exploration.Includes(parent + ".partiallyAuthenticated$"))
            {
                this.PartiallyAuthenticated = new System.Int32();
            }
            //      C# -> System.Int32? Unauthenticated
            // GraphQL -> unauthenticated: Int! (scalar)
            if (this.Unauthenticated == null && Exploration.Includes(parent + ".unauthenticated$"))
            {
                this.Unauthenticated = new System.Int32();
            }
        }


    #endregion

    } // class AuthCounts
    #endregion

    public static class ListAuthCountsExtensions
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
            this List<AuthCounts> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<AuthCounts> list, 
            String parent = "")
        {
            var item = new AuthCounts();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types