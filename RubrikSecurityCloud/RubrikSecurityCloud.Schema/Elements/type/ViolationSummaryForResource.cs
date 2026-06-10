// ViolationSummaryForResource.cs
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
    #region ViolationSummaryForResource
    public class ViolationSummaryForResource: BaseType
    {
        #region members

        //      C# -> Severity? Severity
        // GraphQL -> severity: Severity! (enum)
        [JsonProperty("severity")]
        public Severity? Severity { get; set; }

        //      C# -> System.Int32? ActiveViolationsCount
        // GraphQL -> activeViolationsCount: Int! (scalar)
        [JsonProperty("activeViolationsCount")]
        public System.Int32? ActiveViolationsCount { get; set; }

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


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ViolationSummaryForResource";
    }

    public ViolationSummaryForResource Set(
        Severity? Severity = null,
        System.Int32? ActiveViolationsCount = null,
        System.Int32? CriticalSeverityViolationCount = null,
        System.Int32? HighSeverityViolationCount = null,
        System.Int32? LowSeverityViolationCount = null,
        System.Int32? MediumSeverityViolationCount = null
    ) 
    {
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( ActiveViolationsCount != null ) {
            this.ActiveViolationsCount = ActiveViolationsCount;
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
        //      C# -> Severity? Severity
        // GraphQL -> severity: Severity! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.Int32? ActiveViolationsCount
        // GraphQL -> activeViolationsCount: Int! (scalar)
        if (this.ActiveViolationsCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "activeViolationsCount\n" ;
            } else {
                s += ind + "activeViolationsCount\n" ;
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
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> Severity? Severity
        // GraphQL -> severity: Severity! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new Severity();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.Int32? ActiveViolationsCount
        // GraphQL -> activeViolationsCount: Int! (scalar)
        if (ec.Includes("activeViolationsCount",true))
        {
            if(this.ActiveViolationsCount == null) {

                this.ActiveViolationsCount = Int32.MinValue;

            } else {


            }
        }
        else if (this.ActiveViolationsCount != null && ec.Excludes("activeViolationsCount",true))
        {
            this.ActiveViolationsCount = null;
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
    }


    #endregion

    } // class ViolationSummaryForResource
    
    #endregion

    public static class ListViolationSummaryForResourceExtensions
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
            this List<ViolationSummaryForResource> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<ViolationSummaryForResource> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ViolationSummaryForResource> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ViolationSummaryForResource());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ViolationSummaryForResource> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types