// SingleFrequencyArchivalWarningsDetails.cs
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
    #region SingleFrequencyArchivalWarningsDetails
 
    public class SingleFrequencyArchivalWarningsDetails: BaseType, SlaArchivalWarningsDetails
    {
        #region members

        //      C# -> List<RetentionUnit>? FrequenciesProvided
        // GraphQL -> frequenciesProvided: [RetentionUnit!]! (enum)
        [JsonProperty("frequenciesProvided")]
        public List<RetentionUnit>? FrequenciesProvided { get; set; }

        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        [JsonProperty("severity")]
        public WarningSeverityEnum? Severity { get; set; }

        //      C# -> System.Int32? FrequencyCountExpected
        // GraphQL -> frequencyCountExpected: Int! (scalar)
        [JsonProperty("frequencyCountExpected")]
        public System.Int32? FrequencyCountExpected { get; set; }

        //      C# -> System.Int32? FrequencyCountProvided
        // GraphQL -> frequencyCountProvided: Int! (scalar)
        [JsonProperty("frequencyCountProvided")]
        public System.Int32? FrequencyCountProvided { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SingleFrequencyArchivalWarningsDetails";
    }

    public SingleFrequencyArchivalWarningsDetails Set(
        List<RetentionUnit>? FrequenciesProvided = null,
        WarningSeverityEnum? Severity = null,
        System.Int32? FrequencyCountExpected = null,
        System.Int32? FrequencyCountProvided = null
    ) 
    {
        if ( FrequenciesProvided != null ) {
            this.FrequenciesProvided = FrequenciesProvided;
        }
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( FrequencyCountExpected != null ) {
            this.FrequencyCountExpected = FrequencyCountExpected;
        }
        if ( FrequencyCountProvided != null ) {
            this.FrequencyCountProvided = FrequencyCountProvided;
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
        //      C# -> List<RetentionUnit>? FrequenciesProvided
        // GraphQL -> frequenciesProvided: [RetentionUnit!]! (enum)
        if (this.FrequenciesProvided != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequenciesProvided\n" ;
            } else {
                s += ind + "frequenciesProvided\n" ;
            }
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity != null) {
            if (conf.Flat) {
                s += conf.Prefix + "severity\n" ;
            } else {
                s += ind + "severity\n" ;
            }
        }
        //      C# -> System.Int32? FrequencyCountExpected
        // GraphQL -> frequencyCountExpected: Int! (scalar)
        if (this.FrequencyCountExpected != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequencyCountExpected\n" ;
            } else {
                s += ind + "frequencyCountExpected\n" ;
            }
        }
        //      C# -> System.Int32? FrequencyCountProvided
        // GraphQL -> frequencyCountProvided: Int! (scalar)
        if (this.FrequencyCountProvided != null) {
            if (conf.Flat) {
                s += conf.Prefix + "frequencyCountProvided\n" ;
            } else {
                s += ind + "frequencyCountProvided\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RetentionUnit>? FrequenciesProvided
        // GraphQL -> frequenciesProvided: [RetentionUnit!]! (enum)
        if (ec.Includes("frequenciesProvided",true))
        {
            if(this.FrequenciesProvided == null) {

                this.FrequenciesProvided = new List<RetentionUnit>();

            } else {


            }
        }
        else if (this.FrequenciesProvided != null && ec.Excludes("frequenciesProvided",true))
        {
            this.FrequenciesProvided = null;
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (ec.Includes("severity",true))
        {
            if(this.Severity == null) {

                this.Severity = new WarningSeverityEnum();

            } else {


            }
        }
        else if (this.Severity != null && ec.Excludes("severity",true))
        {
            this.Severity = null;
        }
        //      C# -> System.Int32? FrequencyCountExpected
        // GraphQL -> frequencyCountExpected: Int! (scalar)
        if (ec.Includes("frequencyCountExpected",true))
        {
            if(this.FrequencyCountExpected == null) {

                this.FrequencyCountExpected = Int32.MinValue;

            } else {


            }
        }
        else if (this.FrequencyCountExpected != null && ec.Excludes("frequencyCountExpected",true))
        {
            this.FrequencyCountExpected = null;
        }
        //      C# -> System.Int32? FrequencyCountProvided
        // GraphQL -> frequencyCountProvided: Int! (scalar)
        if (ec.Includes("frequencyCountProvided",true))
        {
            if(this.FrequencyCountProvided == null) {

                this.FrequencyCountProvided = Int32.MinValue;

            } else {


            }
        }
        else if (this.FrequencyCountProvided != null && ec.Excludes("frequencyCountProvided",true))
        {
            this.FrequencyCountProvided = null;
        }
    }


    #endregion

    } // class SingleFrequencyArchivalWarningsDetails
    
    #endregion

    public static class ListSingleFrequencyArchivalWarningsDetailsExtensions
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
            this List<SingleFrequencyArchivalWarningsDetails> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SingleFrequencyArchivalWarningsDetails> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SingleFrequencyArchivalWarningsDetails> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SingleFrequencyArchivalWarningsDetails());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SingleFrequencyArchivalWarningsDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types