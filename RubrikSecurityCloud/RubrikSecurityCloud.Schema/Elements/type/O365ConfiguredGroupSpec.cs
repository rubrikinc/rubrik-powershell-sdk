// O365ConfiguredGroupSpec.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:51.
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
    #region O365ConfiguredGroupSpec
    public class O365ConfiguredGroupSpec: IFragment
    {
        #region members
        //      C# -> List<System.String>? Pdls
        // GraphQL -> pdls: [String!]! (scalar)
        [JsonProperty("pdls")]
        public List<System.String>? Pdls { get; set; }

        //      C# -> System.String? Wildcard
        // GraphQL -> wildcard: String! (scalar)
        [JsonProperty("wildcard")]
        public System.String? Wildcard { get; set; }

        #endregion

    #region methods

    public O365ConfiguredGroupSpec Set(
        List<System.String>? Pdls = null,
        System.String? Wildcard = null
    ) 
    {
        if ( Pdls != null ) {
            this.Pdls = Pdls;
        }
        if ( Wildcard != null ) {
            this.Wildcard = Wildcard;
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
            //      C# -> List<System.String>? Pdls
            // GraphQL -> pdls: [String!]! (scalar)
            if (this.Pdls != null)
            {
                 s += ind + "pdls\n";

            }
            //      C# -> System.String? Wildcard
            // GraphQL -> wildcard: String! (scalar)
            if (this.Wildcard != null)
            {
                 s += ind + "wildcard\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? Pdls
            // GraphQL -> pdls: [String!]! (scalar)
            if (this.Pdls == null && Exploration.Includes(parent + ".pdls$"))
            {
                this.Pdls = new List<System.String>();
            }
            //      C# -> System.String? Wildcard
            // GraphQL -> wildcard: String! (scalar)
            if (this.Wildcard == null && Exploration.Includes(parent + ".wildcard$"))
            {
                this.Wildcard = new System.String("FETCH");
            }
        }


    #endregion

    } // class O365ConfiguredGroupSpec
    #endregion

    public static class ListO365ConfiguredGroupSpecExtensions
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
            this List<O365ConfiguredGroupSpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<O365ConfiguredGroupSpec> list, 
            String parent = "")
        {
            var item = new O365ConfiguredGroupSpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types