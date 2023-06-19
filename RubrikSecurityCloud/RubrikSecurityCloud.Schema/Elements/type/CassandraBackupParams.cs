// CassandraBackupParams.cs
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
    #region CassandraBackupParams
    public class CassandraBackupParams: BaseType
    {
        #region members

        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        [JsonProperty("storeName")]
        public System.String? StoreName { get; set; }

        //      C# -> System.Int64? WatcherFrequency
        // GraphQL -> watcherFrequency: Long! (scalar)
        [JsonProperty("watcherFrequency")]
        public System.Int64? WatcherFrequency { get; set; }


        #endregion

    #region methods

    public CassandraBackupParams Set(
        System.String? StoreName = null,
        System.Int64? WatcherFrequency = null
    ) 
    {
        if ( StoreName != null ) {
            this.StoreName = StoreName;
        }
        if ( WatcherFrequency != null ) {
            this.WatcherFrequency = WatcherFrequency;
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
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (this.StoreName != null) {
            s += ind + "storeName\n" ;
        }
        //      C# -> System.Int64? WatcherFrequency
        // GraphQL -> watcherFrequency: Long! (scalar)
        if (this.WatcherFrequency != null) {
            s += ind + "watcherFrequency\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (this.StoreName == null && Exploration.Includes(parent + ".storeName", true))
        {
            this.StoreName = "FETCH";
        }
        //      C# -> System.Int64? WatcherFrequency
        // GraphQL -> watcherFrequency: Long! (scalar)
        if (this.WatcherFrequency == null && Exploration.Includes(parent + ".watcherFrequency", true))
        {
            this.WatcherFrequency = new System.Int64();
        }
    }


    #endregion

    } // class CassandraBackupParams
    
    #endregion

    public static class ListCassandraBackupParamsExtensions
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
            this List<CassandraBackupParams> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<CassandraBackupParams> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new CassandraBackupParams());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types