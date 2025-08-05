// ThreatHuntDetailsV2.cs
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
    #region ThreatHuntDetailsV2
    public class ThreatHuntDetailsV2: BaseType
    {
        #region members

        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        [JsonProperty("status")]
        public ThreatHuntStatus? Status { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> System.Boolean? HasFileVersionInfo
        // GraphQL -> hasFileVersionInfo: Boolean! (scalar)
        [JsonProperty("hasFileVersionInfo")]
        public System.Boolean? HasFileVersionInfo { get; set; }

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> System.Int64? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Long! (scalar)
        [JsonProperty("totalMatchedSnapshots")]
        public System.Int64? TotalMatchedSnapshots { get; set; }

        //      C# -> System.Int64? TotalObjectFids
        // GraphQL -> totalObjectFids: Long! (scalar)
        [JsonProperty("totalObjectFids")]
        public System.Int64? TotalObjectFids { get; set; }

        //      C# -> System.Int64? TotalScannedSnapshots
        // GraphQL -> totalScannedSnapshots: Long! (scalar)
        [JsonProperty("totalScannedSnapshots")]
        public System.Int64? TotalScannedSnapshots { get; set; }

        //      C# -> System.Int64? TotalUniqueFileMatches
        // GraphQL -> totalUniqueFileMatches: Long! (scalar)
        [JsonProperty("totalUniqueFileMatches")]
        public System.Int64? TotalUniqueFileMatches { get; set; }

        //      C# -> ThreatHuntBaseConfig? BaseConfig
        // GraphQL -> baseConfig: ThreatHuntBaseConfig! (type)
        [JsonProperty("baseConfig")]
        public ThreatHuntBaseConfig? BaseConfig { get; set; }

        //      C# -> List<Cluster>? Clusters
        // GraphQL -> clusters: [Cluster!]! (type)
        [JsonProperty("clusters")]
        public List<Cluster>? Clusters { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ThreatHuntDetailsV2";
    }

    public ThreatHuntDetailsV2 Set(
        ThreatHuntStatus? Status = null,
        DateTime? EndTime = null,
        System.Boolean? HasFileVersionInfo = null,
        DateTime? StartTime = null,
        System.Int64? TotalMatchedSnapshots = null,
        System.Int64? TotalObjectFids = null,
        System.Int64? TotalScannedSnapshots = null,
        System.Int64? TotalUniqueFileMatches = null,
        ThreatHuntBaseConfig? BaseConfig = null,
        List<Cluster>? Clusters = null
    ) 
    {
        if ( Status != null ) {
            this.Status = Status;
        }
        if ( EndTime != null ) {
            this.EndTime = EndTime;
        }
        if ( HasFileVersionInfo != null ) {
            this.HasFileVersionInfo = HasFileVersionInfo;
        }
        if ( StartTime != null ) {
            this.StartTime = StartTime;
        }
        if ( TotalMatchedSnapshots != null ) {
            this.TotalMatchedSnapshots = TotalMatchedSnapshots;
        }
        if ( TotalObjectFids != null ) {
            this.TotalObjectFids = TotalObjectFids;
        }
        if ( TotalScannedSnapshots != null ) {
            this.TotalScannedSnapshots = TotalScannedSnapshots;
        }
        if ( TotalUniqueFileMatches != null ) {
            this.TotalUniqueFileMatches = TotalUniqueFileMatches;
        }
        if ( BaseConfig != null ) {
            this.BaseConfig = BaseConfig;
        }
        if ( Clusters != null ) {
            this.Clusters = Clusters;
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
        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        if (this.Status != null) {
            if (conf.Flat) {
                s += conf.Prefix + "status\n" ;
            } else {
                s += ind + "status\n" ;
            }
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (this.EndTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "endTime\n" ;
            } else {
                s += ind + "endTime\n" ;
            }
        }
        //      C# -> System.Boolean? HasFileVersionInfo
        // GraphQL -> hasFileVersionInfo: Boolean! (scalar)
        if (this.HasFileVersionInfo != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasFileVersionInfo\n" ;
            } else {
                s += ind + "hasFileVersionInfo\n" ;
            }
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (this.StartTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "startTime\n" ;
            } else {
                s += ind + "startTime\n" ;
            }
        }
        //      C# -> System.Int64? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Long! (scalar)
        if (this.TotalMatchedSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalMatchedSnapshots\n" ;
            } else {
                s += ind + "totalMatchedSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? TotalObjectFids
        // GraphQL -> totalObjectFids: Long! (scalar)
        if (this.TotalObjectFids != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalObjectFids\n" ;
            } else {
                s += ind + "totalObjectFids\n" ;
            }
        }
        //      C# -> System.Int64? TotalScannedSnapshots
        // GraphQL -> totalScannedSnapshots: Long! (scalar)
        if (this.TotalScannedSnapshots != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalScannedSnapshots\n" ;
            } else {
                s += ind + "totalScannedSnapshots\n" ;
            }
        }
        //      C# -> System.Int64? TotalUniqueFileMatches
        // GraphQL -> totalUniqueFileMatches: Long! (scalar)
        if (this.TotalUniqueFileMatches != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalUniqueFileMatches\n" ;
            } else {
                s += ind + "totalUniqueFileMatches\n" ;
            }
        }
        //      C# -> ThreatHuntBaseConfig? BaseConfig
        // GraphQL -> baseConfig: ThreatHuntBaseConfig! (type)
        if (this.BaseConfig != null) {
            var fspec = this.BaseConfig.AsFieldSpec(conf.Child("baseConfig"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "baseConfig" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<Cluster>? Clusters
        // GraphQL -> clusters: [Cluster!]! (type)
        if (this.Clusters != null) {
            var fspec = this.Clusters.AsFieldSpec(conf.Child("clusters"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "clusters" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ThreatHuntStatus? Status
        // GraphQL -> status: ThreatHuntStatus! (enum)
        if (ec.Includes("status",true))
        {
            if(this.Status == null) {

                this.Status = new ThreatHuntStatus();

            } else {


            }
        }
        else if (this.Status != null && ec.Excludes("status",true))
        {
            this.Status = null;
        }
        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        if (ec.Includes("endTime",true))
        {
            if(this.EndTime == null) {

                this.EndTime = new DateTime();

            } else {


            }
        }
        else if (this.EndTime != null && ec.Excludes("endTime",true))
        {
            this.EndTime = null;
        }
        //      C# -> System.Boolean? HasFileVersionInfo
        // GraphQL -> hasFileVersionInfo: Boolean! (scalar)
        if (ec.Includes("hasFileVersionInfo",true))
        {
            if(this.HasFileVersionInfo == null) {

                this.HasFileVersionInfo = true;

            } else {


            }
        }
        else if (this.HasFileVersionInfo != null && ec.Excludes("hasFileVersionInfo",true))
        {
            this.HasFileVersionInfo = null;
        }
        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        if (ec.Includes("startTime",true))
        {
            if(this.StartTime == null) {

                this.StartTime = new DateTime();

            } else {


            }
        }
        else if (this.StartTime != null && ec.Excludes("startTime",true))
        {
            this.StartTime = null;
        }
        //      C# -> System.Int64? TotalMatchedSnapshots
        // GraphQL -> totalMatchedSnapshots: Long! (scalar)
        if (ec.Includes("totalMatchedSnapshots",true))
        {
            if(this.TotalMatchedSnapshots == null) {

                this.TotalMatchedSnapshots = new System.Int64();

            } else {


            }
        }
        else if (this.TotalMatchedSnapshots != null && ec.Excludes("totalMatchedSnapshots",true))
        {
            this.TotalMatchedSnapshots = null;
        }
        //      C# -> System.Int64? TotalObjectFids
        // GraphQL -> totalObjectFids: Long! (scalar)
        if (ec.Includes("totalObjectFids",true))
        {
            if(this.TotalObjectFids == null) {

                this.TotalObjectFids = new System.Int64();

            } else {


            }
        }
        else if (this.TotalObjectFids != null && ec.Excludes("totalObjectFids",true))
        {
            this.TotalObjectFids = null;
        }
        //      C# -> System.Int64? TotalScannedSnapshots
        // GraphQL -> totalScannedSnapshots: Long! (scalar)
        if (ec.Includes("totalScannedSnapshots",true))
        {
            if(this.TotalScannedSnapshots == null) {

                this.TotalScannedSnapshots = new System.Int64();

            } else {


            }
        }
        else if (this.TotalScannedSnapshots != null && ec.Excludes("totalScannedSnapshots",true))
        {
            this.TotalScannedSnapshots = null;
        }
        //      C# -> System.Int64? TotalUniqueFileMatches
        // GraphQL -> totalUniqueFileMatches: Long! (scalar)
        if (ec.Includes("totalUniqueFileMatches",true))
        {
            if(this.TotalUniqueFileMatches == null) {

                this.TotalUniqueFileMatches = new System.Int64();

            } else {


            }
        }
        else if (this.TotalUniqueFileMatches != null && ec.Excludes("totalUniqueFileMatches",true))
        {
            this.TotalUniqueFileMatches = null;
        }
        //      C# -> ThreatHuntBaseConfig? BaseConfig
        // GraphQL -> baseConfig: ThreatHuntBaseConfig! (type)
        if (ec.Includes("baseConfig",false))
        {
            if(this.BaseConfig == null) {

                this.BaseConfig = new ThreatHuntBaseConfig();
                this.BaseConfig.ApplyExploratoryFieldSpec(ec.NewChild("baseConfig"));

            } else {

                this.BaseConfig.ApplyExploratoryFieldSpec(ec.NewChild("baseConfig"));

            }
        }
        else if (this.BaseConfig != null && ec.Excludes("baseConfig",false))
        {
            this.BaseConfig = null;
        }
        //      C# -> List<Cluster>? Clusters
        // GraphQL -> clusters: [Cluster!]! (type)
        if (ec.Includes("clusters",false))
        {
            if(this.Clusters == null) {

                this.Clusters = new List<Cluster>();
                this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));

            } else {

                this.Clusters.ApplyExploratoryFieldSpec(ec.NewChild("clusters"));

            }
        }
        else if (this.Clusters != null && ec.Excludes("clusters",false))
        {
            this.Clusters = null;
        }
    }


    #endregion

    } // class ThreatHuntDetailsV2
    
    #endregion

    public static class ListThreatHuntDetailsV2Extensions
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
            this List<ThreatHuntDetailsV2> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ThreatHuntDetailsV2> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ThreatHuntDetailsV2> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ThreatHuntDetailsV2());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ThreatHuntDetailsV2> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types