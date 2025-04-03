// NcdSlaConfig.cs
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
    #region NcdSlaConfig
    public class NcdSlaConfig: BaseType
    {
        #region members

        //      C# -> List<System.String>? DailyBackupLocations
        // GraphQL -> dailyBackupLocations: [UUID!] (scalar)
        [JsonProperty("dailyBackupLocations")]
        public List<System.String>? DailyBackupLocations { get; set; }

        //      C# -> List<System.String>? HourlyBackupLocations
        // GraphQL -> hourlyBackupLocations: [UUID!] (scalar)
        [JsonProperty("hourlyBackupLocations")]
        public List<System.String>? HourlyBackupLocations { get; set; }

        //      C# -> List<System.String>? MinutelyBackupLocations
        // GraphQL -> minutelyBackupLocations: [UUID!] (scalar)
        [JsonProperty("minutelyBackupLocations")]
        public List<System.String>? MinutelyBackupLocations { get; set; }

        //      C# -> List<System.String>? MonthlyBackupLocations
        // GraphQL -> monthlyBackupLocations: [UUID!] (scalar)
        [JsonProperty("monthlyBackupLocations")]
        public List<System.String>? MonthlyBackupLocations { get; set; }

        //      C# -> List<System.String>? QuarterlyBackupLocations
        // GraphQL -> quarterlyBackupLocations: [UUID!] (scalar)
        [JsonProperty("quarterlyBackupLocations")]
        public List<System.String>? QuarterlyBackupLocations { get; set; }

        //      C# -> List<System.String>? WeeklyBackupLocations
        // GraphQL -> weeklyBackupLocations: [UUID!] (scalar)
        [JsonProperty("weeklyBackupLocations")]
        public List<System.String>? WeeklyBackupLocations { get; set; }

        //      C# -> List<System.String>? YearlyBackupLocations
        // GraphQL -> yearlyBackupLocations: [UUID!] (scalar)
        [JsonProperty("yearlyBackupLocations")]
        public List<System.String>? YearlyBackupLocations { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NcdSlaConfig";
    }

    public NcdSlaConfig Set(
        List<System.String>? DailyBackupLocations = null,
        List<System.String>? HourlyBackupLocations = null,
        List<System.String>? MinutelyBackupLocations = null,
        List<System.String>? MonthlyBackupLocations = null,
        List<System.String>? QuarterlyBackupLocations = null,
        List<System.String>? WeeklyBackupLocations = null,
        List<System.String>? YearlyBackupLocations = null
    ) 
    {
        if ( DailyBackupLocations != null ) {
            this.DailyBackupLocations = DailyBackupLocations;
        }
        if ( HourlyBackupLocations != null ) {
            this.HourlyBackupLocations = HourlyBackupLocations;
        }
        if ( MinutelyBackupLocations != null ) {
            this.MinutelyBackupLocations = MinutelyBackupLocations;
        }
        if ( MonthlyBackupLocations != null ) {
            this.MonthlyBackupLocations = MonthlyBackupLocations;
        }
        if ( QuarterlyBackupLocations != null ) {
            this.QuarterlyBackupLocations = QuarterlyBackupLocations;
        }
        if ( WeeklyBackupLocations != null ) {
            this.WeeklyBackupLocations = WeeklyBackupLocations;
        }
        if ( YearlyBackupLocations != null ) {
            this.YearlyBackupLocations = YearlyBackupLocations;
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
        //      C# -> List<System.String>? DailyBackupLocations
        // GraphQL -> dailyBackupLocations: [UUID!] (scalar)
        if (this.DailyBackupLocations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "dailyBackupLocations\n" ;
            } else {
                s += ind + "dailyBackupLocations\n" ;
            }
        }
        //      C# -> List<System.String>? HourlyBackupLocations
        // GraphQL -> hourlyBackupLocations: [UUID!] (scalar)
        if (this.HourlyBackupLocations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hourlyBackupLocations\n" ;
            } else {
                s += ind + "hourlyBackupLocations\n" ;
            }
        }
        //      C# -> List<System.String>? MinutelyBackupLocations
        // GraphQL -> minutelyBackupLocations: [UUID!] (scalar)
        if (this.MinutelyBackupLocations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "minutelyBackupLocations\n" ;
            } else {
                s += ind + "minutelyBackupLocations\n" ;
            }
        }
        //      C# -> List<System.String>? MonthlyBackupLocations
        // GraphQL -> monthlyBackupLocations: [UUID!] (scalar)
        if (this.MonthlyBackupLocations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "monthlyBackupLocations\n" ;
            } else {
                s += ind + "monthlyBackupLocations\n" ;
            }
        }
        //      C# -> List<System.String>? QuarterlyBackupLocations
        // GraphQL -> quarterlyBackupLocations: [UUID!] (scalar)
        if (this.QuarterlyBackupLocations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "quarterlyBackupLocations\n" ;
            } else {
                s += ind + "quarterlyBackupLocations\n" ;
            }
        }
        //      C# -> List<System.String>? WeeklyBackupLocations
        // GraphQL -> weeklyBackupLocations: [UUID!] (scalar)
        if (this.WeeklyBackupLocations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "weeklyBackupLocations\n" ;
            } else {
                s += ind + "weeklyBackupLocations\n" ;
            }
        }
        //      C# -> List<System.String>? YearlyBackupLocations
        // GraphQL -> yearlyBackupLocations: [UUID!] (scalar)
        if (this.YearlyBackupLocations != null) {
            if (conf.Flat) {
                s += conf.Prefix + "yearlyBackupLocations\n" ;
            } else {
                s += ind + "yearlyBackupLocations\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> List<System.String>? DailyBackupLocations
        // GraphQL -> dailyBackupLocations: [UUID!] (scalar)
        if (ec.Includes("dailyBackupLocations",true))
        {
            if(this.DailyBackupLocations == null) {

                this.DailyBackupLocations = new List<System.String>();

            } else {


            }
        }
        else if (this.DailyBackupLocations != null && ec.Excludes("dailyBackupLocations",true))
        {
            this.DailyBackupLocations = null;
        }
        //      C# -> List<System.String>? HourlyBackupLocations
        // GraphQL -> hourlyBackupLocations: [UUID!] (scalar)
        if (ec.Includes("hourlyBackupLocations",true))
        {
            if(this.HourlyBackupLocations == null) {

                this.HourlyBackupLocations = new List<System.String>();

            } else {


            }
        }
        else if (this.HourlyBackupLocations != null && ec.Excludes("hourlyBackupLocations",true))
        {
            this.HourlyBackupLocations = null;
        }
        //      C# -> List<System.String>? MinutelyBackupLocations
        // GraphQL -> minutelyBackupLocations: [UUID!] (scalar)
        if (ec.Includes("minutelyBackupLocations",true))
        {
            if(this.MinutelyBackupLocations == null) {

                this.MinutelyBackupLocations = new List<System.String>();

            } else {


            }
        }
        else if (this.MinutelyBackupLocations != null && ec.Excludes("minutelyBackupLocations",true))
        {
            this.MinutelyBackupLocations = null;
        }
        //      C# -> List<System.String>? MonthlyBackupLocations
        // GraphQL -> monthlyBackupLocations: [UUID!] (scalar)
        if (ec.Includes("monthlyBackupLocations",true))
        {
            if(this.MonthlyBackupLocations == null) {

                this.MonthlyBackupLocations = new List<System.String>();

            } else {


            }
        }
        else if (this.MonthlyBackupLocations != null && ec.Excludes("monthlyBackupLocations",true))
        {
            this.MonthlyBackupLocations = null;
        }
        //      C# -> List<System.String>? QuarterlyBackupLocations
        // GraphQL -> quarterlyBackupLocations: [UUID!] (scalar)
        if (ec.Includes("quarterlyBackupLocations",true))
        {
            if(this.QuarterlyBackupLocations == null) {

                this.QuarterlyBackupLocations = new List<System.String>();

            } else {


            }
        }
        else if (this.QuarterlyBackupLocations != null && ec.Excludes("quarterlyBackupLocations",true))
        {
            this.QuarterlyBackupLocations = null;
        }
        //      C# -> List<System.String>? WeeklyBackupLocations
        // GraphQL -> weeklyBackupLocations: [UUID!] (scalar)
        if (ec.Includes("weeklyBackupLocations",true))
        {
            if(this.WeeklyBackupLocations == null) {

                this.WeeklyBackupLocations = new List<System.String>();

            } else {


            }
        }
        else if (this.WeeklyBackupLocations != null && ec.Excludes("weeklyBackupLocations",true))
        {
            this.WeeklyBackupLocations = null;
        }
        //      C# -> List<System.String>? YearlyBackupLocations
        // GraphQL -> yearlyBackupLocations: [UUID!] (scalar)
        if (ec.Includes("yearlyBackupLocations",true))
        {
            if(this.YearlyBackupLocations == null) {

                this.YearlyBackupLocations = new List<System.String>();

            } else {


            }
        }
        else if (this.YearlyBackupLocations != null && ec.Excludes("yearlyBackupLocations",true))
        {
            this.YearlyBackupLocations = null;
        }
    }


    #endregion

    } // class NcdSlaConfig
    
    #endregion

    public static class ListNcdSlaConfigExtensions
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
            this List<NcdSlaConfig> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<NcdSlaConfig> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NcdSlaConfig> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NcdSlaConfig());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NcdSlaConfig> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types