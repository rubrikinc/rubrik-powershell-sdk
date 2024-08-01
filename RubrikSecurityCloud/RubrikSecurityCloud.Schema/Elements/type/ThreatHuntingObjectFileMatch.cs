// ThreatHuntingObjectFileMatch.cs
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
    #region ThreatHuntingObjectFileMatch
    public class ThreatHuntingObjectFileMatch: BaseType
    {
        #region members

        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        [JsonProperty("matchType")]
        public IndicatorOfCompromiseKind? MatchType { get; set; }

        //      C# -> DateTime? CreatedTime
        // GraphQL -> createdTime: DateTime (scalar)
        [JsonProperty("createdTime")]
        public DateTime? CreatedTime { get; set; }

        //      C# -> DateTime? EarliestMatchedSnapshotDate
        // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("earliestMatchedSnapshotDate")]
        public DateTime? EarliestMatchedSnapshotDate { get; set; }

        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        [JsonProperty("filepath")]
        public System.String? Filepath { get; set; }

        //      C# -> DateTime? LatestMatchedSnapshotDate
        // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("latestMatchedSnapshotDate")]
        public DateTime? LatestMatchedSnapshotDate { get; set; }

        //      C# -> DateTime? LatestSnapshotWithoutMatchDate
        // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
        [JsonProperty("latestSnapshotWithoutMatchDate")]
        public DateTime? LatestSnapshotWithoutMatchDate { get; set; }

        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        [JsonProperty("modifiedTime")]
        public DateTime? ModifiedTime { get; set; }

        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        [JsonProperty("totalSnapshotsScanned")]
        public System.Int64? TotalSnapshotsScanned { get; set; }

        //      C# -> List<MatchedSnapshot>? MatchedSnapshots
        // GraphQL -> matchedSnapshots: [MatchedSnapshot!]! (type)
        [JsonProperty("matchedSnapshots")]
        public List<MatchedSnapshot>? MatchedSnapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntingObjectFileMatch";
    }

    public ThreatHuntingObjectFileMatch Set(
        IndicatorOfCompromiseKind? MatchType = null,
        DateTime? CreatedTime = null,
        DateTime? EarliestMatchedSnapshotDate = null,
        System.String? Filepath = null,
        DateTime? LatestMatchedSnapshotDate = null,
        DateTime? LatestSnapshotWithoutMatchDate = null,
        DateTime? ModifiedTime = null,
        System.Int64? TotalSnapshotsScanned = null,
        List<MatchedSnapshot>? MatchedSnapshots = null
    ) 
    {
        if ( MatchType != null ) {
            this.MatchType = MatchType;
        }
        if ( CreatedTime != null ) {
            this.CreatedTime = CreatedTime;
        }
        if ( EarliestMatchedSnapshotDate != null ) {
            this.EarliestMatchedSnapshotDate = EarliestMatchedSnapshotDate;
        }
        if ( Filepath != null ) {
            this.Filepath = Filepath;
        }
        if ( LatestMatchedSnapshotDate != null ) {
            this.LatestMatchedSnapshotDate = LatestMatchedSnapshotDate;
        }
        if ( LatestSnapshotWithoutMatchDate != null ) {
            this.LatestSnapshotWithoutMatchDate = LatestSnapshotWithoutMatchDate;
        }
        if ( ModifiedTime != null ) {
            this.ModifiedTime = ModifiedTime;
        }
        if ( TotalSnapshotsScanned != null ) {
            this.TotalSnapshotsScanned = TotalSnapshotsScanned;
        }
        if ( MatchedSnapshots != null ) {
            this.MatchedSnapshots = MatchedSnapshots;
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
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (this.MatchType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchType\n" ;
            } else {
                s += ind + "matchType\n" ;
            }
        }
        //      C# -> DateTime? CreatedTime
        // GraphQL -> createdTime: DateTime (scalar)
        if (this.CreatedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdTime\n" ;
            } else {
                s += ind + "createdTime\n" ;
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
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (this.Filepath != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filepath\n" ;
            } else {
                s += ind + "filepath\n" ;
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
        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        if (this.ModifiedTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "modifiedTime\n" ;
            } else {
                s += ind + "modifiedTime\n" ;
            }
        }
        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        if (this.TotalSnapshotsScanned != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSnapshotsScanned\n" ;
            } else {
                s += ind + "totalSnapshotsScanned\n" ;
            }
        }
        //      C# -> List<MatchedSnapshot>? MatchedSnapshots
        // GraphQL -> matchedSnapshots: [MatchedSnapshot!]! (type)
        if (this.MatchedSnapshots != null) {
            var fspec = this.MatchedSnapshots.AsFieldSpec(conf.Child("matchedSnapshots"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "matchedSnapshots" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> IndicatorOfCompromiseKind? MatchType
        // GraphQL -> matchType: IndicatorOfCompromiseKind! (enum)
        if (ec.Includes("matchType",true))
        {
            if(this.MatchType == null) {

                this.MatchType = new IndicatorOfCompromiseKind();

            } else {


            }
        }
        else if (this.MatchType != null && ec.Excludes("matchType",true))
        {
            this.MatchType = null;
        }
        //      C# -> DateTime? CreatedTime
        // GraphQL -> createdTime: DateTime (scalar)
        if (ec.Includes("createdTime",true))
        {
            if(this.CreatedTime == null) {

                this.CreatedTime = new DateTime();

            } else {


            }
        }
        else if (this.CreatedTime != null && ec.Excludes("createdTime",true))
        {
            this.CreatedTime = null;
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
        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        if (ec.Includes("filepath",true))
        {
            if(this.Filepath == null) {

                this.Filepath = "FETCH";

            } else {


            }
        }
        else if (this.Filepath != null && ec.Excludes("filepath",true))
        {
            this.Filepath = null;
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
        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        if (ec.Includes("modifiedTime",true))
        {
            if(this.ModifiedTime == null) {

                this.ModifiedTime = new DateTime();

            } else {


            }
        }
        else if (this.ModifiedTime != null && ec.Excludes("modifiedTime",true))
        {
            this.ModifiedTime = null;
        }
        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        if (ec.Includes("totalSnapshotsScanned",true))
        {
            if(this.TotalSnapshotsScanned == null) {

                this.TotalSnapshotsScanned = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSnapshotsScanned != null && ec.Excludes("totalSnapshotsScanned",true))
        {
            this.TotalSnapshotsScanned = null;
        }
        //      C# -> List<MatchedSnapshot>? MatchedSnapshots
        // GraphQL -> matchedSnapshots: [MatchedSnapshot!]! (type)
        if (ec.Includes("matchedSnapshots",false))
        {
            if(this.MatchedSnapshots == null) {

                this.MatchedSnapshots = new List<MatchedSnapshot>();
                this.MatchedSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("matchedSnapshots"));

            } else {

                this.MatchedSnapshots.ApplyExploratoryFieldSpec(ec.NewChild("matchedSnapshots"));

            }
        }
        else if (this.MatchedSnapshots != null && ec.Excludes("matchedSnapshots",false))
        {
            this.MatchedSnapshots = null;
        }
    }


    #endregion

    } // class ThreatHuntingObjectFileMatch
    
    #endregion

    public static class ListThreatHuntingObjectFileMatchExtensions
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
            this List<ThreatHuntingObjectFileMatch> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntingObjectFileMatch> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntingObjectFileMatch> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntingObjectFileMatch());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntingObjectFileMatch> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types