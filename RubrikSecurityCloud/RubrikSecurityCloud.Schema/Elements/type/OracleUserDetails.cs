// OracleUserDetails.cs
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
    #region OracleUserDetails
    public class OracleUserDetails: IFragment
    {
        #region members
        //      C# -> System.String? QueryUser
        // GraphQL -> queryUser: String! (scalar)
        [JsonProperty("queryUser")]
        public System.String? QueryUser { get; set; }

        //      C# -> System.String? SysDbaUser
        // GraphQL -> sysDbaUser: String! (scalar)
        [JsonProperty("sysDbaUser")]
        public System.String? SysDbaUser { get; set; }

        #endregion

    #region methods

    public OracleUserDetails Set(
        System.String? QueryUser = null,
        System.String? SysDbaUser = null
    ) 
    {
        if ( QueryUser != null ) {
            this.QueryUser = QueryUser;
        }
        if ( SysDbaUser != null ) {
            this.SysDbaUser = SysDbaUser;
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
            //      C# -> System.String? QueryUser
            // GraphQL -> queryUser: String! (scalar)
            if (this.QueryUser != null)
            {
                 s += ind + "queryUser\n";

            }
            //      C# -> System.String? SysDbaUser
            // GraphQL -> sysDbaUser: String! (scalar)
            if (this.SysDbaUser != null)
            {
                 s += ind + "sysDbaUser\n";

            }
            return new string(s);
        }


    
        //[JsonIgnore]
        public void ApplyExploratoryFragment(String parent = "")
        {
            //      C# -> System.String? QueryUser
            // GraphQL -> queryUser: String! (scalar)
            if (this.QueryUser == null && Exploration.Includes(parent + ".queryUser$"))
            {
                this.QueryUser = new System.String("FETCH");
            }
            //      C# -> System.String? SysDbaUser
            // GraphQL -> sysDbaUser: String! (scalar)
            if (this.SysDbaUser == null && Exploration.Includes(parent + ".sysDbaUser$"))
            {
                this.SysDbaUser = new System.String("FETCH");
            }
        }


    #endregion

    } // class OracleUserDetails
    #endregion

    public static class ListOracleUserDetailsExtensions
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
            this List<OracleUserDetails> list,
            int indent=0)
        {
            return list[0].AsFragment();
        }

        public static void ApplyExploratoryFragment(
            this List<OracleUserDetails> list, 
            String parent = "")
        {
            var item = new OracleUserDetails();
            list.Add(item);
            item.ApplyExploratoryFragment(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types