// HostInfo.cs
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
    #region HostInfo
    public class HostInfo: BaseType
    {
        #region members

        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        [JsonProperty("hostname")]
        public System.String? Hostname { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String! (scalar)
        [JsonProperty("oracleQueryUser")]
        public System.String? OracleQueryUser { get; set; }

        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String! (scalar)
        [JsonProperty("oracleSysDbaUser")]
        public System.String? OracleSysDbaUser { get; set; }


        #endregion

    #region methods

    public HostInfo Set(
        System.String? Hostname = null,
        System.String? Id = null,
        System.String? OracleQueryUser = null,
        System.String? OracleSysDbaUser = null
    ) 
    {
        if ( Hostname != null ) {
            this.Hostname = Hostname;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( OracleQueryUser != null ) {
            this.OracleQueryUser = OracleQueryUser;
        }
        if ( OracleSysDbaUser != null ) {
            this.OracleSysDbaUser = OracleSysDbaUser;
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
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname != null) {
            s += ind + "hostname\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String! (scalar)
        if (this.OracleQueryUser != null) {
            s += ind + "oracleQueryUser\n" ;
        }
        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String! (scalar)
        if (this.OracleSysDbaUser != null) {
            s += ind + "oracleSysDbaUser\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Hostname
        // GraphQL -> hostname: String! (scalar)
        if (this.Hostname == null && Exploration.Includes(parent + ".hostname", true))
        {
            this.Hostname = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? OracleQueryUser
        // GraphQL -> oracleQueryUser: String! (scalar)
        if (this.OracleQueryUser == null && Exploration.Includes(parent + ".oracleQueryUser", true))
        {
            this.OracleQueryUser = new System.String("FETCH");
        }
        //      C# -> System.String? OracleSysDbaUser
        // GraphQL -> oracleSysDbaUser: String! (scalar)
        if (this.OracleSysDbaUser == null && Exploration.Includes(parent + ".oracleSysDbaUser", true))
        {
            this.OracleSysDbaUser = new System.String("FETCH");
        }
    }


    #endregion

    } // class HostInfo
    
    #endregion

    public static class ListHostInfoExtensions
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
            this List<HostInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<HostInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new HostInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types