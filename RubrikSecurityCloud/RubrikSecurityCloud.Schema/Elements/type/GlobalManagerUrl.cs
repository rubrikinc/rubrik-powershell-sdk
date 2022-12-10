// GlobalManagerUrl.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:01.
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
    #region GlobalManagerUrl
    public class GlobalManagerUrl: IFragment
    {
        #region members
        //      C# -> System.Boolean? IsReachable
        // GraphQL -> isReachable: Boolean! (scalar)
        [JsonProperty("isReachable")]
        public System.Boolean? IsReachable { get; set; }

        //      C# -> System.String? Url
        // GraphQL -> url: String! (scalar)
        [JsonProperty("url")]
        public System.String? Url { get; set; }

        #endregion

    #region methods

    public GlobalManagerUrl Set(
        System.Boolean? IsReachable = null,
        System.String? Url = null
    ) 
    {
        if ( IsReachable != null ) {
            this.IsReachable = IsReachable;
        }
        if ( Url != null ) {
            this.Url = Url;
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
            //      C# -> System.Boolean? IsReachable
            // GraphQL -> isReachable: Boolean! (scalar)
            if (this.IsReachable != null)
            {
                 s += ind + "isReachable\n";

            }
            //      C# -> System.String? Url
            // GraphQL -> url: String! (scalar)
            if (this.Url != null)
            {
                 s += ind + "url\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.Boolean? IsReachable
            // GraphQL -> isReachable: Boolean! (scalar)
            if (this.IsReachable == null && Exploration.Includes(parent + ".isReachable$"))
            {
                this.IsReachable = new System.Boolean();
            }
            //      C# -> System.String? Url
            // GraphQL -> url: String! (scalar)
            if (this.Url == null && Exploration.Includes(parent + ".url$"))
            {
                this.Url = new System.String("FETCH");
            }
        }


    #endregion

    } // class GlobalManagerUrl
    #endregion

    public static class ListGlobalManagerUrlExtensions
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
            this List<GlobalManagerUrl> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<GlobalManagerUrl> list, 
            String parent = "")
        {
            var item = new GlobalManagerUrl();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types