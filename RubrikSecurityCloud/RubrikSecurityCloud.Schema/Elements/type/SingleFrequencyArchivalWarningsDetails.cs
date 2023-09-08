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
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> List<RetentionUnit>? FrequenciesProvided
        // GraphQL -> frequenciesProvided: [RetentionUnit!]! (enum)
        if (this.FrequenciesProvided != null) {
            s += ind + "frequenciesProvided\n" ;
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> System.Int32? FrequencyCountExpected
        // GraphQL -> frequencyCountExpected: Int! (scalar)
        if (this.FrequencyCountExpected != null) {
            s += ind + "frequencyCountExpected\n" ;
        }
        //      C# -> System.Int32? FrequencyCountProvided
        // GraphQL -> frequencyCountProvided: Int! (scalar)
        if (this.FrequencyCountProvided != null) {
            s += ind + "frequencyCountProvided\n" ;
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<RetentionUnit>? FrequenciesProvided
        // GraphQL -> frequenciesProvided: [RetentionUnit!]! (enum)
        if (this.FrequenciesProvided == null && ec.Includes("frequenciesProvided",true))
        {
            this.FrequenciesProvided = new List<RetentionUnit>();
        }
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity == null && ec.Includes("severity",true))
        {
            this.Severity = new WarningSeverityEnum();
        }
        //      C# -> System.Int32? FrequencyCountExpected
        // GraphQL -> frequencyCountExpected: Int! (scalar)
        if (this.FrequencyCountExpected == null && ec.Includes("frequencyCountExpected",true))
        {
            this.FrequencyCountExpected = Int32.MinValue;
        }
        //      C# -> System.Int32? FrequencyCountProvided
        // GraphQL -> frequencyCountProvided: Int! (scalar)
        if (this.FrequencyCountProvided == null && ec.Includes("frequencyCountProvided",true))
        {
            this.FrequencyCountProvided = Int32.MinValue;
        }
    }


    #endregion

    } // class SingleFrequencyArchivalWarningsDetails
    
    #endregion

    public static class ListSingleFrequencyArchivalWarningsDetailsExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<SingleFrequencyArchivalWarningsDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
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

        public static void Fetch(this List<SingleFrequencyArchivalWarningsDetails> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types