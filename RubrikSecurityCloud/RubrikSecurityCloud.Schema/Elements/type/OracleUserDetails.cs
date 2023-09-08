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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "OracleUserDetails";
    }

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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? QueryUser
        // GraphQL -> queryUser: String! (scalar)
        if (this.QueryUser == null && ec.Includes("queryUser",true))
        {
            this.QueryUser = "FETCH";
        }
        //      C# -> System.String? SysDbaUser
        // GraphQL -> sysDbaUser: String! (scalar)
        if (this.SysDbaUser == null && ec.Includes("sysDbaUser",true))
        {
            this.SysDbaUser = "FETCH";
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
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleUserDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleUserDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<OracleUserDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types