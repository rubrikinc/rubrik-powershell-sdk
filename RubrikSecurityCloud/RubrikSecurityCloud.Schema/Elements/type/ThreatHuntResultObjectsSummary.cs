// ThreatHuntResultObjectsSummary.cs
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
    #region ThreatHuntResultObjectsSummary
    public class ThreatHuntResultObjectsSummary: BaseType
    {
        #region members

        //      C# -> ThreatHuntObjectStatus? ObjectScanStatus
        // GraphQL -> objectScanStatus: ThreatHuntObjectStatus! (enum)
        [JsonProperty("objectScanStatus")]
        public ThreatHuntObjectStatus? ObjectScanStatus { get; set; }

        //      C# -> CdmHierarchySnappableNew? Object
        // GraphQL -> object: CdmHierarchySnappableNew (interface)
        [JsonProperty("object")]
        public CdmHierarchySnappableNew? Object { get; set; }

        //      C# -> HierarchySnappable? ObjectV2
        // GraphQL -> objectV2: HierarchySnappable (interface)
        [JsonProperty("objectV2")]
        public HierarchySnappable? ObjectV2 { get; set; }

        //      C# -> DateTime? EarliestMatchedSnapshotDate
        // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("earliestMatchedSnapshotDate")]
        public DateTime? EarliestMatchedSnapshotDate { get; set; }

        //      C# -> System.Boolean? HasQuarantinedMatches
        // GraphQL -> hasQuarantinedMatches: Boolean! (scalar)
        [JsonProperty("hasQuarantinedMatches")]
        public System.Boolean? HasQuarantinedMatches { get; set; }

        //      C# -> DateTime? LatestMatchedSnapshotDate
        // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("latestMatchedSnapshotDate")]
        public DateTime? LatestMatchedSnapshotDate { get; set; }

        //      C# -> DateTime? LatestSnapshotWithoutMatchDate
        // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
        [JsonProperty("latestSnapshotWithoutMatchDate")]
        public DateTime? LatestSnapshotWithoutMatchDate { get; set; }

        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        [JsonProperty("location")]
        public System.String? Location { get; set; }

        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        [JsonProperty("totalMatchedPaths")]
        public System.Int64? TotalMatchedPaths { get; set; }

        //      C# -> System.Int32? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Int! (scalar)
        [JsonProperty("totalMatchedSnapshots")]
        public System.Int32? TotalMatchedSnapshots { get; set; }

        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        [JsonProperty("totalUniqueMatchedPaths")]
        public System.Int64? TotalUniqueMatchedPaths { get; set; }

        //      C# -> Cluster? ClusterInfo
        // GraphQL -> clusterInfo: Cluster (type)
        [JsonProperty("clusterInfo")]
        public Cluster? ClusterInfo { get; set; }

        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        [JsonProperty("matchTypes")]
        public List<IndicatorOfCompromise>? MatchTypes { get; set; }

        //      C# -> List<ThreatHuntResultSnapshotStats>? SnapshotsStats
        // GraphQL -> snapshotsStats: [ThreatHuntResultSnapshotStats!]! (type)
        [JsonProperty("snapshotsStats")]
        public List<ThreatHuntResultSnapshotStats>? SnapshotsStats { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntResultObjectsSummary";
    }

    public ThreatHuntResultObjectsSummary Set(
        ThreatHuntObjectStatus? ObjectScanStatus = null,
        CdmHierarchySnappableNew? Object = null,
        HierarchySnappable? ObjectV2 = null,
        DateTime? EarliestMatchedSnapshotDate = null,
        System.Boolean? HasQuarantinedMatches = null,
        DateTime? LatestMatchedSnapshotDate = null,
        DateTime? LatestSnapshotWithoutMatchDate = null,
        System.String? Location = null,
        System.Int64? TotalMatchedPaths = null,
        System.Int32? TotalMatchedSnapshots = null,
        System.Int64? TotalUniqueMatchedPaths = null,
        Cluster? ClusterInfo = null,
        List<IndicatorOfCompromise>? MatchTypes = null,
        List<ThreatHuntResultSnapshotStats>? SnapshotsStats = null
    ) 
    {
        if ( ObjectScanStatus != null ) {
            this.ObjectScanStatus = ObjectScanStatus;
        }
        if ( Object != null ) {
            this.Object = Object;
        }
        if ( ObjectV2 != null ) {
            this.ObjectV2 = ObjectV2;
        }
        if ( EarliestMatchedSnapshotDate != null ) {
            this.EarliestMatchedSnapshotDate = EarliestMatchedSnapshotDate;
        }
        if ( HasQuarantinedMatches != null ) {
            this.HasQuarantinedMatches = HasQuarantinedMatches;
        }
        if ( LatestMatchedSnapshotDate != null ) {
            this.LatestMatchedSnapshotDate = LatestMatchedSnapshotDate;
        }
        if ( LatestSnapshotWithoutMatchDate != null ) {
            this.LatestSnapshotWithoutMatchDate = LatestSnapshotWithoutMatchDate;
        }
        if ( Location != null ) {
            this.Location = Location;
        }
        if ( TotalMatchedPaths != null ) {
            this.TotalMatchedPaths = TotalMatchedPaths;
        }
        if ( TotalMatchedSnapshots != null ) {
            this.TotalMatchedSnapshots = TotalMatchedSnapshots;
        }
        if ( TotalUniqueMatchedPaths != null ) {
            this.TotalUniqueMatchedPaths = TotalUniqueMatchedPaths;
        }
        if ( ClusterInfo != null ) {
            this.ClusterInfo = ClusterInfo;
        }
        if ( MatchTypes != null ) {
            this.MatchTypes = MatchTypes;
        }
        if ( SnapshotsStats != null ) {
            this.SnapshotsStats = SnapshotsStats;
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
        //      C# -> ThreatHuntObjectStatus? ObjectScanStatus
        // GraphQL -> objectScanStatus: ThreatHuntObjectStatus! (enum)
        if (this.ObjectScanStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectScanStatus\n" ;
            } else {
                s += ind + "objectScanStatus\n" ;
            }
        }
        //      C# -> CdmHierarchySnappableNew? Object
        // GraphQL -> object: CdmHierarchySnappableNew (interface)
        if (this.Object != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.Object, conf.Child("object"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "object" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> HierarchySnappable? ObjectV2
        // GraphQL -> objectV2: HierarchySnappable (interface)
        if (this.ObjectV2 != null) {
                var fspec = InterfaceHelper.CompositeAsFieldSpec((BaseType)this.ObjectV2, conf.Child("objectV2"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "objectV2" + " " + "{\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> DateTime? EarliestMatchedSnapshotDate
        // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
        if (this.EarliestMatchedSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestMatchedSnapshotDate\n" ;
            } else {
                s += ind + "earliestMatchedSnapshotDate\n" ;
            }
        }
        //      C# -> System.Boolean? HasQuarantinedMatches
        // GraphQL -> hasQuarantinedMatches: Boolean! (scalar)
        if (this.HasQuarantinedMatches != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasQuarantinedMatches\n" ;
            } else {
                s += ind + "hasQuarantinedMatches\n" ;
            }
        }
        //      C# -> DateTime? LatestMatchedSnapshotDate
        // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
        if (this.LatestMatchedSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestMatchedSnapshotDate\n" ;
            } else {
                s += ind + "latestMatchedSnapshotDate\n" ;
            }
        }
        //      C# -> DateTime? LatestSnapshotWithoutMatchDate
        // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
        if (this.LatestSnapshotWithoutMatchDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestSnapshotWithoutMatchDate\n" ;
            } else {
                s += ind + "latestSnapshotWithoutMatchDate\n" ;
            }
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (this.Location != null) {
            if (conf.Flat) {
                s += conf.Prefix + "location\n" ;
            } else {
                s += ind + "location\n" ;
            }
        }
        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        if (this.TotalMatchedPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalMatchedPaths\n" ;
            } else {
                s += ind + "totalMatchedPaths\n" ;
            }
        }
        //      C# -> System.Int32? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Int! (scalar)
        if (this.TotalMatchedSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalMatchedSnapshots\n" ;
            } else {
                s += ind + "totalMatchedSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        if (this.TotalUniqueMatchedPaths != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalUniqueMatchedPaths\n" ;
            } else {
                s += ind + "totalUniqueMatchedPaths\n" ;
            }
        }
        //      C# -> Cluster? ClusterInfo
        // GraphQL -> clusterInfo: Cluster (type)
        if (this.ClusterInfo != null) {
            var fspec = this.ClusterInfo.AsFieldSpec(conf.Child("clusterInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusterInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        if (this.MatchTypes != null) {
            var fspec = this.MatchTypes.AsFieldSpec(conf.Child("matchTypes"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "matchTypes" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<ThreatHuntResultSnapshotStats>? SnapshotsStats
        // GraphQL -> snapshotsStats: [ThreatHuntResultSnapshotStats!]! (type)
        if (this.SnapshotsStats != null) {
            var fspec = this.SnapshotsStats.AsFieldSpec(conf.Child("snapshotsStats"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "snapshotsStats" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ThreatHuntObjectStatus? ObjectScanStatus
        // GraphQL -> objectScanStatus: ThreatHuntObjectStatus! (enum)
        if (ec.Includes("objectScanStatus",true))
        {
            if(this.ObjectScanStatus == null) {

                this.ObjectScanStatus = new ThreatHuntObjectStatus();

            } else {


            }
        }
        else if (this.ObjectScanStatus != null && ec.Excludes("objectScanStatus",true))
        {
            this.ObjectScanStatus = null;
        }
        //      C# -> CdmHierarchySnappableNew? Object
        // GraphQL -> object: CdmHierarchySnappableNew (interface)
        if (ec.Includes("object",false))
        {
            if(this.Object == null) {

                var impls = new List<CdmHierarchySnappableNew>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("object"));
                this.Object = (CdmHierarchySnappableNew)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<CdmHierarchySnappableNew>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("object"));
                this.Object = (CdmHierarchySnappableNew)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.Object != null && ec.Excludes("object",false))
        {
            this.Object = null;
        }
        //      C# -> HierarchySnappable? ObjectV2
        // GraphQL -> objectV2: HierarchySnappable (interface)
        if (ec.Includes("objectV2",false))
        {
            if(this.ObjectV2 == null) {

                var impls = new List<HierarchySnappable>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("objectV2"));
                this.ObjectV2 = (HierarchySnappable)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<HierarchySnappable>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("objectV2"));
                this.ObjectV2 = (HierarchySnappable)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.ObjectV2 != null && ec.Excludes("objectV2",false))
        {
            this.ObjectV2 = null;
        }
        //      C# -> DateTime? EarliestMatchedSnapshotDate
        // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
        if (ec.Includes("earliestMatchedSnapshotDate",true))
        {
            if(this.EarliestMatchedSnapshotDate == null) {

                this.EarliestMatchedSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.EarliestMatchedSnapshotDate != null && ec.Excludes("earliestMatchedSnapshotDate",true))
        {
            this.EarliestMatchedSnapshotDate = null;
        }
        //      C# -> System.Boolean? HasQuarantinedMatches
        // GraphQL -> hasQuarantinedMatches: Boolean! (scalar)
        if (ec.Includes("hasQuarantinedMatches",true))
        {
            if(this.HasQuarantinedMatches == null) {

                this.HasQuarantinedMatches = true;

            } else {


            }
        }
        else if (this.HasQuarantinedMatches != null && ec.Excludes("hasQuarantinedMatches",true))
        {
            this.HasQuarantinedMatches = null;
        }
        //      C# -> DateTime? LatestMatchedSnapshotDate
        // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
        if (ec.Includes("latestMatchedSnapshotDate",true))
        {
            if(this.LatestMatchedSnapshotDate == null) {

                this.LatestMatchedSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.LatestMatchedSnapshotDate != null && ec.Excludes("latestMatchedSnapshotDate",true))
        {
            this.LatestMatchedSnapshotDate = null;
        }
        //      C# -> DateTime? LatestSnapshotWithoutMatchDate
        // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
        if (ec.Includes("latestSnapshotWithoutMatchDate",true))
        {
            if(this.LatestSnapshotWithoutMatchDate == null) {

                this.LatestSnapshotWithoutMatchDate = new DateTime();

            } else {


            }
        }
        else if (this.LatestSnapshotWithoutMatchDate != null && ec.Excludes("latestSnapshotWithoutMatchDate",true))
        {
            this.LatestSnapshotWithoutMatchDate = null;
        }
        //      C# -> System.String? Location
        // GraphQL -> location: String! (scalar)
        if (ec.Includes("location",true))
        {
            if(this.Location == null) {

                this.Location = "FETCH";

            } else {


            }
        }
        else if (this.Location != null && ec.Excludes("location",true))
        {
            this.Location = null;
        }
        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        if (ec.Includes("totalMatchedPaths",true))
        {
            if(this.TotalMatchedPaths == null) {

                this.TotalMatchedPaths = new System.Int64();

            } else {


            }
        }
        else if (this.TotalMatchedPaths != null && ec.Excludes("totalMatchedPaths",true))
        {
            this.TotalMatchedPaths = null;
        }
        //      C# -> System.Int32? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Int! (scalar)
        if (ec.Includes("totalMatchedSnapshots",true))
        {
            if(this.TotalMatchedSnapshots == null) {

                this.TotalMatchedSnapshots = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalMatchedSnapshots != null && ec.Excludes("totalMatchedSnapshots",true))
        {
            this.TotalMatchedSnapshots = null;
        }
        //      C# -> System.Int64? TotalUniqueMatchedPaths
        // GraphQL -> totalUniqueMatchedPaths: Long! (scalar)
        if (ec.Includes("totalUniqueMatchedPaths",true))
        {
            if(this.TotalUniqueMatchedPaths == null) {

                this.TotalUniqueMatchedPaths = new System.Int64();

            } else {


            }
        }
        else if (this.TotalUniqueMatchedPaths != null && ec.Excludes("totalUniqueMatchedPaths",true))
        {
            this.TotalUniqueMatchedPaths = null;
        }
        //      C# -> Cluster? ClusterInfo
        // GraphQL -> clusterInfo: Cluster (type)
        if (ec.Includes("clusterInfo",false))
        {
            if(this.ClusterInfo == null) {

                this.ClusterInfo = new Cluster();
                this.ClusterInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterInfo"));

            } else {

                this.ClusterInfo.ApplyExploratoryFieldSpec(ec.NewChild("clusterInfo"));

            }
        }
        else if (this.ClusterInfo != null && ec.Excludes("clusterInfo",false))
        {
            this.ClusterInfo = null;
        }
        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        if (ec.Includes("matchTypes",false))
        {
            if(this.MatchTypes == null) {

                this.MatchTypes = new List<IndicatorOfCompromise>();
                this.MatchTypes.ApplyExploratoryFieldSpec(ec.NewChild("matchTypes"));

            } else {

                this.MatchTypes.ApplyExploratoryFieldSpec(ec.NewChild("matchTypes"));

            }
        }
        else if (this.MatchTypes != null && ec.Excludes("matchTypes",false))
        {
            this.MatchTypes = null;
        }
        //      C# -> List<ThreatHuntResultSnapshotStats>? SnapshotsStats
        // GraphQL -> snapshotsStats: [ThreatHuntResultSnapshotStats!]! (type)
        if (ec.Includes("snapshotsStats",false))
        {
            if(this.SnapshotsStats == null) {

                this.SnapshotsStats = new List<ThreatHuntResultSnapshotStats>();
                this.SnapshotsStats.ApplyExploratoryFieldSpec(ec.NewChild("snapshotsStats"));

            } else {

                this.SnapshotsStats.ApplyExploratoryFieldSpec(ec.NewChild("snapshotsStats"));

            }
        }
        else if (this.SnapshotsStats != null && ec.Excludes("snapshotsStats",false))
        {
            this.SnapshotsStats = null;
        }
    }


    #endregion

    } // class ThreatHuntResultObjectsSummary
    
    #endregion

    public static class ListThreatHuntResultObjectsSummaryExtensions
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
            this List<ThreatHuntResultObjectsSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntResultObjectsSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntResultObjectsSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntResultObjectsSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntResultObjectsSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types