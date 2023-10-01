// ClusterMetric.cs
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
    #region ClusterMetric
    public class ClusterMetric: BaseType
    {
        #region members

        //      C# -> System.Int64? AvailableCapacity
        // GraphQL -> availableCapacity: Long! (scalar)
        [JsonProperty("availableCapacity")]
        public System.Int64? AvailableCapacity { get; set; }

        //      C# -> System.Int64? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Long! (scalar)
        [JsonProperty("ingestedArchivalStorage")]
        public System.Int64? IngestedArchivalStorage { get; set; }

        //      C# -> System.Int64? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Long! (scalar)
        [JsonProperty("ingestedSnapshotStorage")]
        public System.Int64? IngestedSnapshotStorage { get; set; }

        //      C# -> DateTime? LastUpdateTime
        // GraphQL -> lastUpdateTime: DateTime! (scalar)
        [JsonProperty("lastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; }

        //      C# -> System.Int64? LiveMountCapacity
        // GraphQL -> liveMountCapacity: Long! (scalar)
        [JsonProperty("liveMountCapacity")]
        public System.Int64? LiveMountCapacity { get; set; }

        //      C# -> System.Int64? MiscellaneousCapacity
        // GraphQL -> miscellaneousCapacity: Long! (scalar)
        [JsonProperty("miscellaneousCapacity")]
        public System.Int64? MiscellaneousCapacity { get; set; }

        //      C# -> System.Int64? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Long! (scalar)
        [JsonProperty("physicalArchivalStorage")]
        public System.Int64? PhysicalArchivalStorage { get; set; }

        //      C# -> System.Int64? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Long! (scalar)
        [JsonProperty("physicalSnapshotStorage")]
        public System.Int64? PhysicalSnapshotStorage { get; set; }

        //      C# -> System.Int64? SnapshotCapacity
        // GraphQL -> snapshotCapacity: Long! (scalar)
        [JsonProperty("snapshotCapacity")]
        public System.Int64? SnapshotCapacity { get; set; }

        //      C# -> System.Int64? TotalCapacity
        // GraphQL -> totalCapacity: Long! (scalar)
        [JsonProperty("totalCapacity")]
        public System.Int64? TotalCapacity { get; set; }

        //      C# -> System.Int64? UsedCapacity
        // GraphQL -> usedCapacity: Long! (scalar)
        [JsonProperty("usedCapacity")]
        public System.Int64? UsedCapacity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterMetric";
    }

    public ClusterMetric Set(
        System.Int64? AvailableCapacity = null,
        System.Int64? IngestedArchivalStorage = null,
        System.Int64? IngestedSnapshotStorage = null,
        DateTime? LastUpdateTime = null,
        System.Int64? LiveMountCapacity = null,
        System.Int64? MiscellaneousCapacity = null,
        System.Int64? PhysicalArchivalStorage = null,
        System.Int64? PhysicalSnapshotStorage = null,
        System.Int64? SnapshotCapacity = null,
        System.Int64? TotalCapacity = null,
        System.Int64? UsedCapacity = null
    ) 
    {
        if ( AvailableCapacity != null ) {
            this.AvailableCapacity = AvailableCapacity;
        }
        if ( IngestedArchivalStorage != null ) {
            this.IngestedArchivalStorage = IngestedArchivalStorage;
        }
        if ( IngestedSnapshotStorage != null ) {
            this.IngestedSnapshotStorage = IngestedSnapshotStorage;
        }
        if ( LastUpdateTime != null ) {
            this.LastUpdateTime = LastUpdateTime;
        }
        if ( LiveMountCapacity != null ) {
            this.LiveMountCapacity = LiveMountCapacity;
        }
        if ( MiscellaneousCapacity != null ) {
            this.MiscellaneousCapacity = MiscellaneousCapacity;
        }
        if ( PhysicalArchivalStorage != null ) {
            this.PhysicalArchivalStorage = PhysicalArchivalStorage;
        }
        if ( PhysicalSnapshotStorage != null ) {
            this.PhysicalSnapshotStorage = PhysicalSnapshotStorage;
        }
        if ( SnapshotCapacity != null ) {
            this.SnapshotCapacity = SnapshotCapacity;
        }
        if ( TotalCapacity != null ) {
            this.TotalCapacity = TotalCapacity;
        }
        if ( UsedCapacity != null ) {
            this.UsedCapacity = UsedCapacity;
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
        //      C# -> System.Int64? AvailableCapacity
        // GraphQL -> availableCapacity: Long! (scalar)
        if (this.AvailableCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availableCapacity\n" ;
            } else {
                s += ind + "availableCapacity\n" ;
            }
        }
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
        //      C# -> DateTime? LastUpdateTime
        // GraphQL -> lastUpdateTime: DateTime! (scalar)
        if (this.LastUpdateTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdateTime\n" ;
            } else {
                s += ind + "lastUpdateTime\n" ;
            }
        }
        //      C# -> System.Int64? LiveMountCapacity
        // GraphQL -> liveMountCapacity: Long! (scalar)
        if (this.LiveMountCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "liveMountCapacity\n" ;
            } else {
                s += ind + "liveMountCapacity\n" ;
            }
        }
        //      C# -> System.Int64? MiscellaneousCapacity
        // GraphQL -> miscellaneousCapacity: Long! (scalar)
        if (this.MiscellaneousCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "miscellaneousCapacity\n" ;
            } else {
                s += ind + "miscellaneousCapacity\n" ;
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
        //      C# -> System.Int64? SnapshotCapacity
        // GraphQL -> snapshotCapacity: Long! (scalar)
        if (this.SnapshotCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCapacity\n" ;
            } else {
                s += ind + "snapshotCapacity\n" ;
            }
        }
        //      C# -> System.Int64? TotalCapacity
        // GraphQL -> totalCapacity: Long! (scalar)
        if (this.TotalCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCapacity\n" ;
            } else {
                s += ind + "totalCapacity\n" ;
            }
        }
        //      C# -> System.Int64? UsedCapacity
        // GraphQL -> usedCapacity: Long! (scalar)
        if (this.UsedCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedCapacity\n" ;
            } else {
                s += ind + "usedCapacity\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int64? AvailableCapacity
        // GraphQL -> availableCapacity: Long! (scalar)
        if (ec.Includes("availableCapacity",true))
        {
            if(this.AvailableCapacity == null) {

                this.AvailableCapacity = new System.Int64();

            } else {


            }
        }
        else if (this.AvailableCapacity != null && ec.Excludes("availableCapacity",true))
        {
            this.AvailableCapacity = null;
        }
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
        //      C# -> DateTime? LastUpdateTime
        // GraphQL -> lastUpdateTime: DateTime! (scalar)
        if (ec.Includes("lastUpdateTime",true))
        {
            if(this.LastUpdateTime == null) {

                this.LastUpdateTime = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdateTime != null && ec.Excludes("lastUpdateTime",true))
        {
            this.LastUpdateTime = null;
        }
        //      C# -> System.Int64? LiveMountCapacity
        // GraphQL -> liveMountCapacity: Long! (scalar)
        if (ec.Includes("liveMountCapacity",true))
        {
            if(this.LiveMountCapacity == null) {

                this.LiveMountCapacity = new System.Int64();

            } else {


            }
        }
        else if (this.LiveMountCapacity != null && ec.Excludes("liveMountCapacity",true))
        {
            this.LiveMountCapacity = null;
        }
        //      C# -> System.Int64? MiscellaneousCapacity
        // GraphQL -> miscellaneousCapacity: Long! (scalar)
        if (ec.Includes("miscellaneousCapacity",true))
        {
            if(this.MiscellaneousCapacity == null) {

                this.MiscellaneousCapacity = new System.Int64();

            } else {


            }
        }
        else if (this.MiscellaneousCapacity != null && ec.Excludes("miscellaneousCapacity",true))
        {
            this.MiscellaneousCapacity = null;
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
        //      C# -> System.Int64? SnapshotCapacity
        // GraphQL -> snapshotCapacity: Long! (scalar)
        if (ec.Includes("snapshotCapacity",true))
        {
            if(this.SnapshotCapacity == null) {

                this.SnapshotCapacity = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotCapacity != null && ec.Excludes("snapshotCapacity",true))
        {
            this.SnapshotCapacity = null;
        }
        //      C# -> System.Int64? TotalCapacity
        // GraphQL -> totalCapacity: Long! (scalar)
        if (ec.Includes("totalCapacity",true))
        {
            if(this.TotalCapacity == null) {

                this.TotalCapacity = new System.Int64();

            } else {


            }
        }
        else if (this.TotalCapacity != null && ec.Excludes("totalCapacity",true))
        {
            this.TotalCapacity = null;
        }
        //      C# -> System.Int64? UsedCapacity
        // GraphQL -> usedCapacity: Long! (scalar)
        if (ec.Includes("usedCapacity",true))
        {
            if(this.UsedCapacity == null) {

                this.UsedCapacity = new System.Int64();

            } else {


            }
        }
        else if (this.UsedCapacity != null && ec.Excludes("usedCapacity",true))
        {
            this.UsedCapacity = null;
        }
    }


    #endregion

    } // class ClusterMetric
    
    #endregion

    public static class ListClusterMetricExtensions
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
            this List<ClusterMetric> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ClusterMetric> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterMetric> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterMetric());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterMetric> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types