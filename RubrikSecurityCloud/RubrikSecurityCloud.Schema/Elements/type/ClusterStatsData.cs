// ClusterStatsData.cs
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
    #region ClusterStatsData
    public class ClusterStatsData: BaseType
    {
        #region members

        //      C# -> System.Single? AvailableCapacity
        // GraphQL -> availableCapacity: Float! (scalar)
        [JsonProperty("availableCapacity")]
        public System.Single? AvailableCapacity { get; set; }

        //      C# -> System.Single? AverageDailyGrowth
        // GraphQL -> averageDailyGrowth: Float! (scalar)
        [JsonProperty("averageDailyGrowth")]
        public System.Single? AverageDailyGrowth { get; set; }

        //      C# -> System.Single? CdpCapacity
        // GraphQL -> cdpCapacity: Float! (scalar)
        [JsonProperty("cdpCapacity")]
        public System.Single? CdpCapacity { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Int64? ImmutabilityOverhead
        // GraphQL -> immutabilityOverhead: Long! (scalar)
        [JsonProperty("immutabilityOverhead")]
        public System.Int64? ImmutabilityOverhead { get; set; }

        //      C# -> System.Single? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Float! (scalar)
        [JsonProperty("ingestedArchivalStorage")]
        public System.Single? IngestedArchivalStorage { get; set; }

        //      C# -> System.Single? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Float! (scalar)
        [JsonProperty("ingestedSnapshotStorage")]
        public System.Single? IngestedSnapshotStorage { get; set; }

        //      C# -> DateTime? LastUpdateTime
        // GraphQL -> lastUpdateTime: DateTime! (scalar)
        [JsonProperty("lastUpdateTime")]
        public DateTime? LastUpdateTime { get; set; }

        //      C# -> System.Single? LiveMountCapacity
        // GraphQL -> liveMountCapacity: Float! (scalar)
        [JsonProperty("liveMountCapacity")]
        public System.Single? LiveMountCapacity { get; set; }

        //      C# -> System.Single? MiscellaneousCapacity
        // GraphQL -> miscellaneousCapacity: Float! (scalar)
        [JsonProperty("miscellaneousCapacity")]
        public System.Single? MiscellaneousCapacity { get; set; }

        //      C# -> System.Single? PendingSnapshotCapacity
        // GraphQL -> pendingSnapshotCapacity: Float! (scalar)
        [JsonProperty("pendingSnapshotCapacity")]
        public System.Single? PendingSnapshotCapacity { get; set; }

        //      C# -> System.Single? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Float! (scalar)
        [JsonProperty("physicalArchivalStorage")]
        public System.Single? PhysicalArchivalStorage { get; set; }

        //      C# -> System.Single? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Float! (scalar)
        [JsonProperty("physicalSnapshotStorage")]
        public System.Single? PhysicalSnapshotStorage { get; set; }

        //      C# -> System.Single? SnapshotCapacity
        // GraphQL -> snapshotCapacity: Float! (scalar)
        [JsonProperty("snapshotCapacity")]
        public System.Single? SnapshotCapacity { get; set; }

        //      C# -> System.Single? TotalCapacity
        // GraphQL -> totalCapacity: Float! (scalar)
        [JsonProperty("totalCapacity")]
        public System.Single? TotalCapacity { get; set; }

        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        [JsonProperty("usedCapacity")]
        public System.Single? UsedCapacity { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClusterStatsData";
    }

    public ClusterStatsData Set(
        System.Single? AvailableCapacity = null,
        System.Single? AverageDailyGrowth = null,
        System.Single? CdpCapacity = null,
        System.String? ClusterUuid = null,
        System.Int64? ImmutabilityOverhead = null,
        System.Single? IngestedArchivalStorage = null,
        System.Single? IngestedSnapshotStorage = null,
        DateTime? LastUpdateTime = null,
        System.Single? LiveMountCapacity = null,
        System.Single? MiscellaneousCapacity = null,
        System.Single? PendingSnapshotCapacity = null,
        System.Single? PhysicalArchivalStorage = null,
        System.Single? PhysicalSnapshotStorage = null,
        System.Single? SnapshotCapacity = null,
        System.Single? TotalCapacity = null,
        System.Single? UsedCapacity = null
    ) 
    {
        if ( AvailableCapacity != null ) {
            this.AvailableCapacity = AvailableCapacity;
        }
        if ( AverageDailyGrowth != null ) {
            this.AverageDailyGrowth = AverageDailyGrowth;
        }
        if ( CdpCapacity != null ) {
            this.CdpCapacity = CdpCapacity;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( ImmutabilityOverhead != null ) {
            this.ImmutabilityOverhead = ImmutabilityOverhead;
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
        if ( PendingSnapshotCapacity != null ) {
            this.PendingSnapshotCapacity = PendingSnapshotCapacity;
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
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> System.Single? AvailableCapacity
        // GraphQL -> availableCapacity: Float! (scalar)
        if (this.AvailableCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "availableCapacity\n" ;
            } else {
                s += ind + "availableCapacity\n" ;
            }
        }
        //      C# -> System.Single? AverageDailyGrowth
        // GraphQL -> averageDailyGrowth: Float! (scalar)
        if (this.AverageDailyGrowth != null) {
            if (conf.Flat) {
                s += conf.Prefix + "averageDailyGrowth\n" ;
            } else {
                s += ind + "averageDailyGrowth\n" ;
            }
        }
        //      C# -> System.Single? CdpCapacity
        // GraphQL -> cdpCapacity: Float! (scalar)
        if (this.CdpCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "cdpCapacity\n" ;
            } else {
                s += ind + "cdpCapacity\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Int64? ImmutabilityOverhead
        // GraphQL -> immutabilityOverhead: Long! (scalar)
        if (this.ImmutabilityOverhead != null) {
            if (conf.Flat) {
                s += conf.Prefix + "immutabilityOverhead\n" ;
            } else {
                s += ind + "immutabilityOverhead\n" ;
            }
        }
        //      C# -> System.Single? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Float! (scalar)
        if (this.IngestedArchivalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ingestedArchivalStorage\n" ;
            } else {
                s += ind + "ingestedArchivalStorage\n" ;
            }
        }
        //      C# -> System.Single? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Float! (scalar)
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
        //      C# -> System.Single? LiveMountCapacity
        // GraphQL -> liveMountCapacity: Float! (scalar)
        if (this.LiveMountCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "liveMountCapacity\n" ;
            } else {
                s += ind + "liveMountCapacity\n" ;
            }
        }
        //      C# -> System.Single? MiscellaneousCapacity
        // GraphQL -> miscellaneousCapacity: Float! (scalar)
        if (this.MiscellaneousCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "miscellaneousCapacity\n" ;
            } else {
                s += ind + "miscellaneousCapacity\n" ;
            }
        }
        //      C# -> System.Single? PendingSnapshotCapacity
        // GraphQL -> pendingSnapshotCapacity: Float! (scalar)
        if (this.PendingSnapshotCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingSnapshotCapacity\n" ;
            } else {
                s += ind + "pendingSnapshotCapacity\n" ;
            }
        }
        //      C# -> System.Single? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Float! (scalar)
        if (this.PhysicalArchivalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalArchivalStorage\n" ;
            } else {
                s += ind + "physicalArchivalStorage\n" ;
            }
        }
        //      C# -> System.Single? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Float! (scalar)
        if (this.PhysicalSnapshotStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "physicalSnapshotStorage\n" ;
            } else {
                s += ind + "physicalSnapshotStorage\n" ;
            }
        }
        //      C# -> System.Single? SnapshotCapacity
        // GraphQL -> snapshotCapacity: Float! (scalar)
        if (this.SnapshotCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCapacity\n" ;
            } else {
                s += ind + "snapshotCapacity\n" ;
            }
        }
        //      C# -> System.Single? TotalCapacity
        // GraphQL -> totalCapacity: Float! (scalar)
        if (this.TotalCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalCapacity\n" ;
            } else {
                s += ind + "totalCapacity\n" ;
            }
        }
        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        if (this.UsedCapacity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "usedCapacity\n" ;
            } else {
                s += ind + "usedCapacity\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Single? AvailableCapacity
        // GraphQL -> availableCapacity: Float! (scalar)
        if (ec.Includes("availableCapacity",true))
        {
            if(this.AvailableCapacity == null) {

                this.AvailableCapacity = new System.Single();

            } else {


            }
        }
        else if (this.AvailableCapacity != null && ec.Excludes("availableCapacity",true))
        {
            this.AvailableCapacity = null;
        }
        //      C# -> System.Single? AverageDailyGrowth
        // GraphQL -> averageDailyGrowth: Float! (scalar)
        if (ec.Includes("averageDailyGrowth",true))
        {
            if(this.AverageDailyGrowth == null) {

                this.AverageDailyGrowth = new System.Single();

            } else {


            }
        }
        else if (this.AverageDailyGrowth != null && ec.Excludes("averageDailyGrowth",true))
        {
            this.AverageDailyGrowth = null;
        }
        //      C# -> System.Single? CdpCapacity
        // GraphQL -> cdpCapacity: Float! (scalar)
        if (ec.Includes("cdpCapacity",true))
        {
            if(this.CdpCapacity == null) {

                this.CdpCapacity = new System.Single();

            } else {


            }
        }
        else if (this.CdpCapacity != null && ec.Excludes("cdpCapacity",true))
        {
            this.CdpCapacity = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: String! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Int64? ImmutabilityOverhead
        // GraphQL -> immutabilityOverhead: Long! (scalar)
        if (ec.Includes("immutabilityOverhead",true))
        {
            if(this.ImmutabilityOverhead == null) {

                this.ImmutabilityOverhead = new System.Int64();

            } else {


            }
        }
        else if (this.ImmutabilityOverhead != null && ec.Excludes("immutabilityOverhead",true))
        {
            this.ImmutabilityOverhead = null;
        }
        //      C# -> System.Single? IngestedArchivalStorage
        // GraphQL -> ingestedArchivalStorage: Float! (scalar)
        if (ec.Includes("ingestedArchivalStorage",true))
        {
            if(this.IngestedArchivalStorage == null) {

                this.IngestedArchivalStorage = new System.Single();

            } else {


            }
        }
        else if (this.IngestedArchivalStorage != null && ec.Excludes("ingestedArchivalStorage",true))
        {
            this.IngestedArchivalStorage = null;
        }
        //      C# -> System.Single? IngestedSnapshotStorage
        // GraphQL -> ingestedSnapshotStorage: Float! (scalar)
        if (ec.Includes("ingestedSnapshotStorage",true))
        {
            if(this.IngestedSnapshotStorage == null) {

                this.IngestedSnapshotStorage = new System.Single();

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
        //      C# -> System.Single? LiveMountCapacity
        // GraphQL -> liveMountCapacity: Float! (scalar)
        if (ec.Includes("liveMountCapacity",true))
        {
            if(this.LiveMountCapacity == null) {

                this.LiveMountCapacity = new System.Single();

            } else {


            }
        }
        else if (this.LiveMountCapacity != null && ec.Excludes("liveMountCapacity",true))
        {
            this.LiveMountCapacity = null;
        }
        //      C# -> System.Single? MiscellaneousCapacity
        // GraphQL -> miscellaneousCapacity: Float! (scalar)
        if (ec.Includes("miscellaneousCapacity",true))
        {
            if(this.MiscellaneousCapacity == null) {

                this.MiscellaneousCapacity = new System.Single();

            } else {


            }
        }
        else if (this.MiscellaneousCapacity != null && ec.Excludes("miscellaneousCapacity",true))
        {
            this.MiscellaneousCapacity = null;
        }
        //      C# -> System.Single? PendingSnapshotCapacity
        // GraphQL -> pendingSnapshotCapacity: Float! (scalar)
        if (ec.Includes("pendingSnapshotCapacity",true))
        {
            if(this.PendingSnapshotCapacity == null) {

                this.PendingSnapshotCapacity = new System.Single();

            } else {


            }
        }
        else if (this.PendingSnapshotCapacity != null && ec.Excludes("pendingSnapshotCapacity",true))
        {
            this.PendingSnapshotCapacity = null;
        }
        //      C# -> System.Single? PhysicalArchivalStorage
        // GraphQL -> physicalArchivalStorage: Float! (scalar)
        if (ec.Includes("physicalArchivalStorage",true))
        {
            if(this.PhysicalArchivalStorage == null) {

                this.PhysicalArchivalStorage = new System.Single();

            } else {


            }
        }
        else if (this.PhysicalArchivalStorage != null && ec.Excludes("physicalArchivalStorage",true))
        {
            this.PhysicalArchivalStorage = null;
        }
        //      C# -> System.Single? PhysicalSnapshotStorage
        // GraphQL -> physicalSnapshotStorage: Float! (scalar)
        if (ec.Includes("physicalSnapshotStorage",true))
        {
            if(this.PhysicalSnapshotStorage == null) {

                this.PhysicalSnapshotStorage = new System.Single();

            } else {


            }
        }
        else if (this.PhysicalSnapshotStorage != null && ec.Excludes("physicalSnapshotStorage",true))
        {
            this.PhysicalSnapshotStorage = null;
        }
        //      C# -> System.Single? SnapshotCapacity
        // GraphQL -> snapshotCapacity: Float! (scalar)
        if (ec.Includes("snapshotCapacity",true))
        {
            if(this.SnapshotCapacity == null) {

                this.SnapshotCapacity = new System.Single();

            } else {


            }
        }
        else if (this.SnapshotCapacity != null && ec.Excludes("snapshotCapacity",true))
        {
            this.SnapshotCapacity = null;
        }
        //      C# -> System.Single? TotalCapacity
        // GraphQL -> totalCapacity: Float! (scalar)
        if (ec.Includes("totalCapacity",true))
        {
            if(this.TotalCapacity == null) {

                this.TotalCapacity = new System.Single();

            } else {


            }
        }
        else if (this.TotalCapacity != null && ec.Excludes("totalCapacity",true))
        {
            this.TotalCapacity = null;
        }
        //      C# -> System.Single? UsedCapacity
        // GraphQL -> usedCapacity: Float! (scalar)
        if (ec.Includes("usedCapacity",true))
        {
            if(this.UsedCapacity == null) {

                this.UsedCapacity = new System.Single();

            } else {


            }
        }
        else if (this.UsedCapacity != null && ec.Excludes("usedCapacity",true))
        {
            this.UsedCapacity = null;
        }
    }


    #endregion

    } // class ClusterStatsData
    
    #endregion

    public static class ListClusterStatsDataExtensions
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
            this List<ClusterStatsData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClusterStatsData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClusterStatsData> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterStatsData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClusterStatsData> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types