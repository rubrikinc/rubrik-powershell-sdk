// ThreatMonitoringInfoForObject.cs
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
    #region ThreatMonitoringInfoForObject
    public class ThreatMonitoringInfoForObject: BaseType
    {
        #region members

        //      C# -> DateTime? AnalyzedSnapshotDate
        // GraphQL -> analyzedSnapshotDate: DateTime (scalar)
        [JsonProperty("analyzedSnapshotDate")]
        public DateTime? AnalyzedSnapshotDate { get; set; }

        //      C# -> System.String? AnalyzedSnapshotFid
        // GraphQL -> analyzedSnapshotFid: UUID! (scalar)
        [JsonProperty("analyzedSnapshotFid")]
        public System.String? AnalyzedSnapshotFid { get; set; }

        //      C# -> DateTime? AnalyzedSnapshotScanTime
        // GraphQL -> analyzedSnapshotScanTime: DateTime (scalar)
        [JsonProperty("analyzedSnapshotScanTime")]
        public DateTime? AnalyzedSnapshotScanTime { get; set; }

        //      C# -> System.Boolean? IsObjectMalicious
        // GraphQL -> isObjectMalicious: Boolean! (scalar)
        [JsonProperty("isObjectMalicious")]
        public System.Boolean? IsObjectMalicious { get; set; }

        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        [JsonProperty("objectFid")]
        public System.String? ObjectFid { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatMonitoringInfoForObject";
    }

    public ThreatMonitoringInfoForObject Set(
        DateTime? AnalyzedSnapshotDate = null,
        System.String? AnalyzedSnapshotFid = null,
        DateTime? AnalyzedSnapshotScanTime = null,
        System.Boolean? IsObjectMalicious = null,
        System.String? ObjectFid = null
    ) 
    {
        if ( AnalyzedSnapshotDate != null ) {
            this.AnalyzedSnapshotDate = AnalyzedSnapshotDate;
        }
        if ( AnalyzedSnapshotFid != null ) {
            this.AnalyzedSnapshotFid = AnalyzedSnapshotFid;
        }
        if ( AnalyzedSnapshotScanTime != null ) {
            this.AnalyzedSnapshotScanTime = AnalyzedSnapshotScanTime;
        }
        if ( IsObjectMalicious != null ) {
            this.IsObjectMalicious = IsObjectMalicious;
        }
        if ( ObjectFid != null ) {
            this.ObjectFid = ObjectFid;
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
        //      C# -> DateTime? AnalyzedSnapshotDate
        // GraphQL -> analyzedSnapshotDate: DateTime (scalar)
        if (this.AnalyzedSnapshotDate != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzedSnapshotDate\n" ;
            } else {
                s += ind + "analyzedSnapshotDate\n" ;
            }
        }
        //      C# -> System.String? AnalyzedSnapshotFid
        // GraphQL -> analyzedSnapshotFid: UUID! (scalar)
        if (this.AnalyzedSnapshotFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzedSnapshotFid\n" ;
            } else {
                s += ind + "analyzedSnapshotFid\n" ;
            }
        }
        //      C# -> DateTime? AnalyzedSnapshotScanTime
        // GraphQL -> analyzedSnapshotScanTime: DateTime (scalar)
        if (this.AnalyzedSnapshotScanTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "analyzedSnapshotScanTime\n" ;
            } else {
                s += ind + "analyzedSnapshotScanTime\n" ;
            }
        }
        //      C# -> System.Boolean? IsObjectMalicious
        // GraphQL -> isObjectMalicious: Boolean! (scalar)
        if (this.IsObjectMalicious != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isObjectMalicious\n" ;
            } else {
                s += ind + "isObjectMalicious\n" ;
            }
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (this.ObjectFid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectFid\n" ;
            } else {
                s += ind + "objectFid\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? AnalyzedSnapshotDate
        // GraphQL -> analyzedSnapshotDate: DateTime (scalar)
        if (ec.Includes("analyzedSnapshotDate",true))
        {
            if(this.AnalyzedSnapshotDate == null) {

                this.AnalyzedSnapshotDate = new DateTime();

            } else {


            }
        }
        else if (this.AnalyzedSnapshotDate != null && ec.Excludes("analyzedSnapshotDate",true))
        {
            this.AnalyzedSnapshotDate = null;
        }
        //      C# -> System.String? AnalyzedSnapshotFid
        // GraphQL -> analyzedSnapshotFid: UUID! (scalar)
        if (ec.Includes("analyzedSnapshotFid",true))
        {
            if(this.AnalyzedSnapshotFid == null) {

                this.AnalyzedSnapshotFid = "FETCH";

            } else {


            }
        }
        else if (this.AnalyzedSnapshotFid != null && ec.Excludes("analyzedSnapshotFid",true))
        {
            this.AnalyzedSnapshotFid = null;
        }
        //      C# -> DateTime? AnalyzedSnapshotScanTime
        // GraphQL -> analyzedSnapshotScanTime: DateTime (scalar)
        if (ec.Includes("analyzedSnapshotScanTime",true))
        {
            if(this.AnalyzedSnapshotScanTime == null) {

                this.AnalyzedSnapshotScanTime = new DateTime();

            } else {


            }
        }
        else if (this.AnalyzedSnapshotScanTime != null && ec.Excludes("analyzedSnapshotScanTime",true))
        {
            this.AnalyzedSnapshotScanTime = null;
        }
        //      C# -> System.Boolean? IsObjectMalicious
        // GraphQL -> isObjectMalicious: Boolean! (scalar)
        if (ec.Includes("isObjectMalicious",true))
        {
            if(this.IsObjectMalicious == null) {

                this.IsObjectMalicious = true;

            } else {


            }
        }
        else if (this.IsObjectMalicious != null && ec.Excludes("isObjectMalicious",true))
        {
            this.IsObjectMalicious = null;
        }
        //      C# -> System.String? ObjectFid
        // GraphQL -> objectFid: UUID! (scalar)
        if (ec.Includes("objectFid",true))
        {
            if(this.ObjectFid == null) {

                this.ObjectFid = "FETCH";

            } else {


            }
        }
        else if (this.ObjectFid != null && ec.Excludes("objectFid",true))
        {
            this.ObjectFid = null;
        }
    }


    #endregion

    } // class ThreatMonitoringInfoForObject
    
    #endregion

    public static class ListThreatMonitoringInfoForObjectExtensions
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
            this List<ThreatMonitoringInfoForObject> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatMonitoringInfoForObject> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatMonitoringInfoForObject> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatMonitoringInfoForObject());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatMonitoringInfoForObject> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types