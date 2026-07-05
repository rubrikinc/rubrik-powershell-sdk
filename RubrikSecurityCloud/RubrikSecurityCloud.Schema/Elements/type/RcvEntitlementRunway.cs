// RcvEntitlementRunway.cs
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
    #region RcvEntitlementRunway
    public class RcvEntitlementRunway: BaseType
    {
        #region members

        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        [JsonProperty("redundancy")]
        public RcvRedundancy? Redundancy { get; set; }

        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        [JsonProperty("tier")]
        public RcvTier? Tier { get; set; }

        //      C# -> System.Single? CurrentBytes
        // GraphQL -> currentBytes: Float! (scalar)
        [JsonProperty("currentBytes")]
        public System.Single? CurrentBytes { get; set; }

        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        [JsonProperty("lastRefreshedAt")]
        public DateTime? LastRefreshedAt { get; set; }

        //      C# -> System.Single? RunwayDays
        // GraphQL -> runwayDays: Float! (scalar)
        [JsonProperty("runwayDays")]
        public System.Single? RunwayDays { get; set; }

        //      C# -> System.Single? WeeklyGrowthPct
        // GraphQL -> weeklyGrowthPct: Float! (scalar)
        [JsonProperty("weeklyGrowthPct")]
        public System.Single? WeeklyGrowthPct { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "RcvEntitlementRunway";
    }

    public RcvEntitlementRunway Set(
        RcvRedundancy? Redundancy = null,
        RcvTier? Tier = null,
        System.Single? CurrentBytes = null,
        DateTime? LastRefreshedAt = null,
        System.Single? RunwayDays = null,
        System.Single? WeeklyGrowthPct = null
    ) 
    {
        if ( Redundancy != null ) {
            this.Redundancy = Redundancy;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
        }
        if ( CurrentBytes != null ) {
            this.CurrentBytes = CurrentBytes;
        }
        if ( LastRefreshedAt != null ) {
            this.LastRefreshedAt = LastRefreshedAt;
        }
        if ( RunwayDays != null ) {
            this.RunwayDays = RunwayDays;
        }
        if ( WeeklyGrowthPct != null ) {
            this.WeeklyGrowthPct = WeeklyGrowthPct;
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
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (this.Redundancy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "redundancy\n" ;
            } else {
                s += ind + "redundancy\n" ;
            }
        }
        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        if (this.Tier != null) {
            if (conf.Flat) {
                s += conf.Prefix + "tier\n" ;
            } else {
                s += ind + "tier\n" ;
            }
        }
        //      C# -> System.Single? CurrentBytes
        // GraphQL -> currentBytes: Float! (scalar)
        if (this.CurrentBytes != null) {
            if (conf.Flat) {
                s += conf.Prefix + "currentBytes\n" ;
            } else {
                s += ind + "currentBytes\n" ;
            }
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (this.LastRefreshedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastRefreshedAt\n" ;
            } else {
                s += ind + "lastRefreshedAt\n" ;
            }
        }
        //      C# -> System.Single? RunwayDays
        // GraphQL -> runwayDays: Float! (scalar)
        if (this.RunwayDays != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runwayDays\n" ;
            } else {
                s += ind + "runwayDays\n" ;
            }
        }
        //      C# -> System.Single? WeeklyGrowthPct
        // GraphQL -> weeklyGrowthPct: Float! (scalar)
        if (this.WeeklyGrowthPct != null) {
            if (conf.Flat) {
                s += conf.Prefix + "weeklyGrowthPct\n" ;
            } else {
                s += ind + "weeklyGrowthPct\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> RcvRedundancy? Redundancy
        // GraphQL -> redundancy: RcvRedundancy! (enum)
        if (ec.Includes("redundancy",true))
        {
            if(this.Redundancy == null) {

                this.Redundancy = new RcvRedundancy();

            } else {


            }
        }
        else if (this.Redundancy != null && ec.Excludes("redundancy",true))
        {
            this.Redundancy = null;
        }
        //      C# -> RcvTier? Tier
        // GraphQL -> tier: RcvTier! (enum)
        if (ec.Includes("tier",true))
        {
            if(this.Tier == null) {

                this.Tier = new RcvTier();

            } else {


            }
        }
        else if (this.Tier != null && ec.Excludes("tier",true))
        {
            this.Tier = null;
        }
        //      C# -> System.Single? CurrentBytes
        // GraphQL -> currentBytes: Float! (scalar)
        if (ec.Includes("currentBytes",true))
        {
            if(this.CurrentBytes == null) {

                this.CurrentBytes = new System.Single();

            } else {


            }
        }
        else if (this.CurrentBytes != null && ec.Excludes("currentBytes",true))
        {
            this.CurrentBytes = null;
        }
        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        if (ec.Includes("lastRefreshedAt",true))
        {
            if(this.LastRefreshedAt == null) {

                this.LastRefreshedAt = new DateTime();

            } else {


            }
        }
        else if (this.LastRefreshedAt != null && ec.Excludes("lastRefreshedAt",true))
        {
            this.LastRefreshedAt = null;
        }
        //      C# -> System.Single? RunwayDays
        // GraphQL -> runwayDays: Float! (scalar)
        if (ec.Includes("runwayDays",true))
        {
            if(this.RunwayDays == null) {

                this.RunwayDays = new System.Single();

            } else {


            }
        }
        else if (this.RunwayDays != null && ec.Excludes("runwayDays",true))
        {
            this.RunwayDays = null;
        }
        //      C# -> System.Single? WeeklyGrowthPct
        // GraphQL -> weeklyGrowthPct: Float! (scalar)
        if (ec.Includes("weeklyGrowthPct",true))
        {
            if(this.WeeklyGrowthPct == null) {

                this.WeeklyGrowthPct = new System.Single();

            } else {


            }
        }
        else if (this.WeeklyGrowthPct != null && ec.Excludes("weeklyGrowthPct",true))
        {
            this.WeeklyGrowthPct = null;
        }
    }


    #endregion

    } // class RcvEntitlementRunway
    
    #endregion

    public static class ListRcvEntitlementRunwayExtensions
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
            this List<RcvEntitlementRunway> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<RcvEntitlementRunway> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<RcvEntitlementRunway> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new RcvEntitlementRunway());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<RcvEntitlementRunway> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types