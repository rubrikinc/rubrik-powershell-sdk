// HashDetail.cs
//
// This file is part of the Rubrik PowerShell SDK.
// Generated on 2023-04-13 20:03:40.
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
    #region HashDetail
    public class HashDetail: IFragment
    {
        #region members
        //      C# -> System.String? HashType
        // GraphQL -> hashType: String! (scalar)
        [JsonProperty("hashType")]
        public System.String? HashType { get; set; }

        //      C# -> System.String? HashValue
        // GraphQL -> hashValue: String! (scalar)
        [JsonProperty("hashValue")]
        public System.String? HashValue { get; set; }

        #endregion

    #region methods

    public HashDetail Set(
        System.String? HashType = null,
        System.String? HashValue = null
    ) 
    {
        if ( HashType != null ) {
            this.HashType = HashType;
        }
        if ( HashValue != null ) {
            this.HashValue = HashValue;
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
            //      C# -> System.String? HashType
            // GraphQL -> hashType: String! (scalar)
            if (this.HashType != null)
            {
                 s += ind + "hashType\n";

            }
            //      C# -> System.String? HashValue
            // GraphQL -> hashValue: String! (scalar)
            if (this.HashValue != null)
            {
                 s += ind + "hashValue\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? HashType
            // GraphQL -> hashType: String! (scalar)
            if (this.HashType == null && Exploration.Includes(parent + ".hashType$"))
            {
                this.HashType = new System.String("FETCH");
            }
            //      C# -> System.String? HashValue
            // GraphQL -> hashValue: String! (scalar)
            if (this.HashValue == null && Exploration.Includes(parent + ".hashValue$"))
            {
                this.HashValue = new System.String("FETCH");
            }
        }


    #endregion

    } // class HashDetail
    #endregion

    public static class ListHashDetailExtensions
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
            this List<HashDetail> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<HashDetail> list, 
            String parent = "")
        {
            var item = new HashDetail();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types