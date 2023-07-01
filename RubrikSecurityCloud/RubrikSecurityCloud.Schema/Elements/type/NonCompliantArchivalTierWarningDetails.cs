// NonCompliantArchivalTierWarningDetails.cs
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
    #region NonCompliantArchivalTierWarningDetails
 
    public class NonCompliantArchivalTierWarningDetails: BaseType, SlaArchivalWarningsDetails
    {
        #region members

        //      C# -> WarningSeverityEnum? Severity
        // GraphQL -> severity: WarningSeverityEnum! (enum)
        [JsonProperty("severity")]
        public WarningSeverityEnum? Severity { get; set; }

        //      C# -> List<ArchivalLocationWarningsDetails>? AllWarnings
        // GraphQL -> allWarnings: [ArchivalLocationWarningsDetails!]! (type)
        [JsonProperty("allWarnings")]
        public List<ArchivalLocationWarningsDetails>? AllWarnings { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NonCompliantArchivalTierWarningDetails";
    }

    public NonCompliantArchivalTierWarningDetails Set(
        WarningSeverityEnum? Severity = null,
        List<ArchivalLocationWarningsDetails>? AllWarnings = null
    ) 
    {
        if ( Severity != null ) {
            this.Severity = Severity;
        }
        if ( AllWarnings != null ) {
            this.AllWarnings = AllWarnings;
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
        //      C# -> List<ArchivalLocationWarningsDetails>? AllWarnings
        // GraphQL -> allWarnings: [ArchivalLocationWarningsDetails!]! (type)
        if (this.AllWarnings != null) {
            var fspec = this.AllWarnings.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "allWarnings {\n" + fspec + ind + "}\n" ;
            }
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
        //      C# -> List<ArchivalLocationWarningsDetails>? AllWarnings
        // GraphQL -> allWarnings: [ArchivalLocationWarningsDetails!]! (type)
        if (this.AllWarnings == null && Exploration.Includes(parent + ".allWarnings"))
        {
            this.AllWarnings = new List<ArchivalLocationWarningsDetails>();
            this.AllWarnings.ApplyExploratoryFieldSpec(parent + ".allWarnings");
        }
    }


    #endregion

    } // class NonCompliantArchivalTierWarningDetails
    
    #endregion

    public static class ListNonCompliantArchivalTierWarningDetailsExtensions
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
            this List<NonCompliantArchivalTierWarningDetails> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NonCompliantArchivalTierWarningDetails> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NonCompliantArchivalTierWarningDetails());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types