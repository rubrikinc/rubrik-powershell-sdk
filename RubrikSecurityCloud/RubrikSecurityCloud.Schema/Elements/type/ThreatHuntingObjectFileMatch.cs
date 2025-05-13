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

        //      C# -> DateTime? CreatedTime
        // GraphQL -> createdTime: DateTime (scalar)
        [JsonProperty("createdTime")]
        public DateTime? CreatedTime { get; set; }

        //      C# -> DateTime? EarliestMatchedSnapshotDate
        // GraphQL -> earliestMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("earliestMatchedSnapshotDate")]
        public DateTime? EarliestMatchedSnapshotDate { get; set; }

        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        [JsonProperty("filename")]
        public System.String? Filename { get; set; }

        //      C# -> System.String? Filepath
        // GraphQL -> filepath: String! (scalar)
        [JsonProperty("filepath")]
        public System.String? Filepath { get; set; }

        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        [JsonProperty("isQuarantinedInFirstObservedSnapshot")]
        public System.Boolean? IsQuarantinedInFirstObservedSnapshot { get; set; }

        //      C# -> DateTime? LatestMatchedSnapshotDate
        // GraphQL -> latestMatchedSnapshotDate: DateTime (scalar)
        [JsonProperty("latestMatchedSnapshotDate")]
        public DateTime? LatestMatchedSnapshotDate { get; set; }

        //      C# -> DateTime? LatestSnapshotWithoutMatchDate
        // GraphQL -> latestSnapshotWithoutMatchDate: DateTime (scalar)
        [JsonProperty("latestSnapshotWithoutMatchDate")]
        public DateTime? LatestSnapshotWithoutMatchDate { get; set; }

        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        [JsonProperty("matchId")]
        public System.Int64? MatchId { get; set; }

        //      C# -> System.String? MatchedFileMd5
        // GraphQL -> matchedFileMd5: String! (scalar)
        [JsonProperty("matchedFileMd5")]
        public System.String? MatchedFileMd5 { get; set; }

        //      C# -> System.String? MatchedFileSha1
        // GraphQL -> matchedFileSha1: String! (scalar)
        [JsonProperty("matchedFileSha1")]
        public System.String? MatchedFileSha1 { get; set; }

        //      C# -> System.String? MatchedFileSha256
        // GraphQL -> matchedFileSha256: String! (scalar)
        [JsonProperty("matchedFileSha256")]
        public System.String? MatchedFileSha256 { get; set; }

        //      C# -> DateTime? ModifiedTime
        // GraphQL -> modifiedTime: DateTime (scalar)
        [JsonProperty("modifiedTime")]
        public DateTime? ModifiedTime { get; set; }

        //      C# -> System.Int64? TotalSnapshotsMatched
        // GraphQL -> totalSnapshotsMatched: Long! (scalar)
        [JsonProperty("totalSnapshotsMatched")]
        public System.Int64? TotalSnapshotsMatched { get; set; }

        //      C# -> System.Int64? TotalSnapshotsScanned
        // GraphQL -> totalSnapshotsScanned: Long! (scalar)
        [JsonProperty("totalSnapshotsScanned")]
        public System.Int64? TotalSnapshotsScanned { get; set; }

        //      C# -> List<ThreatHuntIocDetails>? IocDetails
        // GraphQL -> iocDetails: [ThreatHuntIocDetails!]! (type)
        [JsonProperty("iocDetails")]
        public List<ThreatHuntIocDetails>? IocDetails { get; set; }

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
        DateTime? CreatedTime = null,
        DateTime? EarliestMatchedSnapshotDate = null,
        System.String? Filename = null,
        System.String? Filepath = null,
        System.Boolean? IsQuarantinedInFirstObservedSnapshot = null,
        DateTime? LatestMatchedSnapshotDate = null,
        DateTime? LatestSnapshotWithoutMatchDate = null,
        System.Int64? MatchId = null,
        System.String? MatchedFileMd5 = null,
        System.String? MatchedFileSha1 = null,
        System.String? MatchedFileSha256 = null,
        DateTime? ModifiedTime = null,
        System.Int64? TotalSnapshotsMatched = null,
        System.Int64? TotalSnapshotsScanned = null,
        List<ThreatHuntIocDetails>? IocDetails = null,
        List<MatchedSnapshot>? MatchedSnapshots = null
    ) 
    {
        if ( CreatedTime != null ) {
            this.CreatedTime = CreatedTime;
        }
        if ( EarliestMatchedSnapshotDate != null ) {
            this.EarliestMatchedSnapshotDate = EarliestMatchedSnapshotDate;
        }
        if ( Filename != null ) {
            this.Filename = Filename;
        }
        if ( Filepath != null ) {
            this.Filepath = Filepath;
        }
        if ( IsQuarantinedInFirstObservedSnapshot != null ) {
            this.IsQuarantinedInFirstObservedSnapshot = IsQuarantinedInFirstObservedSnapshot;
        }
        if ( LatestMatchedSnapshotDate != null ) {
            this.LatestMatchedSnapshotDate = LatestMatchedSnapshotDate;
        }
        if ( LatestSnapshotWithoutMatchDate != null ) {
            this.LatestSnapshotWithoutMatchDate = LatestSnapshotWithoutMatchDate;
        }
        if ( MatchId != null ) {
            this.MatchId = MatchId;
        }
        if ( MatchedFileMd5 != null ) {
            this.MatchedFileMd5 = MatchedFileMd5;
        }
        if ( MatchedFileSha1 != null ) {
            this.MatchedFileSha1 = MatchedFileSha1;
        }
        if ( MatchedFileSha256 != null ) {
            this.MatchedFileSha256 = MatchedFileSha256;
        }
        if ( ModifiedTime != null ) {
            this.ModifiedTime = ModifiedTime;
        }
        if ( TotalSnapshotsMatched != null ) {
            this.TotalSnapshotsMatched = TotalSnapshotsMatched;
        }
        if ( TotalSnapshotsScanned != null ) {
            this.TotalSnapshotsScanned = TotalSnapshotsScanned;
        }
        if ( IocDetails != null ) {
            this.IocDetails = IocDetails;
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
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (this.Filename != null) {
            if (conf.Flat) {
                s += conf.Prefix + "filename\n" ;
            } else {
                s += ind + "filename\n" ;
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
        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        if (this.IsQuarantinedInFirstObservedSnapshot != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantinedInFirstObservedSnapshot\n" ;
            } else {
                s += ind + "isQuarantinedInFirstObservedSnapshot\n" ;
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
        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        if (this.MatchId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchId\n" ;
            } else {
                s += ind + "matchId\n" ;
            }
        }
        //      C# -> System.String? MatchedFileMd5
        // GraphQL -> matchedFileMd5: String! (scalar)
        if (this.MatchedFileMd5 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedFileMd5\n" ;
            } else {
                s += ind + "matchedFileMd5\n" ;
            }
        }
        //      C# -> System.String? MatchedFileSha1
        // GraphQL -> matchedFileSha1: String! (scalar)
        if (this.MatchedFileSha1 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedFileSha1\n" ;
            } else {
                s += ind + "matchedFileSha1\n" ;
            }
        }
        //      C# -> System.String? MatchedFileSha256
        // GraphQL -> matchedFileSha256: String! (scalar)
        if (this.MatchedFileSha256 != null) {
            if (conf.Flat) {
                s += conf.Prefix + "matchedFileSha256\n" ;
            } else {
                s += ind + "matchedFileSha256\n" ;
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
        //      C# -> System.Int64? TotalSnapshotsMatched
        // GraphQL -> totalSnapshotsMatched: Long! (scalar)
        if (this.TotalSnapshotsMatched != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSnapshotsMatched\n" ;
            } else {
                s += ind + "totalSnapshotsMatched\n" ;
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
        //      C# -> List<ThreatHuntIocDetails>? IocDetails
        // GraphQL -> iocDetails: [ThreatHuntIocDetails!]! (type)
        if (this.IocDetails != null) {
            var fspec = this.IocDetails.AsFieldSpec(conf.Child("iocDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "iocDetails" + " " + "{\n" + fspec + ind + "}\n" ;
                }
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


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
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
        //      C# -> System.String? Filename
        // GraphQL -> filename: String! (scalar)
        if (ec.Includes("filename",true))
        {
            if(this.Filename == null) {

                this.Filename = "FETCH";

            } else {


            }
        }
        else if (this.Filename != null && ec.Excludes("filename",true))
        {
            this.Filename = null;
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
        //      C# -> System.Boolean? IsQuarantinedInFirstObservedSnapshot
        // GraphQL -> isQuarantinedInFirstObservedSnapshot: Boolean! (scalar)
        if (ec.Includes("isQuarantinedInFirstObservedSnapshot",true))
        {
            if(this.IsQuarantinedInFirstObservedSnapshot == null) {

                this.IsQuarantinedInFirstObservedSnapshot = true;

            } else {


            }
        }
        else if (this.IsQuarantinedInFirstObservedSnapshot != null && ec.Excludes("isQuarantinedInFirstObservedSnapshot",true))
        {
            this.IsQuarantinedInFirstObservedSnapshot = null;
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
        //      C# -> System.Int64? MatchId
        // GraphQL -> matchId: Long! (scalar)
        if (ec.Includes("matchId",true))
        {
            if(this.MatchId == null) {

                this.MatchId = new System.Int64();

            } else {


            }
        }
        else if (this.MatchId != null && ec.Excludes("matchId",true))
        {
            this.MatchId = null;
        }
        //      C# -> System.String? MatchedFileMd5
        // GraphQL -> matchedFileMd5: String! (scalar)
        if (ec.Includes("matchedFileMd5",true))
        {
            if(this.MatchedFileMd5 == null) {

                this.MatchedFileMd5 = "FETCH";

            } else {


            }
        }
        else if (this.MatchedFileMd5 != null && ec.Excludes("matchedFileMd5",true))
        {
            this.MatchedFileMd5 = null;
        }
        //      C# -> System.String? MatchedFileSha1
        // GraphQL -> matchedFileSha1: String! (scalar)
        if (ec.Includes("matchedFileSha1",true))
        {
            if(this.MatchedFileSha1 == null) {

                this.MatchedFileSha1 = "FETCH";

            } else {


            }
        }
        else if (this.MatchedFileSha1 != null && ec.Excludes("matchedFileSha1",true))
        {
            this.MatchedFileSha1 = null;
        }
        //      C# -> System.String? MatchedFileSha256
        // GraphQL -> matchedFileSha256: String! (scalar)
        if (ec.Includes("matchedFileSha256",true))
        {
            if(this.MatchedFileSha256 == null) {

                this.MatchedFileSha256 = "FETCH";

            } else {


            }
        }
        else if (this.MatchedFileSha256 != null && ec.Excludes("matchedFileSha256",true))
        {
            this.MatchedFileSha256 = null;
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
        //      C# -> System.Int64? TotalSnapshotsMatched
        // GraphQL -> totalSnapshotsMatched: Long! (scalar)
        if (ec.Includes("totalSnapshotsMatched",true))
        {
            if(this.TotalSnapshotsMatched == null) {

                this.TotalSnapshotsMatched = new System.Int64();

            } else {


            }
        }
        else if (this.TotalSnapshotsMatched != null && ec.Excludes("totalSnapshotsMatched",true))
        {
            this.TotalSnapshotsMatched = null;
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
        //      C# -> List<ThreatHuntIocDetails>? IocDetails
        // GraphQL -> iocDetails: [ThreatHuntIocDetails!]! (type)
        if (ec.Includes("iocDetails",false))
        {
            if(this.IocDetails == null) {

                this.IocDetails = new List<ThreatHuntIocDetails>();
                this.IocDetails.ApplyExploratoryFieldSpec(ec.NewChild("iocDetails"));

            } else {

                this.IocDetails.ApplyExploratoryFieldSpec(ec.NewChild("iocDetails"));

            }
        }
        else if (this.IocDetails != null && ec.Excludes("iocDetails",false))
        {
            this.IocDetails = null;
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
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntingObjectFileMatch());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntingObjectFileMatch> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types