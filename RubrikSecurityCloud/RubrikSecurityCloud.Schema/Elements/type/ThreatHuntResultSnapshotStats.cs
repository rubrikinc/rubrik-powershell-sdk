// ThreatHuntResultSnapshotStats.cs
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
    #region ThreatHuntResultSnapshotStats
    public class ThreatHuntResultSnapshotStats: BaseType
    {
        #region members

        //      C# -> ThreatHuntStatus? SnapshotScanStatus
        // GraphQL -> snapshotScanStatus: ThreatHuntStatus! (enum)
        [JsonProperty("snapshotScanStatus")]
        public ThreatHuntStatus? SnapshotScanStatus { get; set; }

        //      C# -> MalwareScanInSnapshotStatus? Status
        // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
        [JsonProperty("status")]
        public MalwareScanInSnapshotStatus? Status { get; set; }

        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        [JsonProperty("isExpired")]
        public System.Boolean? IsExpired { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        [JsonProperty("snapshotDate")]
        public DateTime? SnapshotDate { get; set; }

        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        [JsonProperty("snapshotFid")]
        public System.String? SnapshotFid { get; set; }

        //      C# -> System.Int64? TotalMatchedPaths
        // GraphQL -> totalMatchedPaths: Long! (scalar)
        [JsonProperty("totalMatchedPaths")]
        public System.Int64? TotalMatchedPaths { get; set; }

        //      C# -> List<IndicatorOfCompromise>? MatchTypes
        // GraphQL -> matchTypes: [IndicatorOfCompromise!]! (type)
        [JsonProperty("matchTypes")]
        public List<IndicatorOfCompromise>? MatchTypes { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntResultSnapshotStats";
    }

    public ThreatHuntResultSnapshotStats Set(
        ThreatHuntStatus? SnapshotScanStatus = null,
        MalwareScanInSnapshotStatus? Status = null,
        System.Boolean? IsExpired = null,
        System.Boolean? IsQuarantined = null,
        DateTime? SnapshotDate = null,
        System.String? SnapshotFid = null,
        System.Int64? TotalMatchedPaths = null,
        List<IndicatorOfCompromise>? MatchTypes = null
    ) 
    {
        if ( SnapshotScanStatus != null ) {
            this.SnapshotScanStatus = SnapshotScanStatus;
        }
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( IsExpired != null ) {
            this.IsExpired = IsExpired;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
        }
        if ( SnapshotDate != null ) {
            this.SnapshotDate = SnapshotDate;
        }
        if ( SnapshotFid != null ) {
            this.SnapshotFid = SnapshotFid;
        }
        if ( TotalMatchedPaths != null ) {
            this.TotalMatchedPaths = TotalMatchedPaths;
        }
        if ( MatchTypes != null ) {
            this.MatchTypes = MatchTypes;
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
        //      C# -> ThreatHuntStatus? SnapshotScanStatus
        // GraphQL -> snapshotScanStatus: ThreatHuntStatus! (enum)
        if (this.SnapshotScanStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotScanStatus\n" ;
            } else {
                s += ind + "snapshotScanStatus\n" ;
            }
        }
        //      C# -> MalwareScanInSnapshotStatus? Status
        // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (this.IsExpired != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isExpired\n" ;
            } else {
                s += ind + "isExpired\n" ;
            }
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (this.IsQuarantined != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isQuarantined\n" ;
            } else {
                s += ind + "isQuarantined\n" ;
            }
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (this.SnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotDate\n" ;
            } else {
                s += ind + "snapshotDate\n" ;
            }
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (this.SnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotFid\n" ;
            } else {
                s += ind + "snapshotFid\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ThreatHuntStatus? SnapshotScanStatus
        // GraphQL -> snapshotScanStatus: ThreatHuntStatus! (enum)
        if (ec.Includes("snapshotScanStatus",true))
        {
            if(this.SnapshotScanStatus == null) {

                this.SnapshotScanStatus = new ThreatHuntStatus();

            } else {


            }
        }
        else if (this.SnapshotScanStatus != null && ec.Excludes("snapshotScanStatus",true))
        {
            this.SnapshotScanStatus = null;
        }
        //      C# -> MalwareScanInSnapshotStatus? Status
        // GraphQL -> status: MalwareScanInSnapshotStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new MalwareScanInSnapshotStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> System.Boolean? IsExpired
        // GraphQL -> isExpired: Boolean! (scalar)
        if (ec.Includes("isExpired",true))
        {
            if(this.IsExpired == null) {

                this.IsExpired = true;

            } else {


            }
        }
        else if (this.IsExpired != null && ec.Excludes("isExpired",true))
        {
            this.IsExpired = null;
        }
        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        if (ec.Includes("isQuarantined",true))
        {
            if(this.IsQuarantined == null) {

                this.IsQuarantined = true;

            } else {


            }
        }
        else if (this.IsQuarantined != null && ec.Excludes("isQuarantined",true))
        {
            this.IsQuarantined = null;
        }
        //      C# -> DateTime? SnapshotDate
        // GraphQL -> snapshotDate: DateTime (scalar)
        if (ec.Includes("snapshotDate",true))
        {
            if(this.SnapshotDate == null) {

                this.SnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.SnapshotDate != null && ec.Excludes("snapshotDate",true))
        {
            this.SnapshotDate = null;
        }
        //      C# -> System.String? SnapshotFid
        // GraphQL -> snapshotFid: String! (scalar)
        if (ec.Includes("snapshotFid",true))
        {
            if(this.SnapshotFid == null) {

                this.SnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotFid != null && ec.Excludes("snapshotFid",true))
        {
            this.SnapshotFid = null;
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
    }


    #endregion

    } // class ThreatHuntResultSnapshotStats
    
    #endregion

    public static class ListThreatHuntResultSnapshotStatsExtensions
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
            this List<ThreatHuntResultSnapshotStats> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntResultSnapshotStats> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntResultSnapshotStats> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntResultSnapshotStats());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntResultSnapshotStats> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types