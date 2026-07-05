// ViolationsEnvironmentSummary.cs
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
    #region ViolationsEnvironmentSummary
    public class ViolationsEnvironmentSummary: BaseType
    {
        #region members

        //      C# -> PlatformCategory? PlatformEnv
        // GraphQL -> platformEnv: PlatformCategory! (enum)
        [JsonProperty("platformEnv")]
        public PlatformCategory? PlatformEnv { get; set; }

        //      C# -> System.Int32? CriticalSeverityViolationCount
        // GraphQL -> criticalSeverityViolationCount: Int! (scalar)
        [JsonProperty("criticalSeverityViolationCount")]
        public System.Int32? CriticalSeverityViolationCount { get; set; }

        //      C# -> System.Int32? HighSeverityViolationCount
        // GraphQL -> highSeverityViolationCount: Int! (scalar)
        [JsonProperty("highSeverityViolationCount")]
        public System.Int32? HighSeverityViolationCount { get; set; }

        //      C# -> System.Int32? LowSeverityViolationCount
        // GraphQL -> lowSeverityViolationCount: Int! (scalar)
        [JsonProperty("lowSeverityViolationCount")]
        public System.Int32? LowSeverityViolationCount { get; set; }

        //      C# -> System.Int32? MediumSeverityViolationCount
        // GraphQL -> mediumSeverityViolationCount: Int! (scalar)
        [JsonProperty("mediumSeverityViolationCount")]
        public System.Int32? MediumSeverityViolationCount { get; set; }

        //      C# -> System.Int32? NewCriticalSeverityViolationCount
        // GraphQL -> newCriticalSeverityViolationCount: Int! (scalar)
        [JsonProperty("newCriticalSeverityViolationCount")]
        public System.Int32? NewCriticalSeverityViolationCount { get; set; }

        //      C# -> System.Int32? NewHighSeverityViolationCount
        // GraphQL -> newHighSeverityViolationCount: Int! (scalar)
        [JsonProperty("newHighSeverityViolationCount")]
        public System.Int32? NewHighSeverityViolationCount { get; set; }

        //      C# -> System.Int32? NewLowSeverityViolationCount
        // GraphQL -> newLowSeverityViolationCount: Int! (scalar)
        [JsonProperty("newLowSeverityViolationCount")]
        public System.Int32? NewLowSeverityViolationCount { get; set; }

        //      C# -> System.Int32? NewMediumSeverityViolationCount
        // GraphQL -> newMediumSeverityViolationCount: Int! (scalar)
        [JsonProperty("newMediumSeverityViolationCount")]
        public System.Int32? NewMediumSeverityViolationCount { get; set; }

        //      C# -> System.Int32? NewViolationsCount
        // GraphQL -> newViolationsCount: Int! (scalar)
        [JsonProperty("newViolationsCount")]
        public System.Int32? NewViolationsCount { get; set; }

        //      C# -> System.Int32? TotalViolationCount
        // GraphQL -> totalViolationCount: Int! (scalar)
        [JsonProperty("totalViolationCount")]
        public System.Int32? TotalViolationCount { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ViolationsEnvironmentSummary";
    }

    public ViolationsEnvironmentSummary Set(
        PlatformCategory? PlatformEnv = null,
        System.Int32? CriticalSeverityViolationCount = null,
        System.Int32? HighSeverityViolationCount = null,
        System.Int32? LowSeverityViolationCount = null,
        System.Int32? MediumSeverityViolationCount = null,
        System.Int32? NewCriticalSeverityViolationCount = null,
        System.Int32? NewHighSeverityViolationCount = null,
        System.Int32? NewLowSeverityViolationCount = null,
        System.Int32? NewMediumSeverityViolationCount = null,
        System.Int32? NewViolationsCount = null,
        System.Int32? TotalViolationCount = null
    ) 
    {
        if ( PlatformEnv != null ) {
            this.PlatformEnv = PlatformEnv;
        }
        if ( CriticalSeverityViolationCount != null ) {
            this.CriticalSeverityViolationCount = CriticalSeverityViolationCount;
        }
        if ( HighSeverityViolationCount != null ) {
            this.HighSeverityViolationCount = HighSeverityViolationCount;
        }
        if ( LowSeverityViolationCount != null ) {
            this.LowSeverityViolationCount = LowSeverityViolationCount;
        }
        if ( MediumSeverityViolationCount != null ) {
            this.MediumSeverityViolationCount = MediumSeverityViolationCount;
        }
        if ( NewCriticalSeverityViolationCount != null ) {
            this.NewCriticalSeverityViolationCount = NewCriticalSeverityViolationCount;
        }
        if ( NewHighSeverityViolationCount != null ) {
            this.NewHighSeverityViolationCount = NewHighSeverityViolationCount;
        }
        if ( NewLowSeverityViolationCount != null ) {
            this.NewLowSeverityViolationCount = NewLowSeverityViolationCount;
        }
        if ( NewMediumSeverityViolationCount != null ) {
            this.NewMediumSeverityViolationCount = NewMediumSeverityViolationCount;
        }
        if ( NewViolationsCount != null ) {
            this.NewViolationsCount = NewViolationsCount;
        }
        if ( TotalViolationCount != null ) {
            this.TotalViolationCount = TotalViolationCount;
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
        //      C# -> PlatformCategory? PlatformEnv
        // GraphQL -> platformEnv: PlatformCategory! (enum)
        if (this.PlatformEnv != null) {
            if (conf.Flat) {
                s += conf.Prefix + "platformEnv\n" ;
            } else {
                s += ind + "platformEnv\n" ;
            }
        }
        //      C# -> System.Int32? CriticalSeverityViolationCount
        // GraphQL -> criticalSeverityViolationCount: Int! (scalar)
        if (this.CriticalSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "criticalSeverityViolationCount\n" ;
            } else {
                s += ind + "criticalSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.Int32? HighSeverityViolationCount
        // GraphQL -> highSeverityViolationCount: Int! (scalar)
        if (this.HighSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "highSeverityViolationCount\n" ;
            } else {
                s += ind + "highSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.Int32? LowSeverityViolationCount
        // GraphQL -> lowSeverityViolationCount: Int! (scalar)
        if (this.LowSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lowSeverityViolationCount\n" ;
            } else {
                s += ind + "lowSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.Int32? MediumSeverityViolationCount
        // GraphQL -> mediumSeverityViolationCount: Int! (scalar)
        if (this.MediumSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "mediumSeverityViolationCount\n" ;
            } else {
                s += ind + "mediumSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.Int32? NewCriticalSeverityViolationCount
        // GraphQL -> newCriticalSeverityViolationCount: Int! (scalar)
        if (this.NewCriticalSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newCriticalSeverityViolationCount\n" ;
            } else {
                s += ind + "newCriticalSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.Int32? NewHighSeverityViolationCount
        // GraphQL -> newHighSeverityViolationCount: Int! (scalar)
        if (this.NewHighSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newHighSeverityViolationCount\n" ;
            } else {
                s += ind + "newHighSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.Int32? NewLowSeverityViolationCount
        // GraphQL -> newLowSeverityViolationCount: Int! (scalar)
        if (this.NewLowSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newLowSeverityViolationCount\n" ;
            } else {
                s += ind + "newLowSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.Int32? NewMediumSeverityViolationCount
        // GraphQL -> newMediumSeverityViolationCount: Int! (scalar)
        if (this.NewMediumSeverityViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newMediumSeverityViolationCount\n" ;
            } else {
                s += ind + "newMediumSeverityViolationCount\n" ;
            }
        }
        //      C# -> System.Int32? NewViolationsCount
        // GraphQL -> newViolationsCount: Int! (scalar)
        if (this.NewViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "newViolationsCount\n" ;
            } else {
                s += ind + "newViolationsCount\n" ;
            }
        }
        //      C# -> System.Int32? TotalViolationCount
        // GraphQL -> totalViolationCount: Int! (scalar)
        if (this.TotalViolationCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalViolationCount\n" ;
            } else {
                s += ind + "totalViolationCount\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> PlatformCategory? PlatformEnv
        // GraphQL -> platformEnv: PlatformCategory! (enum)
        if (ec.Includes("platformEnv",true))
        {
            if(this.PlatformEnv == null) {

                this.PlatformEnv = new PlatformCategory();

            } else {


            }
        }
        else if (this.PlatformEnv != null && ec.Excludes("platformEnv",true))
        {
            this.PlatformEnv = null;
        }
        //      C# -> System.Int32? CriticalSeverityViolationCount
        // GraphQL -> criticalSeverityViolationCount: Int! (scalar)
        if (ec.Includes("criticalSeverityViolationCount",true))
        {
            if(this.CriticalSeverityViolationCount == null) {

                this.CriticalSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.CriticalSeverityViolationCount != null && ec.Excludes("criticalSeverityViolationCount",true))
        {
            this.CriticalSeverityViolationCount = null;
        }
        //      C# -> System.Int32? HighSeverityViolationCount
        // GraphQL -> highSeverityViolationCount: Int! (scalar)
        if (ec.Includes("highSeverityViolationCount",true))
        {
            if(this.HighSeverityViolationCount == null) {

                this.HighSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.HighSeverityViolationCount != null && ec.Excludes("highSeverityViolationCount",true))
        {
            this.HighSeverityViolationCount = null;
        }
        //      C# -> System.Int32? LowSeverityViolationCount
        // GraphQL -> lowSeverityViolationCount: Int! (scalar)
        if (ec.Includes("lowSeverityViolationCount",true))
        {
            if(this.LowSeverityViolationCount == null) {

                this.LowSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.LowSeverityViolationCount != null && ec.Excludes("lowSeverityViolationCount",true))
        {
            this.LowSeverityViolationCount = null;
        }
        //      C# -> System.Int32? MediumSeverityViolationCount
        // GraphQL -> mediumSeverityViolationCount: Int! (scalar)
        if (ec.Includes("mediumSeverityViolationCount",true))
        {
            if(this.MediumSeverityViolationCount == null) {

                this.MediumSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.MediumSeverityViolationCount != null && ec.Excludes("mediumSeverityViolationCount",true))
        {
            this.MediumSeverityViolationCount = null;
        }
        //      C# -> System.Int32? NewCriticalSeverityViolationCount
        // GraphQL -> newCriticalSeverityViolationCount: Int! (scalar)
        if (ec.Includes("newCriticalSeverityViolationCount",true))
        {
            if(this.NewCriticalSeverityViolationCount == null) {

                this.NewCriticalSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewCriticalSeverityViolationCount != null && ec.Excludes("newCriticalSeverityViolationCount",true))
        {
            this.NewCriticalSeverityViolationCount = null;
        }
        //      C# -> System.Int32? NewHighSeverityViolationCount
        // GraphQL -> newHighSeverityViolationCount: Int! (scalar)
        if (ec.Includes("newHighSeverityViolationCount",true))
        {
            if(this.NewHighSeverityViolationCount == null) {

                this.NewHighSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewHighSeverityViolationCount != null && ec.Excludes("newHighSeverityViolationCount",true))
        {
            this.NewHighSeverityViolationCount = null;
        }
        //      C# -> System.Int32? NewLowSeverityViolationCount
        // GraphQL -> newLowSeverityViolationCount: Int! (scalar)
        if (ec.Includes("newLowSeverityViolationCount",true))
        {
            if(this.NewLowSeverityViolationCount == null) {

                this.NewLowSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewLowSeverityViolationCount != null && ec.Excludes("newLowSeverityViolationCount",true))
        {
            this.NewLowSeverityViolationCount = null;
        }
        //      C# -> System.Int32? NewMediumSeverityViolationCount
        // GraphQL -> newMediumSeverityViolationCount: Int! (scalar)
        if (ec.Includes("newMediumSeverityViolationCount",true))
        {
            if(this.NewMediumSeverityViolationCount == null) {

                this.NewMediumSeverityViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewMediumSeverityViolationCount != null && ec.Excludes("newMediumSeverityViolationCount",true))
        {
            this.NewMediumSeverityViolationCount = null;
        }
        //      C# -> System.Int32? NewViolationsCount
        // GraphQL -> newViolationsCount: Int! (scalar)
        if (ec.Includes("newViolationsCount",true))
        {
            if(this.NewViolationsCount == null) {

                this.NewViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.NewViolationsCount != null && ec.Excludes("newViolationsCount",true))
        {
            this.NewViolationsCount = null;
        }
        //      C# -> System.Int32? TotalViolationCount
        // GraphQL -> totalViolationCount: Int! (scalar)
        if (ec.Includes("totalViolationCount",true))
        {
            if(this.TotalViolationCount == null) {

                this.TotalViolationCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.TotalViolationCount != null && ec.Excludes("totalViolationCount",true))
        {
            this.TotalViolationCount = null;
        }
    }


    #endregion

    } // class ViolationsEnvironmentSummary
    
    #endregion

    public static class ListViolationsEnvironmentSummaryExtensions
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
            this List<ViolationsEnvironmentSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ViolationsEnvironmentSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ViolationsEnvironmentSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ViolationsEnvironmentSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ViolationsEnvironmentSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types