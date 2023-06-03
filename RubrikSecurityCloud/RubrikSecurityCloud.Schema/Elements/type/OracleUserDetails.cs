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
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region OracleUserDetails
    public class OracleUserDetails: BaseType
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
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> System.String? QueryUser
        // GraphQL -> queryUser: String! (scalar)
        if (this.QueryUser != null) {
            s += ind + "queryUser\n" ;
        }
        //      C# -> System.String? SysDbaUser
        // GraphQL -> sysDbaUser: String! (scalar)
        if (this.SysDbaUser != null) {
            s += ind + "sysDbaUser\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? QueryUser
        // GraphQL -> queryUser: String! (scalar)
        if (this.QueryUser == null && Exploration.Includes(parent + ".queryUser", true))
        {
            this.QueryUser = new System.String("FETCH");
        }
        //      C# -> System.String? SysDbaUser
        // GraphQL -> sysDbaUser: String! (scalar)
        if (this.SysDbaUser == null && Exploration.Includes(parent + ".sysDbaUser", true))
        {
            this.SysDbaUser = new System.String("FETCH");
        }
    }


    #endregion

    } // class OracleUserDetails
    
    #endregion

    public static class ListOracleUserDetailsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<OracleUserDetails> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleUserDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleUserDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types