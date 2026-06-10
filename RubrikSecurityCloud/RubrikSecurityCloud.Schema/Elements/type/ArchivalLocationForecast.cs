// ArchivalLocationForecast.cs
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
    #region ArchivalLocationForecast
    public class ArchivalLocationForecast: BaseType
    {
        #region members

        //      C# -> ArchivalForecastConfidenceType? Confidence
        // GraphQL -> confidence: ArchivalForecastConfidenceType! (enum)
        [JsonProperty("confidence")]
        public ArchivalForecastConfidenceType? Confidence { get; set; }

        //      C# -> System.Single? CurrentBytes
        // GraphQL -> currentBytes: Float! (scalar)
        [JsonProperty("currentBytes")]
        public System.Single? CurrentBytes { get; set; }

        //      C# -> DateTime? LastRefreshedAt
        // GraphQL -> lastRefreshedAt: DateTime (scalar)
        [JsonProperty("lastRefreshedAt")]
        public DateTime? LastRefreshedAt { get; set; }

        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        [JsonProperty("locationId")]
        public System.String? LocationId { get; set; }

        //      C# -> System.Single? RunwayWeeks
        // GraphQL -> runwayWeeks: Float! (scalar)
        [JsonProperty("runwayWeeks")]
        public System.Single? RunwayWeeks { get; set; }

        //      C# -> System.Single? WeeklyGrowthPct
        // GraphQL -> weeklyGrowthPct: Float! (scalar)
        [JsonProperty("weeklyGrowthPct")]
        public System.Single? WeeklyGrowthPct { get; set; }

        //      C# -> List<ArchivalForecastDataPoint>? Forecast
        // GraphQL -> forecast: [ArchivalForecastDataPoint!]! (type)
        [JsonProperty("forecast")]
        public List<ArchivalForecastDataPoint>? Forecast { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ArchivalLocationForecast";
    }

    public ArchivalLocationForecast Set(
        ArchivalForecastConfidenceType? Confidence = null,
        System.Single? CurrentBytes = null,
        DateTime? LastRefreshedAt = null,
        System.String? LocationId = null,
        System.Single? RunwayWeeks = null,
        System.Single? WeeklyGrowthPct = null,
        List<ArchivalForecastDataPoint>? Forecast = null
    ) 
    {
        if ( Confidence != null ) {
            this.Confidence = Confidence;
        }
        if ( CurrentBytes != null ) {
            this.CurrentBytes = CurrentBytes;
        }
        if ( LastRefreshedAt != null ) {
            this.LastRefreshedAt = LastRefreshedAt;
        }
        if ( LocationId != null ) {
            this.LocationId = LocationId;
        }
        if ( RunwayWeeks != null ) {
            this.RunwayWeeks = RunwayWeeks;
        }
        if ( WeeklyGrowthPct != null ) {
            this.WeeklyGrowthPct = WeeklyGrowthPct;
        }
        if ( Forecast != null ) {
            this.Forecast = Forecast;
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
        //      C# -> ArchivalForecastConfidenceType? Confidence
        // GraphQL -> confidence: ArchivalForecastConfidenceType! (enum)
        if (this.Confidence != null) {
            if (conf.Flat) {
                s += conf.Prefix + "confidence\n" ;
            } else {
                s += ind + "confidence\n" ;
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
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        if (this.LocationId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "locationId\n" ;
            } else {
                s += ind + "locationId\n" ;
            }
        }
        //      C# -> System.Single? RunwayWeeks
        // GraphQL -> runwayWeeks: Float! (scalar)
        if (this.RunwayWeeks != null) {
            if (conf.Flat) {
                s += conf.Prefix + "runwayWeeks\n" ;
            } else {
                s += ind + "runwayWeeks\n" ;
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
        //      C# -> List<ArchivalForecastDataPoint>? Forecast
        // GraphQL -> forecast: [ArchivalForecastDataPoint!]! (type)
        if (this.Forecast != null) {
            var fspec = this.Forecast.AsFieldSpec(conf.Child("forecast"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "forecast" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> ArchivalForecastConfidenceType? Confidence
        // GraphQL -> confidence: ArchivalForecastConfidenceType! (enum)
        if (ec.Includes("confidence",true))
        {
            if(this.Confidence == null) {

                this.Confidence = new ArchivalForecastConfidenceType();

            } else {


            }
        }
        else if (this.Confidence != null && ec.Excludes("confidence",true))
        {
            this.Confidence = null;
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
        //      C# -> System.String? LocationId
        // GraphQL -> locationId: UUID! (scalar)
        if (ec.Includes("locationId",true))
        {
            if(this.LocationId == null) {

                this.LocationId = "FETCH";

            } else {


            }
        }
        else if (this.LocationId != null && ec.Excludes("locationId",true))
        {
            this.LocationId = null;
        }
        //      C# -> System.Single? RunwayWeeks
        // GraphQL -> runwayWeeks: Float! (scalar)
        if (ec.Includes("runwayWeeks",true))
        {
            if(this.RunwayWeeks == null) {

                this.RunwayWeeks = new System.Single();

            } else {


            }
        }
        else if (this.RunwayWeeks != null && ec.Excludes("runwayWeeks",true))
        {
            this.RunwayWeeks = null;
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
        //      C# -> List<ArchivalForecastDataPoint>? Forecast
        // GraphQL -> forecast: [ArchivalForecastDataPoint!]! (type)
        if (ec.Includes("forecast",false))
        {
            if(this.Forecast == null) {

                this.Forecast = new List<ArchivalForecastDataPoint>();
                this.Forecast.ApplyExploratoryFieldSpec(ec.NewChild("forecast"));

            } else {

                this.Forecast.ApplyExploratoryFieldSpec(ec.NewChild("forecast"));

            }
        }
        else if (this.Forecast != null && ec.Excludes("forecast",false))
        {
            this.Forecast = null;
        }
    }


    #endregion

    } // class ArchivalLocationForecast
    
    #endregion

    public static class ListArchivalLocationForecastExtensions
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
            this List<ArchivalLocationForecast> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ArchivalLocationForecast> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ArchivalLocationForecast> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ArchivalLocationForecast());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ArchivalLocationForecast> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types