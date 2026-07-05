// PerDayViolationSummary.cs
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
    #region PerDayViolationSummary
    public class PerDayViolationSummary: BaseType
    {
        #region members

        //      C# -> System.Int32? NumCriticalViolationsCreated
        // GraphQL -> numCriticalViolationsCreated: Int! (scalar)
        [JsonProperty("numCriticalViolationsCreated")]
        public System.Int32? NumCriticalViolationsCreated { get; set; }

        //      C# -> System.Int32? NumCriticalViolationsRemediated
        // GraphQL -> numCriticalViolationsRemediated: Int! (scalar)
        [JsonProperty("numCriticalViolationsRemediated")]
        public System.Int32? NumCriticalViolationsRemediated { get; set; }

        //      C# -> System.Int32? NumHighViolationsCreated
        // GraphQL -> numHighViolationsCreated: Int! (scalar)
        [JsonProperty("numHighViolationsCreated")]
        public System.Int32? NumHighViolationsCreated { get; set; }

        //      C# -> System.Int32? NumHighViolationsRemediated
        // GraphQL -> numHighViolationsRemediated: Int! (scalar)
        [JsonProperty("numHighViolationsRemediated")]
        public System.Int32? NumHighViolationsRemediated { get; set; }

        //      C# -> System.Int32? NumLowViolationsCreated
        // GraphQL -> numLowViolationsCreated: Int! (scalar)
        [JsonProperty("numLowViolationsCreated")]
        public System.Int32? NumLowViolationsCreated { get; set; }

        //      C# -> System.Int32? NumLowViolationsRemediated
        // GraphQL -> numLowViolationsRemediated: Int! (scalar)
        [JsonProperty("numLowViolationsRemediated")]
        public System.Int32? NumLowViolationsRemediated { get; set; }

        //      C# -> System.Int32? NumMediumViolationsCreated
        // GraphQL -> numMediumViolationsCreated: Int! (scalar)
        [JsonProperty("numMediumViolationsCreated")]
        public System.Int32? NumMediumViolationsCreated { get; set; }

        //      C# -> System.Int32? NumMediumViolationsRemediated
        // GraphQL -> numMediumViolationsRemediated: Int! (scalar)
        [JsonProperty("numMediumViolationsRemediated")]
        public System.Int32? NumMediumViolationsRemediated { get; set; }

        //      C# -> System.Int32? NumViolationsCreated
        // GraphQL -> numViolationsCreated: Int! (scalar)
        [JsonProperty("numViolationsCreated")]
        public System.Int32? NumViolationsCreated { get; set; }

        //      C# -> System.Int32? NumViolationsRemediated
        // GraphQL -> numViolationsRemediated: Int! (scalar)
        [JsonProperty("numViolationsRemediated")]
        public System.Int32? NumViolationsRemediated { get; set; }

        //      C# -> DateTime? SummaryTimestamp
        // GraphQL -> summaryTimestamp: DateTime (scalar)
        [JsonProperty("summaryTimestamp")]
        public DateTime? SummaryTimestamp { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "PerDayViolationSummary";
    }

    public PerDayViolationSummary Set(
        System.Int32? NumCriticalViolationsCreated = null,
        System.Int32? NumCriticalViolationsRemediated = null,
        System.Int32? NumHighViolationsCreated = null,
        System.Int32? NumHighViolationsRemediated = null,
        System.Int32? NumLowViolationsCreated = null,
        System.Int32? NumLowViolationsRemediated = null,
        System.Int32? NumMediumViolationsCreated = null,
        System.Int32? NumMediumViolationsRemediated = null,
        System.Int32? NumViolationsCreated = null,
        System.Int32? NumViolationsRemediated = null,
        DateTime? SummaryTimestamp = null
    ) 
    {
        if ( NumCriticalViolationsCreated != null ) {
            this.NumCriticalViolationsCreated = NumCriticalViolationsCreated;
        }
        if ( NumCriticalViolationsRemediated != null ) {
            this.NumCriticalViolationsRemediated = NumCriticalViolationsRemediated;
        }
        if ( NumHighViolationsCreated != null ) {
            this.NumHighViolationsCreated = NumHighViolationsCreated;
        }
        if ( NumHighViolationsRemediated != null ) {
            this.NumHighViolationsRemediated = NumHighViolationsRemediated;
        }
        if ( NumLowViolationsCreated != null ) {
            this.NumLowViolationsCreated = NumLowViolationsCreated;
        }
        if ( NumLowViolationsRemediated != null ) {
            this.NumLowViolationsRemediated = NumLowViolationsRemediated;
        }
        if ( NumMediumViolationsCreated != null ) {
            this.NumMediumViolationsCreated = NumMediumViolationsCreated;
        }
        if ( NumMediumViolationsRemediated != null ) {
            this.NumMediumViolationsRemediated = NumMediumViolationsRemediated;
        }
        if ( NumViolationsCreated != null ) {
            this.NumViolationsCreated = NumViolationsCreated;
        }
        if ( NumViolationsRemediated != null ) {
            this.NumViolationsRemediated = NumViolationsRemediated;
        }
        if ( SummaryTimestamp != null ) {
            this.SummaryTimestamp = SummaryTimestamp;
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
        //      C# -> System.Int32? NumCriticalViolationsCreated
        // GraphQL -> numCriticalViolationsCreated: Int! (scalar)
        if (this.NumCriticalViolationsCreated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numCriticalViolationsCreated\n" ;
            } else {
                s += ind + "numCriticalViolationsCreated\n" ;
            }
        }
        //      C# -> System.Int32? NumCriticalViolationsRemediated
        // GraphQL -> numCriticalViolationsRemediated: Int! (scalar)
        if (this.NumCriticalViolationsRemediated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numCriticalViolationsRemediated\n" ;
            } else {
                s += ind + "numCriticalViolationsRemediated\n" ;
            }
        }
        //      C# -> System.Int32? NumHighViolationsCreated
        // GraphQL -> numHighViolationsCreated: Int! (scalar)
        if (this.NumHighViolationsCreated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numHighViolationsCreated\n" ;
            } else {
                s += ind + "numHighViolationsCreated\n" ;
            }
        }
        //      C# -> System.Int32? NumHighViolationsRemediated
        // GraphQL -> numHighViolationsRemediated: Int! (scalar)
        if (this.NumHighViolationsRemediated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numHighViolationsRemediated\n" ;
            } else {
                s += ind + "numHighViolationsRemediated\n" ;
            }
        }
        //      C# -> System.Int32? NumLowViolationsCreated
        // GraphQL -> numLowViolationsCreated: Int! (scalar)
        if (this.NumLowViolationsCreated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numLowViolationsCreated\n" ;
            } else {
                s += ind + "numLowViolationsCreated\n" ;
            }
        }
        //      C# -> System.Int32? NumLowViolationsRemediated
        // GraphQL -> numLowViolationsRemediated: Int! (scalar)
        if (this.NumLowViolationsRemediated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numLowViolationsRemediated\n" ;
            } else {
                s += ind + "numLowViolationsRemediated\n" ;
            }
        }
        //      C# -> System.Int32? NumMediumViolationsCreated
        // GraphQL -> numMediumViolationsCreated: Int! (scalar)
        if (this.NumMediumViolationsCreated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numMediumViolationsCreated\n" ;
            } else {
                s += ind + "numMediumViolationsCreated\n" ;
            }
        }
        //      C# -> System.Int32? NumMediumViolationsRemediated
        // GraphQL -> numMediumViolationsRemediated: Int! (scalar)
        if (this.NumMediumViolationsRemediated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numMediumViolationsRemediated\n" ;
            } else {
                s += ind + "numMediumViolationsRemediated\n" ;
            }
        }
        //      C# -> System.Int32? NumViolationsCreated
        // GraphQL -> numViolationsCreated: Int! (scalar)
        if (this.NumViolationsCreated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numViolationsCreated\n" ;
            } else {
                s += ind + "numViolationsCreated\n" ;
            }
        }
        //      C# -> System.Int32? NumViolationsRemediated
        // GraphQL -> numViolationsRemediated: Int! (scalar)
        if (this.NumViolationsRemediated != null) {
            if (conf.Flat) {
                s += conf.Prefix + "numViolationsRemediated\n" ;
            } else {
                s += ind + "numViolationsRemediated\n" ;
            }
        }
        //      C# -> DateTime? SummaryTimestamp
        // GraphQL -> summaryTimestamp: DateTime (scalar)
        if (this.SummaryTimestamp != null) {
            if (conf.Flat) {
                s += conf.Prefix + "summaryTimestamp\n" ;
            } else {
                s += ind + "summaryTimestamp\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(AutofieldContext ec)
    {
        //      C# -> System.Int32? NumCriticalViolationsCreated
        // GraphQL -> numCriticalViolationsCreated: Int! (scalar)
        if (ec.Includes("numCriticalViolationsCreated",true))
        {
            if(this.NumCriticalViolationsCreated == null) {

                this.NumCriticalViolationsCreated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumCriticalViolationsCreated != null && ec.Excludes("numCriticalViolationsCreated",true))
        {
            this.NumCriticalViolationsCreated = null;
        }
        //      C# -> System.Int32? NumCriticalViolationsRemediated
        // GraphQL -> numCriticalViolationsRemediated: Int! (scalar)
        if (ec.Includes("numCriticalViolationsRemediated",true))
        {
            if(this.NumCriticalViolationsRemediated == null) {

                this.NumCriticalViolationsRemediated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumCriticalViolationsRemediated != null && ec.Excludes("numCriticalViolationsRemediated",true))
        {
            this.NumCriticalViolationsRemediated = null;
        }
        //      C# -> System.Int32? NumHighViolationsCreated
        // GraphQL -> numHighViolationsCreated: Int! (scalar)
        if (ec.Includes("numHighViolationsCreated",true))
        {
            if(this.NumHighViolationsCreated == null) {

                this.NumHighViolationsCreated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumHighViolationsCreated != null && ec.Excludes("numHighViolationsCreated",true))
        {
            this.NumHighViolationsCreated = null;
        }
        //      C# -> System.Int32? NumHighViolationsRemediated
        // GraphQL -> numHighViolationsRemediated: Int! (scalar)
        if (ec.Includes("numHighViolationsRemediated",true))
        {
            if(this.NumHighViolationsRemediated == null) {

                this.NumHighViolationsRemediated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumHighViolationsRemediated != null && ec.Excludes("numHighViolationsRemediated",true))
        {
            this.NumHighViolationsRemediated = null;
        }
        //      C# -> System.Int32? NumLowViolationsCreated
        // GraphQL -> numLowViolationsCreated: Int! (scalar)
        if (ec.Includes("numLowViolationsCreated",true))
        {
            if(this.NumLowViolationsCreated == null) {

                this.NumLowViolationsCreated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumLowViolationsCreated != null && ec.Excludes("numLowViolationsCreated",true))
        {
            this.NumLowViolationsCreated = null;
        }
        //      C# -> System.Int32? NumLowViolationsRemediated
        // GraphQL -> numLowViolationsRemediated: Int! (scalar)
        if (ec.Includes("numLowViolationsRemediated",true))
        {
            if(this.NumLowViolationsRemediated == null) {

                this.NumLowViolationsRemediated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumLowViolationsRemediated != null && ec.Excludes("numLowViolationsRemediated",true))
        {
            this.NumLowViolationsRemediated = null;
        }
        //      C# -> System.Int32? NumMediumViolationsCreated
        // GraphQL -> numMediumViolationsCreated: Int! (scalar)
        if (ec.Includes("numMediumViolationsCreated",true))
        {
            if(this.NumMediumViolationsCreated == null) {

                this.NumMediumViolationsCreated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumMediumViolationsCreated != null && ec.Excludes("numMediumViolationsCreated",true))
        {
            this.NumMediumViolationsCreated = null;
        }
        //      C# -> System.Int32? NumMediumViolationsRemediated
        // GraphQL -> numMediumViolationsRemediated: Int! (scalar)
        if (ec.Includes("numMediumViolationsRemediated",true))
        {
            if(this.NumMediumViolationsRemediated == null) {

                this.NumMediumViolationsRemediated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumMediumViolationsRemediated != null && ec.Excludes("numMediumViolationsRemediated",true))
        {
            this.NumMediumViolationsRemediated = null;
        }
        //      C# -> System.Int32? NumViolationsCreated
        // GraphQL -> numViolationsCreated: Int! (scalar)
        if (ec.Includes("numViolationsCreated",true))
        {
            if(this.NumViolationsCreated == null) {

                this.NumViolationsCreated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumViolationsCreated != null && ec.Excludes("numViolationsCreated",true))
        {
            this.NumViolationsCreated = null;
        }
        //      C# -> System.Int32? NumViolationsRemediated
        // GraphQL -> numViolationsRemediated: Int! (scalar)
        if (ec.Includes("numViolationsRemediated",true))
        {
            if(this.NumViolationsRemediated == null) {

                this.NumViolationsRemediated = Int32.MinValue;

            } else {


            }
        }
        else if (this.NumViolationsRemediated != null && ec.Excludes("numViolationsRemediated",true))
        {
            this.NumViolationsRemediated = null;
        }
        //      C# -> DateTime? SummaryTimestamp
        // GraphQL -> summaryTimestamp: DateTime (scalar)
        if (ec.Includes("summaryTimestamp",true))
        {
            if(this.SummaryTimestamp == null) {

                this.SummaryTimestamp = new DateTime();

            } else {


            }
        }
        else if (this.SummaryTimestamp != null && ec.Excludes("summaryTimestamp",true))
        {
            this.SummaryTimestamp = null;
        }
    }


    #endregion

    } // class PerDayViolationSummary
    
    #endregion

    public static class ListPerDayViolationSummaryExtensions
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
            this List<PerDayViolationSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<PerDayViolationSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<PerDayViolationSummary> list, 
            AutofieldContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new PerDayViolationSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<PerDayViolationSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new AutofieldContext());
        }
    }


} // namespace RubrikSecurityCloud.Types