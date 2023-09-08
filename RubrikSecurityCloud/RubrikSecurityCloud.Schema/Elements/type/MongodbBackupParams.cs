// MongodbBackupParams.cs
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
    #region MongodbBackupParams
    public class MongodbBackupParams: BaseType
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

    public override string GetGqlTypeName() {
        return "MongodbBackupParams";
    }

    public MongodbBackupParams Set(
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


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (this.StoreName == null && ec.Includes("storeName",true))
        {
            this.StoreName = "FETCH";
        }
        //      C# -> System.Int64? WatcherFrequency
        // GraphQL -> watcherFrequency: Long! (scalar)
        if (this.WatcherFrequency == null && ec.Includes("watcherFrequency",true))
        {
            this.WatcherFrequency = new System.Int64();
        }
    }


    #endregion

    } // class MongodbBackupParams
    
    #endregion

    public static class ListMongodbBackupParamsExtensions
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
            this List<MongodbBackupParams> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<MongodbBackupParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MongodbBackupParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void Fetch(this List<MongodbBackupParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types