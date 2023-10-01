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

    public override string GetGqlTypeName() {
        return "CassandraBackupParams";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (this.StoreName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "storeName\n" ;
            } else {
                s += ind + "storeName\n" ;
            }
        }
        //      C# -> System.Int64? WatcherFrequency
        // GraphQL -> watcherFrequency: Long! (scalar)
        if (this.WatcherFrequency != null) {
            if (conf.Flat) {
                s += conf.Prefix + "watcherFrequency\n" ;
            } else {
                s += ind + "watcherFrequency\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? StoreName
        // GraphQL -> storeName: String! (scalar)
        if (ec.Includes("storeName",true))
        {
            if(this.StoreName == null) {

                this.StoreName = "FETCH";

            } else {


            }
        }
        else if (this.StoreName != null && ec.Excludes("storeName",true))
        {
            this.StoreName = null;
        }
        //      C# -> System.Int64? WatcherFrequency
        // GraphQL -> watcherFrequency: Long! (scalar)
        if (ec.Includes("watcherFrequency",true))
        {
            if(this.WatcherFrequency == null) {

                this.WatcherFrequency = new System.Int64();

            } else {


            }
        }
        else if (this.WatcherFrequency != null && ec.Excludes("watcherFrequency",true))
        {
            this.WatcherFrequency = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CassandraBackupParams> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CassandraBackupParams> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CassandraBackupParams());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CassandraBackupParams> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types