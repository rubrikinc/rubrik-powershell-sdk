// ClusterStatsAggregation.cs
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
    #region ClusterStatsAggregation
    public class ClusterStatsAggregation: BaseType
    {
        #region members

        //      C# -> System.Int64? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Long! (scalar)
        [JsonProperty("ingestedArchivalStorage")]
        public System.Int64? IngestedArchivalStorage { get; set; }

        //      C# -> System.Int64? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
        [JsonProperty("ingestedSnapshotStorage")]
        public System.Int64? IngestedSnapshotStorage { get; set; }

        //      C# -> System.Int64? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Long! (scalar)
        [JsonProperty("physicalArchivalStorage")]
        public System.Int64? PhysicalArchivalStorage { get; set; }

        //      C# -> System.Int64? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Long! (scalar)
        [JsonProperty("physicalSnapshotStorage")]
        public System.Int64? PhysicalSnapshotStorage { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterStatsAggregation";
    }

    public ClusterStatsAggregation Set(
        System.Int64? IngestedArchivalStorage = null,
        System.Int64? IngestedSnapshotStorage = null,
        System.Int64? PhysicalArchivalStorage = null,
        System.Int64? PhysicalSnapshotStorage = null
    ) 
    {
        if ( IngestedArchivalStorage != null ) {
            this.IngestedArchivalStorage = IngestedArchivalStorage;
        }
        if ( IngestedSnapshotStorage != null ) {
            this.IngestedSnapshotStorage = IngestedSnapshotStorage;
        }
        if ( PhysicalArchivalStorage != null ) {
            this.PhysicalArchivalStorage = PhysicalArchivalStorage;
        }
        if ( PhysicalSnapshotStorage != null ) {
            this.PhysicalSnapshotStorage = PhysicalSnapshotStorage;
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
        //      C# -> System.Int64? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Long! (scalar)
        if (this.IngestedArchivalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ingestedArchivalStorage\n" ;
            } else {
                s += ind + "ingestedArchivalStorage\n" ;
            }
        }
        //      C# -> System.Int64? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
        if (this.IngestedSnapshotStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ingestedSnapshotStorage\n" ;
            } else {
                s += ind + "ingestedSnapshotStorage\n" ;
            }
        }
        //      C# -> System.Int64? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Long! (scalar)
        if (this.PhysicalArchivalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalArchivalStorage\n" ;
            } else {
                s += ind + "physicalArchivalStorage\n" ;
            }
        }
        //      C# -> System.Int64? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Long! (scalar)
        if (this.PhysicalSnapshotStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalSnapshotStorage\n" ;
            } else {
                s += ind + "physicalSnapshotStorage\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Long! (scalar)
        if (ec.Includes("ingestedArchivalStorage",true))
        {
            if(this.IngestedArchivalStorage == null) {

                this.IngestedArchivalStorage = new System.Int64();

            } else {


            }
        }
        else if (this.IngestedArchivalStorage != null && ec.Excludes("ingestedArchivalStorage",true))
        {
            this.IngestedArchivalStorage = null;
        }
        //      C# -> System.Int64? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
        if (ec.Includes("ingestedSnapshotStorage",true))
        {
            if(this.IngestedSnapshotStorage == null) {

                this.IngestedSnapshotStorage = new System.Int64();

            } else {


            }
        }
        else if (this.IngestedSnapshotStorage != null && ec.Excludes("ingestedSnapshotStorage",true))
        {
            this.IngestedSnapshotStorage = null;
        }
        //      C# -> System.Int64? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Long! (scalar)
        if (ec.Includes("physicalArchivalStorage",true))
        {
            if(this.PhysicalArchivalStorage == null) {

                this.PhysicalArchivalStorage = new System.Int64();

            } else {


            }
        }
        else if (this.PhysicalArchivalStorage != null && ec.Excludes("physicalArchivalStorage",true))
        {
            this.PhysicalArchivalStorage = null;
        }
        //      C# -> System.Int64? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Long! (scalar)
        if (ec.Includes("physicalSnapshotStorage",true))
        {
            if(this.PhysicalSnapshotStorage == null) {

                this.PhysicalSnapshotStorage = new System.Int64();

            } else {


            }
        }
        else if (this.PhysicalSnapshotStorage != null && ec.Excludes("physicalSnapshotStorage",true))
        {
            this.PhysicalSnapshotStorage = null;
        }
    }


    #endregion

    } // class ClusterStatsAggregation
    
    #endregion

    public static class ListClusterStatsAggregationExtensions
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
            this List<ClusterStatsAggregation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterStatsAggregation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterStatsAggregation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterStatsAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterStatsAggregation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types