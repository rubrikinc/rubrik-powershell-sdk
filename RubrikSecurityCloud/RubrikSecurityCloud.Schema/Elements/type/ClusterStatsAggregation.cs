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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
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
            this List<ClusterStatsAggregation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterStatsAggregation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterStatsAggregation> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterStatsAggregation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterStatsAggregation> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types