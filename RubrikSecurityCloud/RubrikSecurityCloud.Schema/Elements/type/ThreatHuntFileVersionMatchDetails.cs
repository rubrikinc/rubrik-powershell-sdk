// ThreatHuntFileVersionMatchDetails.cs
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
    #region ThreatHuntFileVersionMatchDetails
    public class ThreatHuntFileVersionMatchDetails: BaseType
    {
        #region members

        //      C# -> DateTime? EarliestMatchedSnapshotTime
        // GraphQL -> earliestMatchedSnapshotTime: DateTime (scalar)
        [JsonProperty("earliestMatchedSnapshotTime")]
        public DateTime? EarliestMatchedSnapshotTime { get; set; }

        //      C# -> DateTime? LatestMatchedSnapshotTime
        // GraphQL -> latestMatchedSnapshotTime: DateTime (scalar)
        [JsonProperty("latestMatchedSnapshotTime")]
        public DateTime? LatestMatchedSnapshotTime { get; set; }

        //      C# -> DateTime? LatestSnapshotWithoutVersionTime
        // GraphQL -> latestSnapshotWithoutVersionTime: DateTime (scalar)
        [JsonProperty("latestSnapshotWithoutVersionTime")]
        public DateTime? LatestSnapshotWithoutVersionTime { get; set; }

        //      C# -> DateTime? Mtime
        // GraphQL -> mtime: DateTime (scalar)
        [JsonProperty("mtime")]
        public DateTime? Mtime { get; set; }

        //      C# -> List<MatchedSnapshot>? MatchedSnapshots
        // GraphQL -> matchedSnapshots: [MatchedSnapshot!]! (type)
        [JsonProperty("matchedSnapshots")]
        public List<MatchedSnapshot>? MatchedSnapshots { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntFileVersionMatchDetails";
    }

    public ThreatHuntFileVersionMatchDetails Set(
        DateTime? EarliestMatchedSnapshotTime = null,
        DateTime? LatestMatchedSnapshotTime = null,
        DateTime? LatestSnapshotWithoutVersionTime = null,
        DateTime? Mtime = null,
        List<MatchedSnapshot>? MatchedSnapshots = null
    ) 
    {
        if ( EarliestMatchedSnapshotTime != null ) {
            this.EarliestMatchedSnapshotTime = EarliestMatchedSnapshotTime;
        }
        if ( LatestMatchedSnapshotTime != null ) {
            this.LatestMatchedSnapshotTime = LatestMatchedSnapshotTime;
        }
        if ( LatestSnapshotWithoutVersionTime != null ) {
            this.LatestSnapshotWithoutVersionTime = LatestSnapshotWithoutVersionTime;
        }
        if ( Mtime != null ) {
            this.Mtime = Mtime;
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
        //      C# -> DateTime? EarliestMatchedSnapshotTime
        // GraphQL -> earliestMatchedSnapshotTime: DateTime (scalar)
        if (this.EarliestMatchedSnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestMatchedSnapshotTime\n" ;
            } else {
                s += ind + "earliestMatchedSnapshotTime\n" ;
            }
        }
        //      C# -> DateTime? LatestMatchedSnapshotTime
        // GraphQL -> latestMatchedSnapshotTime: DateTime (scalar)
        if (this.LatestMatchedSnapshotTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestMatchedSnapshotTime\n" ;
            } else {
                s += ind + "latestMatchedSnapshotTime\n" ;
            }
        }
        //      C# -> DateTime? LatestSnapshotWithoutVersionTime
        // GraphQL -> latestSnapshotWithoutVersionTime: DateTime (scalar)
        if (this.LatestSnapshotWithoutVersionTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestSnapshotWithoutVersionTime\n" ;
            } else {
                s += ind + "latestSnapshotWithoutVersionTime\n" ;
            }
        }
        //      C# -> DateTime? Mtime
        // GraphQL -> mtime: DateTime (scalar)
        if (this.Mtime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mtime\n" ;
            } else {
                s += ind + "mtime\n" ;
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
        //      C# -> DateTime? EarliestMatchedSnapshotTime
        // GraphQL -> earliestMatchedSnapshotTime: DateTime (scalar)
        if (ec.Includes("earliestMatchedSnapshotTime",true))
        {
            if(this.EarliestMatchedSnapshotTime == null) {

                this.EarliestMatchedSnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.EarliestMatchedSnapshotTime != null && ec.Excludes("earliestMatchedSnapshotTime",true))
        {
            this.EarliestMatchedSnapshotTime = null;
        }
        //      C# -> DateTime? LatestMatchedSnapshotTime
        // GraphQL -> latestMatchedSnapshotTime: DateTime (scalar)
        if (ec.Includes("latestMatchedSnapshotTime",true))
        {
            if(this.LatestMatchedSnapshotTime == null) {

                this.LatestMatchedSnapshotTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestMatchedSnapshotTime != null && ec.Excludes("latestMatchedSnapshotTime",true))
        {
            this.LatestMatchedSnapshotTime = null;
        }
        //      C# -> DateTime? LatestSnapshotWithoutVersionTime
        // GraphQL -> latestSnapshotWithoutVersionTime: DateTime (scalar)
        if (ec.Includes("latestSnapshotWithoutVersionTime",true))
        {
            if(this.LatestSnapshotWithoutVersionTime == null) {

                this.LatestSnapshotWithoutVersionTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestSnapshotWithoutVersionTime != null && ec.Excludes("latestSnapshotWithoutVersionTime",true))
        {
            this.LatestSnapshotWithoutVersionTime = null;
        }
        //      C# -> DateTime? Mtime
        // GraphQL -> mtime: DateTime (scalar)
        if (ec.Includes("mtime",true))
        {
            if(this.Mtime == null) {

                this.Mtime = new DateTime();

            } else {


            }
        }
        else if (this.Mtime != null && ec.Excludes("mtime",true))
        {
            this.Mtime = null;
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

    } // class ThreatHuntFileVersionMatchDetails
    
    #endregion

    public static class ListThreatHuntFileVersionMatchDetailsExtensions
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
            this List<ThreatHuntFileVersionMatchDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntFileVersionMatchDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntFileVersionMatchDetails> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntFileVersionMatchDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntFileVersionMatchDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types