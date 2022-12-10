// FilesetArraySpec.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:04:25.
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
    #region FilesetArraySpec
    public class FilesetArraySpec: IFragment
    {
        #region members
        //      C# -> System.String? ProxyHostId
        // GraphQL -> proxyHostId: String (scalar)
        [JsonProperty("proxyHostId")]
        public System.String? ProxyHostId { get; set; }

        #endregion

    #region methods

    public FilesetArraySpec Set(
        System.String? ProxyHostId = null
    ) 
    {
        if ( ProxyHostId != null ) {
            this.ProxyHostId = ProxyHostId;
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
            //      C# -> System.String? ProxyHostId
            // GraphQL -> proxyHostId: String (scalar)
            if (this.ProxyHostId != null)
            {
                 s += ind + "proxyHostId\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? ProxyHostId
            // GraphQL -> proxyHostId: String (scalar)
            if (this.ProxyHostId == null && Exploration.Includes(parent + ".proxyHostId$"))
            {
                this.ProxyHostId = new System.String("FETCH");
            }
        }


    #endregion

    } // class FilesetArraySpec
    #endregion

    public static class ListFilesetArraySpecExtensions
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
            this List<FilesetArraySpec> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<FilesetArraySpec> list, 
            String parent = "")
        {
            var item = new FilesetArraySpec();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types