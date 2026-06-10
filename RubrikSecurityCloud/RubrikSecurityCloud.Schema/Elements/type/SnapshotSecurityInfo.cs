// SnapshotSecurityInfo.cs
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
    #region SnapshotSecurityInfo
    public class SnapshotSecurityInfo: BaseType
    {
        #region members

        //      C# -> AnomalyConfidenceEnum? AnomalyConfidence
        // GraphQL -> anomalyConfidence: AnomalyConfidenceEnum! (enum)
        [JsonProperty("anomalyConfidence")]
        public AnomalyConfidenceEnum? AnomalyConfidence { get; set; }

        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        [JsonProperty("date")]
        public DateTime? Date { get; set; }

        //      C# -> System.Boolean? HasMalware
        // GraphQL -> hasMalware: Boolean! (scalar)
        [JsonProperty("hasMalware")]
        public System.Boolean? HasMalware { get; set; }

        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        [JsonProperty("isAnomaly")]
        public System.Boolean? IsAnomaly { get; set; }

        //      C# -> System.Boolean? IsQuarantined
        // GraphQL -> isQuarantined: Boolean! (scalar)
        [JsonProperty("isQuarantined")]
        public System.Boolean? IsQuarantined { get; set; }

        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        [JsonProperty("snapshotId")]
        public System.String? SnapshotId { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> List<ThreatHuntSnapshotInfo>? ThreatHuntInfo
        // GraphQL -> threatHuntInfo: [ThreatHuntSnapshotInfo!]! (type)
        [JsonProperty("threatHuntInfo")]
        public List<ThreatHuntSnapshotInfo>? ThreatHuntInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SnapshotSecurityInfo";
    }

    public SnapshotSecurityInfo Set(
        AnomalyConfidenceEnum? AnomalyConfidence = null,
        DateTime? Date = null,
        System.Boolean? HasMalware = null,
        System.Boolean? IsAnomaly = null,
        System.Boolean? IsQuarantined = null,
        System.String? SnapshotId = null,
        System.String? WorkloadId = null,
        List<ThreatHuntSnapshotInfo>? ThreatHuntInfo = null
    ) 
    {
        if ( AnomalyConfidence != null ) {
            this.AnomalyConfidence = AnomalyConfidence;
        }
        if ( Date != null ) {
            this.Date = Date;
        }
        if ( HasMalware != null ) {
            this.HasMalware = HasMalware;
        }
        if ( IsAnomaly != null ) {
            this.IsAnomaly = IsAnomaly;
        }
        if ( IsQuarantined != null ) {
            this.IsQuarantined = IsQuarantined;
        }
        if ( SnapshotId != null ) {
            this.SnapshotId = SnapshotId;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( ThreatHuntInfo != null ) {
            this.ThreatHuntInfo = ThreatHuntInfo;
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
        //      C# -> AnomalyConfidenceEnum? AnomalyConfidence
        // GraphQL -> anomalyConfidence: AnomalyConfidenceEnum! (enum)
        if (this.AnomalyConfidence != null) {
            if (conf.Flat) {
                s += conf.Prefix + "anomalyConfidence\n" ;
            } else {
                s += ind + "anomalyConfidence\n" ;
            }
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (this.Date != null) {
            if (conf.Flat) {
                s += conf.Prefix + "date\n" ;
            } else {
                s += ind + "date\n" ;
            }
        }
        //      C# -> System.Boolean? HasMalware
        // GraphQL -> hasMalware: Boolean! (scalar)
        if (this.HasMalware != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasMalware\n" ;
            } else {
                s += ind + "hasMalware\n" ;
            }
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (this.IsAnomaly != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isAnomaly\n" ;
            } else {
                s += ind + "isAnomaly\n" ;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (this.SnapshotId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotId\n" ;
            } else {
                s += ind + "snapshotId\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        //      C# -> List<ThreatHuntSnapshotInfo>? ThreatHuntInfo
        // GraphQL -> threatHuntInfo: [ThreatHuntSnapshotInfo!]! (type)
        if (this.ThreatHuntInfo != null) {
            var fspec = this.ThreatHuntInfo.AsFieldSpec(conf.Child("threatHuntInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "threatHuntInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> AnomalyConfidenceEnum? AnomalyConfidence
        // GraphQL -> anomalyConfidence: AnomalyConfidenceEnum! (enum)
        if (ec.Includes("anomalyConfidence",true))
        {
            if(this.AnomalyConfidence == null) {

                this.AnomalyConfidence = new AnomalyConfidenceEnum();

            } else {


            }
        }
        else if (this.AnomalyConfidence != null && ec.Excludes("anomalyConfidence",true))
        {
            this.AnomalyConfidence = null;
        }
        //      C# -> DateTime? Date
        // GraphQL -> date: DateTime (scalar)
        if (ec.Includes("date",true))
        {
            if(this.Date == null) {

                this.Date = new DateTime();

            } else {


            }
        }
        else if (this.Date != null && ec.Excludes("date",true))
        {
            this.Date = null;
        }
        //      C# -> System.Boolean? HasMalware
        // GraphQL -> hasMalware: Boolean! (scalar)
        if (ec.Includes("hasMalware",true))
        {
            if(this.HasMalware == null) {

                this.HasMalware = true;

            } else {


            }
        }
        else if (this.HasMalware != null && ec.Excludes("hasMalware",true))
        {
            this.HasMalware = null;
        }
        //      C# -> System.Boolean? IsAnomaly
        // GraphQL -> isAnomaly: Boolean! (scalar)
        if (ec.Includes("isAnomaly",true))
        {
            if(this.IsAnomaly == null) {

                this.IsAnomaly = true;

            } else {


            }
        }
        else if (this.IsAnomaly != null && ec.Excludes("isAnomaly",true))
        {
            this.IsAnomaly = null;
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
        //      C# -> System.String? SnapshotId
        // GraphQL -> snapshotId: UUID! (scalar)
        if (ec.Includes("snapshotId",true))
        {
            if(this.SnapshotId == null) {

                this.SnapshotId = "FETCH";

            } else {


            }
        }
        else if (this.SnapshotId != null && ec.Excludes("snapshotId",true))
        {
            this.SnapshotId = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: UUID! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
        //      C# -> List<ThreatHuntSnapshotInfo>? ThreatHuntInfo
        // GraphQL -> threatHuntInfo: [ThreatHuntSnapshotInfo!]! (type)
        if (ec.Includes("threatHuntInfo",false))
        {
            if(this.ThreatHuntInfo == null) {

                this.ThreatHuntInfo = new List<ThreatHuntSnapshotInfo>();
                this.ThreatHuntInfo.ApplyExploratoryFieldSpec(ec.NewChild("threatHuntInfo"));

            } else {

                this.ThreatHuntInfo.ApplyExploratoryFieldSpec(ec.NewChild("threatHuntInfo"));

            }
        }
        else if (this.ThreatHuntInfo != null && ec.Excludes("threatHuntInfo",false))
        {
            this.ThreatHuntInfo = null;
        }
    }


    #endregion

    } // class SnapshotSecurityInfo
    
    #endregion

    public static class ListSnapshotSecurityInfoExtensions
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
            this List<SnapshotSecurityInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SnapshotSecurityInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SnapshotSecurityInfo> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SnapshotSecurityInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SnapshotSecurityInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types