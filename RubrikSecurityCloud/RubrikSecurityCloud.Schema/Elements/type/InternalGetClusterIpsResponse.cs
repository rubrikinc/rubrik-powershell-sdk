// InternalGetClusterIpsResponse.cs
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
    #region InternalGetClusterIpsResponse
    public class InternalGetClusterIpsResponse: IFragment
    {
        #region members
        //      C# -> List<System.String>? Items
        // GraphQL -> items: [String!]! (scalar)
        [JsonProperty("items")]
        public List<System.String>? Items { get; set; }

        #endregion

    #region methods

    public InternalGetClusterIpsResponse Set(
        List<System.String>? Items = null
    ) 
    {
        if ( Items != null ) {
            this.Items = Items;
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
            //      C# -> List<System.String>? Items
            // GraphQL -> items: [String!]! (scalar)
            if (this.Items != null)
            {
                 s += ind + "items\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> List<System.String>? Items
            // GraphQL -> items: [String!]! (scalar)
            if (this.Items == null && Exploration.Includes(parent + ".items$"))
            {
                this.Items = new List<System.String>();
            }
        }


    #endregion

    } // class InternalGetClusterIpsResponse
    #endregion

    public static class ListInternalGetClusterIpsResponseExtensions
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
            this List<InternalGetClusterIpsResponse> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<InternalGetClusterIpsResponse> list, 
            String parent = "")
        {
            var item = new InternalGetClusterIpsResponse();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types