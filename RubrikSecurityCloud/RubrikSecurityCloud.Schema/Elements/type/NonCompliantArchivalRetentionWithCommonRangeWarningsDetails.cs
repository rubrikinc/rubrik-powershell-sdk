// NonCompliantArchivalRetentionWithCommonRangeWarningsDetails.cs
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
    #region NonCompliantArchivalRetentionWithCommonRangeWarningsDetails
 
    public class NonCompliantArchivalRetentionWithCommonRangeWarningsDetails: BaseType, SlaArchivalWarningsDetails
    {
        #region members

        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        [JsonProperty("severity")]
        public WarningSeverityEnum? Severity { get; set; }

        //      C# -> System.Int32? MaxArchivalRetentionInDaysExpected
        // GraphQL -> maxArchivalRetentionInDaysExpected: Int! (scalar)
        [JsonProperty("maxArchivalRetentionInDaysExpected")]
        public System.Int32? MaxArchivalRetentionInDaysExpected { get; set; }

        //      C# -> System.Int32? MinArchivalRetentionInDaysExpected
        // GraphQL -> minArchivalRetentionInDaysExpected: Int! (scalar)
        [JsonProperty("minArchivalRetentionInDaysExpected")]
        public System.Int32? MinArchivalRetentionInDaysExpected { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NonCompliantArchivalRetentionWithCommonRangeWarningsDetails";
    }

    public NonCompliantArchivalRetentionWithCommonRangeWarningsDetails Set(
        WarningSeverityEnum? Severity = null,
        System.Int32? MaxArchivalRetentionInDaysExpected = null,
        System.Int32? MinArchivalRetentionInDaysExpected = null
    ) 
    {
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( MaxArchivalRetentionInDaysExpected != null ) {
            this.MaxArchivalRetentionInDaysExpected = MaxArchivalRetentionInDaysExpected;
        }
        if ( MinArchivalRetentionInDaysExpected != null ) {
            this.MinArchivalRetentionInDaysExpected = MinArchivalRetentionInDaysExpected;
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
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity != null) {
            s += ind + "severity\n" ;
        }
        //      C# -> System.Int32? MaxArchivalRetentionInDaysExpected
        // GraphQL -> maxArchivalRetentionInDaysExpected: Int! (scalar)
        if (this.MaxArchivalRetentionInDaysExpected != null) {
            s += ind + "maxArchivalRetentionInDaysExpected\n" ;
        }
        //      C# -> System.Int32? MinArchivalRetentionInDaysExpected
        // GraphQL -> minArchivalRetentionInDaysExpected: Int! (scalar)
        if (this.MinArchivalRetentionInDaysExpected != null) {
            s += ind + "minArchivalRetentionInDaysExpected\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        if (this.Severity == null && Exploration.Includes(parent + ".severity", true))
        {
            this.Severity = new WarningSeverityEnum();
        }
        //      C# -> System.Int32? MaxArchivalRetentionInDaysExpected
        // GraphQL -> maxArchivalRetentionInDaysExpected: Int! (scalar)
        if (this.MaxArchivalRetentionInDaysExpected == null && Exploration.Includes(parent + ".maxArchivalRetentionInDaysExpected", true))
        {
            this.MaxArchivalRetentionInDaysExpected = Int32.MinValue;
        }
        //      C# -> System.Int32? MinArchivalRetentionInDaysExpected
        // GraphQL -> minArchivalRetentionInDaysExpected: Int! (scalar)
        if (this.MinArchivalRetentionInDaysExpected == null && Exploration.Includes(parent + ".minArchivalRetentionInDaysExpected", true))
        {
            this.MinArchivalRetentionInDaysExpected = Int32.MinValue;
        }
    }


    #endregion

    } // class NonCompliantArchivalRetentionWithCommonRangeWarningsDetails
    
    #endregion

    public static class ListNonCompliantArchivalRetentionWithCommonRangeWarningsDetailsExtensions
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
            this List<NonCompliantArchivalRetentionWithCommonRangeWarningsDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NonCompliantArchivalRetentionWithCommonRangeWarningsDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NonCompliantArchivalRetentionWithCommonRangeWarningsDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types