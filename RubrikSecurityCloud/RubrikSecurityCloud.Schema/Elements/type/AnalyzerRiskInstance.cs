// AnalyzerRiskInstance.cs
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
    #region AnalyzerRiskInstance
    public class AnalyzerRiskInstance: BaseType
    {
        #region members

        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        [JsonProperty("risk")]
        public RiskLevelType? Risk { get; set; }

        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        [JsonProperty("analyzerId")]
        public System.String? AnalyzerId { get; set; }

        //      C# -> System.Int32? RiskVersion
        // GraphQL -> riskVersion: Int! (scalar)
        [JsonProperty("riskVersion")]
        public System.Int32? RiskVersion { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnalyzerRiskInstance";
    }

    public AnalyzerRiskInstance Set(
        RiskLevelType? Risk = null,
        System.String? AnalyzerId = null,
        System.Int32? RiskVersion = null
    ) 
    {
        if ( Risk != null ) {
            this.Risk = Risk;
        }
        if ( AnalyzerId != null ) {
            this.AnalyzerId = AnalyzerId;
        }
        if ( RiskVersion != null ) {
            this.RiskVersion = RiskVersion;
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
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk != null) {
            s += ind + "risk\n" ;
        }
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        if (this.AnalyzerId != null) {
            s += ind + "analyzerId\n" ;
        }
        //      C# -> System.Int32? RiskVersion
        // GraphQL -> riskVersion: Int! (scalar)
        if (this.RiskVersion != null) {
            s += ind + "riskVersion\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> RiskLevelType? Risk
        // GraphQL -> risk: RiskLevelType! (enum)
        if (this.Risk == null && Exploration.Includes(parent + ".risk", true))
        {
            this.Risk = new RiskLevelType();
        }
        //      C# -> System.String? AnalyzerId
        // GraphQL -> analyzerId: String! (scalar)
        if (this.AnalyzerId == null && Exploration.Includes(parent + ".analyzerId", true))
        {
            this.AnalyzerId = "FETCH";
        }
        //      C# -> System.Int32? RiskVersion
        // GraphQL -> riskVersion: Int! (scalar)
        if (this.RiskVersion == null && Exploration.Includes(parent + ".riskVersion", true))
        {
            this.RiskVersion = Int32.MinValue;
        }
    }


    #endregion

    } // class AnalyzerRiskInstance
    
    #endregion

    public static class ListAnalyzerRiskInstanceExtensions
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
            this List<AnalyzerRiskInstance> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AnalyzerRiskInstance> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AnalyzerRiskInstance());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace RubrikSecurityCloud.Types