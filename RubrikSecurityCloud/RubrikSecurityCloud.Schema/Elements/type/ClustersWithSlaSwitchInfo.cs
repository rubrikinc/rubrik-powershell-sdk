// ClustersWithSlaSwitchInfo.cs
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
    #region ClustersWithSlaSwitchInfo
    public class ClustersWithSlaSwitchInfo: BaseType
    {
        #region members

        //      C# -> List<SlaMigrationIneligibilityReason>? IneligibleSlasReason
        // GraphQL -> ineligibleSlasReason: [SlaMigrationIneligibilityReason!]! (enum)
        [JsonProperty("ineligibleSlasReason")]
        public List<SlaMigrationIneligibilityReason>? IneligibleSlasReason { get; set; }

        //      C# -> System.Int32? PendingSwitchSlaCount
        // GraphQL -> pendingSwitchSlaCount: Int! (scalar)
        [JsonProperty("pendingSwitchSlaCount")]
        public System.Int32? PendingSwitchSlaCount { get; set; }

        //      C# -> System.Int32? SwitchEligibleSlaCount
        // GraphQL -> switchEligibleSlaCount: Int! (scalar)
        [JsonProperty("switchEligibleSlaCount")]
        public System.Int32? SwitchEligibleSlaCount { get; set; }

        //      C# -> System.Int32? TotalSwitchedSlaCount
        // GraphQL -> totalSwitchedSlaCount: Int! (scalar)
        [JsonProperty("totalSwitchedSlaCount")]
        public System.Int32? TotalSwitchedSlaCount { get; set; }

        //      C# -> List<ClusterWithSlaInfo>? Info
        // GraphQL -> info: [ClusterWithSlaInfo!]! (type)
        [JsonProperty("info")]
        public List<ClusterWithSlaInfo>? Info { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ClustersWithSlaSwitchInfo";
    }

    public ClustersWithSlaSwitchInfo Set(
        List<SlaMigrationIneligibilityReason>? IneligibleSlasReason = null,
        System.Int32? PendingSwitchSlaCount = null,
        System.Int32? SwitchEligibleSlaCount = null,
        System.Int32? TotalSwitchedSlaCount = null,
        List<ClusterWithSlaInfo>? Info = null
    ) 
    {
        if ( IneligibleSlasReason != null ) {
            this.IneligibleSlasReason = IneligibleSlasReason;
        }
        if ( PendingSwitchSlaCount != null ) {
            this.PendingSwitchSlaCount = PendingSwitchSlaCount;
        }
        if ( SwitchEligibleSlaCount != null ) {
            this.SwitchEligibleSlaCount = SwitchEligibleSlaCount;
        }
        if ( TotalSwitchedSlaCount != null ) {
            this.TotalSwitchedSlaCount = TotalSwitchedSlaCount;
        }
        if ( Info != null ) {
            this.Info = Info;
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
        //      C# -> List<SlaMigrationIneligibilityReason>? IneligibleSlasReason
        // GraphQL -> ineligibleSlasReason: [SlaMigrationIneligibilityReason!]! (enum)
        if (this.IneligibleSlasReason != null) {
            if (conf.Flat) {
                s += conf.Prefix + "ineligibleSlasReason\n" ;
            } else {
                s += ind + "ineligibleSlasReason\n" ;
            }
        }
        //      C# -> System.Int32? PendingSwitchSlaCount
        // GraphQL -> pendingSwitchSlaCount: Int! (scalar)
        if (this.PendingSwitchSlaCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "pendingSwitchSlaCount\n" ;
            } else {
                s += ind + "pendingSwitchSlaCount\n" ;
            }
        }
        //      C# -> System.Int32? SwitchEligibleSlaCount
        // GraphQL -> switchEligibleSlaCount: Int! (scalar)
        if (this.SwitchEligibleSlaCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "switchEligibleSlaCount\n" ;
            } else {
                s += ind + "switchEligibleSlaCount\n" ;
            }
        }
        //      C# -> System.Int32? TotalSwitchedSlaCount
        // GraphQL -> totalSwitchedSlaCount: Int! (scalar)
        if (this.TotalSwitchedSlaCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalSwitchedSlaCount\n" ;
            } else {
                s += ind + "totalSwitchedSlaCount\n" ;
            }
        }
        //      C# -> List<ClusterWithSlaInfo>? Info
        // GraphQL -> info: [ClusterWithSlaInfo!]! (type)
        if (this.Info != null) {
            var fspec = this.Info.AsFieldSpec(conf.Child("info"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "info" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<SlaMigrationIneligibilityReason>? IneligibleSlasReason
        // GraphQL -> ineligibleSlasReason: [SlaMigrationIneligibilityReason!]! (enum)
        if (ec.Includes("ineligibleSlasReason",true))
        {
            if(this.IneligibleSlasReason == null) {

                this.IneligibleSlasReason = new List<SlaMigrationIneligibilityReason>();

            } else {


            }
        }
        else if (this.IneligibleSlasReason != null && ec.Excludes("ineligibleSlasReason",true))
        {
            this.IneligibleSlasReason = null;
        }
        //      C# -> System.Int32? PendingSwitchSlaCount
        // GraphQL -> pendingSwitchSlaCount: Int! (scalar)
        if (ec.Includes("pendingSwitchSlaCount",true))
        {
            if(this.PendingSwitchSlaCount == null) {

                this.PendingSwitchSlaCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.PendingSwitchSlaCount != null && ec.Excludes("pendingSwitchSlaCount",true))
        {
            this.PendingSwitchSlaCount = null;
        }
        //      C# -> System.Int32? SwitchEligibleSlaCount
        // GraphQL -> switchEligibleSlaCount: Int! (scalar)
        if (ec.Includes("switchEligibleSlaCount",true))
        {
            if(this.SwitchEligibleSlaCount == null) {

                this.SwitchEligibleSlaCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.SwitchEligibleSlaCount != null && ec.Excludes("switchEligibleSlaCount",true))
        {
            this.SwitchEligibleSlaCount = null;
        }
        //      C# -> System.Int32? TotalSwitchedSlaCount
        // GraphQL -> totalSwitchedSlaCount: Int! (scalar)
        if (ec.Includes("totalSwitchedSlaCount",true))
        {
            if(this.TotalSwitchedSlaCount == null) {

                this.TotalSwitchedSlaCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalSwitchedSlaCount != null && ec.Excludes("totalSwitchedSlaCount",true))
        {
            this.TotalSwitchedSlaCount = null;
        }
        //      C# -> List<ClusterWithSlaInfo>? Info
        // GraphQL -> info: [ClusterWithSlaInfo!]! (type)
        if (ec.Includes("info",false))
        {
            if(this.Info == null) {

                this.Info = new List<ClusterWithSlaInfo>();
                this.Info.ApplyExploratoryFieldSpec(ec.NewChild("info"));

            } else {

                this.Info.ApplyExploratoryFieldSpec(ec.NewChild("info"));

            }
        }
        else if (this.Info != null && ec.Excludes("info",false))
        {
            this.Info = null;
        }
    }


    #endregion

    } // class ClustersWithSlaSwitchInfo
    
    #endregion

    public static class ListClustersWithSlaSwitchInfoExtensions
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
            this List<ClustersWithSlaSwitchInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ClustersWithSlaSwitchInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ClustersWithSlaSwitchInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ClustersWithSlaSwitchInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ClustersWithSlaSwitchInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types