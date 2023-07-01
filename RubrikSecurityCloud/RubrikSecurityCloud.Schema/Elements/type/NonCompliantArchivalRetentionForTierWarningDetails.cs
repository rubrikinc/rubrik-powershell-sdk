// NonCompliantArchivalRetentionForTierWarningDetails.cs
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
    #region NonCompliantArchivalRetentionForTierWarningDetails
 
    public class NonCompliantArchivalRetentionForTierWarningDetails: BaseType, SlaArchivalWarningsDetails
    {
        #region members

        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        [JsonProperty("severity")]
        public WarningSeverityEnum? Severity { get; set; }

        //      C# -> System.Int32? MinArchivalRetentionDaysExpected
        // GraphQL -> minArchivalRetentionDaysExpected: Int! (scalar)
        [JsonProperty("minArchivalRetentionDaysExpected")]
        public System.Int32? MinArchivalRetentionDaysExpected { get; set; }

        //      C# -> System.Int32? MinArchivalRetentionDaysFound
        // GraphQL -> minArchivalRetentionDaysFound: Int! (scalar)
        [JsonProperty("minArchivalRetentionDaysFound")]
        public System.Int32? MinArchivalRetentionDaysFound { get; set; }

        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        [JsonProperty("tier")]
        public System.String? Tier { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NonCompliantArchivalRetentionForTierWarningDetails";
    }

    public NonCompliantArchivalRetentionForTierWarningDetails Set(
        WarningSeverityEnum? Severity = null,
        System.Int32? MinArchivalRetentionDaysExpected = null,
        System.Int32? MinArchivalRetentionDaysFound = null,
        System.String? Tier = null
    ) 
    {
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( MinArchivalRetentionDaysExpected != null ) {
            this.MinArchivalRetentionDaysExpected = MinArchivalRetentionDaysExpected;
        }
        if ( MinArchivalRetentionDaysFound != null ) {
            this.MinArchivalRetentionDaysFound = MinArchivalRetentionDaysFound;
        }
        if ( Tier != null ) {
            this.Tier = Tier;
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
        //      C# -> System.Int32? MinArchivalRetentionDaysExpected
        // GraphQL -> minArchivalRetentionDaysExpected: Int! (scalar)
        if (this.MinArchivalRetentionDaysExpected != null) {
            s += ind + "minArchivalRetentionDaysExpected\n" ;
        }
        //      C# -> System.Int32? MinArchivalRetentionDaysFound
        // GraphQL -> minArchivalRetentionDaysFound: Int! (scalar)
        if (this.MinArchivalRetentionDaysFound != null) {
            s += ind + "minArchivalRetentionDaysFound\n" ;
        }
        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        if (this.Tier != null) {
            s += ind + "tier\n" ;
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
        //      C# -> System.Int32? MinArchivalRetentionDaysExpected
        // GraphQL -> minArchivalRetentionDaysExpected: Int! (scalar)
        if (this.MinArchivalRetentionDaysExpected == null && Exploration.Includes(parent + ".minArchivalRetentionDaysExpected", true))
        {
            this.MinArchivalRetentionDaysExpected = Int32.MinValue;
        }
        //      C# -> System.Int32? MinArchivalRetentionDaysFound
        // GraphQL -> minArchivalRetentionDaysFound: Int! (scalar)
        if (this.MinArchivalRetentionDaysFound == null && Exploration.Includes(parent + ".minArchivalRetentionDaysFound", true))
        {
            this.MinArchivalRetentionDaysFound = Int32.MinValue;
        }
        //      C# -> System.String? Tier
        // GraphQL -> tier: String! (scalar)
        if (this.Tier == null && Exploration.Includes(parent + ".tier", true))
        {
            this.Tier = "FETCH";
        }
    }


    #endregion

    } // class NonCompliantArchivalRetentionForTierWarningDetails
    
    #endregion

    public static class ListNonCompliantArchivalRetentionForTierWarningDetailsExtensions
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
            this List<NonCompliantArchivalRetentionForTierWarningDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NonCompliantArchivalRetentionForTierWarningDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NonCompliantArchivalRetentionForTierWarningDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types