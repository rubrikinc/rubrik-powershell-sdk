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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? QueryUser
        // GraphQL -> queryUser: String! (scalar)
        if (this.QueryUser != null) {
            if (conf.Flat) {
                s += conf.Prefix + "queryUser\n" ;
            } else {
                s += ind + "queryUser\n" ;
            }
        }
        //      C# -> System.String? SysDbaUser
        // GraphQL -> sysDbaUser: String! (scalar)
        if (this.SysDbaUser != null) {
            if (conf.Flat) {
                s += conf.Prefix + "sysDbaUser\n" ;
            } else {
                s += ind + "sysDbaUser\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? QueryUser
        // GraphQL -> queryUser: String! (scalar)
        if (ec.Includes("queryUser",true))
        {
            if(this.QueryUser == null) {

                this.QueryUser = "FETCH";

            } else {


            }
        }
        else if (this.QueryUser != null && ec.Excludes("queryUser",true))
        {
            this.QueryUser = null;
        }
        //      C# -> System.String? SysDbaUser
        // GraphQL -> sysDbaUser: String! (scalar)
        if (ec.Includes("sysDbaUser",true))
        {
            if(this.SysDbaUser == null) {

                this.SysDbaUser = "FETCH";

            } else {


            }
        }
        else if (this.SysDbaUser != null && ec.Excludes("sysDbaUser",true))
        {
            this.SysDbaUser = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
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

        public static void SelectForRetrieval(this List<OracleUserDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types