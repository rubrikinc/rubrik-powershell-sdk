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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<CassandraBackupParams> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
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